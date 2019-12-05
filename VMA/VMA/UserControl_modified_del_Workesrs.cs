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

        public UserControl_modified_del_Workesrs()
        {
            InitializeComponent();
        }


        private void Grid_edit()
        {

            //widocznos kolumn
            //  dataGridView_workers_DB.RowHeadersVisible = false;
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

            dataGridView_workers_DB.Columns[0].ReadOnly = true;//id
            dataGridView_workers_DB.Columns[1].ReadOnly = true;//imie
            dataGridView_workers_DB.Columns[2].ReadOnly = false;//nazwisko
            dataGridView_workers_DB.Columns[3].ReadOnly = false;//pozycja
            dataGridView_workers_DB.Columns[4].ReadOnly = true;//pesel
            dataGridView_workers_DB.Columns[5].ReadOnly = true;//data urodzenia
            dataGridView_workers_DB.Columns[6].ReadOnly = false;//haslo
            dataGridView_workers_DB.Columns[7].ReadOnly = false;//telefon
            dataGridView_workers_DB.Columns[8].ReadOnly = true;//keeper



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

            int row = dataGridView_workers_DB.CurrentCell.RowIndex;

            var edit_id = (int)dataGridView_workers_DB.Rows[row].Cells[0].Value;
            var surname_edit = dataGridView_workers_DB.Rows[row].Cells[2].Value.ToString();
            var position_edit = dataGridView_workers_DB.Rows[row].Cells[3].Value.ToString();
            var phone_edit = dataGridView_workers_DB.Rows[row].Cells[7].Value.ToString();

            var query = from x in db.WorkerSets where x.worker_id == edit_id select x;

            foreach (WorkerSet x in query)
            {
                x.surname = surname_edit;
                x.position = position_edit;
                x.phone_nr = phone_edit;

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

        private void button_delete_Click(object sender, EventArgs e)
        {
            

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
            int row = dataGridView_workers_DB.CurrentCell.RowIndex;

            var delete_id = (int)dataGridView_workers_DB.Rows[row].Cells[0].Value;




            var delete_list = (from x in db.WorkerSets where x.worker_id == delete_id select x).ToList();

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
    }
}