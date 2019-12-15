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
    public partial class UserControl_raports_stats_cars : UserControl
    {
        public UserControl_raports_stats_cars()
        {
            InitializeComponent();
        }
        private void gridedit()
        {

            dataGridView_veh_DB.RowHeadersVisible = false;
            dataGridView_veh_DB.Columns[0].Visible = false;
            dataGridView_veh_DB.Columns[1].Visible = true;
            dataGridView_veh_DB.Columns[2].Visible = true;
            dataGridView_veh_DB.Columns[3].Visible = true;
            dataGridView_veh_DB.Columns[4].Visible = false;
            dataGridView_veh_DB.Columns[5].Visible = true;
            dataGridView_veh_DB.Columns[6].Visible = true;
            dataGridView_veh_DB.Columns[7].Visible = true;
            dataGridView_veh_DB.Columns[8].Visible = false;

        }
        public void fillDataGridView()
        {

            DataBaseDataContext db = new DataBaseDataContext();
            var Selectquery = from x in db.VehicleSets where x.available != "deleted" select x;

            dataGridView_veh_DB.DataSource = Selectquery;

            gridedit();



        }

      

        private void UserControl_raports_stats_cars_Load(object sender, EventArgs e)
        {

        }

        private void button_show_Click(object sender, EventArgs e)
        {

            int id = 0;

            var date_from = dateTimePicker_from_date_reserv.Value;
            var date_to = dateTimePicker_to_date_reserv.Value;


            try
            {
                int row = dataGridView_veh_DB.CurrentCell.RowIndex;
                id = (int)dataGridView_veh_DB.Rows[row].Cells[0].Value;

                label_brand.Text = (string)dataGridView_veh_DB.Rows[row].Cells[1].Value;
                label_model.Text = (string)dataGridView_veh_DB.Rows[row].Cells[2].Value;
                label_license.Text = dataGridView_veh_DB.Rows[row].Cells[5].Value.ToString();
                label_current_mileage.Text = dataGridView_veh_DB.Rows[row].Cells[9].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Nie wybrano auta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            DataBaseDataContext db = new DataBaseDataContext();

            //ilosc kilometórw
            try
            {
                var worker_rent2 = from x in db.RentSets
                                   where x.Vehicle_vehicle_id == id && x.date_from.Date <= date_from.Date && x.date_to.Date >= date_to.Date
                                   select x;

                var count_km = worker_rent2
                                .Where(x => x.mileage_end != 0)
                                    .Sum(x => x.mileage_end - x.mileage_start);



                label_mileage_time.Text = count_km.ToString()+" Km";
            }
            catch
            {

                label_mileage_time.Text = " ---";
            }

            //ilosc spalonego paliwa
            try
            {
                var worker_rent2 = from x in db.RentSets
                                   where x.Vehicle_vehicle_id == id && x.date_from.Date >= date_from.Date && x.date_to.Date <= date_to.Date
                                   select x;

                var count_km = worker_rent2
                                .Where(x => x.mileage_end != 0)
                                    .Sum(x => (x.mileage_end - x.mileage_start)/100*x.VehicleSet.avg_consumption);



                label_all_combustion.Text = count_km.ToString() + " L";
            }
            catch
            {

                label_all_combustion.Text = " ---";
            }


            // ilosc serwisow

            

            try
            {
                var query1 = ((from x in db.Care_serviceSets
                               where x.CareSet.Vehicle_vehicle_id == id && x.date_from.Date >= date_from.Date && x.data_to.Value.Date<=date_to.Date
                               select x.care_service_id)).Count();




                label_count_services.Text = query1.ToString();
               
            }
            catch
            {

                label_count_services.Text = "----";

            }


            //koszt pojazdu

            try
            {



                var count_cost_workers = db.PurchaseSets
                                .Where(x => x.RentSet.Vehicle_vehicle_id == id && x.RentSet.date_from.Date >=date_from.Date && x.RentSet.date_to.Date <= date_to.Date)
                                    .Sum(x => x.price);



                var count_cost_servis = db.Care_serviceSets
                                .Where(x => x.CareSet.Vehicle_vehicle_id == id && x.date_from.Date >= date_from.Date && x.data_to.Value.Date <=date_to.Date)
                                    .Sum(x => x.price);




                label_cost_car.Text = (count_cost_servis + count_cost_workers).ToString() + "zł";

            }
            catch
            {

                label_cost_car.Text ="----";
            }









        }

        private void button_generate_to_pdf_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Robie PDF dla wszystkich autek w danym okresie :)", "PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
