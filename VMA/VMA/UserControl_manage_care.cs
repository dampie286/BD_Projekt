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
    public partial class UserControl_manage_care : UserControl
    {
        public event EventHandler Button_send_receive_car_Click;
        public event EventHandler Button_reserve_block_car_Click;
        public UserControl_manage_care()
        {
            InitializeComponent();
        }

        private void button_send_receive_car_Click(object sender, EventArgs e)
        {
            if (Button_send_receive_car_Click != null)
            {
                Button_send_receive_car_Click(this, e);
            }
        }

        private void button_reserve_block_car_Click(object sender, EventArgs e)
        {
            if (Button_reserve_block_car_Click != null)
            {
                Button_reserve_block_car_Click(this, e);
            }
        }

        private void pictureBox_help_Click(object sender, EventArgs e)
        {
            helppdf help = new helppdf(19);
            help.Show();
        }
    }
}
