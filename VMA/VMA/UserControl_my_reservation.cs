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
    public partial class UserControl_my_reservation : UserControl
    {
        public UserControl_my_reservation()
        {
            InitializeComponent();
        }

      
        public void fillDataGridView(DataTable tmp) //funkcja do wypłenienia tabeli
        {
            dataGridView_my_reservation.DataSource = tmp;



            dataGridView_my_reservation.Columns[0].Visible = false;
            dataGridView_my_reservation.RowHeadersVisible = false;
            dataGridView_my_reservation.ReadOnly = true;        //nie moze edytować kolumn


            dataGridView_my_reservation.Columns[1].Width = 60;
            dataGridView_my_reservation.Columns[2].Width = 60;
            dataGridView_my_reservation.Columns[3].Width = 60;
            dataGridView_my_reservation.Columns[4].Width = 90;
            dataGridView_my_reservation.Columns[5].Width = 90;
            

        }
    }
}
