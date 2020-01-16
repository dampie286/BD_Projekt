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
    public partial class UserControl_add_Car : UserControl
    {
        public UserControl_add_Car()
        {
            InitializeComponent();
        }

        private void button_add_car_Click(object sender, EventArgs e)
        {
            double consump=0;
            bool confirm=false;
            try
            {
                if (textBox_avg_fuel.Text.Contains("."))
                {
                    consump = Convert.ToDouble(textBox_avg_fuel.Text.Replace('.', ','));
                }
                else
                {
                    consump = Convert.ToDouble(textBox_avg_fuel.Text);
                }
            }
            catch {

                MessageBox.Show("Bład dodania auta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            using (DataBaseDataContext db = new DataBaseDataContext())
            {


                string plate = textBox_license.Text;
               string plateV1= plate.ToUpper();



                try
                {
                    VehicleSet car = new VehicleSet()
                    {
                        brand = textBox_brand.Text,
                        model =textBox_model.Text,
                        version = comboBox_car_version.Text,
                        equipment = "",
                        licence_plate = plateV1,
                        fuel_type = comboBox_type_of_fuel.Text,
                        avg_consumption = Convert.ToDouble(consump),
                        available = "yes",
                        mileage=Convert.ToInt32(textBox_mileage.Text)
                    };
                    db.VehicleSets.InsertOnSubmit(car);
                  
                    db.SubmitChanges();

                    VehicleSet newcar = db.VehicleSets.OrderByDescending(p => p.vehicle_id).First();

                    Check_vehicleSet check = new Check_vehicleSet()
                    {

                        tech_review = dateTimePicker_date_tech.Value,
                        oil_change=dateTimePicker_oil_date.Value,
                        oil_change_mileage= Convert.ToInt32(textBox_oil_km.Text),
                        timing_gear= dateTimePicker_gear_date.Value,
                        timing_gear_mileage=Convert.ToInt32(textBox_gear_km.Text),
                        Vehicle_vehicle_id=newcar.vehicle_id,
                    };
                    
                    db.Check_vehicleSets.InsertOnSubmit(check);
                    db.SubmitChanges();
                    confirm = true;
                }
                catch
                {

                    MessageBox.Show("Bład dodania auta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (confirm)
                {
                    MessageBox.Show("Dodano auto", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox_age.Clear();
                    textBox_avg_fuel.Clear();
                    textBox_brand.Clear();
                    textBox_license.Clear();
                    textBox_mileage.Clear();
                    textBox_model.Clear();

                    textBox_oil_km.Clear();
                    textBox_gear_km.Clear();
                }
            }
        }
       
        private void textBox_brand_Click(object sender, EventArgs e)
        {
            textBox_brand.Clear();
        }

        private void textBox_model_Click(object sender, EventArgs e)
        {
            textBox_model.Clear();
        }

        private void textBox_age_Click(object sender, EventArgs e)
        {
            textBox_age.Clear();
        }

        private void textBox_version_Click(object sender, EventArgs e)
        {
            //textBox_version.Clear();
        }

        private void textBox_fuel_type_Click(object sender, EventArgs e)
        {
          //  textBox_fuel_type.Clear();
        }

        private void textBox_license_Click(object sender, EventArgs e)
        {
            textBox_license.Clear();
        }

        private void textBox_mileage_Click(object sender, EventArgs e)
        {
            textBox_mileage.Clear();
        }

        private void textBox_avg_fuel_Click(object sender, EventArgs e)
        {
            textBox_avg_fuel.Clear();
        }

        private void UserControl_add_Car_Load(object sender, EventArgs e)
        {

        }

        private void textBox_avg_fuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chh = e.KeyChar;
            if (chh == 46 && textBox_avg_fuel.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(chh) && chh != 8 && chh != 46)
            {
                e.Handled = true;
            }

        }

        private void textBox_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = textBox_age.TextLength;


            char chh = e.KeyChar;


            if (Char.IsDigit(chh) || chh ==8)
            {
                if ( chh != 8)
                {
                    if (x > 3)
                    {

                        e.Handled = true;


                    }

                }
            }
            else
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

        private void UserControl_add_Car_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chh = e.KeyChar;

            if (!Char.IsDigit(chh) && chh != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_gear_km_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chh = e.KeyChar;

            if (!Char.IsDigit(chh) && chh != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_license_KeyPress(object sender, KeyPressEventArgs e)
        {

         int x= textBox_license.TextLength;
            

            char chh = e.KeyChar;


            if (chh != 32)
            {
                if (chh != 8)
                {
                    if (x > 8)
                    {

                        e.Handled = true;


                    }

                }
            }
            else
            {
                e.Handled = true;

            }


        }

        public void ClearUserControl()
        {
            textBox_brand.Clear();
            textBox_model.Clear();
            textBox_age.Clear();
            textBox_license.Clear();
            textBox_mileage.Clear();
            textBox_avg_fuel.Clear();
            dateTimePicker_date_tech.Value = DateTime.Today;
            dateTimePicker_oil_date.Value = DateTime.Today;
            textBox_oil_km.Clear();
            dateTimePicker_gear_date.Value = DateTime.Today;
            textBox_gear_km.Clear();
        }

        private void textBox_oil_km_KeyPress(object sender, KeyPressEventArgs e)
        {

            char chh = e.KeyChar;

            if (!Char.IsDigit(chh) && chh != 8)
            {
                e.Handled = true;
            }



        }

        private void pictureBox_help_Click(object sender, EventArgs e)
        {
            helppdf help = new helppdf(30);
            help.Show();
        }
    }
    }
    


