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
    public partial class UserControl_raports_stats : UserControl
    {
        public event EventHandler Button_cars_Click;
        public event EventHandler Button_workers_Click;
        public UserControl_raports_stats()
        {
            InitializeComponent();
        }

        private void button_cars_Click(object sender, EventArgs e)
        {
            if (Button_cars_Click != null)
            {
                Button_cars_Click(this, e);
            }
        }

        private void button_workers_Click(object sender, EventArgs e)
        {
            if (Button_workers_Click != null)
            {
                Button_workers_Click(this, e);
            }
        }
    }
}
