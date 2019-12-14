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

            // najczesciej uzywane auto
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
                label_your_favourite_car.Text = "----";
            }

            // najwięcej km
            try
            {
                var worker_rent2 = from x in db.RentSets
                                   where x.Worker_worker_id == worker_id
                                   select x;

                var count_km = worker_rent2
                                .Where(x => x.mileage_end != 0)
                                    .Sum(x => x.mileage_end - x.mileage_start);

                label_kilometers.Text = count_km.ToString() + " km";
            }
            catch (Exception)
            {
                label_kilometers.Text = "----";
            }
        }
    }
    }

