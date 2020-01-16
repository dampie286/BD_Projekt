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
    public partial class UserControl_menage_all : UserControl
    {
        public event EventHandler Button_manage_services_Click;
        public event EventHandler Button_raports_statistics_Click;
        public event EventHandler Button_manage_keeper_Click;
        public UserControl_menage_all()
        {
            InitializeComponent();
        }

        private void button_manage_services_Click(object sender, EventArgs e)
        {
            if (Button_manage_services_Click != null)
            {
                Button_manage_services_Click(this, e);

               



            }
        }

        private void button_raports_statistics_Click(object sender, EventArgs e)
        {
            if (Button_raports_statistics_Click != null)
            {
                Button_raports_statistics_Click(this, e);
            }
        }

        private void button_manage_keeper_Click(object sender, EventArgs e)
        {
            if (Button_manage_keeper_Click != null)
            {
                Button_manage_keeper_Click(this, e);
            }
        }

        private void pictureBox_help_Click(object sender, EventArgs e)
        {
            helppdf help = new helppdf(28);
            help.Show();
        }
    }
}
