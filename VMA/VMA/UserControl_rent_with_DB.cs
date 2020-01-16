using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace VMA
{
    public partial class UserControl_rent_with_DB : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        AutoCompleteStringCollection instcol = new AutoCompleteStringCollection();  //modele
        AutoCompleteStringCollection instcol1 = new AutoCompleteStringCollection(); //marki

        AutoCompleteStringCollection instcolVersion = new AutoCompleteStringCollection(); //wersje
        AutoCompleteStringCollection instcolTypeFuel = new AutoCompleteStringCollection(); //typ paliwa
        private DateTime time_from = DateTime.Today;
        private DateTime time_to;
        //private bool confirm = false;  //czy użytkownik sprawdził dostępne auta
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

        public void fillDataGridView() //uzupełnienie tabeli
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
        public void auto_Complete_textBox()     // Automatyczne podpowiedzi
        {
            // Modele
            var brands = db.VehicleSets.Where(y => y.available != "deleted").Select(x => x.brand).Distinct().ToArray();
            instcol.AddRange(brands);

            // Marki
            var models = db.VehicleSets.Where(y => y.available != "deleted").Select(x => x.model).Distinct().ToArray();
            instcol1.AddRange(models);



            //Wersja
            var versions = db.VehicleSets.Where(y => y.available != "deleted").Select(x => x.version).ToArray();
            instcolVersion.AddRange(versions);
            //Typ paliwa
            var typefuel = db.VehicleSets.Where(y => y.available != "deleted").Select(x => x.fuel_type).ToArray();
            instcolTypeFuel.AddRange(typefuel);



        }
        private void button_show_available_cars_Click(object sender, EventArgs e)
        {
            string filtr_brand = textBox_brand.Text;
            string filtr_model = textBox_model.Text;
            string filtr_version = textBox_version.Text;

            string filtr_avg = textBox_equipment.Text;
            string filtr_fuel = textBox_mileage.Text;

            try
            {

                var not_Available_Cars = db.ReservationSets
                .Where(x => (x.date_from <= time_from && x.date_to >= time_from)
                       || (x.date_to >= time_to && x.date_from <= time_to)
                       || (x.date_from >= time_from && x.date_to <= time_to))
                           .Select(x => x.Vehicle_vehicle_id);
            
            var available_Cars = db.VehicleSets
                .Where(x => !not_Available_Cars
                .Contains(x.vehicle_id) && x.available == "yes");




                if (filtr_brand == "Marka" || filtr_brand == "")
                { }
                else
                {
                    available_Cars = from x in available_Cars where x.brand == filtr_brand select x;

                }

                if (filtr_model == "Model" || filtr_model == "")
                { }
                else
                {
                    available_Cars = from x in available_Cars where x.model == filtr_model select x;

                }

                if (filtr_version == "Wersja" || filtr_version == "")
                { }
                else
                {
                    available_Cars = from x in available_Cars where x.version == filtr_version select x;

                }


                if (filtr_avg == "Spalanie" || filtr_avg == "")
                { }
                else
                {
                    double avg = Double.Parse(filtr_avg, CultureInfo.InvariantCulture); ;
                    available_Cars = from x in available_Cars where x.avg_consumption <= avg select x;

                }

                if (filtr_fuel == "Typ paliwa" || filtr_fuel == "")
                { }
                else
                {
                    available_Cars = from x in available_Cars where x.fuel_type == filtr_fuel select x;

                }

                var query1 = from x in available_Cars select new { ID = x.vehicle_id, MARKA = x.brand, MODEL = x.model, WERSJA = x.version, REJESTRACJA = x.licence_plate, SPALANIE = x.avg_consumption, PALIWO = x.fuel_type, };

                dataGridView_veh_DB.DataSource = query1;

                dataGridView_veh_DB.RowHeadersVisible = false;
                dataGridView_veh_DB.ReadOnly = true;
                dataGridView_veh_DB.Columns[0].Visible = false;
                button_rent.Visible = true;
                //confirm = true;


            }
            catch
            {
                MessageBox.Show("Zły format danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button_rent_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView_veh_DB.CurrentCell.RowIndex;
                car_id = (int)dataGridView_veh_DB.Rows[row].Cells[0].Value;
                

                if (comboBox_purpose_of_rent.Text == "Służbowy" || comboBox_purpose_of_rent.Text == "Prywatny" || comboBox_purpose_of_rent.Text == "Delegacja")
                {

                    var counter_modulo = db.RentSets
                                               .Where(x => x.Worker_worker_id == user_id
                                                       && ((x.date_from <= time_from
                                                           && x.date_to >= time_from)
                                                           || (x.date_from <= time_to
                                                               && x.date_to >= time_to)) && x.mileage_end == 0)
                                                                   .Select(x => x.rent_id)
                                                                       .Count();


                    if (counter_modulo==0)
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
                            MessageBox.Show("Nie udało się dokonać wypożyczenia pojazdu", "Error Rent", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                            MessageBox.Show("Wypożyczyłeś pojazd od dzisiaj do " + time_to.Date.ToShortDateString(), "Good Rent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillDataGridView();

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Nie udało się dokonać wypożyczenia pojazdu", "Error Rent", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else

                    {
                        MessageBox.Show("Masz już wypożyczone auto w takim okresie", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wybierz cel wypożyczenia", "Error Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Zaznacz auto które chcesz wypożyczyć", "Error Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_brand_Enter(object sender, EventArgs e)
        {
            if (textBox_brand.Text.Equals(@"Marka"))
            {
                textBox_brand.ForeColor = Color.FromArgb(255, 255, 0);
                textBox_brand.Text = "";
            }
            textBox_brand.AutoCompleteCustomSource = instcol;
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
            textBox_model.AutoCompleteCustomSource = instcol1;
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
            textBox_version.AutoCompleteCustomSource = instcolVersion;
        }

        private void textBox_mileage_Enter(object sender, EventArgs e)
        {
            if (textBox_mileage.Text.Equals(@"Typ paliwa"))
            {
                textBox_mileage.ForeColor = Color.FromArgb(255, 255, 0);
                textBox_mileage.Text = "";
            }
            textBox_mileage.AutoCompleteCustomSource = instcolTypeFuel;

        }

        private void textBox_mileage_Leave(object sender, EventArgs e)
        {
            if (textBox_mileage.Text.Equals(""))
            {
                textBox_mileage.Text = "Typ paliwa";
                textBox_mileage.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

    

        
        
        private void dateTimePicker_to_date_rent_Leave(object sender, EventArgs e)
        {
            time_to = dateTimePicker_to_date_rent.Value;
        }

        private void dateTimePicker_from_date_rent_ValueChanged(object sender, EventArgs e) // mozna wywalic
        {
            
        }
        public void clearTextbox()
        {
            textBox_brand.Text = "Marka";
            textBox_brand.ForeColor = Color.FromArgb(120, 120, 0);
            textBox_model.Text = "Model";
            textBox_model.ForeColor = Color.FromArgb(120, 120, 0);
            textBox_equipment.Text = "Spalanie";
            textBox_equipment.ForeColor = Color.FromArgb(120, 120, 0);
            textBox_version.Text = "Wersja";
            textBox_version.ForeColor = Color.FromArgb(120, 120, 0);
            textBox_mileage.Text = "Typ paliwa";
            textBox_mileage.ForeColor = Color.FromArgb(120, 120, 0);

        }

        private void pictureBox_help_Click(object sender, EventArgs e)
        {
            helppdf help = new helppdf(13);
            help.Show();
        }
    }
}
