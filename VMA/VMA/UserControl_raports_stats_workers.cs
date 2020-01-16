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
    public partial class UserControl_raports_stats_workers : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();

        public UserControl_raports_stats_workers()
        {
            InitializeComponent();
        }

        public void fillDataGridView()
        {

            var query = from x in db.WorkerSets
                        where x.position != "fired"
                        select new
                        {
                            ID = x.worker_id,
                            IMIĘ = x.name,
                            NAZWISKO = x.surname,
                            STANOWISKO = x.position,
                            TELEFON = x.phone_nr
                        };

            dataGridView_workers_DB.DataSource = query;
            
        }

        private void GeneratePDF(string filename, string description, DataTable data, double kms, double costs, double counts)
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
                    pdfdoc.Add(new Phrase(description + " \n \n"));
                    pdfdoc.Add(pdftable);
                    pdfdoc.Add(new Phrase("\n"));
                    pdfdoc.Add(new Phrase("Sumaryczna liczba km za zadany okres: " + kms + " km\n"));
                    pdfdoc.Add(new Phrase("Sumaryczna liczba wypożyczen: " + counts + "\n"));
                    pdfdoc.Add(new Phrase("Sumaryczny koszt: " + costs + " zl\n"));
                    pdfdoc.Close();
                    fstream.Close();
                }
            }
        }

        private void Pdf_Data_Creator()
        {
            DataTable data = new DataTable("Stats");
            data.Columns.Add("ID");
            data.Columns.Add("IMIE");
            data.Columns.Add("NAZWISKO");
            data.Columns.Add("Liczba KM");
            data.Columns.Add("Liczba wyp. pojazdów");
            data.Columns.Add("Koszt [ZŁ]");
            WorkerSet worker;
            string km, cost, count;
            double kms = 0, costs = 0, counts = 0;
            var Worker = from x in db.WorkerSets
                       select x.worker_id;

            var date_from = dateTimePicker_from_date_reserv.Value;
            var date_to = dateTimePicker_to_date_reserv.Value;

            foreach (int idw in Worker)
            {

                worker = db.WorkerSets.Where(x => x.worker_id == idw).First();
                try
                {
                    var worker_rent2 = from x in db.RentSets
                                       where x.Worker_worker_id == idw && x.date_from.Date >= date_from.Date && x.date_to.Date <= date_to.Date
                                       select x;

                    var count_km = (worker_rent2
                                        .Where(x => x.mileage_end != 0)
                                            .Sum(x => x.mileage_end - x.mileage_start)); 

                    km = count_km.ToString();
                    kms += count_km;
                }
                catch (Exception)
                {
                    km = "---";
                }
                try
                {
                    var query1 = ((from x in db.RentSets
                                   where x.Worker_worker_id == idw && x.date_from.Date >= date_from.Date && x.date_to.Date <= date_to.Date
                                   select x.Vehicle_vehicle_id)).Count();

                    count = query1.ToString();
                    counts += query1;
                }
                catch (Exception)
                {
                    count = "---";
                }
                try
                {
                    var count_cost = db.PurchaseSets
                                        .Where(x => x.RentSet.Worker_worker_id == idw && x.RentSet.date_from.Date >= date_from.Date && x.RentSet.date_to.Date <= date_to.Date)
                                            .Sum(x => x.price);

                    cost = count_cost.ToString();
                    costs += count_cost;
                }
                catch (Exception)
                {
                    cost = "---";
                }
                    data.Rows.Add(worker.worker_id, worker.name, worker.surname, km, count, cost);
            }


            GeneratePDF("Statystyki pracowników", "Statystyki za okres: " + dateTimePicker_from_date_reserv.Value.ToShortDateString() +
                         " - " + dateTimePicker_to_date_reserv.Value.ToShortDateString(), data, kms, costs, counts);
        }
     

        private void button_show_Click(object sender, EventArgs e)
        {
            int id =0;

            var date_from = dateTimePicker_from_date_reserv.Value;
            var date_to = dateTimePicker_to_date_reserv.Value;

            try
            {
                int row = dataGridView_workers_DB.CurrentCell.RowIndex;

                label_name_with_choice.Text = dataGridView_workers_DB.Rows[row].Cells[1].Value.ToString();
                label_surrname.Text = dataGridView_workers_DB.Rows[row].Cells[2].Value.ToString();
                label_number.Text = dataGridView_workers_DB.Rows[row].Cells[4].Value.ToString();
                label_position.Text = dataGridView_workers_DB.Rows[row].Cells[3].Value.ToString();

                 id = (int)dataGridView_workers_DB.Rows[row].Cells[0].Value;
            }
            catch
            {
                MessageBox.Show("Nie wybrano prcownika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                // ilość wyporzyczonych aut
               
                var query1 = ((from x in db.RentSets
                               where x.Worker_worker_id == id && x.date_from.Date >= date_from.Date && x.date_to.Date <= date_to.Date
                               select x.Vehicle_vehicle_id)).Count();

                label_time.Text = query1.ToString();
            
          //ilosc kilometrów
                try { 
                var worker_rent2 = from x in db.RentSets
                                   where x.Worker_worker_id == id && x.date_from.Date >= date_from.Date && x.date_to.Date <= date_to.Date
                                   select x;

                var count_km = worker_rent2
                                .Where(x => x.mileage_end != 0)
                                    .Sum(x => x.mileage_end - x.mileage_start);
                
                label_count_kilometers.Text = count_km.ToString() + " km";       }
            catch
            {
                label_count_kilometers.Text = " ----";
            }
            
            //koszt w daynm okresie
            try
            {
                var count_cost = db.PurchaseSets
                                .Where(x => x.RentSet.Worker_worker_id == id &&x.RentSet.date_from.Date>=date_from.Date&&x.RentSet.date_to.Date<=date_to.Date)
                                    .Sum(x => x.price);

                
                label_cost.Text = count_cost.ToString() + "  zł";
                
            }
            catch
            {
                label_cost.Text = " ----";
            }
        }

        private void button_generate_to_pdf_Click(object sender, EventArgs e)
        {
            try
            {
                Pdf_Data_Creator();
            }
            catch (Exception)
            {
                MessageBox.Show("Coś się zepsuło i nie było mnie słychać", "PDF.Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox_help_Click(object sender, EventArgs e)
        {
            helppdf help = new helppdf(27);
            help.Show();
        }
    }
}
