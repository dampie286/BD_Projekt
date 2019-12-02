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
    public partial class UserControl_addKeeper : UserControl
    {
        public UserControl_addKeeper()
        {
            InitializeComponent();
        }

        public void fillDataGridView(DataTable tmp) //uzupełnienie tabeli
        {
            dataGridView_veh_DB.DataSource = tmp;



            dataGridView_veh_DB.Columns[0].Visible = false;
            dataGridView_veh_DB.RowHeadersVisible = false;
            dataGridView_veh_DB.ReadOnly = true;        //nie moze edytować kolumn


            dataGridView_veh_DB.Columns[1].Width = 60;
            dataGridView_veh_DB.Columns[2].Width = 60;
            dataGridView_veh_DB.Columns[3].Width = 60;
            dataGridView_veh_DB.Columns[4].Width = 90;
            dataGridView_veh_DB.Columns[5].Width = 90;
            dataGridView_veh_DB.Columns[6].Width = 90;

        }

        private void Grid_edit()
        {

            //widocznos kolumn
            //  dataGridView_workers_DB.RowHeadersVisible = false;
            dataGridView_work_DB.Columns[0].Visible = false;
            //  dataGridView_workers_DB.Columns[1].Visible = false;
            // dataGridView_workers_DB.Columns[2].Visible = false;
            //dataGridView_workers_DB.Columns[3].Visible = false;
            //dataGridView_workers_DB.Columns[4].Visible = false;
            dataGridView_work_DB.Columns[5].Visible = false;
            dataGridView_work_DB.Columns[6].Visible = false;
            // dataGridView_workers_DB.Columns[7].Visible = false;
            dataGridView_work_DB.Columns[8].Visible = false;
            //opcje kolumn w edycji

            dataGridView_work_DB.Columns[0].ReadOnly = true;//id
            dataGridView_work_DB.Columns[1].ReadOnly = true;//imie
            dataGridView_work_DB.Columns[2].ReadOnly = false;//nazwisko
            dataGridView_work_DB.Columns[3].ReadOnly = false;//pozycja
            dataGridView_work_DB.Columns[4].ReadOnly = true;//pesel
            dataGridView_work_DB.Columns[5].ReadOnly = true;//data urodzenia
            dataGridView_work_DB.Columns[6].ReadOnly = false;//haslo
            dataGridView_work_DB.Columns[7].ReadOnly = false;//telefon
            dataGridView_work_DB.Columns[8].Visible = false;//keeper



            //rozmiary kolumn

            dataGridView_work_DB.Columns[1].Width = 100;
            dataGridView_work_DB.Columns[2].Width = 150;
            dataGridView_work_DB.Columns[3].Width = 100;
            dataGridView_work_DB.Columns[4].Width = 100;
            dataGridView_work_DB.Columns[7].Width = 100;

        }

        public void fillDataGridView2()
        {


            DataBaseDataContext db = new DataBaseDataContext();
            var query = from x in db.WorkerSets select x;

            dataGridView_work_DB.DataSource = query;
            Grid_edit();

        }
    }
}
