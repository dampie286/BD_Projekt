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
                VehicleSet car = new VehicleSet()
                {
                    brand = Convert.ToString(textBox_brand.Text),
                    model = Convert.ToString(textBox_model.Text),
                    version = Convert.ToString(textBox_fuel_type.Text),
                    equipment = Convert.ToString(textBox_equipment.Text),
                    licence_plate = Convert.ToString(textBox_license.Text),
                    fuel_type = Convert.ToString(textBox_fuel_type.Text),
                    avg_consumption = Convert.ToDouble(consump),
                    available = "yes"
                };
                db.VehicleSets.InsertOnSubmit(car);
                db.SubmitChanges();
            }
        }
        private void textBox_brand_Leave(object sender, EventArgs e)
        {
            if (textBox_brand.Text.Equals(""))
            {
                textBox_brand.Text = "Marka";
            }
        }

        private void textBox_brand_Enter(object sender, EventArgs e)
        {
            if (textBox_brand.Text.Equals(@"Marka"))
            {
                textBox_brand.Text = "";
            }
        }

        private void textBox_model_Enter(object sender, EventArgs e)
        {
            if (textBox_model.Text.Equals(@"Model"))
            {
                textBox_model.Text = "";
            }
        }

        private void textBox_model_Leave(object sender, EventArgs e)
        {
            if (textBox_model.Text.Equals(""))
            {
                textBox_model.Text = "Model";
            }
        }

        private void textBox_age_Leave(object sender, EventArgs e)
        {
            if (textBox_age.Text.Equals(""))
            {
                textBox_age.Text = "Rocznik";
            }
        }

        private void textBox_age_Enter(object sender, EventArgs e)
        {
            if (textBox_age.Text.Equals(@"Rocznik"))
            {
                textBox_age.Text = "";
            }
        }

        private void textBox_equipment_Leave(object sender, EventArgs e)
        {
            if (textBox_equipment.Text.Equals(""))
            {
                textBox_equipment.Text = "Wyposażenie";
            }
        }

        private void textBox_equipment_Enter(object sender, EventArgs e)
        {
            if (textBox_equipment.Text.Equals(@"Wyposażenie"))
            {
                textBox_equipment.Text = "";
            }
        }

        private void textBox_fuel_type_Enter(object sender, EventArgs e)
        {
            if (textBox_fuel_type.Text.Equals(@"Typ paliwa"))
            {
                textBox_fuel_type.Text = "";
            }
        }

        private void textBox_fuel_type_Leave(object sender, EventArgs e)
        {
            if (textBox_fuel_type.Text.Equals(""))
            {
                textBox_fuel_type.Text = "Typ paliwa";
            }
        }

        private void textBox_license_Enter(object sender, EventArgs e)
        {
            if (textBox_license.Text.Equals(@"Numer rejestracyjny"))
            {
                textBox_license.Text = "";
            }
        }

        private void textBox_license_Leave(object sender, EventArgs e)
        {
            if (textBox_license.Text.Equals(""))
            {
                textBox_license.Text = "Numer rejestracyjny";
            }
        }

        private void textBox_date_register_Enter(object sender, EventArgs e)
        {
            if (textBox_date_register.Text.Equals(@"Data Rejestracji"))
            {
                textBox_date_register.Text = "";
            }
        }

        private void textBox_date_register_Leave(object sender, EventArgs e)
        {
            if (textBox_date_register.Text.Equals(""))
            {
                textBox_date_register.Text = "Data Rejestracji";
            }
        }

        private void textBox_mileage_Enter(object sender, EventArgs e)
        {
            if (textBox_mileage.Text.Equals(@"Przebieg"))
            {
                textBox_mileage.Text = "";
            }
        }

        private void textBox_mileage_Leave(object sender, EventArgs e)
        {
            if (textBox_mileage.Text.Equals(""))
            {
                textBox_mileage.Text = "Przebieg";
            }
        }

        private void textBox_avg_fuel_Enter(object sender, EventArgs e)
        {
            if (textBox_avg_fuel.Text.Equals(@"Średnie spalanie"))
            {
                textBox_avg_fuel.Text = "";
            }
        }

        private void textBox_avg_fuel_Leave(object sender, EventArgs e)
        {
            if (textBox_avg_fuel.Text.Equals(""))
            {
                textBox_avg_fuel.Text = "Średnie spalanie";
            }
        }
    }
}

