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
        int rent_id;
        double litres;
        int mileage1;
        
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
                                  DO = y.date_to.ToShortDateString(),
                                  PRZEBIEG = x.mileage,
                                  CEL = y.purpose,
                                  id_rent = y.rent_id
                              };

            dataGridView_my_rents.DataSource = Selectquery;


            dataGridView_my_rents.Columns[0].Visible = false;
            dataGridView_my_rents.Columns[8].Visible = false;
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
                rent_id = (int)dataGridView_my_rents.Rows[row].Cells[8].Value;
            }
            catch
            { }
        }

        private void button_confirm_end_rent_Click(object sender, EventArgs e)
        {
             try
             {
            var rent = (from x in db.RentSets
                            where x.rent_id == rent_id select x).Single();

                if (!string.IsNullOrEmpty(textBox_mileage.Text))
                {
                    if (rent.mileage_start < Convert.ToInt32(textBox_mileage.Text))
                    {
                        rent.mileage_end = Convert.ToInt32(textBox_mileage.Text);


                        try
                        {
                            VehicleSet veh = (from x in db.VehicleSets
                                              where x.vehicle_id == car_id
                                              select x).Single();
                            veh.mileage = Convert.ToInt32(textBox_mileage.Text);
                            db.SubmitChanges();

                            MessageBox.Show("Zakończenie rezerwacji zakończyło się powodzeniem", "Ending Rent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Nie udało się nadpisać przebiegu pojazdu", "Error Ending Rent", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        mileage1 = Convert.ToInt32(textBox_mileage.Text) - Convert.ToInt32(dataGridView_my_rents.Rows[row].Cells[6].Value.ToString());

                        if (comboBox_type_cost.SelectedIndex == -1)
                        {
                            db.SubmitChanges();
                        }
                        else if (comboBox_type_cost.Text == "Tankowanie")
                        {
                            litres = Convert.ToDouble(textBox_litres.Text);
                            PurchaseSet car = new PurchaseSet()
                            {
                                Rent_rent_id = rent_id,
                                price = Convert.ToDouble(textBox_all_cost.Text),
                                type = "Paliwo",
                                purchase_date = rent.date_to,
                                litres = Convert.ToDouble(textBox_litres.Text),
                                mileage = mileage1
                            };
                            db.PurchaseSets.InsertOnSubmit(car);

                            db.SubmitChanges();
                        }
                        else if (comboBox_type_cost.Text == "Tankowanie oraz inne")
                        {
                            litres = Convert.ToDouble(textBox_litres.Text);
                            PurchaseSet car = new PurchaseSet()
                            {
                                Rent_rent_id = rent_id,
                                price = Convert.ToDouble(textBox_all_cost.Text),
                                type = textBox_other.Text,
                                purchase_date = rent.date_to,
                                litres = litres,
                                mileage = mileage1
                            };
                            db.PurchaseSets.InsertOnSubmit(car);

                            db.SubmitChanges();
                        }
                        else if (comboBox_type_cost.Text == "Inne")
                        {
                            PurchaseSet car = new PurchaseSet()
                            {
                                Rent_rent_id = rent_id,
                                price = Convert.ToDouble(textBox_all_cost.Text),
                                type = textBox_other.Text,
                                purchase_date = rent.date_to,
                                litres = 0,
                                mileage = mileage1
                            };
                            db.PurchaseSets.InsertOnSubmit(car);

                            db.SubmitChanges();
                        }


                        fillDataGridView();
                        litres_and_other_hide();
                    }
                    else
                    {
                        MessageBox.Show("Przebieg po jest mniejszy niż przed", "Error Ending Rent", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Wpisz przebieg po zakończeniu jazd", "Error Ending Rent", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
           catch (Exception)
            {
                MessageBox.Show("Zaznacz wypożyczenie", "Error Ending Rent", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
            //   czyszczenie
            textBox_mileage.Clear();
            textBox_other.Clear();
            textBox_litres.Clear();
            textBox_all_cost.Clear();





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

        private void textBox_litres_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chh = e.KeyChar;
            if (chh == 46 && textBox_litres.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(chh) && chh != 8 && chh != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox_all_cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chh = e.KeyChar;
            if (chh == 46 && textBox_all_cost.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(chh) && chh != 8 && chh != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox_mileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chh = e.KeyChar;

            if (!Char.IsDigit(chh) && chh != 8)
            {
                e.Handled = true;
            }
        }
    }
}
