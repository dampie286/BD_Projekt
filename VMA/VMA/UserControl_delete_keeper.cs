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

        private void Grid_edit()
        {

            //widocznos kolumn
            //  dataGridView_workers_DB.RowHeadersVisible = false;
            //dataGridView_keepers_DB.Columns[0].Visible = false;
            //  dataGridView_workers_DB.Columns[1].Visible = false;
            // dataGridView_workers_DB.Columns[2].Visible = false;
            //dataGridView_workers_DB.Columns[3].Visible = false;
            //dataGridView_workers_DB.Columns[4].Visible = false;
            //dataGridView_keepers_DB.Columns[5].Visible = false;
            //dataGridView_keepers_DB.Columns[6].Visible = false;
            // dataGridView_workers_DB.Columns[7].Visible = false;
            //dataGridView_keepers_DB.Columns[8].Visible = false;
            //opcje kolumn w edycji

            //dataGridView_keepers_DB.Columns[0].ReadOnly = true;//id
            //dataGridView_keepers_DB.Columns[1].ReadOnly = true;//imie
            //dataGridView_keepers_DB.Columns[2].ReadOnly = false;//nazwisko
            //dataGridView_keepers_DB.Columns[3].ReadOnly = false;//pozycja
           // dataGridView_keepers_DB.Columns[4].ReadOnly = true;//pesel
            //dataGridView_keepers_DB.Columns[5].ReadOnly = true;//data urodzenia
            //dataGridView_keepers_DB.Columns[6].ReadOnly = false;//haslo
            //dataGridView_keepers_DB.Columns[7].ReadOnly = false;//telefon
            //dataGridView_keepers_DB.Columns[8].Visible = false;//keeper



            //rozmiary kolumn
            
            //dataGridView_keepers_DB.Columns[1].Width = 100;
            //dataGridView_keepers_DB.Columns[2].Width = 150;
            //dataGridView_keepers_DB.Columns[3].Width = 100;
            //dataGridView_keepers_DB.Columns[4].Width = 100;
            //dataGridView_keepers_DB.Columns[7].Width = 100;

        }

        public void fillDataGridView2()
        {



         
          var query = from x in db.CareSets select new { IMIE = x.WorkerSet_Keeper.WorkerSet.name, NAZWISKO = x.WorkerSet_Keeper.WorkerSet.surname, OPIEKA = x.VehicleSet.model, REJESTRACJA = x.VehicleSet.licence_plate };
            dataGridView_keepers_DB.DataSource = query;
            Grid_edit();

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

        }
    }
}
