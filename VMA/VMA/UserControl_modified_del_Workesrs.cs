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
    { int id;

        public UserControl_modified_del_Workesrs()
        {
            InitializeComponent();
        }


        private void Grid_edit()
        {

            //widocznos kolumn
              dataGridView_workers_DB.RowHeadersVisible = false;
            dataGridView_workers_DB.Columns[0].Visible = false;
            //  dataGridView_workers_DB.Columns[1].Visible = false;
            // dataGridView_workers_DB.Columns[2].Visible = false;
            //dataGridView_workers_DB.Columns[3].Visible = false;
            //dataGridView_workers_DB.Columns[4].Visible = false;
            dataGridView_workers_DB.Columns[5].Visible = false;
            dataGridView_workers_DB.Columns[6].Visible = false;
            // dataGridView_workers_DB.Columns[7].Visible = false;
            dataGridView_workers_DB.Columns[8].Visible = false;
            //opcje kolumn w edycji

          



            //rozmiary kolumn

            dataGridView_workers_DB.Columns[1].Width = 100;
            dataGridView_workers_DB.Columns[2].Width = 150;
            dataGridView_workers_DB.Columns[3].Width = 100;
            dataGridView_workers_DB.Columns[4].Width = 100;
            dataGridView_workers_DB.Columns[7].Width = 100;

        }

        public void fillDataGridView()
        {


            DataBaseDataContext db = new DataBaseDataContext();
            var query = from x in db.WorkerSets select x;

            dataGridView_workers_DB.DataSource = query;
            Grid_edit();

        }

        




        private void button_modified_Click(object sender, EventArgs e)
        {
            //modyfikowanie pracownika
            DataBaseDataContext db = new DataBaseDataContext();
            bool confirm = false;




            

            var query = from x in db.WorkerSets where x.worker_id == id select x;

            foreach (WorkerSet x in query)
            {
                x.surname = textBox_edit_surname.Text.ToString();
                x.position = textBox_edit_position.Text.ToString();
                x.phone_nr = textBox_edit_number.Text.ToString();

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
                MessageBox.Show("Zmieniono dane", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        

        private void button_filter_Click(object sender, EventArgs e)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            var query = from x in db.WorkerSets select x;
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


            //usuwanie pracownika
            DataBaseDataContext db = new DataBaseDataContext();

            bool confirm = false;
           




            var delete_list = (from x in db.WorkerSets where x.worker_id == id select x).ToList();

            db.WorkerSets.DeleteAllOnSubmit(delete_list);


            try
            {
                db.SubmitChanges();
                confirm = true;
            }
            catch
            {

                MessageBox.Show("Nie można usunąć pracownika będącego opiekunem", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (confirm)
                MessageBox.Show("Usunięto pracownika", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            var Selectquery = from x in db.WorkerSets select x;




            dataGridView_workers_DB.DataSource = Selectquery;
            Grid_edit();


        }


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

       

       

        private void dataGridView_workers_DB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView_workers_DB.CurrentCell.RowIndex;

            id = (int)dataGridView_workers_DB.Rows[row].Cells[0].Value; ;
            var surname = dataGridView_workers_DB.Rows[row].Cells[2].Value;
            var position = dataGridView_workers_DB.Rows[row].Cells[3].Value;
            var number = dataGridView_workers_DB.Rows[row].Cells[7].Value.ToString();


            label_name.Text = dataGridView_workers_DB.Rows[row].Cells[1].Value.ToString();



            textBox_edit_surname.Text = surname.ToString();
            textBox_edit_position.Text = position.ToString();
            textBox_edit_number.Text = number.ToString();



        }
    }
}