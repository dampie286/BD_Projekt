using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMA
{
    public partial class UserControl_menage_care_cars : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        private int user_id;
        int car_id;
        public UserControl_menage_care_cars()
        {
            InitializeComponent();
            Combobox_service.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void setUserID(int id)
        {
            user_id = id;
        }
        public void fillDataGridView()
        {
            var query = from x in db.CareSets
                        join y in db.VehicleSets on x.Vehicle_vehicle_id equals y.vehicle_id
                        where x.Keeper_worker_id == user_id
                        select new
                        {
                            ID = y.vehicle_id,
                            AUTO = y.model,
                            REJESTRACJA = y.licence_plate,
                            DOSTĘPNOSC = y.available
                        };
            
            dataGridView_care_car_DB.DataSource = query;

            dataGridView_care_car_DB.Columns[0].Visible = false;

        }

        public void fillDataGridView2()    //Auta na serwisie
        {
            try
            {
                var query = from x in db.ServiceSets
                            join y in db.Care_serviceSets on x.service_id equals y.Service_service_id
                            join z in db.CareSets on y.Care_care_id equals z.care_id
                            join q in db.VehicleSets on z.Vehicle_vehicle_id equals q.vehicle_id
                            where z.Keeper_worker_id == user_id && x.is_repair == false
                            select new
                            {
                                ID_car = q.vehicle_id,
                                ID_Service = x.service_id,
                                AUTO = q.model,
                                REJESTRACJA = q.licence_plate,
                                OD = y.date_from,
                                PRZYCZYNA = x.name,
                                OPIS = x.description
                            };
                dataGridView_cars_on_service.DataSource = query;
                dataGridView_cars_on_service.Columns[0].Visible = false;
                dataGridView_cars_on_service.Columns[1].Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Nie masz aut na serwisie", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combobox_service.Text == "INNA")
            {
                textBox_other_service.Visible = true;
            }
            else
            {
                textBox_other_service.Visible = false;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox_other_service.Text == "Rodzaj serwisu")
            {
                textBox_other_service.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox_other_service.Text == "")
            {
                textBox_other_service.Text = "Rodzaj serwisu";
            }
        }

        private void button_send_to_service_Click(object sender, EventArgs e)
        {
            if (Combobox_service.SelectedIndex == -1 || string.IsNullOrEmpty(textBox_description.Text))
            {
                MessageBox.Show("Wybierz przyczynę serwisu i opisz problem", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int row = dataGridView_care_car_DB.CurrentCell.RowIndex;
                    car_id = (int)dataGridView_care_car_DB.Rows[row].Cells[0].Value;
                    VehicleSet vechicle = db.VehicleSets.Where(x => x.vehicle_id == car_id).First();

                    vechicle.available = "no";

                    CareSet care_id = db.CareSets
                                      .Where(x => x.Vehicle_vehicle_id == car_id)
                                      .First();

                    CompanySet company_id = db.CompanySets
                                            .Where(x => x.name == "AutoRIP")
                                            .First();
                    try
                    {
                        ServiceSet service = new ServiceSet()
                        {
                            is_repair = false,
                            name = Combobox_service.Text,
                            description = textBox_description.Text
                        };
                        db.ServiceSets.InsertOnSubmit(service);
                        db.SubmitChanges();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie udało się oddać auta do serwisu", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    try
                    {
                        ServiceSet service = db.ServiceSets.OrderByDescending(p => p.service_id).First();

                        Care_serviceSet newservice = new Care_serviceSet()
                        {
                            date_from = DateTime.Today,
                            Care_care_id = care_id.care_id,
                            Service_service_id = service.service_id,
                            price = 500,
                            Company_company_id = company_id.company_id
                        };
                        db.Care_serviceSets.InsertOnSubmit(newservice);
                        db.SubmitChanges();

                        fillDataGridView();
                        fillDataGridView2();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie dodało się do bazy care_service", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Zaznacz samochód", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_care_car_DB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView_care_car_DB.CurrentCell.RowIndex;
            label_brand.Text = (string)dataGridView_care_car_DB.Rows[row].Cells[1].Value;
            label_model.Text = (string)dataGridView_care_car_DB.Rows[row].Cells[2].Value;
        }
        private int if_car_is_in_service()
        {



            return 0;
        }

        private void button_blocked_Click(object sender, EventArgs e)
        {
            //if car is in service
            

            try
            {
                
                int row = dataGridView_care_car_DB.CurrentCell.RowIndex;
                int car_id = (int)dataGridView_care_car_DB.Rows[row].Cells[0].Value;

                VehicleSet veh = db.VehicleSets.Where(v => v.vehicle_id == car_id).First();
                if (veh.available == "yes")
                {
                    veh.available = "no";

                    db.SubmitChanges();
                    fillDataGridView();
                }
                else
                {
                    MessageBox.Show("Auto jest juz niedostępne", "Information available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            }
            catch (Exception)
            {
                MessageBox.Show("Zaznacz samochód, który chcesz blokować", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_unblocking_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView_care_car_DB.CurrentCell.RowIndex;
                int car_id = (int)dataGridView_care_car_DB.Rows[row].Cells[0].Value;

               var chceck_serv = db.Care_serviceSets.Where(v => v.CareSet.Vehicle_vehicle_id == car_id && v.ServiceSet.is_repair==false).Any();

                if (chceck_serv)
                {

                    MessageBox.Show("Nie można odblokować auta będącego w serwsie", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {



                    VehicleSet veh = db.VehicleSets.Where(v => v.vehicle_id == car_id).First();

                    if (veh.available == "no")
                    {
                        veh.available = "yes";

                        db.SubmitChanges();
                        fillDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Auto jest juz dostępne", "Information available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }



            }
            catch (Exception)
            {
                MessageBox.Show("Zaznacz samochód, który chcesz blokować", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_repaired_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView_cars_on_service.CurrentCell.RowIndex;
                int car_id = (int)dataGridView_cars_on_service.Rows[row].Cells[0].Value;
                int service_id = (int)dataGridView_cars_on_service.Rows[row].Cells[1].Value;

                Care_serviceSet care = db.Care_serviceSets.Where(p=>p.ServiceSet.service_id==service_id).First();
                care.data_to = DateTime.Today;

              ServiceSet service = db.ServiceSets.Where(p => p.service_id == service_id).First();
                service.is_repair = true;

                VehicleSet veh = db.VehicleSets.Where(p => p.vehicle_id == car_id).First();
                veh.available = "yes";

                db.SubmitChanges();
                fillDataGridView();
                fillDataGridView2();
            }
            catch (Exception)
            {
                MessageBox.Show("Zaznacz samochód, który został naprawiony", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

