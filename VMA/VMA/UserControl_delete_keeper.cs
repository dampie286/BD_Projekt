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
    public partial class UserControl_delete_keeper : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public UserControl_delete_keeper()
        {
            InitializeComponent();
        }

        private void Grid_edit()
        {

            //widocznos kolumn
            //  dataGridView_workers_DB.RowHeadersVisible = false;
            dataGridView_keepers_DB.Columns[0].Visible = false;
            //  dataGridView_workers_DB.Columns[1].Visible = false;
            // dataGridView_workers_DB.Columns[2].Visible = false;
            //dataGridView_workers_DB.Columns[3].Visible = false;
            //dataGridView_workers_DB.Columns[4].Visible = false;
            dataGridView_keepers_DB.Columns[5].Visible = false;
            dataGridView_keepers_DB.Columns[6].Visible = false;
            // dataGridView_workers_DB.Columns[7].Visible = false;
            dataGridView_keepers_DB.Columns[8].Visible = false;
            //opcje kolumn w edycji

            dataGridView_keepers_DB.Columns[0].ReadOnly = true;//id
            dataGridView_keepers_DB.Columns[1].ReadOnly = true;//imie
            dataGridView_keepers_DB.Columns[2].ReadOnly = false;//nazwisko
            dataGridView_keepers_DB.Columns[3].ReadOnly = false;//pozycja
            dataGridView_keepers_DB.Columns[4].ReadOnly = true;//pesel
            dataGridView_keepers_DB.Columns[5].ReadOnly = true;//data urodzenia
            dataGridView_keepers_DB.Columns[6].ReadOnly = false;//haslo
            dataGridView_keepers_DB.Columns[7].ReadOnly = false;//telefon
            dataGridView_keepers_DB.Columns[8].Visible = false;//keeper



            //rozmiary kolumn

            dataGridView_keepers_DB.Columns[1].Width = 100;
            dataGridView_keepers_DB.Columns[2].Width = 150;
            dataGridView_keepers_DB.Columns[3].Width = 100;
            dataGridView_keepers_DB.Columns[4].Width = 100;
            dataGridView_keepers_DB.Columns[7].Width = 100;

        }

        public void fillDataGridView2()
        {



            var query = from x in db.WorkerSets select x;

            dataGridView_keepers_DB.DataSource = query;
            Grid_edit();

        }
    }
}
