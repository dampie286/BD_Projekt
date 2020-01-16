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
    public partial class UserControl_manage_keeper : UserControl
    {
        public event EventHandler Button_addKeeper_Click;
        public event EventHandler Button_menANDDelKeeper_Click;
        public UserControl_manage_keeper()
        {

            InitializeComponent();
        }

        private void button_add_keeper_Click(object sender, EventArgs e)
        {
            if (Button_addKeeper_Click != null)
            {
                Button_addKeeper_Click(this, e);
            }
        }

        private void button_meng_or_del_keeper_Click(object sender, EventArgs e)
        {
            if (Button_menANDDelKeeper_Click != null)
            {
                Button_menANDDelKeeper_Click(this, e);
                
            }
        }

        private void pictureBox_help_Click(object sender, EventArgs e)
        {
            helppdf help = new helppdf(36);
            help.Show();
        }
    }
}
