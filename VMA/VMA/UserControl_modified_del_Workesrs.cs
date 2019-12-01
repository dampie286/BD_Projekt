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

        public void fillDataGridView(DataTable tmp)
        { 
            DataBaseDataContext db = new DataBaseDataContext();
            var Selectquery = from x in db.WorkerSets select new { IMIE = x.name, NAZWISKO = x.surname, STANOWISKO = x.position, PESEL = x.PESEL, DATA_UR = x.date_of_birth, HASLO = x.password, NR_TEL = x.phone_nr};

            dataGridView_workers_DB.DataSource = Selectquery;


            dataGridView_workers_DB.Columns[0].Visible = false;
            dataGridView_workers_DB.RowHeadersVisible = false;
            dataGridView_workers_DB.ReadOnly = true;        //nie moze edytować kolumn


            dataGridView_workers_DB.Columns[1].Width = 60;
            dataGridView_workers_DB.Columns[2].Width = 60;
            dataGridView_workers_DB.Columns[3].Width = 60;
            dataGridView_workers_DB.Columns[4].Width = 90;
            
        }
    }
}
