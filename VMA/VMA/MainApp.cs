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
        public DataTable tmp;           //przykładowe zmienne do bazy danych z samochodami
        public DataTable tmp2;          //przykładowe zmienne do rezerwacji
        private bool close = false;     //sprawdzamy czy wylogowywaliśmy się
        private string name, surrname;
        public int log;                 //id zalogowanego
       



        public MainApp(Form_login login,string nameWork,string surrnameWork,int id_log,bool if_keeper)
        {
            InitializeComponent();
            windLog = login;        //przenoszenie adresu do zmiennej
            log = id_log;
            userControl_Welcome2.BringToFront();
            
            label_who_online.Text = "Zalogowany jako " + nameWork + " " + surrnameWork;
            if( if_keeper)
            {
                //label_who_online.Text += " Opiekunek"; to było do sprawdzenai czy opiekun się pojawi i wczyta
                this.button_manag_care_car.Location = new System.Drawing.Point(0, 326);
                this.button_statistic.Location= new System.Drawing.Point(0, 377);
                this.button_settings.Location= new System.Drawing.Point(0, 428);
               // this.userControl_menage_care_car1 = new UserControl_menage_care_cars();
                
                //userControl_menage_care_car1.SendToBack();
            }
            else
            {
                button_manag_care_car.Hide();
                this.Controls.Remove(userControl_menage_care_cars1);
            }
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            //dodanie zdarzenia klikniecia wypozyczenia  z bazy
            userControl_rent1.Button_rentDB_Click += new System.EventHandler(this.userControl_rent_Button_rentDB_Click);
            //dodanie zdarzenia klikniecia wypozyczenia z rezerwacji
            userControl_rent1.Button_rentReserv_Click+= new System.EventHandler(this.userControl_rent_Button_rentResev_Click);
            userControl_rent1.Button_my_rents_Click += new System.EventHandler(this.userControl_rent_Button_my_rents_Click);
           
          
        }

        private void userControl_rent_Button_my_rents_Click(object sender, EventArgs e)
        {
            userControl_my_rents1.setID(log);
            userControl_my_rents1.fillDataGridView();
            userControl_my_rents1.BringToFront();
        }

        private void MainApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!close)
                 Application.Exit();
        }
      

        private void button_databaseVeh_Click(object sender, EventArgs e)
        {
            
            userControl_veh_DB2.fillDataGridView();      //dodanie danych do tabeli

            userControl_veh_DB2.BringToFront();
            userControl_veh_DB2.auto_Complete_textBox();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
            windLog.Show();
        }

        

     

        private void button_reservation_Click(object sender, EventArgs e)
        {
            userControl_reservation1.fillDataGridView(tmp);
            userControl_reservation1.BringToFront();
            userControl_reservation1.setWorkerID(log); //przekazanie id pracownika do rezerwacji
        }

        private void button_rent_Click(object sender, EventArgs e)
        {
            userControl_rent1.BringToFront();
            
        }

        //zdarzenie, które robi, gdy klikniemy na bazie danych
        private void userControl_rent_Button_rentDB_Click(object sender, EventArgs e)
        {
            userControl_rent_with_DB1.BringToFront();
            userControl_rent_with_DB1.fillDataGridView(tmp);
            userControl_rent_with_DB1.user_ID_Set(log);
        }

        private void userControl_rent_Button_rentResev_Click(object sender, EventArgs e)    //zdarzenie kiedy naciśnie się przycisk wypożyczenie z baz danyuch
        {
            userControl_my_reservation1.BringToFront();
            userControl_my_reservation1.setID(log);
            userControl_my_reservation1.fillDataGridView();
        }

        private void button_statistic_Click(object sender, EventArgs e)
        {
            userControl_myStatics1.statistic(log);
            userControl_myStatics1.BringToFront();
           
        }

        private void button_manag_care_car_Click(object sender, EventArgs e)
        {
            using (DataBaseDataContext db = new DataBaseDataContext())
            {
                var if_keeper = db.CareSets.Where(x => x.Keeper_worker_id == log).FirstOrDefault();
                if (if_keeper == null)
                {
                    MessageBox.Show("Nie jesteś opiekunem", "Error Care", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    userControl_menage_care_cars1.BringToFront();
                    userControl_menage_care_cars1.setUserID(log);
                    userControl_menage_care_cars1.fillDataGridView();
                    userControl_menage_care_cars1.fillDataGridView2();
                }
            }
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            
                    userControl_settings1.workersettings(log);//przekazanie id pracownika
                    userControl_settings1.BringToFront();
             
            
        }
    }
}
