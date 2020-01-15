using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace VMA
{
    public partial class UserControl_raports_stats_cars : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public UserControl_raports_stats_cars()
        {
            InitializeComponent();
        }

        private void GeneratePDF(string filename, string description, DataTable data)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(data.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_MIDDLE;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            foreach (DataColumn col in data.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.ColumnName, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            foreach (DataRow row in data.Rows)
            {
                foreach (object obj in row.ItemArray)
                {
                    pdftable.AddCell(new Phrase(obj.ToString(), text));
                }
            }

            var savefiledialogue = new SaveFileDialog();
            savefiledialogue.FileName = filename;
            savefiledialogue.DefaultExt = ".pdf";
            if (savefiledialogue.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fstream = new FileStream(savefiledialogue.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfdoc, fstream);
                    pdfdoc.Open();
                    Phrase ph = new Phrase(description + " \n \n");
                    pdfdoc.Add(ph);
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    fstream.Close();
                }
            }
        }
        
        public void fillDataGridView()
        {

            var Selectquery = from x in db.VehicleSets
                              where x.available != "deleted"
                              select new
                              {
                                  ID = x.vehicle_id,
                                  MARKA = x.brand,
                                  MODEL = x.model,
                                  WERSJA = x.version,
                                  REJESTRACJA = x.licence_plate,
                                  SPALANIE = x.avg_consumption,
                                  PALIWO = x.fuel_type,
                                  PRZEBIEG = x.mileage
                              };

            dataGridView_veh_DB.DataSource = Selectquery;

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
                label_license.Text = dataGridView_veh_DB.Rows[row].Cells[4].Value.ToString();
                label_current_mileage.Text = dataGridView_veh_DB.Rows[row].Cells[7].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Nie wybrano auta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

           

            //ilosc kilometórw
            try
            {
                var worker_rent2 = from x in db.RentSets
                                   where x.Vehicle_vehicle_id == id && x.date_from.Date >= date_from.Date && x.date_to.Date <= date_to.Date
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
                                    .Sum(x => (x.mileage_end - x.mileage_start)*x.VehicleSet.avg_consumption/100);
                
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
                var count_cost_workers =0.0;
                var count_cost_servis = 0.0;
                try
                {
                     count_cost_workers = db.PurchaseSets
                                    .Where(x => x.RentSet.Vehicle_vehicle_id == id && x.RentSet.date_from.Date >= date_from.Date && x.RentSet.date_to.Date <= date_to.Date)
                                        .Sum(x => x.price);
                }

                catch
                {
                   
                }

                try
                {
                     count_cost_servis = db.Care_serviceSets
                                    .Where(x => x.CareSet.Vehicle_vehicle_id == id && x.date_from.Date >= date_from.Date && x.data_to.Value.Date <= date_to.Date && x.price!=-10)
                                        .Sum(x => x.price);
                }
                catch
                {

                }
                label_cost_car.Text = (count_cost_servis + count_cost_workers).ToString() + "zł";
            }
            catch
            {
                label_cost_car.Text ="----";
            }
        }

        private void button_generate_to_pdf_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable("Stats");
            data.Columns.Add("Marka");
            data.Columns.Add("Model");
            data.Columns.Add("Rejestracja");
            data.Columns.Add("Liczba KM");
            data.Columns.Add("Spalone litry");
            data.Columns.Add("Koszt pojazdów");

            VehicleSet worker;
            string km, cost, count;

            var Worker = from x in db.VehicleSets
                         select x.vehicle_id;

            var date_from = dateTimePicker_from_date_reserv.Value;
            var date_to = dateTimePicker_to_date_reserv.Value;

            foreach (int idw in Worker)
            {

                worker = db.VehicleSets.Where(x => x.vehicle_id == idw).First();
                try // liczba km działa
                {
                    var worker_rent2 = from x in db.RentSets
                                       where x.Vehicle_vehicle_id == idw && x.date_from.Date >= date_from.Date && x.date_to.Date <= date_to.Date
                                       select x;

                    var count_km = worker_rent2
                                    .Where(x => x.mileage_end != 0)
                                        .Sum(x => x.mileage_end - x.mileage_start);
                    km = count_km.ToString();

                }
                catch (Exception)
                {
                    km = "---";
                }
                try // paliwo nie działa
                {
                    var worker_rent2 = from x in db.RentSets
                                       where x.Vehicle_vehicle_id == idw && x.date_from.Date >= date_from.Date && x.date_to.Date <= date_to.Date
                                       select x;
                    
                    var count_km = worker_rent2
                                    .Where(x => x.mileage_end != 0)
                                        .Sum(x => (x.mileage_end - x.mileage_start) * x.VehicleSet.avg_consumption/100);

                    count = count_km.ToString();
                }
                catch (Exception)
                {
                    count = "---";
                }
                try
                {
                    var count_cost_workers = 0.0;
                    var count_cost_servis = 0.0;
                    try
                    {
                        count_cost_workers = db.PurchaseSets
                                       .Where(x => x.RentSet.Vehicle_vehicle_id == idw && x.RentSet.date_from.Date >= date_from.Date && x.RentSet.date_to.Date <= date_to.Date)
                                           .Sum(x => x.price);
                    }

                    catch
                    {

                    }

                    try
                    {
                        count_cost_servis = db.Care_serviceSets
                                       .Where(x => x.CareSet.Vehicle_vehicle_id == idw && x.date_from.Date >= date_from.Date && x.data_to.Value.Date <= date_to.Date && x.price != -10)
                                           .Sum(x => x.price);
                    }
                    catch
                    {

                    }
                    cost= (count_cost_servis + count_cost_workers).ToString() + "zł";
                }
                catch
                {
                    cost= "----";
                }
                // liczba serwisow nie działa
                try
                {
                    var query1 = ((from x in db.Care_serviceSets
                                   where x.CareSet.Vehicle_vehicle_id == idw && x.date_from.Date >= date_from.Date && x.data_to.Value.Date <= date_to.Date
                                   select x.care_service_id)).Count();

                    label_count_services.Text = query1.ToString();
                }
                catch
                {
                    label_count_services.Text = "----";
                }
                data.Rows.Add(worker.brand, worker.model, worker.licence_plate, km, count, cost);
            }
            GeneratePDF("Koszta pojazdów", "Koszta za okres: " + dateTimePicker_from_date_reserv.Value.ToShortDateString() + " - " + dateTimePicker_to_date_reserv.Value.ToShortDateString(), data);
        }
    }
}
