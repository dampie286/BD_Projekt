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
                    var position = (from WorkerSet W in db.WorkerSets
                                    where W.name == name
                                    select W.position).Single();
                    if (position == "kierownik")
                    {
                        textBox_login_name.Clear();
                        textBox_login_password.Clear();
                        adminapp = new Form_panel_admin(this);
                        adminapp.Show();
                        this.Hide();
                    }
                    else
                    {

                        var surname = (from WorkerSet W in db.WorkerSets
                                       where W.name == name
                                       select W.surname).Single();
                        textBox_login_name.Clear();
                        textBox_login_password.Clear();
                        mainapp = new MainApp(this, name, surname);
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
            //if ()
            //{
            //    //    mainapp = new MainApp(this,"Damian","Pietryja");
            //    //    mainapp.Show();
            //    //    this.Hide();
            //}
            //if ((name == textBox_login_name.Text.ToString()) && (password == textBox_login_password.Text.ToString()))
            //{
            //    textBox_login_name.Clear();
            //    textBox_login_password.Clear();
            //    mainapp = new MainApp(this,"Damian","Pietryja");
            //    mainapp.Show();
            //    this.Hide();
            //}
            //else if ((name_adm == textBox_login_name.Text.ToString()) && (pass_adm == textBox_login_password.Text.ToString()))
            //{
            //    textBox_login_name.Clear();
            //    textBox_login_password.Clear();
            //    adminapp = new Form_panel_admin(this);
            //    adminapp.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    textBox_login_name.Clear();
            //    textBox_login_password.Clear();
            //    MessageBox.Show("Błędny login lub hasło ", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            
            
            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
