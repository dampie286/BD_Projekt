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
        private int user_id;
        public UserControl_menage_care_cars()
        {
            InitializeComponent();
        }

        public void setUserID(int id)
        {
            user_id = id;
        }
        public void fillDataGridView()
        {
            DataBaseDataContext db = new DataBaseDataContext();

            var query = from x in db.CareSets
                        join y in db.VehicleSets on x.Vehicle_vehicle_id equals y.vehicle_id
                        where x.Keeper_worker_id == user_id
                        select new
                        {
                            AUTO = y.model,
                            REJESTRACJA = y.licence_plate

                        };
            dataGridView_care_car_DB.DataSource = query;
        }
        
    }
}
