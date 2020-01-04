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

        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combobox_service.Text == "INNA")
            {
                textBox_other_service.Visible = true;
            }
            else
            {
                textBox_other_service.Visible = false;
            }
        }*/

       /* private void textBox1_Enter(object sender, EventArgs e)
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
        }*/

        
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
        private int if_car_is_in_service()
        {
            return 0;
        }

        public void fillComboBox_Company()
        {
            var qury = (from x in db.CompanySets where x.description!= "brakwspolpracy"
                        select x.name).ToList();

            comboBox_Company_name.DataSource = qury;

            dateTimePicker_from_date_reserv.MinDate = DateTime.Today;
            dateTimePicker_to_date_reserv.MinDate = dateTimePicker_from_date_reserv.Value;
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
                else if (veh.available == "Serwis")
                {
                    MessageBox.Show("Auto jest na Serwisie", "Information available", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    else if (veh.available == "Serwis")
                    {
                        MessageBox.Show("Auto jest na Serwisie", "Information available", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void button_reserv_Click(object sender, EventArgs e)
        {
            if (comboBox_service.SelectedIndex == -1 || string.IsNullOrEmpty(textBox_description.Text))
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

                    //vechicle.available = "no";

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
                            name = comboBox_service.Text,
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
                            date_from = dateTimePicker_from_date_reserv.Value,
                            data_to = Convert.ToDateTime("1999-01-01 00:00:00.000"),
                            Care_care_id = care_id.care_id,
                            Service_service_id = service.service_id,
                            price = -10,
                            Company_company_id = company_id.company_id
                        };
                        db.Care_serviceSets.InsertOnSubmit(newservice);
                        db.SubmitChanges();

                        fillDataGridView();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie dodało się do bazy care_service", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    try
                    {
                        WorkerSet worker;
                        
                        try
                        {
                            var people = (from x in db.ReservationSets
                                         where ((x.date_from >= dateTimePicker_from_date_reserv.Value && x.date_from <= dateTimePicker_to_date_reserv.Value)
                                                || (x.date_to >= dateTimePicker_from_date_reserv.Value && x.date_to <= dateTimePicker_to_date_reserv.Value)
                                                || (x.date_from >= dateTimePicker_from_date_reserv.Value && x.date_to <= dateTimePicker_to_date_reserv.Value))
                                                && x.Vehicle_vehicle_id == vechicle.vehicle_id
                                                && x.Worker_worker_id != user_id
                                         select x.Worker_worker_id).Distinct();

                            string peoples = "Powiadom następujące osoby o wysyłaniu pojazdu na serwis w terminie ich rezerwacji, oraz poproś o usunięcie owej rezerwacji: \n ";
                            foreach (int id in people)
                            {
                                worker = db.WorkerSets.Where(x => x.worker_id == id).SingleOrDefault();

                                peoples += worker.name + " " + worker.surname + " nr telefonu do pracownika: " + worker.phone_nr.ToString() + "\n";
                            }

                            if (peoples == "Powiadom następujące osoby o wysyłaniu pojazdu na serwis w terminie ich rezerwacji, oraz poproś o usunięcie owej rezerwacji: \n ")
                            { }
                            else
                            {
                                MessageBox.Show(peoples, "Error check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception)
                        {
                        }
                        ReservationSet newreserv = new ReservationSet()
                        {
                            date_from = dateTimePicker_to_date_reserv.Value,
                            date_to = dateTimePicker_to_date_reserv.Value,
                            purpose = "Serwis",
                            Worker_worker_id = user_id,
                            Vehicle_vehicle_id = vechicle.vehicle_id
                        };

                        db.ReservationSets.InsertOnSubmit(newreserv);
                        db.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie udało się stworzyć rezerwacji", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Zaznacz samochód", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

