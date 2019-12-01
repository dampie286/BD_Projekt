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

        private void textBox_name_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
        }

        private void textBox_surrname_Click(object sender, EventArgs e)
        {
            textBox_surrname.Clear();
        }

        private void textBox_id_worker_Click(object sender, EventArgs e)
        {
            textBox_id_worker.Clear();
        }

        private void textBox_equipment_Click(object sender, EventArgs e)
        {
            textBox_equipment.Clear();
        }

        private void textBox_phone_number_Click(object sender, EventArgs e)
        {
            textBox_phone_number.Clear();
        }

        private void textBox_position_Click(object sender, EventArgs e)
        {
            textBox_position.Clear();
        }

        private void textBox_tmp_pass_Click(object sender, EventArgs e)
        {
            textBox_tmp_pass.Clear();
        }
    }
}
