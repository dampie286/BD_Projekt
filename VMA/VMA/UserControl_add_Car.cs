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
                    equipment = Convert.ToString(textBox_version.Text),
                    licence_plate = Convert.ToString(textBox_license.Text),
                    fuel_type = Convert.ToString(textBox_fuel_type.Text),
                    avg_consumption = Convert.ToDouble(consump),
                    available = "yes"
                };
                db.VehicleSets.InsertOnSubmit(car);
                db.SubmitChanges();
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
            textBox_version.Clear();
        }

        private void textBox_fuel_type_Click(object sender, EventArgs e)
        {
            textBox_fuel_type.Clear();
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

       
    }
}

