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
        private Form_login windLog;     //przechowywanie adresu do loginy
        public DataTable tmp;
        private bool close = false;     //sprawdzamy czy wylogowywaliśmy się
       
        public MainApp(Form_login login)
        {
            InitializeComponent();
            windLog = login;        //przenoszenie adresu do zmiennej
            userControl_Welcome2.BringToFront();
           
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            FillTmpDataTable();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void MainApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!close)
                 Application.Exit();
        }
      

        private void button_databaseVeh_Click(object sender, EventArgs e)
        {
            userControl_veh_DB2.fillDataGridView(tmp);
            userControl_veh_DB2.BringToFront();
            
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
            windLog.Show();
        }

        private void FillTmpDataTable()
        {
            tmp = new DataTable();
            tmp.Columns.Add("VehID", typeof(int));
            tmp.Columns.Add("BrandName");
            tmp.Columns.Add("Model");
            tmp.Columns.Add("Equipment");
            tmp.Columns.Add("Version");
            tmp.Columns.Add("Mileage");
            tmp.Columns.Add("License");
            for(int i=0;i<50;i++)
            {
                tmp.Rows.Add(i+1, "Audi", "A3", "VIP", "Hatchback", "34 315 km", "WE 123BD");
                i++;
                tmp.Rows.Add(i + 1, "BMW", "X3", "LUX", "SUV", "12 131 km", "WE 567BD");
            }
            
             
        }
      
    }
}
