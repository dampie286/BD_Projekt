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
    public partial class UserControl_reservation : UserControl
    {
        private int id_user; //id usera aktualnie zalogowanego
        private string licence_plate; //automatyczna filtracja rezerwacji dla danego pojazdu
        DataBaseDataContext db = new DataBaseDataContext();
        private DateTime time_from;
        private DateTime time_to;
        private int car_id;
        private bool confirm = false;

        public UserControl_reservation()
        {
            InitializeComponent();
        }

        public void fillDataGridView(DataTable tmp)     //uzupełnienie tabeli
        {
            time_from = dateTimePicker_from_date_reserv.Value;
            time_to = dateTimePicker_to_date_reserv.Value;


            var Selectquery = from x in db.VehicleSets
                              join y in db.ReservationSets on x.vehicle_id equals y.Vehicle_vehicle_id
                              join z in db.WorkerSets on y.Worker_worker_id equals z.worker_id
                              select new { ID = x.vehicle_id, REJESTRACJA = x.licence_plate, MARKA = x.brand, MODEL = x.model,OD = y.date_from,
                                  DO = y.date_to, REZERWUJACY = z.surname, CEL = y.purpose};
            
            dataGridView_veh_DB.DataSource = Selectquery;



            //dataGridView_veh_DB.Columns[0].Visible = false;
            dataGridView_veh_DB.RowHeadersVisible = false;
            dataGridView_veh_DB.ReadOnly = true;        //nie moze edytować kolumn
            dataGridView_veh_DB.Columns[0].Visible = false;  // id pojazdu
            dataGridView_veh_DB.Columns[1].Width = 60;
            dataGridView_veh_DB.Columns[2].Width = 60;
            dataGridView_veh_DB.Columns[3].Width = 60;
            dataGridView_veh_DB.Columns[4].Width = 90;
            dataGridView_veh_DB.Columns[5].Width = 90;
            //dataGridView_veh_DB.Columns[6].Width = 90;

        }

        private void dateTimePicker_from_date_reserv_ValueChanged(object sender, EventArgs e)
        {

            dateTimePicker_to_date_reserv.MinDate = dateTimePicker_from_date_reserv.Value;
        }

        private void UserControl_reservation_Load(object sender, EventArgs e)
        {
            dateTimePicker_from_date_reserv.MinDate = DateTime.Today;

        }
        public void setWorkerID(int worker_idB)
        {
           id_user = worker_idB;
        }

        private void button_reserv_Click(object sender, EventArgs e)
        {
            if (confirm)
            {
                try
                {
                    int row = dataGridView_veh_DB.CurrentCell.RowIndex;
                    car_id = (int)dataGridView_veh_DB.Rows[row].Cells[0].Value;

                    if (comboBox_purpose_of_reservation.Text == "Służbowy" || comboBox_purpose_of_reservation.Text == "Prywatny")
                    {
                        try
                        {
                            ReservationSet newReservation = new ReservationSet()
                            {
                                purpose = comboBox_purpose_of_reservation.Text,
                                date_from = time_from,
                                date_to = time_to,
                                Worker_worker_id = id_user,
                                Vehicle_vehicle_id = car_id
                            };
                            db.ReservationSets.InsertOnSubmit(newReservation);
                            db.SubmitChanges();

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Nie udało się dokonać rezerwacji pojazdu", "Error Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            else
            {
                MessageBox.Show("Wybierz datę", "Error Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_reser_license_Enter(object sender, EventArgs e)
        {
            if (textBox_reser_license.Text.Equals(@"Nr rejestracyjny"))
            {
                textBox_reser_license.Text = "";
            }
        }

        private void textBox_reser_license_Leave(object sender, EventArgs e)
        {
            if (textBox_reser_license.Text.Equals(""))
            {
                textBox_reser_license.Text = "Nr rejestracyjny";
            }
            else
            {
                    licence_plate = textBox_reser_license.Text;
                    var Selectquery = from x in db.VehicleSets
                                      join y in db.ReservationSets on x.vehicle_id equals y.Vehicle_vehicle_id
                                      join z in db.WorkerSets on y.Worker_worker_id equals z.worker_id
                                      where x.licence_plate == licence_plate
                                      select new { REJESTRACJA = x.licence_plate, MARKA = x.brand, MODEL = x.model,
                                          OD = y.date_from, DO = y.date_to, REZERWUJACY = z.surname, CEL = y.purpose };

                    
                    dataGridView_veh_DB.DataSource = Selectquery;
                    
            }
        }

        private void textBox_reserv_purpose_Leave(object sender, EventArgs e)
        {
            if (textBox_reserv_purpose.Text.Equals(""))
            {
                textBox_reserv_purpose.Text = "Cel rezerwacji";
            }
        }

        private void textBox_reserv_purpose_Enter(object sender, EventArgs e)
        {
            if (textBox_reserv_purpose.Text.Equals(@"Cel rezerwacji"))
            {
                textBox_reserv_purpose.Text = "";
            }
        }

        private void dateTimePicker_from_date_reserv_Leave(object sender, EventArgs e)
        {
            time_from = dateTimePicker_from_date_reserv.Value;
        }

        private void dateTimePicker_to_date_reserv_Leave(object sender, EventArgs e)
        {
            time_to = dateTimePicker_to_date_reserv.Value;
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
            if (textBox_model.Text.Equals(@"Model"))
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

        private void button_check_available_cars_Click(object sender, EventArgs e)
        {
            
            var not_Available_Cars = db.ReservationSets.Where(x => (x.date_from < time_from && x.date_to > time_from) 
                    || (x.date_to > time_to && x.date_from < time_to) || (x.date_from > time_from && x.date_to < time_to)).Select(x=> x.Vehicle_vehicle_id);
            

            var available_Cars = db.VehicleSets.Where(x => !not_Available_Cars.Contains(x.vehicle_id) && x.available != "deleted");

            dataGridView_veh_DB.DataSource = available_Cars;


            confirm = true;
           
        }
    }
}
