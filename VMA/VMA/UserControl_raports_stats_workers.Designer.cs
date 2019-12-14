namespace VMA
{
    partial class UserControl_raports_stats_workers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_menage_keepers = new System.Windows.Forms.Label();
            this.button_show = new System.Windows.Forms.Button();
            this.label_to_date_reserv = new System.Windows.Forms.Label();
            this.dateTimePicker_to_date_reserv = new System.Windows.Forms.DateTimePicker();
            this.label_from_date = new System.Windows.Forms.Label();
            this.dateTimePicker_from_date_reserv = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_workers_DB = new System.Windows.Forms.DataGridView();
            this.label_desc_my_choice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_name_with_choice = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_surrname = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_count_kilometers = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_cost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_generate_to_pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_workers_DB)).BeginInit();
            this.SuspendLayout();
            // 
            // label_menage_keepers
            // 
            this.label_menage_keepers.AutoSize = true;
            this.label_menage_keepers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold);
            this.label_menage_keepers.ForeColor = System.Drawing.Color.Yellow;
            this.label_menage_keepers.Location = new System.Drawing.Point(27, 17);
            this.label_menage_keepers.Margin = new System.Windows.Forms.Padding(0);
            this.label_menage_keepers.Name = "label_menage_keepers";
            this.label_menage_keepers.Size = new System.Drawing.Size(521, 29);
            this.label_menage_keepers.TabIndex = 45;
            this.label_menage_keepers.Text = "RAPORTY I STATYSTYKI PRACOWNIKÓW";
            // 
            // button_show
            // 
            this.button_show.BackColor = System.Drawing.Color.Yellow;
            this.button_show.FlatAppearance.BorderSize = 0;
            this.button_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show.Font = new System.Drawing.Font("Arial", 12F);
            this.button_show.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_show.Location = new System.Drawing.Point(720, 54);
            this.button_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(203, 41);
            this.button_show.TabIndex = 54;
            this.button_show.Text = "Pokaż";
            this.button_show.UseVisualStyleBackColor = false;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // label_to_date_reserv
            // 
            this.label_to_date_reserv.AutoSize = true;
            this.label_to_date_reserv.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label_to_date_reserv.ForeColor = System.Drawing.Color.Yellow;
            this.label_to_date_reserv.Location = new System.Drawing.Point(373, 65);
            this.label_to_date_reserv.Margin = new System.Windows.Forms.Padding(0);
            this.label_to_date_reserv.Name = "label_to_date_reserv";
            this.label_to_date_reserv.Size = new System.Drawing.Size(74, 19);
            this.label_to_date_reserv.TabIndex = 53;
            this.label_to_date_reserv.Text = "Do kiedy";
            // 
            // dateTimePicker_to_date_reserv
            // 
            this.dateTimePicker_to_date_reserv.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_to_date_reserv.CalendarForeColor = System.Drawing.Color.Yellow;
            this.dateTimePicker_to_date_reserv.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_to_date_reserv.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_to_date_reserv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_to_date_reserv.Location = new System.Drawing.Point(457, 60);
            this.dateTimePicker_to_date_reserv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_to_date_reserv.MinDate = new System.DateTime(2019, 12, 9, 0, 0, 0, 0);
            this.dateTimePicker_to_date_reserv.Name = "dateTimePicker_to_date_reserv";
            this.dateTimePicker_to_date_reserv.Size = new System.Drawing.Size(247, 26);
            this.dateTimePicker_to_date_reserv.TabIndex = 52;
            // 
            // label_from_date
            // 
            this.label_from_date.AutoSize = true;
            this.label_from_date.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label_from_date.ForeColor = System.Drawing.Color.Yellow;
            this.label_from_date.Location = new System.Drawing.Point(28, 65);
            this.label_from_date.Margin = new System.Windows.Forms.Padding(0);
            this.label_from_date.Name = "label_from_date";
            this.label_from_date.Size = new System.Drawing.Size(74, 19);
            this.label_from_date.TabIndex = 51;
            this.label_from_date.Text = "Od kiedy";
            // 
            // dateTimePicker_from_date_reserv
            // 
            this.dateTimePicker_from_date_reserv.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_from_date_reserv.CalendarForeColor = System.Drawing.Color.Yellow;
            this.dateTimePicker_from_date_reserv.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_from_date_reserv.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_from_date_reserv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_from_date_reserv.Location = new System.Drawing.Point(110, 60);
            this.dateTimePicker_from_date_reserv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_from_date_reserv.MinDate = new System.DateTime(2019, 12, 9, 0, 0, 0, 0);
            this.dateTimePicker_from_date_reserv.Name = "dateTimePicker_from_date_reserv";
            this.dateTimePicker_from_date_reserv.Size = new System.Drawing.Size(247, 26);
            this.dateTimePicker_from_date_reserv.TabIndex = 50;
            // 
            // dataGridView_workers_DB
            // 
            this.dataGridView_workers_DB.AllowUserToAddRows = false;
            this.dataGridView_workers_DB.AllowUserToDeleteRows = false;
            this.dataGridView_workers_DB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_workers_DB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_workers_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_workers_DB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_workers_DB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_workers_DB.Location = new System.Drawing.Point(32, 113);
            this.dataGridView_workers_DB.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_workers_DB.Name = "dataGridView_workers_DB";
            this.dataGridView_workers_DB.ReadOnly = true;
            this.dataGridView_workers_DB.RowTemplate.Height = 24;
            this.dataGridView_workers_DB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_workers_DB.Size = new System.Drawing.Size(909, 255);
            this.dataGridView_workers_DB.TabIndex = 75;
            // 
            // label_desc_my_choice
            // 
            this.label_desc_my_choice.AutoSize = true;
            this.label_desc_my_choice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc_my_choice.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_my_choice.Location = new System.Drawing.Point(27, 392);
            this.label_desc_my_choice.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_my_choice.Name = "label_desc_my_choice";
            this.label_desc_my_choice.Size = new System.Drawing.Size(162, 29);
            this.label_desc_my_choice.TabIndex = 76;
            this.label_desc_my_choice.Text = "MÓJ WYBÓR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(28, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 86;
            this.label1.Text = "Nazwisko";
            // 
            // label_name_with_choice
            // 
            this.label_name_with_choice.AutoSize = true;
            this.label_name_with_choice.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label_name_with_choice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_name_with_choice.Location = new System.Drawing.Point(176, 459);
            this.label_name_with_choice.Name = "label_name_with_choice";
            this.label_name_with_choice.Size = new System.Drawing.Size(0, 19);
            this.label_name_with_choice.TabIndex = 85;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Arial", 12F);
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_name.Location = new System.Drawing.Point(28, 455);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(47, 23);
            this.label_name.TabIndex = 84;
            this.label_name.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label2.Location = new System.Drawing.Point(28, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 88;
            this.label2.Text = "Numer telefonu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label3.Location = new System.Drawing.Point(28, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 90;
            this.label3.Text = "Stanowisko";
            // 
            // label_surrname
            // 
            this.label_surrname.AutoSize = true;
            this.label_surrname.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label_surrname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_surrname.Location = new System.Drawing.Point(176, 498);
            this.label_surrname.Name = "label_surrname";
            this.label_surrname.Size = new System.Drawing.Size(0, 19);
            this.label_surrname.TabIndex = 91;
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_number.Location = new System.Drawing.Point(176, 531);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(0, 19);
            this.label_number.TabIndex = 92;
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label_position.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_position.Location = new System.Drawing.Point(176, 566);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(0, 19);
            this.label_position.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label9.Location = new System.Drawing.Point(310, 455);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 23);
            this.label9.TabIndex = 94;
            this.label9.Text = "Liczba kilometrów za dany okres";
            // 
            // label_count_kilometers
            // 
            this.label_count_kilometers.AutoSize = true;
            this.label_count_kilometers.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label_count_kilometers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_count_kilometers.Location = new System.Drawing.Point(615, 459);
            this.label_count_kilometers.Name = "label_count_kilometers";
            this.label_count_kilometers.Size = new System.Drawing.Size(0, 19);
            this.label_count_kilometers.TabIndex = 95;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_time.Location = new System.Drawing.Point(615, 498);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 19);
            this.label_time.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label5.Location = new System.Drawing.Point(310, 494);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 23);
            this.label5.TabIndex = 96;
            this.label5.Text = "Ilość wypożyczeń pojazdów";
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label_cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_cost.Location = new System.Drawing.Point(615, 531);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(0, 19);
            this.label_cost.TabIndex = 99;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label7.Location = new System.Drawing.Point(310, 527);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 23);
            this.label7.TabIndex = 98;
            this.label7.Text = "Wygenerowany koszt";
            // 
            // button_generate_to_pdf
            // 
            this.button_generate_to_pdf.BackColor = System.Drawing.Color.Yellow;
            this.button_generate_to_pdf.FlatAppearance.BorderSize = 0;
            this.button_generate_to_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_generate_to_pdf.Font = new System.Drawing.Font("Arial", 12F);
            this.button_generate_to_pdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_generate_to_pdf.Location = new System.Drawing.Point(720, 590);
            this.button_generate_to_pdf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_generate_to_pdf.Name = "button_generate_to_pdf";
            this.button_generate_to_pdf.Size = new System.Drawing.Size(203, 41);
            this.button_generate_to_pdf.TabIndex = 100;
            this.button_generate_to_pdf.Text = "Generuj do PDF";
            this.button_generate_to_pdf.UseVisualStyleBackColor = false;
            this.button_generate_to_pdf.Click += new System.EventHandler(this.button_generate_to_pdf_Click);
            // 
            // UserControl_raports_stats_workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.button_generate_to_pdf);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_count_kilometers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_position);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label_surrname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_name_with_choice);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_desc_my_choice);
            this.Controls.Add(this.dataGridView_workers_DB);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.label_to_date_reserv);
            this.Controls.Add(this.dateTimePicker_to_date_reserv);
            this.Controls.Add(this.label_from_date);
            this.Controls.Add(this.dateTimePicker_from_date_reserv);
            this.Controls.Add(this.label_menage_keepers);
            this.Name = "UserControl_raports_stats_workers";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_workers_DB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_menage_keepers;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Label label_to_date_reserv;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to_date_reserv;
        private System.Windows.Forms.Label label_from_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from_date_reserv;
        private System.Windows.Forms.DataGridView dataGridView_workers_DB;
        private System.Windows.Forms.Label label_desc_my_choice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_name_with_choice;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_surrname;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_count_kilometers;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_generate_to_pdf;
    }
}
