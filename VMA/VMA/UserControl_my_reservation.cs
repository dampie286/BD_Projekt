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
    public partial class UserControl_my_reservation : UserControl
    {
        int user_id;
        public UserControl_my_reservation()
        {
           
            InitializeComponent();
            panel_with_myreservation.Hide();
        }

        public void setID(int id)
        {
            user_id = id;
        }

        public void fillDataGridView(DataTable tmp) //funkcja do wypłenienia tabeli
        {

            DataBaseDataContext db = new DataBaseDataContext();
            var Selectquery = from x in db.VehicleSets join y in db.ReservationSets on x.vehicle_id equals y.Vehicle_vehicle_id join z in db.WorkerSets on y.Worker_worker_id equals z.worker_id where z.worker_id== user_id select new { REJESTRACJA = x.licence_plate, MARKA = x.brand, MODEL = x.model, OD = y.date_from, DO = y.date_to, REZERWUJACY = z.surname, CEL = y.purpose };

            dataGridView_my_reservation.DataSource = Selectquery;

            
            dataGridView_my_reservation.Columns[0].Visible = false;
            dataGridView_my_reservation.RowHeadersVisible = false;
            dataGridView_my_reservation.ReadOnly = true;        //nie moze edytować kolumn


            dataGridView_my_reservation.Columns[1].Width = 60;
            dataGridView_my_reservation.Columns[2].Width = 60;
            dataGridView_my_reservation.Columns[3].Width = 60;
            dataGridView_my_reservation.Columns[4].Width = 90;
            dataGridView_my_reservation.Columns[5].Width = 90;
            

        }

      

        private void dataGridView_my_reservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_with_myreservation.Show();
            int row = dataGridView_my_reservation.CurrentCell.RowIndex;
            label_brand.Text = (string)dataGridView_my_reservation.Rows[row].Cells[1].Value;
            label_model.Text = (string)dataGridView_my_reservation.Rows[row].Cells[2].Value;
            label_from.Text = dataGridView_my_reservation.Rows[row].Cells[3].Value.ToString();
            label_to.Text = (string)dataGridView_my_reservation.Rows[row].Cells[4].Value.ToString();
            label_purpose.Text = dataGridView_my_reservation.Rows[row].Cells[6].Value.ToString();
        }
    }
}
