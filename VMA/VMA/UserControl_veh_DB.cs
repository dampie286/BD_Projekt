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
            var Selectquery = from x in db.VehicleSets  where x.available=="yes "select new { MARKA=x.brand,MODEL=x.model,WERSJA=x.version,REJESTRACJA=x.licence_plate,SPALANIE=x.avg_consumption,PALIWO=x.fuel_type };

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
            DataBaseDataContext db = new DataBaseDataContext();



     

            var query = from x in db.VehicleSets where x.available == "yes " select x;

            if (filtr_brand == "Brand" || filtr_brand == "")
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
            if (filtr_version == "Version" || filtr_version == "")
            {

            }
            else
            {
                query = from x in query where x.version == filtr_version select x;

            }

            var query1 = from x in query select new { MARKA = x.brand, MODEL = x.model, WERSJA = x.version, REJESTRACJA = x.licence_plate, SPALANIE = x.avg_consumption, PALIWO = x.fuel_type };

            dataGridView_veh_DB.DataSource = query1;







            
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
    }
}
