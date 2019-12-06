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
    public partial class UserControl_menage_care_cars : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        private int user_id;
        int car_id;
        public UserControl_menage_care_cars()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void setUserID(int id)
        {
            user_id = id;
        }
        public void fillDataGridView()
        {
           

            var query = from x in db.CareSets
                        join y in db.VehicleSets on x.Vehicle_vehicle_id equals y.vehicle_id
                        where x.Keeper_worker_id == user_id
                        select new
                        {
                            ID = y.vehicle_id,
                            AUTO = y.model,
                            REJESTRACJA = y.licence_plate

                        };
            dataGridView_care_car_DB.DataSource = query;

            dataGridView_care_car_DB.Columns[0].Visible = false;

        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "INNA")
            {
                textBox1.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Rodzaj serwisu")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Rodzaj serwisu";
            }
        }

        private void button_send_to_service_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView_care_car_DB.CurrentCell.RowIndex;
                car_id = (int)dataGridView_care_car_DB.Rows[row].Cells[0].Value;
                VehicleSet vechicle = db.VehicleSets.Where(x => x.vehicle_id == car_id).First();

                //vechicle.available = "no"; //Auto nie dostępne

                CareSet care_id = db.CareSets.Where(x => x.Vehicle_vehicle_id == car_id).First();

                //Care_serviceSet newservice = new Care_serviceSet()
                //{
                //    date_from = DateTime.Today,
                //    price = ,
                //    Care_care_id = care_id.care_id,

                    
                //};
                //WorkerSet worker = new WorkerSet()
                //{
                //    name = Convert.ToString(textBox_name.Text),
                //    surname = Convert.ToString(textBox_surrname.Text),
                //    position = Convert.ToString(comboBox_position.Text),
                //    PESEL = Convert.ToString(textBox_id_worker.Text),

                //    date_of_birth = Convert.ToDateTime(dateTimePicker_date_birth.Text),


                //    password = Convert.ToString(textBox_tmp_pass.Text),
                //    phone_nr = Convert.ToString(textBox_phone_number.Text)
                //};
                //db.WorkerSets.InsertOnSubmit(worker);
                //db.SubmitChanges();

            }
            catch (Exception)
            {
                MessageBox.Show("Zaznacz samochód", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //vechicle.available = "no";
           
        }
    }
}
