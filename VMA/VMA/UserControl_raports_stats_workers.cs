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
        public UserControl_raports_stats_workers()
        {
            InitializeComponent();
        }
        private void Grid_edit()
        {

            //widocznos kolumn
            dataGridView_workers_DB.RowHeadersVisible = false;
            dataGridView_workers_DB.Columns[0].Visible = false;
            //  dataGridView_workers_DB.Columns[1].Visible = false; imie
            // dataGridView_workers_DB.Columns[2].Visible = false;  nazwisko    
            //dataGridView_workers_DB.Columns[3].Visible = false;   pozycja
            dataGridView_workers_DB.Columns[4].Visible = false;
            dataGridView_workers_DB.Columns[5].Visible = false;
            dataGridView_workers_DB.Columns[6].Visible = false;
            // dataGridView_workers_DB.Columns[7].Visible = false;  nr telefonu
            dataGridView_workers_DB.Columns[8].Visible = false;
            dataGridView_workers_DB.Columns[9].Visible = false;
            dataGridView_workers_DB.Columns[10].Visible = false;
            dataGridView_workers_DB.Columns[11].Visible = false;
            dataGridView_workers_DB.Columns[12].Visible = false;

        }

        public void fillDataGridView()
        {


            DataBaseDataContext db = new DataBaseDataContext();
            var query = from x in db.WorkerSets where x.position != "fired" select x;

            dataGridView_workers_DB.DataSource = query;
            Grid_edit();

        }

     

        private void button_show_Click(object sender, EventArgs e)
        {




            int id =0;

            var date_from = dateTimePicker_from_date_reserv.Value;
            var date_to = dateTimePicker_to_date_reserv.Value;
            DataBaseDataContext db = new DataBaseDataContext();
            try
            {
                int row = dataGridView_workers_DB.CurrentCell.RowIndex;

                label_name_with_choice.Text = dataGridView_workers_DB.Rows[row].Cells[1].Value.ToString();
                label_surrname.Text = dataGridView_workers_DB.Rows[row].Cells[2].Value.ToString();
                label_number.Text = dataGridView_workers_DB.Rows[row].Cells[7].Value.ToString();
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

                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
                doc.Open();
                Paragraph paragraph = new Paragraph("Coś się zepsuło i nie było mnie słychać");
                doc.Add(paragraph);
                doc.Close();
            }
            catch (Exception)
            {

            }
            MessageBox.Show("Robie PDF dla wszystkich pracowników w danym okresie :)", "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
