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
    
    public partial class UserControl_menage_cars : UserControl
    {
        public event EventHandler Button_addCar_Click;
        public event EventHandler Button_menANDDelCar_Click;
        public UserControl_menage_cars()
        {
            InitializeComponent();
        }

        private void button_add_car_Click(object sender, EventArgs e)
        {
            if (Button_addCar_Click != null)
            {
                Button_addCar_Click(this, e);
            }
        }

        private void button_meng_or_del_car_Click(object sender, EventArgs e)
        {
            if (Button_menANDDelCar_Click != null)
            {
                Button_menANDDelCar_Click(this, e);
            }
        }

        private void pictureBox_help_Click(object sender, EventArgs e)
        {
            helppdf help = new helppdf(29);
            help.Show();
        }
    }
}
