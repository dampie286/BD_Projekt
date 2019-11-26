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
    public partial class UserControl_reservation : UserControl
    {
        public UserControl_reservation()
        {
            InitializeComponent();
        }

        public void fillDataGridView(DataTable tmp)     //uzupełnienie tabeli
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

        private void dateTimePicker_from_date_reserv_ValueChanged(object sender, EventArgs e)
        {

            dateTimePicker_to_date_reserv.MinDate = dateTimePicker_from_date_reserv.Value;
        }

        private void UserControl_reservation_Load(object sender, EventArgs e)
        {
            dateTimePicker_from_date_reserv.MinDate = DateTime.Today;

        }

       
    }
}
