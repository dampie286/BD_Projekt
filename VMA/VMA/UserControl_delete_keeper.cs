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
    public partial class UserControl_delete_keeper : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public UserControl_delete_keeper()
        {
            InitializeComponent();
        }

     

        public void fillDataGridView2()
        {



         
          var query = from x in db.CareSets select new { IMIE = x.WorkerSet_Keeper.WorkerSet.name, NAZWISKO = x.WorkerSet_Keeper.WorkerSet.surname, OPIEKA = x.VehicleSet.model, REJESTRACJA = x.VehicleSet.licence_plate };
            dataGridView_keepers_DB.DataSource = query;
           

        }

        private void textBox_name_Enter(object sender, EventArgs e)
        {
            if (textBox_name.Text.Equals(@"Imię"))
            {
                textBox_name.Text = "";
            }
        }

        private void textBox_name_Leave(object sender, EventArgs e)
        {
            if (textBox_name.Text.Equals(""))
            {
                textBox_name.Text = "Imię";
            }
        }

        private void textBox_surrname_Enter(object sender, EventArgs e)
        {
            if (textBox_surrname.Text.Equals(@"Nazwisko"))
            {
                textBox_surrname.Text = "";
            }
        }

        private void textBox_surrname_Leave(object sender, EventArgs e)
        {
            if (textBox_surrname.Text.Equals(""))
            {
                textBox_surrname.Text = "Nazwisko";
            }
        }

        private void textBox_position_Enter(object sender, EventArgs e)
        {
            if (textBox_position.Text.Equals(@"Stanowisko"))
            {
                textBox_position.Text = "";
            }
        }

        private void textBox_position_Leave(object sender, EventArgs e)
        {
            if (textBox_position.Text.Equals(""))
            {
                textBox_position.Text = "Stanowisko";
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {



            
            System.Diagnostics.Process.Start("https://youtu.be/XqZsoesa55w?t=29");
        }
    }
}
