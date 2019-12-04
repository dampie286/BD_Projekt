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
    public partial class UserControl_veh_DB : UserControl
    {
        private DataTable veh_DB = new DataTable();
        public UserControl_veh_DB()
        {
            InitializeComponent();

           
        }


        public void fillDataGridView()
        {
            DataBaseDataContext db = new DataBaseDataContext();
            var Selectquery = from x in db.VehicleSets  where x.available=="yes " &&x.available!="deleted"select new { MARKA=x.brand,MODEL=x.model,WERSJA=x.version,REJESTRACJA=x.licence_plate,SPALANIE=x.avg_consumption,PALIWO=x.fuel_type };

            dataGridView_veh_DB.DataSource = Selectquery;
            
  
           
         dataGridView_veh_DB.RowHeadersVisible = false;
            dataGridView_veh_DB.ReadOnly = true;        //nie moze edytować kolumn

            dataGridView_veh_DB.Columns[0].Width = 70;
            dataGridView_veh_DB.Columns[1].Width = 70;
           dataGridView_veh_DB.Columns[2].Width = 90;
            dataGridView_veh_DB.Columns[3].Width = 100;
          dataGridView_veh_DB.Columns[4].Width = 90;
            dataGridView_veh_DB.Columns[5].Width = 90;
        

        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            // dtSpecifficCliniDoctors = dtDoctor.Select("CID = " + dtClinic.Rows[comboBox_clinic.SelectedIndex]["CID"]).CopyToDataTable();
            string filtr_brand = textBox_brand.Text;
            string filtr_model = textBox_model.Text;
            string filtr_version = textBox_version.Text;
            string filtr_licence = textBox_license.Text;
            string filtr_avg = textBox_equipment.Text;
            string filtr_fuel = textBox_mileage.Text;
            DataBaseDataContext db = new DataBaseDataContext();


            try
            {


                var query = from x in db.VehicleSets where x.available == "yes " &&x.available!="deleted" select x;

                if (filtr_brand == "Marka" || filtr_brand == "")
                {

                }
                else
                {
                    query = from x in query where x.brand == filtr_brand select x;

                }

                if (filtr_model == "Model" || filtr_model == "")
                {

                }
                else
                {
                    query = from x in query where x.model == filtr_model select x;

                }
                if (filtr_version == "Wersja" || filtr_version == "")
                {

                }
                else
                {
                    query = from x in query where x.version == filtr_version select x;

                }
                if (filtr_licence == "Rejestracja" || filtr_licence == "")
                {

                }
                else
                {
                    query = from x in query where x.licence_plate == filtr_licence select x;

                }

                if (filtr_avg == "Spalanie" || filtr_avg == "")
                {

                }
                else
                {
                    double avg = Convert.ToDouble(filtr_avg);// wymaga zabezpieczenia przed złym formatem i stringiem 
                    query = from x in query where x.avg_consumption <= avg select x;

                }
                if (filtr_fuel == "Typ paliwa" || filtr_fuel == "")
                {

                }
                else
                {
                    query = from x in query where x.fuel_type == filtr_fuel select x;

                }




                var query1 = from x in query select new { MARKA = x.brand, MODEL = x.model, WERSJA = x.version, REJESTRACJA = x.licence_plate, SPALANIE = x.avg_consumption, PALIWO = x.fuel_type, };

                dataGridView_veh_DB.DataSource = query1;

            }
            catch
            {
                MessageBox.Show("Zły format danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





            
                        dataGridView_veh_DB.RowHeadersVisible = false;
                        dataGridView_veh_DB.ReadOnly = true;        //nie moze edytować kolumn

                      dataGridView_veh_DB.Columns[0].Width = 70;
                        dataGridView_veh_DB.Columns[1].Width = 70;
                       dataGridView_veh_DB.Columns[2].Width = 90;
                        dataGridView_veh_DB.Columns[3].Width = 100;
                        dataGridView_veh_DB.Columns[4].Width = 90;
                        dataGridView_veh_DB.Columns[5].Width = 90;
            

        }

        private void textBox_brand_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_brand_Leave(object sender, EventArgs e)
        {
            if (textBox_brand.Text.Equals(""))
            {
                textBox_brand.Text = "Marka";
                textBox_brand.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        private void textBox_brand_Enter(object sender, EventArgs e)
        {
            if (textBox_brand.Text.Equals(@"Marka"))
            {
                textBox_brand.ForeColor = Color.FromArgb(255, 255, 0);
                textBox_brand.Text = "";
            }
        }

        private void textBox_model_Enter(object sender, EventArgs e)
        {
            if (textBox_model.Text.Equals(@"Model"))
            {
                textBox_model.Text = "";
                textBox_model.ForeColor = Color.FromArgb(255, 255, 0);
            }
        }

        private void textBox_model_Leave(object sender, EventArgs e)
        {
            if (textBox_model.Text.Equals(""))
            {
                textBox_model.Text = "Model";
                textBox_model.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        private void textBox_equipment_Enter(object sender, EventArgs e)
        {
            if (textBox_equipment.Text.Equals(@"Spalanie"))
            {
                textBox_equipment.Text = "";
                textBox_equipment.ForeColor = Color.FromArgb(255, 255, 0);
            }
        }

        private void textBox_equipment_Leave(object sender, EventArgs e)
        {
            if (textBox_equipment.Text.Equals(""))
            {
                textBox_equipment.Text = "Spalanie";
                textBox_equipment.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        private void textBox_version_Enter(object sender, EventArgs e)
        {
            if (textBox_version.Text.Equals(@"Wersja"))
            {
                textBox_version.Text = "";
                textBox_version.ForeColor = Color.FromArgb(255, 255, 0);
            }
        }

        private void textBox_version_Leave(object sender, EventArgs e)
        {
            if (textBox_version.Text.Equals(""))
            {
                textBox_version.Text = "Wersja";
                textBox_version.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        private void textBox_mileage_Enter(object sender, EventArgs e)
        {
            if (textBox_mileage.Text.Equals(@"Typ paliwa"))
            {
                textBox_mileage.Text = "";
                textBox_mileage.ForeColor = Color.FromArgb(255, 255, 0);
            }
        }

        private void textBox_mileage_Leave(object sender, EventArgs e)
        {
            if (textBox_mileage.Text.Equals(""))
            {
                textBox_mileage.Text = "Typ paliwa";
                textBox_mileage.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        private void textBox_license_Enter(object sender, EventArgs e)
        {
            if (textBox_license.Text.Equals(@"Rejestracja"))
            {
                textBox_license.Text = "";
                textBox_license.ForeColor = Color.FromArgb(255, 255, 0);
            }
        }

        private void textBox_license_Leave(object sender, EventArgs e)
        {
            if (textBox_license.Text.Equals(""))
            {
                textBox_license.Text = "Rejestracja";
                textBox_license.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }
    }
}
