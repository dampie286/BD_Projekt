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
                              select new { REJESTRACJA = x.licence_plate, MARKA = x.brand, MODEL = x.model,OD = y.date_from,
                                  DO = y.date_to, REZERWUJACY = z.surname, CEL = y.purpose};

            dataGridView_veh_DB.DataSource = Selectquery;

            

            //dataGridView_veh_DB.Columns[0].Visible = false;
            dataGridView_veh_DB.RowHeadersVisible = false;
            dataGridView_veh_DB.ReadOnly = true;        //nie moze edytować kolumn
            
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
            try
            {
                var vechicle_id = db.VehicleSets.Where(i => i.licence_plate == Convert.ToString(textBox_reser_license.Text)).Single();

                var worker_id = db.WorkerSets.Where(j => j.worker_id == id_user).Single();

                var Selectquery = from x in db.VehicleSets
                                  join y in db.ReservationSets on x.vehicle_id equals y.Vehicle_vehicle_id
                                  join z in db.WorkerSets on y.Worker_worker_id equals z.worker_id
                                  select new
                                  {
                                      REJESTRACJA = x.licence_plate,
                                      MARKA = x.brand,
                                      MODEL = x.model,
                                      OD = y.date_from,
                                      DO = y.date_to,
                                      REZERWUJACY = z.surname,
                                      CEL = y.purpose
                                  };

                var check_date = from x in Selectquery
                                 where x.REJESTRACJA == licence_plate
                                 where (x.OD <= time_from && time_from <= x.DO) || (x.OD <= time_to && time_to <= x.DO)
                                 select new
                                 {
                                     REJESTRACJA = x.REJESTRACJA,
                                     MARKA = x.MARKA,
                                     MODEL = x.MODEL,
                                     OD = x.OD,
                                     DO = x.DO,
                                     REZERWUJACY = x.REZERWUJACY,
                                     CEL = x.CEL
                                 };
                if (!check_date.Any())
                {
                    ReservationSet reserv = new ReservationSet()
                    {
                        purpose = Convert.ToString(textBox_reserv_purpose.Text),
                        date_from = dateTimePicker_from_date_reserv.Value,
                        date_to = dateTimePicker_to_date_reserv.Value,
                        Worker_worker_id = worker_id.worker_id,
                        Vehicle_vehicle_id = vechicle_id.vehicle_id
                    };


                    db.ReservationSets.InsertOnSubmit(reserv);
                    db.SubmitChanges();



                    dataGridView_veh_DB.DataSource = check_date;

                }
                else
                {
                    MessageBox.Show("KURWA CHYBA DZIAŁA", "Error license plate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                textBox_reserv_purpose.Text = "Cel rezerwacji";
                textBox_reser_license.Text = "Nr rejestracyjny";

                MessageBox.Show("Nie ma samochodu z takim numerem rejestracyjnym", "Error license plate", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
