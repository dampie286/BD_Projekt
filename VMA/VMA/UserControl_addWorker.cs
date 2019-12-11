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
            dateTimePicker_date_birth.MaxDate=DateTime.Today;
        }

        private void button_add_worker_Click(object sender, EventArgs e)
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
                       city= Convert.ToString(textBox_city.Text),
                       city_code= Convert.ToString(textBox_code.Text),
                        street=Convert.ToString(textBox_street.Text),
                        house=Convert.ToString(textBox_house.Text),

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

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
