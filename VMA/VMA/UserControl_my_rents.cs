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
    public partial class UserControl_my_rents : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        int user_id;
        int car_id;
        int row;
        public UserControl_my_rents()
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
                              join y in db.RentSets on x.vehicle_id equals y.Vehicle_vehicle_id
                              join z in db.WorkerSets on y.Worker_worker_id equals z.worker_id
                              where z.worker_id == user_id && y.mileage_end == 0
                              select new
                              {
                                  ID = x.vehicle_id,
                                  REJESTRACJA = x.licence_plate,
                                  MARKA = x.brand,
                                  MODEL = x.model,
                                  OD = y.date_from,
                                  DO = y.date_to,
                                  PRZEBIEG = x.mileage,
                                  CEL = y.purpose
                              };

            dataGridView_my_rents.DataSource = Selectquery;


            dataGridView_my_rents.Columns[0].Visible = false;
            dataGridView_my_rents.RowHeadersVisible = false;
            dataGridView_my_rents.ReadOnly = true;        //nie moze edytować kolumn


            dataGridView_my_rents.Columns[1].Width = 60;
            dataGridView_my_rents.Columns[2].Width = 60;
            dataGridView_my_rents.Columns[3].Width = 60;
            dataGridView_my_rents.Columns[4].Width = 90;
            dataGridView_my_rents.Columns[5].Width = 90;

              
        }

        private void dataGridView_my_rents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = dataGridView_my_rents.CurrentCell.RowIndex;
                label_brand.Text = (string)dataGridView_my_rents.Rows[row].Cells[2].Value;
                label_model.Text = (string)dataGridView_my_rents.Rows[row].Cells[3].Value;
                label_from.Text = Convert.ToDateTime(dataGridView_my_rents.Rows[row].Cells[4].Value.ToString()).ToShortDateString();
                label_to.Text = Convert.ToDateTime((string)dataGridView_my_rents.Rows[row].Cells[5].Value.ToString()).ToShortDateString();
                label_purpose.Text = dataGridView_my_rents.Rows[row].Cells[6].Value.ToString() + " [KM]";
                car_id = (int)dataGridView_my_rents.Rows[row].Cells[0].Value;
            }
            catch
            { }
        }

        private void button_confirm_end_rent_Click(object sender, EventArgs e)
        {
            try
            {
                RentSet rent = (from x in db.RentSets
                                where x.Vehicle_vehicle_id == car_id
                                      && x.date_from == Convert.ToDateTime(dataGridView_my_rents.Rows[row].Cells[4].Value)
                                      && x.date_to == Convert.ToDateTime(dataGridView_my_rents.Rows[row].Cells[5].Value)
                                select x).Single();
                
                    if (rent.mileage_start < Convert.ToInt32(textBox_mileage.Text))
                    {
                        rent.mileage_end = Convert.ToInt32(textBox_mileage.Text);
                        db.SubmitChanges();

                        try
                        {
                            VehicleSet veh = (from x in db.VehicleSets
                                              where x.vehicle_id == car_id
                                              select x).Single();
                            veh.mileage = Convert.ToInt32(textBox_mileage.Text);
                            db.SubmitChanges();
                        fillDataGridView();
                        litres_and_other_hide();
                        MessageBox.Show("Zakończenie rezerwacji zakończyło się powodzeniem", "Ending Rent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception)
                        {
                            MessageBox.Show("Nie udało się nadpisać przebiegu pojazdu", "Error Ending Rent", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Przebieg po jest mniejszy niż przed", "Error Ending Rent", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Zaznacz wypożyczenie", "Error Ending Rent", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_type_cost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_type_cost.SelectedIndex==0)
            {
                other_hide();
                litres_fuel_show();
            }
            else if(comboBox_type_cost.SelectedIndex == 1)
            {
                other_show();
                litres_fuel_hide();
            }
            else
            {
                litres_and_other_show();
            }
        }

        private void other_hide()
        {
            label_other.Hide();
            panel_other.Hide();
            textBox_other.Hide();
        }
        private void other_show()
        {
            label_other.Show();
            panel_other.Show();
            textBox_other.Show();
        }

        private void litres_fuel_hide()
        {
            label_litres.Hide();
            panel_litres.Hide();
            textBox_litres.Hide();
        }
        private void litres_fuel_show()
        {
            label_litres.Show();
            panel_litres.Show();
            textBox_litres.Show();
        }

        public void litres_and_other_show()
        {
            other_show();
            litres_fuel_show();
        }

        public void litres_and_other_hide()
        {
            other_hide();
            litres_fuel_hide();
        }
    }
}
