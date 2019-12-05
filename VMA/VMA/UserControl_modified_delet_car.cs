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
    public partial class UserControl_modified_delet_car : UserControl
    {
        public UserControl_modified_delet_car()
        {
            InitializeComponent();
        }

        private void gridedit()
        {

            dataGridView_veh_DB.Columns[0].Visible = false;
            dataGridView_veh_DB.Columns[1].Visible = true;
            dataGridView_veh_DB.Columns[2].Visible = true;
            dataGridView_veh_DB.Columns[3].Visible = true;
            dataGridView_veh_DB.Columns[4].Visible = false;
            dataGridView_veh_DB.Columns[5].Visible = true;
            dataGridView_veh_DB.Columns[6].Visible = true;
            dataGridView_veh_DB.Columns[7].Visible = true;
            dataGridView_veh_DB.Columns[8].Visible = false;

           
            
            dataGridView_veh_DB.Columns[1].Width = 60;///marka
            dataGridView_veh_DB.Columns[2].Width = 60;//model
            dataGridView_veh_DB.Columns[3].Width = 70;//wersja
            dataGridView_veh_DB.Columns[5].Width = 85;//rejestracja
            dataGridView_veh_DB.Columns[6].Width = 66;//spalanie
            dataGridView_veh_DB.Columns[7].Width = 55;//paliwo
            //dataGridView_veh_DB.Columns[7].Width = 55;//przebieg 



            dataGridView_veh_DB.Columns[0].ReadOnly = true;
            dataGridView_veh_DB.Columns[1].ReadOnly = true;
            dataGridView_veh_DB.Columns[2].ReadOnly = true;
            dataGridView_veh_DB.Columns[3].ReadOnly = true;
            dataGridView_veh_DB.Columns[4].ReadOnly = true;
            dataGridView_veh_DB.Columns[5].ReadOnly = true;
            dataGridView_veh_DB.Columns[6].ReadOnly = false;
            dataGridView_veh_DB.Columns[7].ReadOnly = false;
            dataGridView_veh_DB.Columns[8].ReadOnly = true;
            //  dataGridView_veh_DB.Columns[7].ReadOnly = true;//przebieg



        }

        public void fillDataGridView()
        {

            DataBaseDataContext db = new DataBaseDataContext();
            var Selectquery = from x in db.VehicleSets where x.available == "yes " && x.available != "deleted" select x;

            dataGridView_veh_DB.DataSource = Selectquery;

            gridedit();

         

        }

        private void button_delete_Click(object sender, EventArgs e)
        {


            DataBaseDataContext db = new DataBaseDataContext();
            bool confirm = false;

            int row = dataGridView_veh_DB.CurrentCell.RowIndex;

            var delete_id = (int)dataGridView_veh_DB.Rows[row].Cells[0].Value;
          

            var query = from x in db.VehicleSets where x.vehicle_id == delete_id select x;

            foreach (VehicleSet x in query)
            {
                x.available = "deleted";


            }
            try
            {
                db.SubmitChanges();
                confirm = true;
            }
            catch
            {
                MessageBox.Show("Nie udało się usunąć auta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (confirm)
            {
                MessageBox.Show("Usunięto auto", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            fillDataGridView();



        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            string filtr_brand = textBox_brand.Text;
            string filtr_model = textBox_model.Text;
            string filtr_version = textBox_version.Text;
            string filtr_licence = textBox_license.Text;
            string filtr_avg = textBox_equipment.Text;
            string filtr_fuel = textBox_mileage.Text;
            DataBaseDataContext db = new DataBaseDataContext();


            try
            { 

            var query = from x in db.VehicleSets where x.available == "yes " && x.available != "deleted" select x;

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




            var query1 = from x in query select new {I_auta=x.vehicle_id, MARKA = x.brand, MODEL = x.model, WERSJA = x.version, REJESTRACJA = x.licence_plate, SPALANIE = x.avg_consumption, PALIWO = x.fuel_type };

            dataGridView_veh_DB.DataSource = query1;

            gridedit();
        }
            catch
            {


                MessageBox.Show("Zły format danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





        }

        private void button_modified_Click(object sender, EventArgs e)
        {

            DataBaseDataContext db = new DataBaseDataContext();
            bool confirm = false;
            try
            {
                int row = dataGridView_veh_DB.CurrentCell.RowIndex;

            var edit_id = (int)dataGridView_veh_DB.Rows[row].Cells[0].Value;
            var avg = (double)dataGridView_veh_DB.Rows[row].Cells[6].Value;
            var fuel = dataGridView_veh_DB.Rows[row].Cells[7].Value.ToString();
            

            var query = from x in db.VehicleSets where x.vehicle_id == edit_id select x;

            foreach (VehicleSet x in query)
            {
                x.avg_consumption = avg;
                x.fuel_type = fuel;
                

            }
           
                db.SubmitChanges();
                confirm = true;
            }
            catch
            {
                MessageBox.Show("Nie udało się zmienić danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (confirm)
            {
                MessageBox.Show("Zmieniono dane", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            fillDataGridView();
            gridedit();


        }

        private void textBox_brand_Enter(object sender, EventArgs e)
        {
            if (textBox_brand.Text.Equals(@"Marka"))
            {
                textBox_brand.Text = "";
            }
        }

        private void textBox_brand_Leave(object sender, EventArgs e)
        {
            if (textBox_brand.Text.Equals(""))
            {
                textBox_brand.Text= "Marka";
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

        private void textBox_equipment_Enter(object sender, EventArgs e)
        {
            if (textBox_equipment.Text.Equals(@"Spalanie"))
            {
                textBox_equipment.Text = "";
            }
        }

        private void textBox_equipment_Leave(object sender, EventArgs e)
        {
            if (textBox_equipment.Text.Equals(""))
            {
                textBox_equipment.Text = "Spalanie";
            }
        }

        private void textBox_version_Enter(object sender, EventArgs e)
        {
            if (textBox_version.Text.Equals(@"Wersja"))
            {
                textBox_version.Text = "";
            }

        }

        private void textBox_version_Leave(object sender, EventArgs e)
        {
            if (textBox_version.Text.Equals(""))
            {
                textBox_version.Text = "Wersja";
            }
        }

        private void textBox_mileage_Enter(object sender, EventArgs e)
        {
            if (textBox_mileage.Text.Equals(@"Typ paliwa"))
            {
                textBox_mileage.Text = "";
            }
        }

        private void textBox_mileage_Leave(object sender, EventArgs e)
        {
            if (textBox_mileage.Text.Equals(""))
            {
                textBox_mileage.Text = "Typ paliwa";
            }
        }

        private void textBox_license_Enter(object sender, EventArgs e)
        {
            if (textBox_license.Text.Equals(@"Rejestracja"))
            {
                textBox_license.Text = "";
            }
        }

        private void textBox_license_Leave(object sender, EventArgs e)
        {
            if (textBox_license.Text.Equals(""))
            {
                textBox_license.Text = "Rejestracja";
            }
        }
    }
}
