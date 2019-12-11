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
            double consump;
            bool confirm=false;
            if (textBox_avg_fuel.Text.Contains("."))
            {
                consump = Convert.ToDouble(textBox_avg_fuel.Text.Replace('.', ','));
            }
            else
            {
                consump = Convert.ToDouble(textBox_avg_fuel.Text);
            }

            using (DataBaseDataContext db = new DataBaseDataContext())
            {
                try
                {
                    VehicleSet car = new VehicleSet()
                    {
                        brand = textBox_brand.Text,
                        model =textBox_model.Text,
                        version = comboBox_car_version.Text,
                        equipment = "",
                        licence_plate = textBox_license.Text,
                        fuel_type = comboBox_type_of_fuel.Text,
                        avg_consumption = Convert.ToDouble(consump),
                        available = "yes",
                        mileage=Convert.ToInt32(textBox_mileage.Text)
                    };
                    db.VehicleSets.InsertOnSubmit(car);
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

            char chh = e.KeyChar;
           
            if (!Char.IsDigit(chh) && chh != 8)
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

