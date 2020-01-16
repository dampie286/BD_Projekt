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
    public partial class UserControl_Welcome : UserControl
    {
        public UserControl_Welcome()
        {
            InitializeComponent();
        }

        private void pictureBox_help_Click(object sender, EventArgs e)
        {
            helppdf help = new helppdf(4);
            help.Show();
        }
    }
}
