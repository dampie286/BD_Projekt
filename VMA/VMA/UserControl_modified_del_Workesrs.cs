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
    public partial class UserControl_modified_del_Workesrs : UserControl
    {

        int id;
        public UserControl_modified_del_Workesrs()
        {
            InitializeComponent();
        }

        public void panelHide()
        {
            panel_modified.Hide();
        }

        private void Grid_edit()
        {

            //widocznos kolumn
              dataGridView_workers_DB.RowHeadersVisible = false;
            dataGridView_workers_DB.Columns[0].Visible = false;
            //  dataGridView_workers_DB.Columns[1].Visible = false;
            // dataGridView_workers_DB.Columns[2].Visible = false;
            //dataGridView_workers_DB.Columns[3].Visible = false;
            dataGridView_workers_DB.Columns[4].Visible = false;
            dataGridView_workers_DB.Columns[5].Visible = false;
            dataGridView_workers_DB.Columns[6].Visible = false;
            // dataGridView_workers_DB.Columns[7].Visible = false;
            dataGridView_workers_DB.Columns[8].Visible = false;
            //opcje kolumn w edycji

          


            

          

        }

        public void fillDataGridView()
        {


            DataBaseDataContext db = new DataBaseDataContext();
            var query = from x in db.WorkerSets where x.position!="fired" select x;
           
            dataGridView_workers_DB.DataSource = query;
            Grid_edit();

        }

        




        private void button_modified_Click(object sender, EventArgs e)
        {
            panel_modified.Show();



            
           int row = dataGridView_workers_DB.CurrentCell.RowIndex;

            id = (int)dataGridView_workers_DB.Rows[row].Cells[0].Value; ;
           
            var surname = dataGridView_workers_DB.Rows[row].Cells[2].Value;
           var position = dataGridView_workers_DB.Rows[row].Cells[3].Value;
           var number = dataGridView_workers_DB.Rows[row].Cells[7].Value.ToString();
            var code = "KOD";
            var city = "Miasto";
            var street = "ulica";
            var home = "98/5";




            label_name_with_choice.Text = dataGridView_workers_DB.Rows[row].Cells[1].Value.ToString();
            textBox_edit_surname.Text = surname.ToString();
           comboBox_position.Text = position.ToString();
           textBox_edit_number.Text = number.ToString();
            textBox_city_cod.Text = code;
            textBox_city.Text = city;
            textBox_street.Text = street;
            textBox1_number_home.Text = home;




        }//dodac gdy w bazie bedzie adres



        private void button_filter_Click(object sender, EventArgs e)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            var query = from x in db.WorkerSets where x.position!="fired"  select x;
            string filtr_name=textBox_name.Text;
            string filtr_surname=textBox_surrname.Text;
            string filtr_position=textBox_position.Text;
            try
            {
                if (filtr_name == "Imię" || filtr_name == "")
                {

                }
                else
                {
                    query = from x in query where x.name == filtr_name select x;

                }
                if (filtr_surname == "Nazwisko" || filtr_surname == "")
                {
                }
                else
                {
                    query = from x in query where x.surname == filtr_surname select x;

                }
                if (filtr_position == "Stanowisko" || filtr_position == "")
                {

                }
                else
                {
                    query = from x in query where x.position == filtr_position select x;
                }

                dataGridView_workers_DB.DataSource = query;
                Grid_edit();
            }
            catch
            {
                MessageBox.Show("Zły format danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            }

        private void button_delete_Click_1(object sender, EventArgs e)
        {




            var result = MessageBox.Show("Czy napewno chcesz usunąć pracownika?", "Potwierdzenie",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                DataBaseDataContext db = new DataBaseDataContext();

                bool confirm = false;


                int row = dataGridView_workers_DB.CurrentCell.RowIndex;

               var idd = (int)dataGridView_workers_DB.Rows[row].Cells[0].Value; ;


                var delete_worker = from x in db.WorkerSets where x.worker_id == idd  select x;

                foreach (WorkerSet x in delete_worker)
                {
                    x.position = "fired";


                }
               
                var query = from x in db.CareSets where x.Keeper_worker_id == idd select x;

                foreach (CareSet x in query)
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

                    MessageBox.Show("Nie udało się usunąć pracownika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (confirm)
                    MessageBox.Show("Usunięto pracownika", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                fillDataGridView();
            }
            else
            {
                MessageBox.Show("Anulowano usunięcie pracownika", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }//zmodyfikować gdy usuniecie bedzie jako przeniesienie na stanowisko nie pracuje


        private void textBox_name_Enter_1(object sender, EventArgs e)
        {
            if (textBox_name.Text.Equals(@"Imię"))
            {
                textBox_name.Text = "";
            }
        }

        private void textBox_name_Leave_1(object sender, EventArgs e)
        {
            if (textBox_name.Text.Equals(""))
            {
                textBox_name.Text = "Imię";
            }
        }

        private void textBox_surrname_Enter_1(object sender, EventArgs e)
        {
            if (textBox_surrname.Text.Equals(@"Nazwisko"))
            {
                textBox_surrname.Text = "";
            }
        }

        private void textBox_surrname_Leave_1(object sender, EventArgs e)
        {
            if (textBox_surrname.Text.Equals(""))
            {
                textBox_surrname.Text = "Nazwisko";
            }
        }

        private void textBox_position_Enter_1(object sender, EventArgs e)
        {
            if (textBox_position.Text.Equals(@"Stanowisko"))
            {
                textBox_position.Text = "";
            }
        }

        private void textBox_position_Leave_1(object sender, EventArgs e)
        {
            if (textBox_position.Text.Equals(""))
            {
                textBox_position.Text = "Stanowisko";
            }
        }

       

       

        

        private void button_confirm_modification_Click(object sender, EventArgs e)
        {

            
           
           DataBaseDataContext db = new DataBaseDataContext();
           bool confirm = false;






           var query = from x in db.WorkerSets where x.worker_id == id select x;

           foreach (WorkerSet x in query)
           {
            
              x.surname=textBox_edit_surname.Text.ToString();
               x.position=comboBox_position.Text.ToString();
               x.phone_nr=textBox_edit_number.Text.ToString();
                //  textBox_city_cod.Text.ToString();
                // textBox_city.Text.ToString();
                //textBox_street.Text.ToString();
                // textBox1_number_home.Text.ToString();
                x.city="miasto";
            }
           try
           {
               db.SubmitChanges();
               confirm = true;
           }
           catch
           {
               MessageBox.Show("Nie udało się zmienić danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);

           }

           if (confirm)
           {
                fillDataGridView();
               MessageBox.Show("Zmieniono dane", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
           }

        }

        private void textBox_edit_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chh = e.KeyChar;

            if (!Char.IsDigit(chh) && chh != 8)
            {
                e.Handled = true;
            }
        }
    }
}