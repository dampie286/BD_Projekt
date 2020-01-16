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
    public partial class UserControl_rent : UserControl
    {
        
        public event EventHandler Button_rentDB_Click;
        public event EventHandler Button_rentReserv_Click;
        public event EventHandler Button_my_rents_Click;
        public UserControl_rent()
        {
            InitializeComponent();
        }

        private void button_rent_with_DB_Click(object sender, EventArgs e)  //zdarzenie, gdy klikniemy wypożycz z bazy danych
        {
            if (Button_rentDB_Click != null)
            {
                Button_rentDB_Click(this, e);
            }
        }

        private void button1_rent_with_reservation_Click(object sender, EventArgs e)    //zdarzenie, gdy klikniemy  wypożyczenie z rezerwacji
        {
            if (Button_rentReserv_Click != null)
            {
                Button_rentReserv_Click(this, e);
            }
        }

        private void button_my_rent_Click(object sender, EventArgs e)
        {
            if (Button_my_rents_Click != null)
            {
                Button_my_rents_Click(this, e);
            }
        }

        private void pictureBox_help_Click(object sender, EventArgs e)
        {
            helppdf help = new helppdf(11);
            help.Show();
        }
    }
}
