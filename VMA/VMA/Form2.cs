using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace VMA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            string connection = textBox1.Text;


            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["VMA.Properties.Settings.Baza_projektConnectionString"].ConnectionString = connection;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
            MessageBox.Show("Po zmianie Connection String należy zrestartować aplikację! ", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();


        }
    }
}
