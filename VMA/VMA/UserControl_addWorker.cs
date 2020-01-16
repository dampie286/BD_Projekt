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
    public partial class UserControl_addWorker : UserControl
    {
        public UserControl_addWorker()
        {
            InitializeComponent();
            dateTimePicker_date_birth.MaxDate = DateTime.Today;
        }

        private void button_add_worker_Click(object sender, EventArgs e)
        {
           

          

            if (Convert.ToString(textBox_id_worker.Text)!=""&& Convert.ToString(textBox_name.Text)!="" && Convert.ToString(textBox_surrname.Text)!= "" && Convert.ToString(comboBox_position.Text) != "" && Convert.ToString(textBox_city.Text) != "" && Convert.ToString(textBox_street.Text) != "" && Convert.ToString(textBox_house.Text) != "" && Convert.ToString(textBox_tmp_pass.Text) != "" && Convert.ToString(textBox_phone_number.Text) != "")
            { 
            using (DataBaseDataContext db = new DataBaseDataContext())
            {
                bool confirm = false;
                try
                {
                    WorkerSet worker = new WorkerSet()
                    {
                        name = Convert.ToString(textBox_name.Text),
                        surname = Convert.ToString(textBox_surrname.Text),
                        position = Convert.ToString(comboBox_position.Text),
                        PESEL = Convert.ToString(textBox_id_worker.Text),

                        date_of_birth = Convert.ToDateTime(dateTimePicker_date_birth.Text),
                        city = Convert.ToString(textBox_city.Text),
                        city_code = Convert.ToString(textBox_code.Text),
                        street = Convert.ToString(textBox_street.Text),
                        house = Convert.ToString(textBox_house.Text),

                        password = Convert.ToString(textBox_tmp_pass.Text),
                        phone_nr = Convert.ToString(textBox_phone_number.Text)
                    };
                    db.WorkerSets.InsertOnSubmit(worker);
                    db.SubmitChanges();
                    confirm = true;
                }
                catch
                {
                    MessageBox.Show("Bład dodania pracownika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



                if (confirm)
                {
                    MessageBox.Show("Dodano pracownika", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox_city.Clear();
                    textBox_code.Clear();
                    textBox_house.Clear();
                    textBox_id_worker.Clear();
                    textBox_name.Clear();
                    textBox_street.Clear();
                    textBox_phone_number.Clear();
                    textBox_surrname.Clear();
                    textBox_tmp_pass.Clear();
                }


            }

            }else
            {

                MessageBox.Show("Należy uzupełnić wszystkie pola", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBox_phone_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chh = e.KeyChar;

            if (!Char.IsDigit(chh) && chh != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_id_worker_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chh = e.KeyChar;

            if (!Char.IsDigit(chh) && chh != 8)
            {
                e.Handled = true;
            }
        }

        public void ClearUserControl()
        {
            textBox_name.Clear();
            textBox_surrname.Clear();
            textBox_id_worker.Clear();
            dateTimePicker_date_birth.Value = DateTime.Today;
            textBox_city.Clear();
            textBox_code.Clear();
            textBox_house.Clear();
            textBox_phone_number.Clear();
            textBox_street.Clear();
            textBox_tmp_pass.Clear();
        }

        private void textBox_code_KeyPress(object sender, KeyPressEventArgs e)
        {



            char chh = e.KeyChar;
            if (chh == 46 && textBox_code.Text.IndexOf('-') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(chh) && chh != 8 && chh != 45)
            {
                e.Handled = true;
            }





        }

        private void textBox_street_KeyPress(object sender, KeyPressEventArgs e)
        {




        }

        private void textBox_phone_number_KeyPress_1(object sender, KeyPressEventArgs e)
        {


            int x = textBox_phone_number.TextLength;
            char chh = e.KeyChar;







            if (!Char.IsDigit(chh) && chh != 8)
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

        private void pictureBox_help_Click(object sender, EventArgs e)
        {
            helppdf help = new helppdf(46);
            help.Show();
        }
    }
}