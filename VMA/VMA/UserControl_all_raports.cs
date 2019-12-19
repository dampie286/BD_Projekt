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
                    Phrase ph = new Phrase(description +  " \n \n");
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
            data.Columns.Add("STANOWISKO");
            data.Columns.Add("NUMER TELEFONU");
            WorkerSet worker;
            var Cars = from x in db.WorkerSets
                       select x.worker_id;

            foreach (int idw in Cars)
            {
                worker = db.WorkerSets.Where(x => x.worker_id == idw).First();
               
                data.Rows.Add(worker.worker_id, worker.name, worker.surname, worker.position, worker.phone_nr);
            }
            
            
            GeneratePDF("Lista Pracowników", "Lista pracownikow na dzien " + DateTime.Today.ToShortDateString(), data);
        }

        private void button_cars_generate_to_pdf_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable("Stats");
            data.Columns.Add("ID");
            data.Columns.Add("MARKA");
            data.Columns.Add("MODEL");
            data.Columns.Add("REJESTRACJA");
            data.Columns.Add("PRZEBIEG [KM]");

            VehicleSet worker;
            var Cars = from x in db.VehicleSets
                       select x.vehicle_id;
            
            foreach (int idw in Cars)
            {
                worker = db.VehicleSets.Where(x => x.vehicle_id == idw).First();

                data.Rows.Add(worker.vehicle_id, worker.brand, worker.model, worker.licence_plate, worker.mileage);
            }

            GeneratePDF("Lista Pojazdów", "Lista pojazdów na dzien " + DateTime.Today.ToShortDateString(), data);
        }

        private void button_reservation_generate_to_pdf_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable("Stats");
            data.Columns.Add("Imię");
            data.Columns.Add("Nazwisko");
            data.Columns.Add("Marka");
            data.Columns.Add("Model");
            data.Columns.Add("Rejestracja");
            data.Columns.Add("Data od");
            data.Columns.Add("Data do");
            data.Columns.Add("Cel rezerwacji");


            VehicleSet vehicle;
            ReservationSet Reservation;
            WorkerSet worker;
            var Cars = from x in db.ReservationSets
                       where (x.date_from >= dateTimePicker_from_date_reserv.Value.Date && x.date_to <= dateTimePicker_to_date_reserv.Value.Date)
                               || (x.date_from <= dateTimePicker_from_date_reserv.Value.Date && x.date_to >= dateTimePicker_from_date_reserv.Value.Date)
                       select x.reservation_id;

            foreach (int idw in Cars)
            {
                
                Reservation = db.ReservationSets.Where(x => x.reservation_id == idw).First();

                vehicle = db.VehicleSets.Where(y => y.vehicle_id == Reservation.Vehicle_vehicle_id).First();

                worker = db.WorkerSets.Where(z => z.worker_id == Reservation.Worker_worker_id).First();

                data.Rows.Add(worker.name, worker.surname, vehicle.brand, vehicle.model, vehicle.licence_plate, Reservation.date_from.Date.ToShortDateString(), Reservation.date_to.Date.ToShortDateString(), Reservation.purpose);
            }
            
            GeneratePDF("Lista Rezerwacji", "Lista rezerwacji od " + dateTimePicker_from_date_reserv.Value.Date.ToShortDateString() + " do " + dateTimePicker_to_date_reserv.Value.Date.ToShortDateString(), data);
        }

        private void button_keeper_generate_to_pdf_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable("Stats");
            data.Columns.Add("Imię");
            data.Columns.Add("Nazwisko");
            data.Columns.Add("Marka");
            data.Columns.Add("Model");
            data.Columns.Add("Rejestracja");
            data.Columns.Add("Rozpoczęcie opieki");
            data.Columns.Add("Zakończenie opieki");

            DateTime time_to_Compare = Convert.ToDateTime("1999-01-01 00:00:00.000");
            CareSet Care;
            WorkerSet Worker;
            VehicleSet Vehicle;
            string history;
            string description = "stan opieki";
            var Cars = from x in db.CareSets
                       select x.care_id;
            
            foreach (int idw in Cars)
            {
                if (comboBox_status_of_care.Text == "Aktualni opiekunowie")
                {
                    Care = db.CareSets.Where(x => x.care_id == idw && x.date_to == time_to_Compare).SingleOrDefault();
                    if (Care == null)
                    {

                    }
                    else
                    {
                        Vehicle = db.VehicleSets.Where(x => x.vehicle_id == Care.Vehicle_vehicle_id).First();

                        Worker = db.WorkerSets.Where(x => x.worker_id == Care.Keeper_worker_id).First();

                        data.Rows.Add(Worker.name, Worker.surname, Vehicle.brand, Vehicle.model, Vehicle.licence_plate, Care.date_from.ToShortDateString(), "----");
                    }
                    description = "Stan opiekunów na dzień " + DateTime.Today.ToShortDateString();
                }
                else if (comboBox_status_of_care.Text == "Byli opiekunowie")
                {
                    Care = db.CareSets.Where(x => x.care_id == idw && x.date_to != time_to_Compare).SingleOrDefault();
                    if (Care == null)
                    {

                    }
                    else
                    {
                        Vehicle = db.VehicleSets.Where(x => x.vehicle_id == Care.Vehicle_vehicle_id).First();

                        Worker = db.WorkerSets.Where(x => x.worker_id == Care.Keeper_worker_id).First();

                        data.Rows.Add(Worker.name, Worker.surname, Vehicle.brand, Vehicle.model, Vehicle.licence_plate, Care.date_from.ToShortDateString(), Care.date_to.Value.ToShortDateString());
                    }
                    description = "Opieki już zakończone, stan na dzień " + DateTime.Today.ToShortDateString();
                }
                else if (comboBox_status_of_care.Text == "Historia opieki")
                {
                    Care = db.CareSets.Where(x => x.care_id == idw).SingleOrDefault();

                    if (Care == null)
                    {

                    }
                    else
                    {
                        if (Care.date_to == time_to_Compare)
                        {
                            history = "----";
                        }
                        else
                        {
                            history = Care.date_to.Value.ToShortDateString();
                        }
                        Vehicle = db.VehicleSets.Where(x => x.vehicle_id == Care.Vehicle_vehicle_id).First();

                        Worker = db.WorkerSets.Where(x => x.worker_id == Care.Keeper_worker_id).First();

                        data.Rows.Add(Worker.name, Worker.surname, Vehicle.brand, Vehicle.model, Vehicle.licence_plate, Care.date_from.ToShortDateString(), history);
                    }
                    description = "Historia opiek na dzień " + DateTime.Today.ToShortDateString();
                }
                else
                {
                    Care = db.CareSets.Where(x => x.care_id == idw && x.date_from >= dateTimePicker_from_date_reserv.Value.Date && x.date_to <= dateTimePicker_to_date_reserv.Value).SingleOrDefault(); ;
                    if (Care == null)
                    {

                    }
                    else
                    {
                        if (Care.date_to == time_to_Compare)
                        {
                            history = "----";
                        }
                        else
                        {
                            history = Care.date_to.Value.ToShortDateString();
                        }

                        Vehicle = db.VehicleSets.Where(x => x.vehicle_id == Care.Vehicle_vehicle_id).First();

                        Worker = db.WorkerSets.Where(x => x.worker_id == Care.Keeper_worker_id).First();

                        data.Rows.Add(Worker.name, Worker.surname, Vehicle.brand, Vehicle.model, Vehicle.licence_plate, Care.date_from.ToShortDateString(), history);
                    }

                  description =  "Lista opiekunów od " + dateTimePicker_from_date_reserv.Value.Date.ToShortDateString() + " do " + dateTimePicker_to_date_reserv.Value.Date.ToShortDateString();
                }

               
            }

            GeneratePDF("Lista Opiekunów", description, data);
        }

        private void button_services_generate_to_pdf_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable("Stats");
            data.Columns.Add("Marka");
            data.Columns.Add("Model");
            data.Columns.Add("Rejestracja");
            data.Columns.Add("Przypadłość");
            data.Columns.Add("Opis");
            data.Columns.Add("Firma");
            data.Columns.Add("Telefon");
            data.Columns.Add("Od");
            data.Columns.Add("Status");

            Care_serviceSet Care_Service;
            CareSet care;
            VehicleSet vehicle;
            ServiceSet service;
            CompanySet company;
            DateTime time_to_Compare = Convert.ToDateTime("1999-01-01 00:00:00.000");
            string repaired;
            var Cars = from x in db.Care_serviceSets
                       select x.care_service_id;

            foreach (int idw in Cars)
            {
                Care_Service = db.Care_serviceSets.Where(x => x.care_service_id == idw).First();

                care = db.CareSets.Where(x => x.care_id == Care_Service.Care_care_id).First();

                vehicle = db.VehicleSets.Where(x => x.vehicle_id == care.Vehicle_vehicle_id).First();

                service = db.ServiceSets.Where(x => x.service_id == Care_Service.Service_service_id).First();

                company = db.CompanySets.Where(x => x.company_id == Care_Service.Company_company_id).First();
                if (Care_Service.data_to == time_to_Compare)
                {
                    repaired = "W naprawie";
                }
                else
                {
                    repaired = Care_Service.data_to.Value.ToShortDateString();
                }
                data.Rows.Add(vehicle.model, vehicle.brand, vehicle.licence_plate, 
                    service.name, service.description, company.name, company.phone_nr, Care_Service.date_from.ToShortDateString(), repaired);
            }

            GeneratePDF("Lista Serwisów", "Lista serwisow na dzien " + DateTime.Today.ToShortDateString(), data);
        }

        private void button_rents_generate_to_pdf_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable("Stats");
            data.Columns.Add("Imię");
            data.Columns.Add("Nazwisko");
            data.Columns.Add("Marka");
            data.Columns.Add("Model");
            data.Columns.Add("Rejestracja");
            data.Columns.Add("Data od");
            data.Columns.Add("Data do");
            data.Columns.Add("Cel rezerwacji");
            data.Columns.Add("Przejechana liczba km");

            RentSet rent;
            VehicleSet vehicle;
            WorkerSet worker;
            string km;
            var Cars = from x in db.RentSets
                       where (x.date_from >= dateTimePicker_from_date_reserv.Value.Date && x.date_to <= dateTimePicker_to_date_reserv.Value.Date)
                               || (x.date_from <= dateTimePicker_from_date_reserv.Value.Date && x.date_to >= dateTimePicker_from_date_reserv.Value.Date)
                       select x.rent_id;

            foreach (int idw in Cars)
            {

                rent = db.RentSets.Where(x => x.rent_id == idw).First();

                vehicle = db.VehicleSets.Where(y => y.vehicle_id == rent.Vehicle_vehicle_id).First();

                worker = db.WorkerSets.Where(z => z.worker_id == rent.Worker_worker_id).First();

                if (rent.mileage_end == 0)
                {
                    km = "W trakcie";
                }
                else
                {
                    km = (rent.mileage_end - rent.mileage_start).ToString();
                }
                data.Rows.Add(worker.name, worker.surname, vehicle.brand, vehicle.model, vehicle.licence_plate, 
                    rent.date_from.Date.ToShortDateString(), rent.date_to.Date.ToShortDateString(), rent.purpose, km);
            }
            
            GeneratePDF("Lista Wypożyczeń", "Lista wypozyczen od " + dateTimePicker_from_date_reserv.Value.Date.ToShortDateString() + " do " + dateTimePicker_to_date_reserv.Value.Date.ToShortDateString(), data);
        }

        private void button_cost_generate_to_pdf_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable("Stats");
            data.Columns.Add("Imię");
            data.Columns.Add("Nazwisko");
            data.Columns.Add("Marka");
            data.Columns.Add("Model");
            data.Columns.Add("Rejestracja");
            data.Columns.Add("Data od");
            data.Columns.Add("Data do");
            data.Columns.Add("Cel rezerwacji");
            data.Columns.Add("Koszt podczas wypożyczenia");

            RentSet rent;
            VehicleSet vehicle;
            WorkerSet worker;
            PurchaseSet purchase;

            var Cars = from x in db.RentSets
                       where ((x.date_from >= dateTimePicker_from_date_reserv.Value.Date && x.date_to <= dateTimePicker_to_date_reserv.Value.Date)
                               || (x.date_from <= dateTimePicker_from_date_reserv.Value.Date && x.date_to >= dateTimePicker_from_date_reserv.Value.Date))
                               && x.mileage_end != 0
                       select x.rent_id;

            foreach (int idw in Cars)
            {

                rent = db.RentSets.Where(x => x.rent_id == idw).First();

                purchase = db.PurchaseSets.Where(x => x.Rent_rent_id == rent.rent_id).SingleOrDefault();

                if (purchase == null)
                {

                }
                else
                {
                    vehicle = db.VehicleSets.Where(y => y.vehicle_id == rent.Vehicle_vehicle_id).First();

                    worker = db.WorkerSets.Where(z => z.worker_id == rent.Worker_worker_id).First();


                    data.Rows.Add(worker.name, worker.surname, vehicle.brand, vehicle.model, vehicle.licence_plate,
                        rent.date_from.Date.ToShortDateString(), rent.date_to.Date.ToShortDateString(), rent.purpose, purchase.price);
                }

                
            }

            
            GeneratePDF("Lista Kosztów", "Lista kosztow od " + dateTimePicker_from_date_reserv.Value.Date.ToShortDateString() + " do " + dateTimePicker_to_date_reserv.Value.Date.ToShortDateString(), data);
        }
      
    }
}
