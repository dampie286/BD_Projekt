using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace VMA
{
    public partial class UserControl_modified_delet_car : UserControl
    {
        int id;
        
        
        public UserControl_modified_delet_car()
        {
            InitializeComponent();
            
        }

        private void gridedit()
        {



            dataGridView_veh_DB.RowHeadersVisible = false;
            dataGridView_veh_DB.Columns[0].Visible = false;
            dataGridView_veh_DB.Columns[1].Visible = true;
            dataGridView_veh_DB.Columns[2].Visible = true;
            dataGridView_veh_DB.Columns[3].Visible = true;
            dataGridView_veh_DB.Columns[4].Visible = false;
            dataGridView_veh_DB.Columns[5].Visible = true;
            dataGridView_veh_DB.Columns[6].Visible = true;
            dataGridView_veh_DB.Columns[7].Visible = true;
            dataGridView_veh_DB.Columns[8].Visible = false;

           
            
        


          



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


            var result = MessageBox.Show("Czy napewno chcesz usunąć auto?", "Potwierdzenie",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                DataBaseDataContext db = new DataBaseDataContext();
                bool confirm = false;

                int row = dataGridView_veh_DB.CurrentCell.RowIndex;

                var id_del = (int)dataGridView_veh_DB.Rows[row].Cells[0].Value;


                var query = from x in db.VehicleSets where x.vehicle_id == id_del select x;



                foreach (VehicleSet x in query)
                {
                    x.available = "deleted";


                }


                var query1 = from x in db.CareSets where x.Vehicle_vehicle_id == id_del && x.date_to==null select x;

                foreach (CareSet x in query1)
                {
                    x.date_to = DateTime.Today;

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
            else {

                MessageBox.Show("Anulowano usunięcie auta", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



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
                double avg = Double.Parse(filtr_avg, CultureInfo.InvariantCulture);
                    query = from x in query where x.avg_consumption <= avg select x;

            }
            if (filtr_fuel == "Typ paliwa" || filtr_fuel == "")
            {

            }
            else
            {
                query = from x in query where x.fuel_type == filtr_fuel select x;

            }




            var query1 = from x in query select x; 

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
            try
            {
               

                int row = dataGridView_veh_DB.CurrentCell.RowIndex;

                id = (int)dataGridView_veh_DB.Rows[row].Cells[0].Value;
                label_brand.Text = dataGridView_veh_DB.Rows[row].Cells[1].Value.ToString();
                label_model.Text = dataGridView_veh_DB.Rows[row].Cells[2].Value.ToString();

                string x = dataGridView_veh_DB.Rows[row].Cells[6].Value.ToString();

                string y = x.Replace(",", ".");

                textBox_combustion.Text = y;


                comboBox_car_version.Text = dataGridView_veh_DB.Rows[row].Cells[3].Value.ToString();

                textBox_edit_lic.Text = dataGridView_veh_DB.Rows[row].Cells[5].Value.ToString();
                comboBox_type_of_fuel.Text = dataGridView_veh_DB.Rows[row].Cells[7].Value.ToString();
                panel_modified.Show();
            }
            catch {

                MessageBox.Show("Nie wybrano auta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private void button1_Click(object sender, EventArgs e)
        {

            DataBaseDataContext db = new DataBaseDataContext();
            bool confirm = false;
            try
            {


                var query = from x in db.VehicleSets where x.vehicle_id == id select x;

                double avg = Double.Parse(textBox_combustion.Text, CultureInfo.InvariantCulture);

              

                foreach (VehicleSet x in query)
                {
                    x.avg_consumption = avg;
                    x.fuel_type = comboBox_type_of_fuel.Text.ToString();
                    x.licence_plate = textBox_edit_lic.Text.ToString();
                    x.version = comboBox_car_version.Text.ToString();
                    

                }

                db.SubmitChanges();
                confirm = true;
            }
            catch
            {
                MessageBox.Show("Nie udało się zmienić danych.Spróbuj podać Spalanie w formiacie wartość.wartość", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
       
        public void panelHide()
        {
            panel_modified.Hide();
        }

        private void textBox_combustion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chh = e.KeyChar;
            if (chh == 46 && textBox_combustion.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(chh) && chh != 8 && chh != 46)
            {
                e.Handled = true;
            }



        }

        private void textBox_equipment_KeyPress(object sender, KeyPressEventArgs e)
        {


            char chh = e.KeyChar;
            if (chh == 46 && textBox_equipment.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(chh) && chh != 8 && chh != 46)
            {
                e.Handled = true;
            }




        }
    }
}
