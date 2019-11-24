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
        public Form_login()
        {
            InitializeComponent();
        }

        private void button_sign_in_Click(object sender, EventArgs e)
        {
            
            mainapp = new MainApp(this);
            mainapp.Show();
            this.Hide();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            
            
            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
