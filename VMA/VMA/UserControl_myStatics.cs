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

        public UserControl_myStatics()
        {
            InitializeComponent();

            
           
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

            // najczesciej uzywane auto
            /*
            var query2 = db.RentSets.Where(w => w.Worker_worker_id == worker_id)
                                   .GroupBy(q => q.Vehicle_vehicle_id);

            int max=0;
            string tmpp="" ;
            foreach (RentSet x in query2)
            {


                var tmp = db.RentSets.Where(w => w.Vehicle_vehicle_id == x.Vehicle_vehicle_id).Count();

                if (tmp > max)
                {

                    tmpp = x.VehicleSet.licence_plate;


                }



                label_your_favourite_car.Text = tmpp;
                
            }


         */
         





        }



    }
}
