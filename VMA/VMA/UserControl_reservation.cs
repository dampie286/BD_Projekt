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
        public UserControl_reservation()
        {
            InitializeComponent();
        }

        public void fillDataGridView(DataTable tmp)     //uzupełnienie tabeli
        {
            DataBaseDataContext db = new DataBaseDataContext();
            var Selectquery = from x in db.VehicleSets join y in db.ReservationSets on x.vehicle_id equals y.Vehicle_vehicle_id select new { REJESTRACJA = x.licence_plate, MARKA = x.brand, MODEL = x.model, WERSJA = x.version,  SPALANIE = x.avg_consumption, PALIWO = x.fuel_type, y.date_from, y.date_to  };

            dataGridView_veh_DB.DataSource = Selectquery;



            //dataGridView_veh_DB.Columns[0].Visible = false;
            dataGridView_veh_DB.RowHeadersVisible = false;
            dataGridView_veh_DB.ReadOnly = true;        //nie moze edytować kolumn
            


            dataGridView_veh_DB.Columns[1].Width = 60;
            dataGridView_veh_DB.Columns[2].Width = 60;
            dataGridView_veh_DB.Columns[3].Width = 60;
            dataGridView_veh_DB.Columns[4].Width = 90;
            dataGridView_veh_DB.Columns[5].Width = 90;
            dataGridView_veh_DB.Columns[6].Width = 90;

        }

        private void dateTimePicker_from_date_reserv_ValueChanged(object sender, EventArgs e)
        {

            dateTimePicker_to_date_reserv.MinDate = dateTimePicker_from_date_reserv.Value;
        }

        private void UserControl_reservation_Load(object sender, EventArgs e)
        {
            dateTimePicker_from_date_reserv.MinDate = DateTime.Today;

        }

        private void button_reserv_Click(object sender, EventArgs e)
        {
            using (DataBaseDataContext db = new DataBaseDataContext())
            {
                var vechicle_id = db.VehicleSets.Where(i => i.licence_plate == Convert.ToString(textBox_reser_license.Text)).Single();

                ReservationSet reserv = new ReservationSet()
                {
                    purpose = Convert.ToString(textBox_reserv_purpose.Text),
                    date_from = dateTimePicker_from_date_reserv.Value,
                    date_to = dateTimePicker_to_date_reserv.Value,
                    Worker_worker_id = 2,
                    Vehicle_vehicle_id = vechicle_id.vehicle_id
                };

                db.ReservationSets.InsertOnSubmit(reserv);
                db.SubmitChanges();
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
        }
    }
}
