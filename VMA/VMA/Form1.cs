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
    public partial class Form_login : Form
    {
        MainApp mainapp;
        Form_panel_admin adminapp;
        Form_panel_manager menagerapp;
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
                MessageBox.Show("Masz rezerwacje na jutro", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (select.Any(x => x.OD == DateTime.Today.Date))
            {
                MessageBox.Show("Masz dzisiaj rezerwacje", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
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
                            check_reservation(user.worker_id);
                            this.Hide();
                        }
                        else if (user.position == "kierownik" || user.position == "Kierownik")
                        {
                            textBox_login_name.Clear();
                            textBox_login_password.Clear();
                            menagerapp = new Form_panel_manager(this, user.worker_id);
                            menagerapp.Show();
                            check_reservation(user.worker_id);
                            this.Hide();
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
                                check_reservation(user.worker_id);
                                this.Hide();
                            }
                            else
                            {
                                textBox_login_name.Clear();
                                textBox_login_password.Clear();
                                mainapp = new MainApp(this, user.name, user.surname, user.worker_id, false);
                                mainapp.Show();
                                check_reservation(user.worker_id);
                                this.Hide();
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

        private void Form_login_KeyPress(object sender, KeyPressEventArgs e)
        {


            char chh = e.KeyChar;

            if ( chh == 13)
            {
              login();

            }



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
    }
}
