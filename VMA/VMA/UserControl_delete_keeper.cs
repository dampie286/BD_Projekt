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




            var query = from x in db.CareSets where x.date_to==null select new { ID=x.care_id,IMIE = x.WorkerSet_Keeper.WorkerSet.name, NAZWISKO = x.WorkerSet_Keeper.WorkerSet.surname, OPIEKA = x.VehicleSet.model, REJESTRACJA = x.VehicleSet.licence_plate };
            dataGridView_keepers_DB.DataSource = query;
            dataGridView_keepers_DB.Columns[0].Visible = false;

        }

        private void button_delete_Click(object sender, EventArgs e)
        {



            DataBaseDataContext db = new DataBaseDataContext();
            bool confirm = false;

            int row = dataGridView_keepers_DB.CurrentCell.RowIndex;

            var edit_id = (int)dataGridView_keepers_DB.Rows[row].Cells[0].Value;
            
            var query = from x in db.CareSets where x.care_id== edit_id select x;

            foreach (CareSet x in query)
            {
                x.date_to = DateTime.Today;
                
            }
            try
            {
                db.SubmitChanges();
                confirm = true;
            }
            catch
            {
                MessageBox.Show("Nie udało się zakończyć opieki", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (confirm)
            {
                MessageBox.Show("Zakończono opieke", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            fillDataGridView2();


          
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


    }
}