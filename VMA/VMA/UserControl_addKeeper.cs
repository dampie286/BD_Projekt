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
            // obecni opiekunowie
            var query = from x in db.WorkerSet_Keepers
                        select new {Id_opiekuna=x.keeper_id,Imie=x.WorkerSet.name, Nawisko = x.WorkerSet.surname, Stanowsiko= x.WorkerSet.position };
            
            dataGridView_Keepers.DataSource = query;
            dataGridView_Keepers.Columns[0].Visible = false;
            ////
            ///
            //pracownicy którzy mogą stać się opiekunami

            var query1 = from x in db.WorkerSets
                         where !(from o in db.WorkerSet_Keepers select o.worker_id).Contains(x.worker_id)
                         select new {Id=x.worker_id, Imie = x.name, Nawisko = x.surname, Stanowsiko = x.position };

            
            dataGridView_Worker.DataSource = query1;
            dataGridView_Worker.Columns[0].Visible = false;

            ///auta bez opiekuna

            var query2 = from x in db.VehicleSets
                         where !(from o in db.CareSets select o.Vehicle_vehicle_id).Contains(x.vehicle_id)
                         select new { Id = x.vehicle_id, Marka = x.brand, Model = x.model, Rejestracja = x.licence_plate };


            dataGridView_veh.DataSource = query2;
            dataGridView_veh.Columns[0].Visible = false;
            dataGridView_veh.Columns[1].Width = 70;
            dataGridView_veh.Columns[2].Width = 70;

           


        }





        private void button_add_keeper_Click(object sender, EventArgs e) // dodanie pracownika jako opiekuna 
        {
            

            bool confirm = false;
            try
            {
                

                int row = dataGridView_Worker.CurrentCell.RowIndex;

                var new_id = (int)dataGridView_Worker.Rows[row].Cells[0].Value;

                WorkerSet_Keeper keeper = new WorkerSet_Keeper()
                {
                  keeper_id=new_id,
                  worker_id=new_id,
                
                };
                db.WorkerSet_Keepers.InsertOnSubmit(keeper);
                db.SubmitChanges();
                confirm = true;

            }
            catch
            {
                MessageBox.Show("Bład dodania opiekuna", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            if (confirm)
                MessageBox.Show("Dodano opiekuna", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            fillDataGridView();

        }

        private void add_care_Click(object sender, EventArgs e)// przypisanie auta opiekunowi z listy 
        {

            bool confirm = false;
            try
            {


                int row = dataGridView_Keepers.CurrentCell.RowIndex;
                int row1 = dataGridView_veh.CurrentCell.RowIndex;

                var keeper_id = (int)dataGridView_Keepers.Rows[row].Cells[0].Value;
                var car_id = (int)dataGridView_veh.Rows[row1].Cells[0].Value;

                CareSet care = new CareSet()
                {
                    date_from = DateTime.Today,
                    date_to=null,
                    Vehicle_vehicle_id=car_id,
                    Keeper_worker_id=keeper_id,

                };

                db.CareSets.InsertOnSubmit(care);
                db.SubmitChanges();
                confirm = true;

            }
            catch
            {
                MessageBox.Show("Bład przypisania auta do opiekuna", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            if (confirm)
                MessageBox.Show("Przypisano auto opiekunowi", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            fillDataGridView();



        }
    }
    }

