﻿namespace VMA
{
    partial class UserControl_menage_care_cars
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
            this.dataGridView_care_car_DB = new System.Windows.Forms.DataGridView();
            this.label_your_cars_care = new System.Windows.Forms.Label();
            this.button_blocked = new System.Windows.Forms.Button();
            this.button_unblocking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_to_date_reserv = new System.Windows.Forms.Label();
            this.dateTimePicker_to_date_reserv = new System.Windows.Forms.DateTimePicker();
            this.label_from_date = new System.Windows.Forms.Label();
            this.dateTimePicker_from_date_reserv = new System.Windows.Forms.DateTimePicker();
            this.button_reserv = new System.Windows.Forms.Button();
            this.label_model = new System.Windows.Forms.Label();
            this.label_brand = new System.Windows.Forms.Label();
            this.label_desc_model = new System.Windows.Forms.Label();
            this.label_desc_brand = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Company_name = new System.Windows.Forms.ComboBox();
            this.comboBox_service = new System.Windows.Forms.ComboBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_care_car_DB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_care_car_DB
            // 
            this.dataGridView_care_car_DB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_care_car_DB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_care_car_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_care_car_DB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_care_car_DB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_care_car_DB.Location = new System.Drawing.Point(33, 93);
            this.dataGridView_care_car_DB.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_care_car_DB.Name = "dataGridView_care_car_DB";
            this.dataGridView_care_car_DB.RowTemplate.Height = 24;
            this.dataGridView_care_car_DB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_care_car_DB.Size = new System.Drawing.Size(506, 230);
            this.dataGridView_care_car_DB.TabIndex = 21;
            this.dataGridView_care_car_DB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_care_car_DB_CellClick);
            // 
            // label_your_cars_care
            // 
            this.label_your_cars_care.AutoSize = true;
            this.label_your_cars_care.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_your_cars_care.ForeColor = System.Drawing.Color.Yellow;
            this.label_your_cars_care.Location = new System.Drawing.Point(28, 30);
            this.label_your_cars_care.Margin = new System.Windows.Forms.Padding(0);
            this.label_your_cars_care.Name = "label_your_cars_care";
            this.label_your_cars_care.Size = new System.Drawing.Size(271, 29);
            this.label_your_cars_care.TabIndex = 22;
            this.label_your_cars_care.Text = "Twoje auta pod opieką";
            // 
            // button_blocked
            // 
            this.button_blocked.BackColor = System.Drawing.Color.Yellow;
            this.button_blocked.FlatAppearance.BorderSize = 0;
            this.button_blocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_blocked.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_blocked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_blocked.Location = new System.Drawing.Point(660, 93);
            this.button_blocked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_blocked.Name = "button_blocked";
            this.button_blocked.Size = new System.Drawing.Size(187, 42);
            this.button_blocked.TabIndex = 33;
            this.button_blocked.Text = "Zablokuj";
            this.button_blocked.UseVisualStyleBackColor = false;
            this.button_blocked.Click += new System.EventHandler(this.button_blocked_Click);
            // 
            // button_unblocking
            // 
            this.button_unblocking.BackColor = System.Drawing.Color.Yellow;
            this.button_unblocking.FlatAppearance.BorderSize = 0;
            this.button_unblocking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_unblocking.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_unblocking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_unblocking.Location = new System.Drawing.Point(660, 201);
            this.button_unblocking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_unblocking.Name = "button_unblocking";
            this.button_unblocking.Size = new System.Drawing.Size(187, 42);
            this.button_unblocking.TabIndex = 34;
            this.button_unblocking.Text = "Odblokuj";
            this.button_unblocking.UseVisualStyleBackColor = false;
            this.button_unblocking.Click += new System.EventHandler(this.button_unblocking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(28, 395);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Rezerwacja pojazdu na serwis";
            // 
            // label_to_date_reserv
            // 
            this.label_to_date_reserv.AutoSize = true;
            this.label_to_date_reserv.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label_to_date_reserv.ForeColor = System.Drawing.Color.Yellow;
            this.label_to_date_reserv.Location = new System.Drawing.Point(326, 564);
            this.label_to_date_reserv.Margin = new System.Windows.Forms.Padding(0);
            this.label_to_date_reserv.Name = "label_to_date_reserv";
            this.label_to_date_reserv.Size = new System.Drawing.Size(74, 19);
            this.label_to_date_reserv.TabIndex = 39;
            this.label_to_date_reserv.Text = "Do kiedy";
            // 
            // dateTimePicker_to_date_reserv
            // 
            this.dateTimePicker_to_date_reserv.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_to_date_reserv.CalendarForeColor = System.Drawing.Color.Yellow;
            this.dateTimePicker_to_date_reserv.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_to_date_reserv.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_to_date_reserv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_to_date_reserv.Location = new System.Drawing.Point(436, 564);
            this.dateTimePicker_to_date_reserv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_to_date_reserv.MinDate = new System.DateTime(2019, 12, 9, 0, 0, 0, 0);
            this.dateTimePicker_to_date_reserv.Name = "dateTimePicker_to_date_reserv";
            this.dateTimePicker_to_date_reserv.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_to_date_reserv.TabIndex = 38;
            // 
            // label_from_date
            // 
            this.label_from_date.AutoSize = true;
            this.label_from_date.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label_from_date.ForeColor = System.Drawing.Color.Yellow;
            this.label_from_date.Location = new System.Drawing.Point(326, 501);
            this.label_from_date.Margin = new System.Windows.Forms.Padding(0);
            this.label_from_date.Name = "label_from_date";
            this.label_from_date.Size = new System.Drawing.Size(74, 19);
            this.label_from_date.TabIndex = 37;
            this.label_from_date.Text = "Od kiedy";
            // 
            // dateTimePicker_from_date_reserv
            // 
            this.dateTimePicker_from_date_reserv.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_from_date_reserv.CalendarForeColor = System.Drawing.Color.Yellow;
            this.dateTimePicker_from_date_reserv.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_from_date_reserv.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_from_date_reserv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_from_date_reserv.Location = new System.Drawing.Point(436, 501);
            this.dateTimePicker_from_date_reserv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_from_date_reserv.MinDate = new System.DateTime(2019, 12, 9, 0, 0, 0, 0);
            this.dateTimePicker_from_date_reserv.Name = "dateTimePicker_from_date_reserv";
            this.dateTimePicker_from_date_reserv.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_from_date_reserv.TabIndex = 36;
            // 
            // button_reserv
            // 
            this.button_reserv.BackColor = System.Drawing.Color.Yellow;
            this.button_reserv.FlatAppearance.BorderSize = 0;
            this.button_reserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reserv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_reserv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_reserv.Location = new System.Drawing.Point(660, 550);
            this.button_reserv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_reserv.Name = "button_reserv";
            this.button_reserv.Size = new System.Drawing.Size(187, 42);
            this.button_reserv.TabIndex = 40;
            this.button_reserv.Text = "Rezerwuj";
            this.button_reserv.UseVisualStyleBackColor = false;
            this.button_reserv.Click += new System.EventHandler(this.button_reserv_Click);
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_model.Location = new System.Drawing.Point(101, 563);
            this.label_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(0, 24);
            this.label_model.TabIndex = 98;
            // 
            // label_brand
            // 
            this.label_brand.AutoSize = true;
            this.label_brand.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_brand.Location = new System.Drawing.Point(101, 501);
            this.label_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(0, 24);
            this.label_brand.TabIndex = 97;
            // 
            // label_desc_model
            // 
            this.label_desc_model.AutoSize = true;
            this.label_desc_model.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_model.Location = new System.Drawing.Point(29, 560);
            this.label_desc_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_model.Name = "label_desc_model";
            this.label_desc_model.Size = new System.Drawing.Size(70, 23);
            this.label_desc_model.TabIndex = 96;
            this.label_desc_model.Text = "Model:";
            // 
            // label_desc_brand
            // 
            this.label_desc_brand.AutoSize = true;
            this.label_desc_brand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_brand.Location = new System.Drawing.Point(29, 501);
            this.label_desc_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_brand.Name = "label_desc_brand";
            this.label_desc_brand.Size = new System.Drawing.Size(72, 23);
            this.label_desc_brand.TabIndex = 95;
            this.label_desc_brand.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(804, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 105;
            this.label4.Text = "Firma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(456, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 104;
            this.label3.Text = "Opisz problem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(426, 401);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 103;
            this.label2.Text = "Rodzaj serwisu:";
            // 
            // comboBox_Company_name
            // 
            this.comboBox_Company_name.FormattingEnabled = true;
            this.comboBox_Company_name.Location = new System.Drawing.Point(787, 435);
            this.comboBox_Company_name.Name = "comboBox_Company_name";
            this.comboBox_Company_name.Size = new System.Drawing.Size(103, 24);
            this.comboBox_Company_name.TabIndex = 106;
            // 
            // comboBox_service
            // 
            this.comboBox_service.FormattingEnabled = true;
            this.comboBox_service.Items.AddRange(new object[] {
            "Wymiana oleju",
            "Wymiana oleju + filtry",
            "Przegląd",
            "Wymiana żarówek",
            "Wymiana rozrzadu ",
            "Naprawa",
            "INNA"});
            this.comboBox_service.Location = new System.Drawing.Point(592, 398);
            this.comboBox_service.Name = "comboBox_service";
            this.comboBox_service.Size = new System.Drawing.Size(121, 24);
            this.comboBox_service.TabIndex = 107;
            this.comboBox_service.Text = "Rodzaj serwiu";
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(600, 454);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(100, 22);
            this.textBox_description.TabIndex = 108;
            // 
            // UserControl_menage_care_cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.comboBox_service);
            this.Controls.Add(this.comboBox_Company_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_model);
            this.Controls.Add(this.label_brand);
            this.Controls.Add(this.label_desc_model);
            this.Controls.Add(this.label_desc_brand);
            this.Controls.Add(this.button_reserv);
            this.Controls.Add(this.label_to_date_reserv);
            this.Controls.Add(this.dateTimePicker_to_date_reserv);
            this.Controls.Add(this.label_from_date);
            this.Controls.Add(this.dateTimePicker_from_date_reserv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_unblocking);
            this.Controls.Add(this.button_blocked);
            this.Controls.Add(this.label_your_cars_care);
            this.Controls.Add(this.dataGridView_care_car_DB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_menage_care_cars";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_care_car_DB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_care_car_DB;
        private System.Windows.Forms.Label label_your_cars_care;
        private System.Windows.Forms.Button button_blocked;
        private System.Windows.Forms.Button button_unblocking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_to_date_reserv;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to_date_reserv;
        private System.Windows.Forms.Label label_from_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from_date_reserv;
        private System.Windows.Forms.Button button_reserv;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_brand;
        private System.Windows.Forms.Label label_desc_model;
        private System.Windows.Forms.Label label_desc_brand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Company_name;
        private System.Windows.Forms.ComboBox comboBox_service;
        private System.Windows.Forms.TextBox textBox_description;
    }
}
