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
        public int log;
        public Form_panel_manager(Form_login add_tmp ,int id_log)
        {
            windLog = add_tmp;
            InitializeComponent();
            log = id_log;
            //dodanie zdarzenia klikniecia wypozyczenia  z bazy
            userControl_rent1.Button_rentDB_Click += new System.EventHandler(this.userControl_rent_Button_rentDB_Click);
            //dodanie zdarzenia klikniecia wypozyczenia z rezerwacji
            userControl_rent1.Button_rentReserv_Click += new System.EventHandler(this.userControl_rent_Button_rentResev_Click);
            userControl_rent1.Button_my_rents_Click += new System.EventHandler(this.userControl_rent_Button_my_rents_Click);
            userControl_menage_all1.Button_manage_services_Click += new System.EventHandler(this.userControl_services_Click);
            userControl_menage_all1.Button_raports_statistics_Click += new System.EventHandler(this.userControl_raports_statistic_Click);
            userControl_menage_all1.Button_manage_keeper_Click += new System.EventHandler(this.userControl_menage_keeper_Click);
            userControl_manage_keeper1.Button_addKeeper_Click += new System.EventHandler(this.userControl_menage_Button_addKeeper_Click);
            userControl_manage_keeper1.Button_menANDDelKeeper_Click += new System.EventHandler(this.userControl_meange_Button_modAndDelKeeper_Click);
            userControl_raports_stats1.Button_cars_Click += new System.EventHandler(this.userControl_raports_Button_cars_Click);
            userControl_raports_stats1.Button_workers_Click += new System.EventHandler(this.userControl_raports_Button_workers_Click);
            userControl_raports_stats1.Button_all_Click += new System.EventHandler(this.userControl_raports_Button_all_Click);
        }

        private void userControl_rent_Button_my_rents_Click(object sender, EventArgs e)
        {
            userControl_my_rents1.litres_and_other_hide();
            userControl_my_rents1.setID(log);
            userControl_my_rents1.fillDataGridView();
            userControl_my_rents1.BringToFront();
        }

        private void userControl_rent_Button_rentResev_Click(object sender, EventArgs e)
        {
            userControl_reservation1.Button();
            userControl_my_reservation1.BringToFront();
            userControl_my_reservation1.setID(log);
            userControl_my_reservation1.fillDataGridView();
        }

        private void userControl_rent_Button_rentDB_Click(object sender, EventArgs e)
        {
            userControl_rent_with_DB1.BringToFront();
            userControl_rent_with_DB1.fillDataGridView();
            userControl_rent_with_DB1.user_ID_Set(log);

        }

        private void userControl_raports_Button_all_Click(object sender, EventArgs e)
        {
            userControl_all_raports1.BringToFront();
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

        private void userControl_menage_keeper_Click(object sender, EventArgs e)
        {
            userControl_manage_keeper1.BringToFront();
        }

        private void userControl_raports_statistic_Click(object sender, EventArgs e)
        {
            userControl_myStatics1.statistic(log);
            userControl_raports_stats1.BringToFront();
        }

        private void userControl_services_Click(object sender, EventArgs e)
        {
            userControl_services1.fillDataGridView();
            userControl_services1.BringToFront();
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
 

        private void button_veh_DB_Click(object sender, EventArgs e)
        {
            userControl_veh_DB1.fillDataGridView();
            userControl_veh_DB1.BringToFront();
           
        }

        private void button_reservation_Click(object sender, EventArgs e)
        {

            userControl_reservation1.Button();
            userControl_reservation1.fillDataGridView();
            userControl_reservation1.BringToFront();
            userControl_reservation1.setWorkerID(log); //przekazanie id pracownika do rezerwacji

        }

        private void button_rent_Click(object sender, EventArgs e)
        {
            userControl_rent1.BringToFront();
        }

        private void button_statistic_Click(object sender, EventArgs e)
        {
            userControl_myStatics1.BringToFront();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            userControl_settings1.workersettings(log);//przekazanie id pracownika
            userControl_settings1.BringToFront();
        }

        private void button_logout_Click_1(object sender, EventArgs e)
        {
            close = true;
            this.Close();
            windLog.Show();
        }

        private void button_raports_stats_Click(object sender, EventArgs e)
        {
            userControl_raports_stats_workers1.fillDataGridView();
            userControl_raports_stats_cars1.fillDataGridView();
            userControl_menage_all1.BringToFront();
        }
    }
}
