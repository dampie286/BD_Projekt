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
    public partial class UserControl_send_to_service : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        private int user_id;
        int car_id;
        public UserControl_send_to_service()
        {
           
            InitializeComponent();
        }
        public void setUserID(int id)
        {
            user_id = id;
        }

        public void fillDataGridView()
        {
            var query = from x in db.CareSets
                        join y in db.VehicleSets on x.Vehicle_vehicle_id equals y.vehicle_id
                        where x.Keeper_worker_id == user_id && x.VehicleSet.available !="Serwis" && x.VehicleSet.available != "deleted"
                        select new
                        {
                            ID = y.vehicle_id,
                            AUTO = y.model,
                            REJESTRACJA = y.licence_plate,
                            DOSTĘPNOŚĆ = y.available
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

        public void fillComboBox_Company()
        {
            var qury = (from x in db.CompanySets
                        where x.description != "brakwspolpracy"
                        select x.name).ToList();

            qury.Insert(0,"Wybierz");
            comboBox_Company_name.DataSource = qury;
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
                    string company_name;
                    VehicleSet vechicle = db.VehicleSets.Where(x => x.vehicle_id == car_id).First();

                    vechicle.available = "Serwis";

                    CareSet care_id = db.CareSets
                                      .Where(x => x.Vehicle_vehicle_id == car_id)
                                      .First();

                    company_name = comboBox_Company_name.Text;

                    CompanySet company_id = db.CompanySets
                                            .Where(x => x.name == company_name)
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
                            data_to = Convert.ToDateTime("1999 - 01 - 01 00:00:00.000"),
                            Care_care_id = care_id.care_id,
                            Service_service_id = service.service_id,
                            price = -10,
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

        private void button_repaired_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_price.Text))
            {
                MessageBox.Show("Wpisz poniesiony koszt na naprawę", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int row = dataGridView_cars_on_service.CurrentCell.RowIndex;
                    int car_id = (int)dataGridView_cars_on_service.Rows[row].Cells[0].Value;
                    int service_id = (int)dataGridView_cars_on_service.Rows[row].Cells[1].Value;

                    Care_serviceSet care = db.Care_serviceSets.Where(p => p.ServiceSet.service_id == service_id).First();
                    care.data_to = DateTime.Today;

                    Check_vehicleSet check = db.Check_vehicleSets.Where(p => p.Vehicle_vehicle_id == car_id).First();
                    
                    ServiceSet service = db.ServiceSets.Where(p => p.service_id == service_id).First();
                    service.is_repair = true;

                    VehicleSet veh = db.VehicleSets.Where(p => p.vehicle_id == car_id).First();
                    veh.available = "yes";


                    if (service.name == "Wymiana oleju + filtry")
                    {
                        check.oil_change_mileage += 15000;
                    }
                    else if (service.name == "Wymiana rozrzadu")
                    {
                        check.timing_gear_mileage += 15000;
                    }
                    else if (service.name == "Przegląd")
                    {
                        check.tech_review.AddYears(1); 
                    }

                    care.price = Convert.ToDouble(textBox_price.Text);
                    db.SubmitChanges();
                    fillDataGridView();
                    fillDataGridView2();
                    textBox_price.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Zaznacz samochód, który został naprawiony", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_care_car_DB_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                int row = dataGridView_care_car_DB.CurrentCell.RowIndex;
                label_brand.Text = (string)dataGridView_care_car_DB.Rows[row].Cells[1].Value;
                label_model.Text = (string)dataGridView_care_car_DB.Rows[row].Cells[2].Value;
            }
            catch { }


        }

        private void textBox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chh = e.KeyChar;
            if (chh == 46 && textBox_price.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(chh) && chh != 8 && chh != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox_description_Enter(object sender, EventArgs e)
        {
            if (textBox_description.Text.Equals(@"Opis..."))
            {
                textBox_description.Text = "";
                textBox_description.ForeColor = Color.FromArgb(255, 255, 0);
            }
        }

        private void textBox_description_Leave(object sender, EventArgs e)
        {
            if (textBox_description.Text.Equals(""))
            {
                textBox_description.Text = "Opis...";
                textBox_description.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }
    }
}
