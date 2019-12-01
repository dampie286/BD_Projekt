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
                    avg_consumption = Convert.ToDouble(textBox_avg_fuel.Text),
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


    }
}

