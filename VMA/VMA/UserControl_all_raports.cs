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
    public partial class UserControl_all_raports : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public UserControl_all_raports()
        {
            InitializeComponent();
        }
        private void GeneratePDF(string filename, string description, PdfPTable pdftable)
        {
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
                    DateTime today = DateTime.Today.Date;
                    Phrase ph = new Phrase(description + today.ToString() + " \n \n");
                    pdfdoc.Add(ph);
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    fstream.Close();
                }
            }
        }

        private void button_worker_generate_to_pdf_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable("Stats");
            data.Columns.Add("ID");
            data.Columns.Add("IMIE");
            data.Columns.Add("NAZWISKO");
            WorkerSet worker;
            var Cars = from x in db.WorkerSets
                       select x.worker_id;

            foreach (int idw in Cars)
            {
                worker = db.WorkerSets.Where(x => x.worker_id == idw).First();
               
                data.Rows.Add(worker.worker_id, worker.name, worker.surname);
            }
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

            GeneratePDF("Lista Pracowników", "Lista pracownikow na dzien ", pdftable);
        }

        private void button_cars_generate_to_pdf_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable("Stats");
            data.Columns.Add("ID");
            data.Columns.Add("MARKA");
            data.Columns.Add("MODEL");
            data.Columns.Add("REJESTRACJA");
            data.Columns.Add("PRZEBIEG");

            VehicleSet worker;
            var Cars = from x in db.VehicleSets
                       select x.vehicle_id;
            
            foreach (int idw in Cars)
            {
                worker = db.VehicleSets.Where(x => x.vehicle_id == idw).First();

                data.Rows.Add(worker.vehicle_id, worker.brand, worker.model, worker.licence_plate, worker.mileage);
            }
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

            GeneratePDF("Lista Pojazdów", "Lista pojazdów na dzien ", pdftable);
        }

        private void button_reservation_generate_to_pdf_Click(object sender, EventArgs e)
        {

        }
    }
}
