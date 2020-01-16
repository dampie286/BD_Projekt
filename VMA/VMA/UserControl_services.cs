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
    public partial class UserControl_services : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public UserControl_services()
        {
            InitializeComponent();
        }

        public void fillDataGridView()
        {
            var Selectquery = from x in db.CompanySets
                              where x.description!="brakwspolpracy"
                              select new
                              {
                                  ID = x.company_id,
                                  NAZWA = x.name,
                                  SPECJALNOŚĆ = x.description,
                                  ADRES = x.address,
                                  TELEFON = x.phone_nr,
                              };

            dataGridView_services.DataSource = Selectquery;
            dataGridView_services.Columns[0].Visible = false;
            dataGridView_services.RowHeadersVisible = false;
            dataGridView_services.ReadOnly = true;        
        }





        private void button_add_company_Click(object sender, EventArgs e)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            bool confirm = false;


            if (textBox_name.Text == "" || textBox_city_post.Text == "" || textBox_city.Text == "" || textBox_number_phone.Text == "" || textBox_number_service.Text == "" || textBox_street.Text == "" || textBox_what_are_they_doing.Text == "")
            {
                MessageBox.Show("Wymagane są wszystkie pola", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    CompanySet newcompany = new CompanySet()
                    {

                        name = textBox_name.Text,
                        description = textBox_what_are_they_doing.Text,
                        address = textBox_street.Text + "  " + textBox_number_service.Text + "  " + textBox_city.Text + "  " + textBox_city_post.Text,
                        phone_nr = textBox_number_phone.Text




                    };
                    db.CompanySets.InsertOnSubmit(newcompany);
                    db.SubmitChanges();
                    confirm = true;
                }
                catch
                {
                    MessageBox.Show("Bład dodania firmy do bazy", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                if (confirm)
                {
                    MessageBox.Show("Dodano nową firmę", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textBox_name.Clear();
                    textBox_city_post.Clear();
                    textBox_city.Clear();
                    textBox_number_phone.Clear();
                    textBox_number_service.Clear();
                    textBox_street.Clear();
                    textBox_what_are_they_doing.Clear();
                    fillDataGridView();

                }
            }
            
            
              
            




        }

        private void textBox_city_post_KeyPress(object sender, KeyPressEventArgs e)
        {


            char chh = e.KeyChar;
            if (chh == 46 && textBox_city_post.Text.IndexOf('-') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(chh) && chh != 8 && chh != 45)
            {
                e.Handled = true;
            }

        }

      

        private void textBox_number_phone_KeyPress(object sender, KeyPressEventArgs e)
        {

            int x = textBox_number_phone.TextLength;
            char chh = e.KeyChar;







            if (!Char.IsDigit(chh) && chh!=8)
            {
                e.Handled = true;
            }
            else
            {
                if (chh != 8)
                {
                    if (x > 8)
                    {

                        e.Handled = true;


                    }

                }


            }



            
         

        
              
            
           



        }

        private void button_delete_servie_Click(object sender, EventArgs e)
        {



            var result = MessageBox.Show("Czy napewno chcesz usunąć firme z bazy?", "Potwierdzenie",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                DataBaseDataContext db = new DataBaseDataContext();
                bool confirm = false;

                int row = dataGridView_services.CurrentCell.RowIndex;

                var id_del = (int)dataGridView_services.Rows[row].Cells[0].Value;


                var query = from x in db.CompanySets where x.company_id == id_del select x;



                foreach (CompanySet x in query)
                {
                    x.description = "brakwspolpracy";


                }
                
          
                try
                {
                    db.SubmitChanges();
                    confirm = true;
                }
                catch
                {
                    MessageBox.Show("Nie udało się usunąć firmy", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                if (confirm)
                {
                    MessageBox.Show("Usunięto firme", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }




                fillDataGridView();
            }
           
        }

        private void pictureBox_help_Click(object sender, EventArgs e)
        {
            helppdf help = new helppdf(23);
            help.Show();
        }
    }
}
