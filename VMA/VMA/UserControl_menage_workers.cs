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
    public partial class UserControl_menage_workers : UserControl
    {
        public event EventHandler Button_addWorker_Click;
        public event EventHandler Button_menANDDelWorker_Click;
        public UserControl_menage_workers()
        {
            InitializeComponent();
        }

        private void button_add_worker_Click(object sender, EventArgs e)
        {
            if (Button_addWorker_Click != null)
            {
                Button_addWorker_Click(this, e);
            }
        }

        private void button_meng_or_del_car_Click(object sender, EventArgs e)
        {
            if (Button_menANDDelWorker_Click != null)
            {
                Button_menANDDelWorker_Click(this, e);
            }
        }

        private void pictureBox_help_Click(object sender, EventArgs e)
        {
            helppdf help = new helppdf(45);
            help.Show();
        }
    }
}
