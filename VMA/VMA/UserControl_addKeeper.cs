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
    public partial class UserControl_addKeeper : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public UserControl_addKeeper()
        {
            InitializeComponent();
        }

        public void fillDataGridView() //uzupełnienie tabeli 
        {

       
            //pracownicy którzy mogą stać się opiekunami



        

            var query = from x in db.WorkerSets
                        where x.position!="fired" && x.position != "admin" 
                        select new
                        {
                            Id_opiekuna = x.worker_id,
                            Imie = x.name,
                            Nawisko = x.surname,
                            Stanowsiko = x.position
                        };

            dataGridView_Worker.DataSource = query;
            dataGridView_Worker.Columns[0].Visible = false;

            ///auta bez opiekuna

            var query2 = from x in db.VehicleSets
                         where (!(from o in db.CareSets
                                  where o.date_to== Convert.ToDateTime("1999 - 01 - 01 00:00:00.000")
                                  select o.Vehicle_vehicle_id).Contains(x.vehicle_id)) 
                                  && x.available!="deleted" select new { Id = x.vehicle_id, Marka = x.brand, Model = x.model, Rejestracja = x.licence_plate };


            dataGridView_veh.DataSource = query2;
            dataGridView_veh.Columns[0].Visible = false;
        }
        private void add_care_Click(object sender, EventArgs e)// przypisanie auta opiekunowi z listy 
        {

            bool confirm = false;
            try
            {
                var result = MessageBox.Show("Czy napewno chcesz dodać opieke?", "Potwierdzenie",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    int row = dataGridView_Worker.CurrentCell.RowIndex;
                    int row1 = dataGridView_veh.CurrentCell.RowIndex;

                    int selected_worker_id = (int)dataGridView_Worker.Rows[row].Cells[0].Value;
                    var car_id = (int)dataGridView_veh.Rows[row1].Cells[0].Value;

                    var keeper = (from x in db.WorkerSet_Keepers where x.keeper_id == selected_worker_id select x).Any();

                    if (!keeper)
                    {
                        WorkerSet_Keeper keeperr = new WorkerSet_Keeper()
                        {
                            keeper_id = selected_worker_id,
                            worker_id = selected_worker_id,

                        };
                        db.WorkerSet_Keepers.InsertOnSubmit(keeperr);
                        db.SubmitChanges();

                    }



                    int keeper_id = selected_worker_id;

                    CareSet care = new CareSet()
                    {
                        date_from = DateTime.Today,
                        date_to = Convert.ToDateTime("1999 - 01 - 01 00:00:00.000"),
                        Vehicle_vehicle_id = car_id,
                        Keeper_worker_id = keeper_id,

                    };

                    db.CareSets.InsertOnSubmit(care);
                    db.SubmitChanges();
                    confirm = true;

                }
            }
            catch
            {
                MessageBox.Show("Bład przypisania auta do opiekuna", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            if (confirm)
                MessageBox.Show("Przypisano auto opiekunowi", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            fillDataGridView();
        


        }

        private void dataGridView_Worker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView_Worker.CurrentCell.RowIndex;
            label_name.Text = (string)dataGridView_Worker.Rows[row].Cells[1].Value;
            label_surrname.Text = (string)dataGridView_Worker.Rows[row].Cells[2].Value;
            label_postion.Text = (string)dataGridView_Worker.Rows[row].Cells[3].Value;
        }

        private void dataGridView_veh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView_veh.CurrentCell.RowIndex;
            label_brand.Text = (string)dataGridView_veh.Rows[row].Cells[1].Value;
            label_model.Text = (string)dataGridView_veh.Rows[row].Cells[2].Value;
            label_license.Text = (string)dataGridView_veh.Rows[row].Cells[3].Value;
        }

        private void pictureBox_help_Click(object sender, EventArgs e)
        {
            helppdf help = new helppdf(37);
            help.Show();
        }
    }
}

