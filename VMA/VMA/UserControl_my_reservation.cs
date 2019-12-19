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
        int row = -1;
        DataBaseDataContext db = new DataBaseDataContext();
        public UserControl_my_reservation()
        {
            InitializeComponent();
        }

        public void setID(int id)
        {
            user_id = id;
        }

        public void fillDataGridView() //funkcja do wypłenienia tabeli
        {
            var Selectquery = from x in db.VehicleSets
                              join y in db.ReservationSets on x.vehicle_id equals y.Vehicle_vehicle_id
                              join z in db.WorkerSets on y.Worker_worker_id equals z.worker_id
                              where z.worker_id == user_id
                              select new
                              {
                                  ID = x.vehicle_id,
                                  REJESTRACJA = x.licence_plate,
                                  MARKA = x.brand, MODEL = x.model,
                                  OD = y.date_from,
                                  DO = y.date_to,
                                  REZERWUJACY = z.surname,
                                  CEL = y.purpose,
                                  PRZEBIEG = x.mileage,
                                  Reserv_id = y.reservation_id
                              };

            var rents = from x in db.RentSets
                        select x.Reservation_reservation_id;

            var select = Selectquery.Where(x => !rents.Contains(x.Reserv_id));

            dataGridView_my_reservation.DataSource = select;
            
            dataGridView_my_reservation.Columns[0].Visible = false; // veh_id
            dataGridView_my_reservation.Columns[8].Visible = false; // przebieg
            dataGridView_my_reservation.Columns[9].Visible = false; // reservation_id
            dataGridView_my_reservation.RowHeadersVisible = false;
            dataGridView_my_reservation.ReadOnly = true;        //nie moze edytować kolumn
            
            dataGridView_my_reservation.Columns[1].Width = 90;
            dataGridView_my_reservation.Columns[2].Width = 90;
            dataGridView_my_reservation.Columns[3].Width = 90;
            dataGridView_my_reservation.Columns[4].Width = 90;
            dataGridView_my_reservation.Columns[5].Width = 90;
            dataGridView_my_reservation.Columns[6].Width = 90;
            dataGridView_my_reservation.Columns[7].Width = 90;
        }
        
        private void dataGridView_my_reservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // panel_with_myreservation.Show();
            try
            {
                row = dataGridView_my_reservation.CurrentCell.RowIndex;
                label_brand.Text = (string)dataGridView_my_reservation.Rows[row].Cells[2].Value;
                label_model.Text = (string)dataGridView_my_reservation.Rows[row].Cells[3].Value;
                label_from.Text = dataGridView_my_reservation.Rows[row].Cells[4].Value.ToString();
                label_to.Text = (string)dataGridView_my_reservation.Rows[row].Cells[5].Value.ToString();
                label_purpose.Text = dataGridView_my_reservation.Rows[row].Cells[7].Value.ToString();
            }
            catch { }
        }

        private void button_rent_Click(object sender, EventArgs e)
        {
            try
            {
                if (row == -1)
                {
                    MessageBox.Show("Zaznacz rezerwację", "Good Rent", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RentSet newRent = new RentSet()
                    {
                        purpose = dataGridView_my_reservation.Rows[row].Cells[7].Value.ToString(),
                        date_from = Convert.ToDateTime(dataGridView_my_reservation.Rows[row].Cells[4].Value),
                        date_to = Convert.ToDateTime(dataGridView_my_reservation.Rows[row].Cells[5].Value),
                        mileage_start = Convert.ToInt32(dataGridView_my_reservation.Rows[row].Cells[8].Value),
                        Worker_worker_id = user_id,
                        Reservation_reservation_id = Convert.ToInt32(dataGridView_my_reservation.Rows[row].Cells[9].Value),
                        Vehicle_vehicle_id = Convert.ToInt32(dataGridView_my_reservation.Rows[row].Cells[0].Value),
                        mileage_end = 0
                        
                    };

                    db.RentSets.InsertOnSubmit(newRent);
                    db.SubmitChanges();

                    MessageBox.Show("Wypożyczyłeś samochód, bezpiecznej jazdy", "Good Rent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillDataGridView();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Coś się popsuło i nie było mnie słychać", "Good Rent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_delete_res_Click(object sender, EventArgs e)
        {
            try
            {
                if (row == -1)
                {
                    MessageBox.Show("Zaznacz rezerwację", "Bad delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var row_To_Delete = (from x in db.ReservationSets
                                         where x.reservation_id == Convert.ToInt32(dataGridView_my_reservation.Rows[row].Cells[9].Value)
                                         select x)
                                            .FirstOrDefault();
                    db.ReservationSets.DeleteOnSubmit(row_To_Delete);
                    db.SubmitChanges();

                    fillDataGridView();

                    MessageBox.Show("Rezerwacja usunięta", "Good delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Coś się popsuło i nie było mnie słychać", "Bad delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
