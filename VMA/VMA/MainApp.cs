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

       
        public MainApp(Form_login login,string nameWork,string surrnameWork)
        {
            InitializeComponent();
            windLog = login;        //przenoszenie adresu do zmiennej
          
            userControl_Welcome2.BringToFront();
            label_who_online.Text = "Zalogowany jako " + nameWork + " " + surrnameWork;


        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            //dodanie zdarzenia klikniecia wypozyczenia  z bazy
            userControl_rent1.Button_rentDB_Click += new System.EventHandler(this.userControl_rent_Button_rentDB_Click);
            //dodanie zdarzenia klikniecia wypozyczenia z rezerwacji
            userControl_rent1.Button_rentReserv_Click+= new System.EventHandler(this.userControl_rent_Button_rentResev_Click);
            FillTmpDataTable();         //uzupełnienie przykładowych wartości
            FillTmp2DataTable();
          
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
            
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
            windLog.Show();
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
            for(int i=0;i<50;i++)
            {
                tmp.Rows.Add(i+1, "Audi", "A3", "VIP", "Hatchback", "34 315 km", "WE 123BD");
                i++;
                tmp.Rows.Add(i + 1, "BMW", "X3", "LUX", "SUV", "12 131 km", "WE 567BD");
            }    
        }


        private void FillTmp2DataTable()        //dodanie danych
        {
            tmp2 = new DataTable();
            tmp2.Columns.Add("ResID", typeof(int));
            tmp2.Columns.Add("Data rezerwacji");
            tmp2.Columns.Add("Nr Rejestracyjny");
            tmp2.Columns.Add("Cel rezerwacji");
            tmp2.Columns.Add("Data rozpoczęcia");
            tmp2.Columns.Add("Data zakończenia");
            for (int i = 0; i < 4; i++)
            {
                tmp2.Rows.Add(i + 1, "26.11.2019", "WE 1234BD", "Prywatnie", "29.11.2019", "29.11.2019");
                i++;
                tmp2.Rows.Add(i + 1, "26.11.2019", "WE 1235BD", "Slużbowo", "30.11.2019", "2.12.2019");
            }
        }

     

        private void button_reservation_Click(object sender, EventArgs e)
        {
            userControl_reservation1.fillDataGridView(tmp);
            userControl_reservation1.BringToFront();
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
        }

        private void userControl_rent_Button_rentResev_Click(object sender, EventArgs e)    //zdarzenie kiedy naciśnie się przycisk wypożyczenie z baz danyuch
        {
            userControl_my_reservation1.BringToFront();
            userControl_my_reservation1.fillDataGridView(tmp2);
        }

        private void button_statistic_Click(object sender, EventArgs e)
        {
            userControl_myStatics1.BringToFront();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            userControl_settings1.BringToFront();
        }
    }
}
