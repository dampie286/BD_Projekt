using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMA
{
    public partial class UserControl_settings : UserControl
    {

        int id_worker;

        public UserControl_settings()
        {
          
            InitializeComponent();
            
        }


        public void workersettings(int id_worker_B)
        {

            id_worker = id_worker_B;

        }




       

        private void button2_Click(object sender, EventArgs e)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            string passwd1 = textBox_new_passwor.Text;
            string passwd2 = textBox_new_repeat_password.Text;
            bool confirm;
            if (passwd1 == passwd2 && passwd1!="")
            {
                var query = from x in db.WorkerSets where x.worker_id == id_worker select x;

                foreach (WorkerSet x in query)
                {
                    x.password = passwd1;
                   
                }
                try
                {
                    db.SubmitChanges();
                    confirm = true;
                }
                catch
                {
                    MessageBox.Show("Nie udało się zmienić hasła ", "Zmiana hasła", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    confirm = false;
                }

            }
            else
            {
                if (passwd1 == "")
                {
                    MessageBox.Show("Hasło nie może być puste", "Zmiana hasła", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                MessageBox.Show("Nie pasujące hasła", "Zmiana hasła", MessageBoxButtons.OK, MessageBoxIcon.Error);
                confirm = false;
            }

            if(confirm)
                MessageBox.Show("Hasło zostało zmienione", "Zmiana hasła", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            textBox_new_passwor.Clear();
            textBox_new_repeat_password.Clear();

        }

        private void button_check_adress_Click(object sender, EventArgs e)
        {

            DataBaseDataContext db = new DataBaseDataContext();
            bool confirm = false;

                var query = from x in db.WorkerSets where x.worker_id == id_worker select x;

                foreach (WorkerSet x in query)
                {
                x.city = textBox_new_city.Text.ToString();
                x.city_code = textBox_new_code.Text.ToString();
                x.street = textBox_new_street.Text.ToString();
                x.house = textBox_new_house.Text.ToString();

                }

                try
                {
                    db.SubmitChanges();
                    confirm = true;
                }
                catch
                {
                    MessageBox.Show("Nie udało się zmienić danych ", "Zmiana danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    confirm = false;
                }
        
            
             
            

            if (confirm)
                MessageBox.Show("Dane zostały zmienione", "Zmiana danych", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
          




        }

        private void pictureBox_help_Click(object sender, EventArgs e)
        {
            helppdf help = new helppdf(19);
            help.Show();
        }
    }
}
