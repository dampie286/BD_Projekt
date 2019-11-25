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
        string name = "admin";
        string password = "admin";
        public Form_login()
        {
            InitializeComponent();
        }

        private void button_sign_in_Click(object sender, EventArgs e)
        {
            if ((name == textBox_login_name.Text.ToString()) && (password == textBox_login_password.Text.ToString()))
            {
                textBox_login_name.Clear();
                textBox_login_password.Clear();
                mainapp = new MainApp(this);
                mainapp.Show();
                this.Hide();
            }
            else
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
    }
}
