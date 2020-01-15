using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
namespace VMA
{
    public partial class Form_login : Form
    {
        MainApp mainapp;
        Form_panel_admin adminapp;
        Form_panel_manager menagerapp;
        Form2 sett;

        string name;
        string password;

        DataBaseDataContext db = new DataBaseDataContext();
        public Form_login()
        {
            InitializeComponent();
        }

        private void check_reservation(int user_id)
        {
           

            var Selectquery = from x in db.VehicleSets
                              join y in db.ReservationSets on x.vehicle_id equals y.Vehicle_vehicle_id
                              join z in db.WorkerSets on y.Worker_worker_id equals z.worker_id
                              where z.worker_id == user_id
                              select new
                              {
                                  ID = x.vehicle_id,
                                  REJESTRACJA = x.licence_plate,
                                  MARKA = x.brand,
                                  MODEL = x.model,
                                  OD = y.date_from,
                                  DO = y.date_to,
                                  REZERWUJACY = z.surname,
                                  CEL = y.purpose,
                                  PRZEBIEG = x.mileage,
                                  Reserv_id = y.reservation_id
                              };
            
            var rents = from x in db.RentSets
                        select x.Reservation_reservation_id;

            var select = Selectquery.Where(x => !rents.Contains(x.Reserv_id));

            if (select.Any(x => x.OD == DateTime.Today.Date.AddDays(1)))
            {
                MessageBox.Show("Masz rezerwacje na jutro", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (select.Any(x => x.OD == DateTime.Today.Date))
            {
                MessageBox.Show("Masz dzisiaj rezerwacje", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void check_rent(int user_id)
        {
            var rents = (from x in db.RentSets
                         where x.Worker_worker_id == user_id
                               && x.date_to < DateTime.Today
                               && x.mileage_end == 0
                         select x).FirstOrDefault();
            if (rents == null)
            { }
            else
            {
                var car = (from x in db.VehicleSets
                          where x.vehicle_id == rents.Vehicle_vehicle_id
                          select x).FirstOrDefault();
                
                MessageBox.Show("Zakończ wypożyczenie samochodu: \n" + car.model + " " + car.licence_plate + "\n" + "Wypożyczenie zakończyło się: " + rents.date_to.ToShortDateString(),
                                "Rent Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void check_Cars(int user_id)
        {
            //VehicleSet veh;


            string cars_oil = "Zbliża się wymiana oleju dla: \n";

            string cars_tech_review = "Zbliża się koniec przeglądu dla: \n";

            string cars_timing = "Zbliża się wymiana rozrządu dla: \n";
            
            try
            {
                var query = (from x in db.CareSets
                             join y in db.VehicleSets on x.Vehicle_vehicle_id equals y.vehicle_id
                             where x.Keeper_worker_id == user_id
                             select y.vehicle_id);

                try
                {
                    foreach (int id_car in query)
                    {
                        /// olej
                        var query1 = (from x in db.Check_vehicleSets
                                      join y in db.VehicleSets on x.Vehicle_vehicle_id equals y.vehicle_id
                                      where x.Vehicle_vehicle_id == id_car
                                            && x.oil_change_mileage - 1000 <= y.mileage
                                      select y).First().vehicle_id;

                        var veh = (from x in db.VehicleSets where x.vehicle_id == query1 select x).Single();

                        cars_oil += veh.model + "  " + veh.licence_plate;

                        cars_oil += "\n";
                    }

                    if (cars_oil == "Zbliża się wymiana oleju dla: \n")
                    {
                        cars_oil = "";
                    }
                    else
                    {
                        MessageBox.Show(cars_oil, "Cars Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cars_oil = "Zbliża się wymiana oleju dla: \n";
                }
                catch (Exception)
                { }
                try
                {  ///rozrząd
                    foreach (int id_car in query)
                    {
                        

                        var query2 = (from x in db.Check_vehicleSets
                                      join y in db.VehicleSets on x.Vehicle_vehicle_id equals y.vehicle_id
                                      where x.Vehicle_vehicle_id == id_car
                                            && x.timing_gear_mileage - 1000 <= y.mileage
                                      select y).First().vehicle_id;

                        var veh1 = db.VehicleSets.Where(x => x.vehicle_id == query2)
                                                .SingleOrDefault();
                        
                        cars_timing += veh1.model + "  " + veh1.licence_plate;
                        cars_timing += "\n";
                    }

                    if (cars_timing == "Zbliża się wymiana rozrządu dla: \n")
                    {
                        cars_timing = ".";
                    }
                    else
                    {
                        MessageBox.Show(cars_timing, "Cars Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cars_timing = "Zbliża się wymiana rozrządu dla: \n";
                }
                catch (Exception)
                { }

                try
                {
                    foreach (int id_car in query)
                    {
                        /// przegląd
                        var query3 = (from x in db.Check_vehicleSets
                                      join y in db.VehicleSets on x.Vehicle_vehicle_id equals y.vehicle_id
                                      where x.Vehicle_vehicle_id == id_car
                                            && x.tech_review.AddMonths(11) <= DateTime.Today
                                      select y).First().vehicle_id;

                        var veh2 = db.VehicleSets.Where(x => x.vehicle_id == query3)
                                               .SingleOrDefault();

                        cars_tech_review += veh2.brand + " " + veh2.licence_plate;
                        cars_tech_review += "\n";
                    }

                    if (cars_tech_review == "Zbliża się koniec przeglądu dla: \n")
                    {
                        cars_tech_review = " ";
                    }
                    else
                    {

                        MessageBox.Show(cars_tech_review, "Cars Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cars_tech_review = "Zbliża się koniec przeglądu dla: \n";
                }
                catch
                { }

              

            }
            catch (Exception)
            { }
        }

        private void login()
        {

            name = textBox_login_name.Text.ToString();
            password = textBox_login_password.Text.ToString();


            try
            {
                var user = db.WorkerSets.Where(i => i.password == password && i.name == name).Single();
                if (user != null)
                {
                    if (user.position != "fired")

                    {
                        if (user.position == "admin")
                        {
                            textBox_login_name.Clear();
                            textBox_login_password.Clear();
                            adminapp = new Form_panel_admin(this);
                            adminapp.Show();
                            this.Hide();
                        }
                        else if (user.position == "kierownik" || user.position == "Kierownik")
                        {
                            textBox_login_name.Clear();
                            textBox_login_password.Clear();
                            menagerapp = new Form_panel_manager(this, user.worker_id,user.surname,user.name);
                            menagerapp.Show();
                            this.Hide();
                            check_reservation(user.worker_id);
                            check_Cars(user.worker_id);
                            check_rent(user.worker_id);
                        }
                        else


                        {
                            var keeeper = db.WorkerSet_Keepers.Where(i => i.worker_id == user.worker_id);
                            if (keeeper != null)
                            {
                                textBox_login_name.Clear();
                                textBox_login_password.Clear();
                                mainapp = new MainApp(this, user.name, user.surname, user.worker_id, true);
                                mainapp.Show();
                                this.Hide();
                                check_reservation(user.worker_id);
                                check_Cars(user.worker_id);
                                check_rent(user.worker_id);
                            }
                            else
                            {
                                textBox_login_name.Clear();
                                textBox_login_password.Clear();
                                mainapp = new MainApp(this, user.name, user.surname, user.worker_id, false);
                                mainapp.Show();
                                this.Hide();
                                check_reservation(user.worker_id);
                                check_Cars(user.worker_id);
                                check_rent(user.worker_id);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Zablokowany dostęp ", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                textBox_login_name.Clear();
                textBox_login_password.Clear();
                MessageBox.Show("Błędny login lub hasło ", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button_sign_in_Click(object sender, EventArgs e)
        {

            login();
            
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            
            
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void button_sign_in_KeyDown(object sender, KeyEventArgs e)
        {
           
        }


        private void textBox_login_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chh = e.KeyChar;

            if (chh == 13)
            {
                login();
             

            }

        }

        private void textBox_login_name_KeyPress(object sender, KeyPressEventArgs e)
        {

            char chh = e.KeyChar;
            if (chh == 13)
            {
                SendKeys.Send("{TAB}");

            }


        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {


            sett = new Form2();

            sett.Show();










        }

        private void button1_Click(object sender, EventArgs e)
        {
            int page = 5;
            helppdf help = new helppdf(5);
            help.Show();            
            //Process process = new Process();
           // ProcessStartInfo startInfo = new ProcessStartInfo();
          
           /* process.StartInfo.Arguments = "/A \"page=5\" \"C:\\Users\\damian\\Source\\Repos\\BD_Projekt\\VMA\\VMA\\bin\\Debug\\VMA_help_user.pdf";
            process.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "VMA_help_user.pdf";
            process.Start();
            /*Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;
            startInfo.Arguments = "/A \"page=4\"";
            startInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "VMA_help_user.pdf";
            process.Start();*/

        }
    }
}
