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
    public partial class UserControl_myStatics : UserControl
    {

        DataBaseDataContext db = new DataBaseDataContext();

        private DataTable veh_DB = new DataTable();
        int max = 0;
        int res_id;
        int user_id;
        public UserControl_myStatics()
        {
            InitializeComponent();
        }

        public void setUserID(int val)
        {
            user_id = val;
        }
        
        



        public void statistic(int worker_id)
        {
            //ilosc aut w opiece

            var query = (from x in db.CareSets
                               where x.WorkerSet_Keeper.worker_id == worker_id
                               select x).Count();

            label_how_much_care_cars.Text = query.ToString();
            // ilosc uzywanych aut
            var query1 = ((from x in db.RentSets
                               where x.Worker_worker_id == worker_id
                               select  x.Vehicle_vehicle_id).Distinct()).Count();


            label_how_much_cars.Text = query1.ToString();
            //ilosc kilometrow

            // najczesciej uzywane aut
        
            try
            {
                var worker_rent = from x in db.RentSets
                                  where x.Worker_worker_id == worker_id
                                  select x;

                int number = (from x in worker_rent
                              group x by x.Vehicle_vehicle_id into g
                              orderby g.Count() descending
                              select g.Key).FirstOrDefault();

                
                    label_your_favourite_car.Text = (from x in db.VehicleSets
                                                where x.vehicle_id == number
                                                select x.licence_plate).First();
            }
            catch (Exception)
            {
                MessageBox.Show("Coś się popsuło i nie było mnie słychać", "Error Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }









    }



    }

