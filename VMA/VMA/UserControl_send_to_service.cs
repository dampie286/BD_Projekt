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
    public partial class UserControl_send_to_service : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        private int user_id;
        int car_id;
        public UserControl_send_to_service()
        {
            InitializeComponent();
        }
        public void setUserID(int id)
        {
            user_id = id;
        }
        public void fillDataGridView2()    //Auta na serwisie
        {
            try
            {
                var query = from x in db.ServiceSets
                            join y in db.Care_serviceSets on x.service_id equals y.Service_service_id
                            join z in db.CareSets on y.Care_care_id equals z.care_id
                            join q in db.VehicleSets on z.Vehicle_vehicle_id equals q.vehicle_id
                            where z.Keeper_worker_id == user_id && x.is_repair == false
                            select new
                            {
                                ID_car = q.vehicle_id,
                                ID_Service = x.service_id,
                                AUTO = q.model,
                                REJESTRACJA = q.licence_plate,
                                OD = y.date_from,
                                PRZYCZYNA = x.name,
                                OPIS = x.description
                            };
                dataGridView_cars_on_service.DataSource = query;
                dataGridView_cars_on_service.Columns[0].Visible = false;
                dataGridView_cars_on_service.Columns[1].Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Nie masz aut na serwisie", "Error check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

    }
}
