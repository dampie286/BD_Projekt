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
                        position = Convert.ToString(textBox_position.Text),
                        PESEL = Convert.ToString(textBox_id_worker.Text),

                        date_of_birth = Convert.ToDateTime(textBox_equipment.Text),


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
                    MessageBox.Show("Dodano pracownika", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

               
            }
        }

        private void textBox_name_Enter(object sender, EventArgs e)
        {
            if (textBox_name.Text.Equals(@"Imię"))
            {
                textBox_name.Text = "";
            }
        }

        private void textBox_name_Leave(object sender, EventArgs e)
        {
            if (textBox_name.Text.Equals(""))
            {
                textBox_name.Text = "Imię";
            }
        }

        private void textBox_surrname_Leave(object sender, EventArgs e)
        {
            if (textBox_surrname.Text.Equals(""))
            {
                textBox_surrname.Text = "Nazwisko";
            }
        }

        private void textBox_surrname_Enter(object sender, EventArgs e)
        {
            if (textBox_surrname.Text.Equals(@"Nazwisko"))
            {
                textBox_surrname.Text = "";
            }
        }

        private void textBox_id_worker_Leave(object sender, EventArgs e)
        {
            if (textBox_id_worker.Text.Equals(""))
            {
                textBox_id_worker.Text = "Pesel";
            }
        }

        private void textBox_id_worker_Enter(object sender, EventArgs e)
        {
            if (textBox_id_worker.Text.Equals(@"Pesel"))
            {
                textBox_id_worker.Text = "";
            }
        }

        private void textBox_equipment_Enter(object sender, EventArgs e)
        {
            if (textBox_equipment.Text.Equals(@"Data urodzenia"))
            {
                textBox_equipment.Text = "";
            }
        }

        private void textBox_equipment_Leave(object sender, EventArgs e)
        {
            if (textBox_equipment.Text.Equals(""))
            {
                textBox_equipment.Text = "Data urodzenia";
            }
        }

        private void textBox_phone_number_Enter(object sender, EventArgs e)
        {
            if (textBox_phone_number.Text.Equals(@"Numer telefonu"))
            {
                textBox_phone_number.Text = "";
            }
        }

        private void textBox_phone_number_Leave(object sender, EventArgs e)
        {
            if (textBox_phone_number.Text.Equals(""))
            {
                textBox_phone_number.Text = "Numer telefonu";
            }
        }

        private void textBox_position_Enter(object sender, EventArgs e)
        {
            if (textBox_position.Text.Equals(@"Stanowisko"))
            {
                textBox_position.Text = "";
            }
        }

        private void textBox_position_Leave(object sender, EventArgs e)
        {
            if (textBox_position.Text.Equals(""))
            {
                textBox_position.Text = "Stanowisko";
            }
        }

        private void textBox_tmp_pass_Enter(object sender, EventArgs e)
        {
            if (textBox_tmp_pass.Text.Equals(@"Hasło"))
            {
                textBox_tmp_pass.Text = "";
            }
        }

        private void textBox_tmp_pass_Leave(object sender, EventArgs e)
        {
            if (textBox_tmp_pass.Text.Equals(""))
            {
                textBox_tmp_pass.Text = "Hasło";
            }
        }
    }
}
