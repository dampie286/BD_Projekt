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
    public partial class MainApp : Form
    {
        private Form_login windLog;
        private Panel tmp;
        private bool close = false;
        public MainApp(Form_login login)
        {
            InitializeComponent();
            windLog = login;
        }

        private void MainApp_Load(object sender, EventArgs e)
        {



           // panel_vehicle_DB2();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void MainApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!close)
                 Application.Exit();
        }
        private void panel_vehicle_DB2()
        {
            panel_vehicleDB.Hide();
            tmp = new Panel();
            tmp.BackColor =Color.Black;
            tmp.Location = new Point(177, 27);
           tmp.Name = "panel_vehicleDB";
           tmp.Size = new Size(706, 533);
           tmp.TabIndex = 11;
           Controls.Add(tmp);
            

        }

        private void button_databaseVeh_Click(object sender, EventArgs e)
        {
            panel_vehicle_DB2();
          tmp.Show();

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
            windLog.Show();
          
           
        }
    }
}
