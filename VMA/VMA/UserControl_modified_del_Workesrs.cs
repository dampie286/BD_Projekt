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
        int delete_id;
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

            dataGridView_workers_DB.Columns[0].ReadOnly = true;//id
            dataGridView_workers_DB.Columns[1].ReadOnly = true;//imie
            dataGridView_workers_DB.Columns[2].ReadOnly = false;//nazwisko
            dataGridView_workers_DB.Columns[3].ReadOnly = false;//pozycja
            dataGridView_workers_DB.Columns[4].ReadOnly = true;//pesel
            dataGridView_workers_DB.Columns[5].ReadOnly = true;//data urodzenia
            dataGridView_workers_DB.Columns[6].ReadOnly = false;//haslo
            dataGridView_workers_DB.Columns[7].ReadOnly = false;//telefon
            dataGridView_workers_DB.Columns[8].Visible = false;//keeper



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
            var Selectquery = from x in db.WorkerSets select x;

          


            dataGridView_workers_DB.DataSource = Selectquery;
            Grid_edit();

        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            string filtr_name = textBox_name.Text;
            string filtr_surname = textBox_surrname.Text;
            string filtr_position = textBox_position.Text;


            DataBaseDataContext db = new DataBaseDataContext();





            var query = from x in db.WorkerSets select x;

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
            if (filtr_position == "Stanowisko" || filtr_position== "")
            {

            }
            else
            {
                query = from x in query where x.position == filtr_position select x;

            }

            dataGridView_workers_DB.DataSource = query;
            Grid_edit();

        }



        private void button_modified_Click(object sender, EventArgs e)
        {

            
            DataBaseDataContext db = new DataBaseDataContext();

            db.SubmitChanges();


            var Selectquery = from x in db.WorkerSets select x;

            dataGridView_workers_DB.DataSource = Selectquery;
            Grid_edit();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            var delete = from x in db.WorkerSets where x.worker_id == delete_id select x;

            foreach (var worker in delete)
            {
                db.WorkerSets.DeleteOnSubmit(worker);
            }

            try
            {
                db.SubmitChanges();
            }
            catch 
            {
               
            }
            var Selectquery = from x in db.WorkerSets select x;


        }


        private void dataGridView_workers_DB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView_workers_DB.Rows[index];
            delete_id = (int)selectedRow.Cells[0].Value;
            MessageBox.Show(delete_id.ToString());

        }
    }
}
