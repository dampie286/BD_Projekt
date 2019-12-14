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
        public DataTable tmp2;          //przykładowe dane pracowników
        public Form_panel_admin(Form_login add_tmp)
        {
            windLog = add_tmp;
            InitializeComponent();
            userControl_menage_cars1.Button_addCar_Click+= new System.EventHandler(this.userControl_menage_Button_addCar_Click);
            userControl_menage_cars1.Button_menANDDelCar_Click+=new System.EventHandler(this.userControl_menage_Button_menANDDelCar_Click);
            userControl_menage_workers1.Button_addWorker_Click += new System.EventHandler(this.userControl_menage_Button_addWorker_Click);
            userControl_menage_workers1.Button_menANDDelWorker_Click += new System.EventHandler(this.userControl_menage_Button_menAndDelWorker_Click);
            userControl_manage_keeper1.Button_addKeeper_Click += new System.EventHandler(this.userControl_menage_Button_addKeeper_Click);
            userControl_manage_keeper1.Button_menANDDelKeeper_Click += new System.EventHandler(this.userControl_meange_Button_modAndDelKeeper_Click);
            userControl_raports_stats1.Button_cars_Click += new System.EventHandler(this.userControl_raports_Button_cars_Click);
            userControl_raports_stats1.Button_workers_Click += new System.EventHandler(this.userControl_raports_Button_workers_Click);

            FillTmpDataTable();
            FillTmp2DataTable();
            userControl_veh_DB1.fillDataGridView();
            userControl_veh_DB1.auto_Complete_textBox();
            userControl_veh_DB1.BringToFront();
        }

        private void userControl_raports_Button_workers_Click(object sender, EventArgs e)
        {
            userControl_raports_stats_workers1.fillDataGridView();
            userControl_raports_stats_workers1.BringToFront();
        }

        private void userControl_raports_Button_cars_Click(object sender, EventArgs e)
        {
            userControl_raports_stats_cars1.fillDataGridView();
            userControl_raports_stats_cars1.BringToFront();
        }

        private void userControl_meange_Button_modAndDelKeeper_Click(object sender, EventArgs e)
        {
            userControl_delete_keeper1.fillDataGridView2();
            userControl_delete_keeper1.BringToFront();
        }

        private void userControl_menage_Button_addKeeper_Click(object sender, EventArgs e)
        {
           
            userControl_addKeeper1.fillDataGridView();
            userControl_addKeeper1.BringToFront();  
        }

        private void userControl_menage_Button_menAndDelWorker_Click(object sender, EventArgs e)
        {
            userControl_modified_del_Workesrs1.fillDataGridView();
            userControl_modified_del_Workesrs1.panelHide();
            userControl_modified_del_Workesrs1.BringToFront();
        }

        private void userControl_menage_Button_addWorker_Click(object sender, EventArgs e)
        {
            userControl_addWorker1.BringToFront();
        }

        private void button_databaseVeh_Click(object sender, EventArgs e)
        {
            
            userControl_veh_DB1.fillDataGridView();
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

        private void FillTmp2DataTable()     //dodanie danych
        {
            tmp2 = new DataTable();
            tmp2.Columns.Add("WorkID", typeof(int));
            tmp2.Columns.Add("Name");
            tmp2.Columns.Add("Surrname");
            tmp2.Columns.Add("ID");
            tmp2.Columns.Add("Position");
            
            for (int i = 0; i < 50; i++)
            {
                tmp2.Rows.Add(i + 1, "Damian", "Pietryja", "97070745619", "Przedstawiciel");
                i++;
                tmp2.Rows.Add(i + 1, "Tobiasz", "Pilnicki", "97070845719", "Przedstawiciel");

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
            userControl_modified_delet_car1.fillDataGridView();
            userControl_modified_delet_car1.panelHide();
            userControl_modified_delet_car1.BringToFront();
        }

        private void button_rent_Click(object sender, EventArgs e)
        {
            userControl_menage_workers1.BringToFront();
        }

        private void button_manage_ceeper_Click(object sender, EventArgs e)
        {
            userControl_manage_keeper1.BringToFront();
        }

        private void button_raports_stats_Click(object sender, EventArgs e)
        {
            userControl_raports_stats1.BringToFront();
        }
    }
}
