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
            dataGridView_workers_DB.DataSource = tmp;



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
