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
        string name;
        string password;
        
        
      
        DataBaseDataContext db = new DataBaseDataContext();
        public Form_login()
        {
            
            InitializeComponent();
        }

        private void button_sign_in_Click(object sender, EventArgs e)
        {
            name = textBox_login_name.Text.ToString();
            password = textBox_login_password.Text.ToString();
            
        
            try
            {
                var user = db.WorkerSets.Where(i => i.password == password && i.name == name).Single();

                if (user != null)
                {
                    if (user.position == "kierownik")
                    {
                        textBox_login_name.Clear();
                        textBox_login_password.Clear();
                        adminapp = new Form_panel_admin(this);
                        adminapp.Show();
                        this.Hide();
                    }
                    else
                    {
                    
                        textBox_login_name.Clear();
                        textBox_login_password.Clear();
                        mainapp = new MainApp(this, user.name, user.surname,user.worker_id);
                        mainapp.Show();
                        this.Hide();
                    }
                }
            }
            catch(Exception)
            {
                textBox_login_name.Clear();
                textBox_login_password.Clear();
                MessageBox.Show("Błędny login lub hasło ", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            
            
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void button_sign_in_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
