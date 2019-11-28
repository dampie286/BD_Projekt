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
    public partial class Form_panel_admin : Form
    {
        private Form_login windLog;     //przechowywanie adresu do loginy
        private bool close = false;     //sprawdzamy czy wylogowywaliśmy się
        public DataTable tmp;           //przykładowe zmienne do bazy danych z samochodami
        public Form_panel_admin(Form_login add_tmp)
        {
            windLog = add_tmp;
            InitializeComponent();
            userControl_menage_cars1.Button_addCar_Click+= new System.EventHandler(this.userControl_menage_Button_addCar_Click);
            userControl_menage_cars1.Button_menANDDelCar_Click+=new System.EventHandler(this.userControl_menage_Button_menANDDelCar_Click);
            userControl_menage_workers1.Button_addWorker_Click += new System.EventHandler(this.userControl_menage_Button_addWorker_Click);
            userControl_menage_workers1.Button_menANDDelWorker_Click += new System.EventHandler(this.userControl_menage_Button_menAndDelWorker_Click);

            FillTmpDataTable();
            userControl_veh_DB1.fillDataGridView(tmp);
            userControl_veh_DB1.BringToFront();
        }

        private void userControl_menage_Button_menAndDelWorker_Click(object sender, EventArgs e)
        {
            
        }

        private void userControl_menage_Button_addWorker_Click(object sender, EventArgs e)
        {
            userControl_addWorker1.BringToFront();
        }

        private void button_databaseVeh_Click(object sender, EventArgs e)
        {
            userControl_veh_DB1.fillDataGridView(tmp);
            userControl_veh_DB1.BringToFront();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
            windLog.Show();
        }

        private void Form_panel_admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!close)
                Application.Exit();
        }

        private void FillTmpDataTable()     //dodanie danych
        {
            tmp = new DataTable();
            tmp.Columns.Add("VehID", typeof(int));
            tmp.Columns.Add("BrandName");
            tmp.Columns.Add("Model");
            tmp.Columns.Add("Equipment");
            tmp.Columns.Add("Version");
            tmp.Columns.Add("Mileage");
            tmp.Columns.Add("License");
            for (int i = 0; i < 50; i++)
            {
                tmp.Rows.Add(i + 1, "Audi", "A3", "VIP", "Hatchback", "34 315 km", "WE 123BD");
                i++;
                tmp.Rows.Add(i + 1, "BMW", "X3", "LUX", "SUV", "12 131 km", "WE 567BD");
            }
        }

        private void button_reservation_Click(object sender, EventArgs e)
        {
            userControl_menage_cars1.BringToFront();
        }

        private void userControl_menage_Button_addCar_Click(object sender, EventArgs e)
        {
            userControl_add_Car1.BringToFront();
        }

        private void userControl_menage_Button_menANDDelCar_Click(object sender,EventArgs e)
        {
            userControl_modified_delet_car1.fillDataGridView(tmp); 
            userControl_modified_delet_car1.BringToFront();
        }

        private void button_rent_Click(object sender, EventArgs e)
        {
            userControl_menage_workers1.BringToFront();
        }
    }
}
