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
    public partial class UserControl_raports_stats_workers : UserControl
    {
        public UserControl_raports_stats_workers()
        {
            InitializeComponent();
        }
        private void Grid_edit()
        {

            //widocznos kolumn
            dataGridView_workers_DB.RowHeadersVisible = false;
            dataGridView_workers_DB.Columns[0].Visible = false;
            //  dataGridView_workers_DB.Columns[1].Visible = false; imie
            // dataGridView_workers_DB.Columns[2].Visible = false;  nazwisko    
            //dataGridView_workers_DB.Columns[3].Visible = false;   pozycja
            dataGridView_workers_DB.Columns[4].Visible = false;
            dataGridView_workers_DB.Columns[5].Visible = false;
            dataGridView_workers_DB.Columns[6].Visible = false;
            // dataGridView_workers_DB.Columns[7].Visible = false;  nr telefonu
            dataGridView_workers_DB.Columns[8].Visible = false;
            dataGridView_workers_DB.Columns[9].Visible = false;
            dataGridView_workers_DB.Columns[10].Visible = false;
            dataGridView_workers_DB.Columns[11].Visible = false;
            dataGridView_workers_DB.Columns[12].Visible = false;

        }

        public void fillDataGridView()
        {


            DataBaseDataContext db = new DataBaseDataContext();
            var query = from x in db.WorkerSets where x.position != "fired" select x;

            dataGridView_workers_DB.DataSource = query;
            Grid_edit();

        }

        private void dataGridView_workers_DB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView_workers_DB.CurrentCell.RowIndex;
            //label_brand.Text = (string)dataGridView_veh_DB.Rows[row].Cells[1].Value;
            label_name_with_choice.Text = dataGridView_workers_DB.Rows[row].Cells[1].Value.ToString();
            label_surrname.Text = dataGridView_workers_DB.Rows[row].Cells[2].Value.ToString();
            label_number.Text = dataGridView_workers_DB.Rows[row].Cells[7].Value.ToString();
            label_position.Text = dataGridView_workers_DB.Rows[row].Cells[3].Value.ToString();
        }
    }
}
