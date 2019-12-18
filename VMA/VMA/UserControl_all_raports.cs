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

        private void button_worker_generate_to_pdf_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable("Stats");
            data.Columns.Add("ID");
            data.Columns.Add("IMIE");
            data.Columns.Add("NAZWISKO");
            WorkerSet worker;
            var Cars = from x in db.WorkerSets
                       select x.worker_id;

            var date_from = dateTimePicker_from_date_reserv.Value;
            var date_to = dateTimePicker_to_date_reserv.Value;

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

            var savefiledialogue = new SaveFileDialog();
            savefiledialogue.FileName = "Lista Pracowników";
            savefiledialogue.DefaultExt = ".pdf";
            if (savefiledialogue.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fstream = new FileStream(savefiledialogue.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfdoc, fstream);
                    pdfdoc.Open();
                    Phrase ph = new Phrase("Lista pracowników na dzień " + DateTime.Today.Date.ToString() + " \n");
                    pdfdoc.Add(ph);
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    fstream.Close();
                }
            }
        }
    }
}
