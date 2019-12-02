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

        }

        private void textBox_name_Leave(object sender, EventArgs e)
        {

        }

        private void textBox_surrname_Leave(object sender, EventArgs e)
        {

        }

        private void textBox_surrname_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_id_worker_Leave(object sender, EventArgs e)
        {

        }

        private void textBox_id_worker_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_equipment_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_equipment_Leave(object sender, EventArgs e)
        {

        }

        private void textBox_phone_number_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_phone_number_Leave(object sender, EventArgs e)
        {

        }

        private void textBox_position_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_position_Leave(object sender, EventArgs e)
        {

        }
    }
}
