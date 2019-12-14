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
    public partial class UserControl_rent_with_DB : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        private DateTime time_from = DateTime.Today;
        private DateTime time_to;
        private bool confirm = false;  //czy użytkownik sprawdził dostępne auta
        private int car_id;
        private int user_id;

        public UserControl_rent_with_DB()
        {
            InitializeComponent();
        }

        public void user_ID_Set(int id)
        {
            user_id = id;
        }

        public void fillDataGridView(DataTable tmp) //uzupełnienie tabeli
        {
            dateTimePicker_from_date_rent.MinDate = DateTime.Today;
            dateTimePicker_to_date_rent.MinDate = dateTimePicker_from_date_rent.Value;
            time_to = dateTimePicker_to_date_rent.Value;

            var query = from x in db.VehicleSets
                        where x.available == "yes"
                        select new
                        {
                            ID = x.vehicle_id,
                            MARKA = x.brand,
                            MODEL = x.model,
                            WERSJA = x.version,
                            REJESTRACJA = x.licence_plate,
                            SPALANIE = x.avg_consumption,
                            PALIWO = x.fuel_type
                        };

            dataGridView_veh_DB.DataSource = query;
            
            dataGridView_veh_DB.RowHeadersVisible = false;
            dataGridView_veh_DB.ReadOnly = true;        //nie moze edytować kolumn

            dataGridView_veh_DB.Columns[0].Visible = false;
            dataGridView_veh_DB.Columns[1].Width = 60;
            dataGridView_veh_DB.Columns[2].Width = 60;
            dataGridView_veh_DB.Columns[3].Width = 60;
            dataGridView_veh_DB.Columns[4].Width = 90;
            dataGridView_veh_DB.Columns[5].Width = 90;
            dataGridView_veh_DB.Columns[6].Width = 90;
        }

        private void button_show_available_cars_Click(object sender, EventArgs e)
        {
            var not_Available_Cars = db.ReservationSets
                .Where(x => (x.date_from <= time_from && x.date_to >= time_from)
                       || (x.date_to >= time_to && x.date_from <= time_to)
                       || (x.date_from >= time_from && x.date_to <= time_to))
                           .Select(x => x.Vehicle_vehicle_id);
            
            var available_Cars = db.VehicleSets
                .Where(x => !not_Available_Cars
                .Contains(x.vehicle_id) && x.available == "yes");

            dataGridView_veh_DB.DataSource = available_Cars;
            dataGridView_veh_DB.Columns[0].Visible = false;

            confirm = true;
        }

        private void button_rent_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView_veh_DB.CurrentCell.RowIndex;
                car_id = (int)dataGridView_veh_DB.Rows[row].Cells[0].Value;
                

                if (comboBox_purpose_of_rent.Text == "Służbowy" || comboBox_purpose_of_rent.Text == "Prywatny")
                {
                    try
                    {
                        ReservationSet newReserv = new ReservationSet()
                        {
                            purpose = comboBox_purpose_of_rent.Text,
                            date_from = time_from,
                            date_to = time_to,
                            Worker_worker_id = user_id,
                            Vehicle_vehicle_id = car_id
                        };
                        db.ReservationSets.InsertOnSubmit(newReserv);
                        db.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie udało się dokonać rezerwacji pojazdu", "Error Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    try
                    {
                        var mileage_st = (from x in db.VehicleSets
                                         where x.vehicle_id == car_id
                                         select x.mileage)
                                            .Single();

                        ReservationSet reserv = db.ReservationSets
                                            .Where(x => x.date_to == time_to 
                                                    && x.date_from == time_from 
                                                    && x.Vehicle_vehicle_id == car_id)
                                                    .First();
                    RentSet newRent = new RentSet()
                        {
                            purpose = comboBox_purpose_of_rent.Text,
                            date_from = time_from,
                            date_to = time_to,
                            mileage_start = mileage_st,
                            Worker_worker_id = user_id,
                            Reservation_reservation_id = reserv.reservation_id,
                            Vehicle_vehicle_id = car_id
                        };
                        db.RentSets.InsertOnSubmit(newRent);
                        db.SubmitChanges();

                        MessageBox.Show("Wypożyczyłeś pojazd od dzisiaj do" + time_to.ToString(), "Good Rent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie udało się dokonać wypożyczenia pojazdu", "Error Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wybierz cel rezerwacji", "Error Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Zaznacz auto które chcesz zarezerwować", "Error Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_brand_Enter(object sender, EventArgs e)
        {
            if (textBox_brand.Text.Equals(@"Marka"))
            {
                textBox_brand.ForeColor = Color.FromArgb(255, 255, 0);
                textBox_brand.Text = "";
            }
        }

        private void textBox_brand_Leave(object sender, EventArgs e)
        {
            if (textBox_brand.Text.Equals(""))
            {
                textBox_brand.Text = "Marka";
                textBox_brand.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        private void textBox_model_Enter(object sender, EventArgs e)
        {
            if(textBox_model.Text.Equals(@"Model"))
            {
                textBox_model.ForeColor = Color.FromArgb(255, 255, 0);
                textBox_model.Text = "";
            }
        }

        private void textBox_model_Leave(object sender, EventArgs e)
        {
            if (textBox_model.Text.Equals(""))
            {
                textBox_model.Text = "Model";
                textBox_model.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        private void textBox_equipment_Enter(object sender, EventArgs e)
        {
            if (textBox_equipment.Text.Equals(@"Spalanie"))
            {
                textBox_equipment.ForeColor = Color.FromArgb(255, 255, 0);
                textBox_equipment.Text = "";
            }
        }

        private void textBox_equipment_Leave(object sender, EventArgs e)
        {
            if (textBox_equipment.Text.Equals(""))
            {
                textBox_equipment.Text = "Spalanie";
                textBox_equipment.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        private void textBox_version_Enter(object sender, EventArgs e)
        {
            if (textBox_version.Text.Equals(@"Wersja"))
            {
                textBox_version.ForeColor = Color.FromArgb(255, 255, 0);
                textBox_version.Text = "";
            }
        }

        private void textBox_version_Leave(object sender, EventArgs e)
        {
            if (textBox_version.Text.Equals(""))
            {
                textBox_version.Text = "Wersja";
                textBox_version.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        private void textBox_mileage_Enter(object sender, EventArgs e)
        {
            if (textBox_mileage.Text.Equals(@"Typ paliwa"))
            {
                textBox_mileage.ForeColor = Color.FromArgb(255, 255, 0);
                textBox_mileage.Text = "";
            }
        }

        private void textBox_mileage_Leave(object sender, EventArgs e)
        {
            if (textBox_mileage.Text.Equals(""))
            {
                textBox_mileage.Text = "Typ paliwa";
                textBox_mileage.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        private void textBox_license_Enter(object sender, EventArgs e)
        {
            if (textBox_license.Text.Equals(@"Rejestracja"))
            {
                textBox_license.ForeColor = Color.FromArgb(255, 255, 0);
                textBox_license.Text = "";
            }
        }

        private void textBox_license_Leave(object sender, EventArgs e)
        {
            if (textBox_license.Text.Equals(""))
            {
                textBox_license.Text = "Rejestracja";
                textBox_license.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        private void textBox_reser_license_Enter(object sender, EventArgs e)
        {
            if (textBox_reser_license.Text.Equals(@"Nr rejestracyjny"))
            {
                textBox_reser_license.ForeColor = Color.FromArgb(255, 255, 0);
                textBox_reser_license.Text = "";
            }
        }

        private void textBox_reser_license_Leave(object sender, EventArgs e)
        {
            if (textBox_reser_license.Text.Equals(""))
            {
                textBox_reser_license.Text = "Nr rejestracyjny";
                textBox_reser_license.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        
        
        private void dateTimePicker_to_date_rent_Leave(object sender, EventArgs e)
        {
            time_to = dateTimePicker_to_date_rent.Value;
        }

        private void dateTimePicker_from_date_rent_ValueChanged(object sender, EventArgs e) // mozna wywalic
        {
            
        }
    }
}
