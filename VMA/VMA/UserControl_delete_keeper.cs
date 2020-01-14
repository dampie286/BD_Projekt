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
        AutoCompleteStringCollection instcol = new AutoCompleteStringCollection();
        AutoCompleteStringCollection instcol1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection instcol2 = new AutoCompleteStringCollection();
        public UserControl_delete_keeper()
        {
            autoComplite_textBox();
            InitializeComponent();
        }

        public void autoComplite_textBox() //Autopodpowiedź
        {
            // Imię
            var names = db.CareSets
                        .Join(db.WorkerSets, 
                              x => x.Keeper_worker_id, 
                              y => y.worker_id, 
                              (x,y) =>  y.name)
                                .Distinct()
                                    .ToArray();

            instcol.AddRange(names);

            //Nazwisko
            var surnames = db.CareSets
                           .Join(db.WorkerSets, 
                                 x => x.Keeper_worker_id, 
                                 y => y.worker_id, 
                                 (x, y) => y.surname)
                                    .Distinct()
                                        .ToArray();
            instcol1.AddRange(surnames);

            // Rejestracja
            var plate = db.CareSets
                        .Join(db.VehicleSets, 
                              x => x.Vehicle_vehicle_id, 
                              y => y.vehicle_id, 
                              (x, y) => y.licence_plate)
                                .Distinct()
                                    .ToArray();
            instcol2.AddRange(plate);
                
        }


        public void fillDataGridView2()
        {
            var query = from x in db.CareSets
                        where x.date_to == Convert.ToDateTime("1999 - 01 - 01 00:00:00.000")
                        select new
                        {
                            ID = x.care_id,
                            IMIĘ = x.WorkerSet_Keeper.WorkerSet.name,
                            NAZWISKO = x.WorkerSet_Keeper.WorkerSet.surname,
                            OPIEKA = x.VehicleSet.model,
                            REJESTRACJA = x.VehicleSet.licence_plate
                        };

            dataGridView_keepers_DB.DataSource = query;
            dataGridView_keepers_DB.Columns[0].Visible = false;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            
            bool confirm = false;


            var result = MessageBox.Show("Czy napewno chcesz dodać opieke?", "Potwierdzenie",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {

                int row = dataGridView_keepers_DB.CurrentCell.RowIndex;

                var edit_id = (int)dataGridView_keepers_DB.Rows[row].Cells[0].Value;

                var query = from x in db.CareSets where x.care_id == edit_id select x;

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

        }
        

        private void textBox_name_Enter(object sender, EventArgs e)
        {
            if (textBox_name.Text.Equals(@"Imię"))
            {
                textBox_name.Text = "";
                textBox_name.ForeColor = Color.FromArgb(255,255,0);
            }
            textBox_name.AutoCompleteCustomSource = instcol;
        }

        private void textBox_name_Leave(object sender, EventArgs e)
        {
            if (textBox_name.Text.Equals(""))
            {
                textBox_name.Text = "Imię";
                textBox_name.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        private void textBox_surrname_Enter(object sender, EventArgs e)
        {
            if (textBox_surrname.Text.Equals(@"Nazwisko"))
            {
                textBox_surrname.Text = "";
                textBox_surrname.ForeColor = Color.FromArgb(255, 255, 0);
            }
            textBox_surrname.AutoCompleteCustomSource = instcol1;
        }

        private void textBox_surrname_Leave(object sender, EventArgs e)
        {
            if (textBox_surrname.Text.Equals(""))
            {
                textBox_surrname.Text = "Nazwisko";
                textBox_surrname.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        private void textBox_position_Enter(object sender, EventArgs e)
        {
            if (textBox_licence_plate.Text.Equals(@"Rejestracja"))
            {
                textBox_licence_plate.Text = "";
                textBox_licence_plate.ForeColor = Color.FromArgb(255, 255, 0);
            }
            textBox_licence_plate.AutoCompleteCustomSource = instcol2;
        }

        private void textBox_position_Leave(object sender, EventArgs e)
        {
            if (textBox_licence_plate.Text.Equals(""))
            {
                textBox_licence_plate.Text = "Rejestracja";
                textBox_licence_plate.ForeColor = Color.FromArgb(120, 120, 0);
            }
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            var query = from x in db.CareSets
                        where x.date_to == null
                        select new
                        {
                            ID = x.care_id,
                            IMIE = x.WorkerSet_Keeper.WorkerSet.name,
                            NAZWISKO = x.WorkerSet_Keeper.WorkerSet.surname,
                            OPIEKA = x.VehicleSet.model,
                            REJESTRACJA = x.VehicleSet.licence_plate,
                            STANOWISKO = x.WorkerSet_Keeper.WorkerSet.position
                        };

            string filtr_name = textBox_name.Text;
            string filtr_surname = textBox_surrname.Text;
            string filtr_position = textBox_licence_plate.Text;
            try
            {
                if (filtr_name == "Imię" || filtr_name == "")
                {

                }
                else
                {
                    query = from x in query where x.IMIE == filtr_name select x;

                }
                if (filtr_surname == "Nazwisko" || filtr_surname == "")
                {
                }
                else
                {
                    query = from x in query where x.NAZWISKO == filtr_surname select x;

                }
                if (filtr_position == "Rejestracja" || filtr_position == "")
                {

                }
                else
                {
                    query = from x in query where x.REJESTRACJA == filtr_position select x;
                }

                var query1 = from x in query select x;
                dataGridView_keepers_DB.DataSource = query;
                dataGridView_keepers_DB.Columns[0].Visible = false;
                dataGridView_keepers_DB.Columns[5].Visible = false;
            }
            catch(Exception)
            { }
        }
    }
}