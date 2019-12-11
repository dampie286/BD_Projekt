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
    public partial class UserControl_raports_stats_cars : UserControl
    {
        public UserControl_raports_stats_cars()
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

        private void dataGridView_veh_DB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView_veh_DB.CurrentCell.RowIndex;
            label_brand.Text = (string)dataGridView_veh_DB.Rows[row].Cells[1].Value;
            label_model.Text = (string)dataGridView_veh_DB.Rows[row].Cells[2].Value;
            label_license.Text = dataGridView_veh_DB.Rows[row].Cells[5].Value.ToString();
            label_current_mileage.Text = dataGridView_veh_DB.Rows[row].Cells[9].Value.ToString();
        }

        private void UserControl_raports_stats_cars_Load(object sender, EventArgs e)
        {

        }
    }
}
