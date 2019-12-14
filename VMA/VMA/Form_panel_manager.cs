using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMA
{
    public partial class Form_panel_manager : Form
    {
        private Form_login windLog;     //przechowywanie adresu do loginy
        private bool close = false;     //sprawdzamy czy wylogowywaliśmy się
        public Form_panel_manager(Form_login add_tmp)
        {
            windLog = add_tmp;
            InitializeComponent();
        }

        private void Form_panel_manager_Load(object sender, EventArgs e)
        {
            userControl_Welcome1.BringToFront();
        }

        private void Form_panel_manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!close)
                Application.Exit();
        }
        private void button_logout_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
            windLog.Show();
        }

        private void button_veh_DB_Click(object sender, EventArgs e)
        {
            userControl_veh_DB1.BringToFront();
        }
    }
}
