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
            this.button_send_to_service = new System.Windows.Forms.Button();
            this.button_blocked = new System.Windows.Forms.Button();
            this.button_unblocking = new System.Windows.Forms.Button();
            this.Combobox_service = new System.Windows.Forms.ComboBox();
            this.textBox_other_service = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.dataGridView_cars_on_service = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_repaired = new System.Windows.Forms.Button();
            this.label_model = new System.Windows.Forms.Label();
            this.label_brand = new System.Windows.Forms.Label();
            this.label_desc_model = new System.Windows.Forms.Label();
            this.label_desc_brand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_care_car_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cars_on_service)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_care_car_DB
            // 
            this.dataGridView_care_car_DB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_care_car_DB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_care_car_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_care_car_DB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_care_car_DB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_care_car_DB.Location = new System.Drawing.Point(17, 127);
            this.dataGridView_care_car_DB.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_care_car_DB.Name = "dataGridView_care_car_DB";
            this.dataGridView_care_car_DB.RowTemplate.Height = 24;
            this.dataGridView_care_car_DB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_care_car_DB.Size = new System.Drawing.Size(429, 146);
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
            // button_send_to_service
            // 
            this.button_send_to_service.BackColor = System.Drawing.Color.Yellow;
            this.button_send_to_service.FlatAppearance.BorderSize = 0;
            this.button_send_to_service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_send_to_service.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_send_to_service.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_send_to_service.Location = new System.Drawing.Point(659, 549);
            this.button_send_to_service.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_send_to_service.Name = "button_send_to_service";
            this.button_send_to_service.Size = new System.Drawing.Size(237, 42);
            this.button_send_to_service.TabIndex = 32;
            this.button_send_to_service.Text = "Wyślij do serwisu";
            this.button_send_to_service.UseVisualStyleBackColor = false;
            this.button_send_to_service.Click += new System.EventHandler(this.button_send_to_service_Click);
            // 
            // button_blocked
            // 
            this.button_blocked.BackColor = System.Drawing.Color.Yellow;
            this.button_blocked.FlatAppearance.BorderSize = 0;
            this.button_blocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_blocked.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_blocked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_blocked.Location = new System.Drawing.Point(33, 335);
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
            this.button_unblocking.Location = new System.Drawing.Point(273, 335);
            this.button_unblocking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_unblocking.Name = "button_unblocking";
            this.button_unblocking.Size = new System.Drawing.Size(187, 42);
            this.button_unblocking.TabIndex = 34;
            this.button_unblocking.Text = "Odblokuj";
            this.button_unblocking.UseVisualStyleBackColor = false;
            // 
            // Combobox_service
            // 
            this.Combobox_service.Items.AddRange(new object[] {
            "Wymiana oleju",
            "Wymiana oleju + filtry",
            "Przegląd",
            "Wymiana żarówek",
            "Wymiana rozrzadu ",
            "Naprawa",
            "INNA"});
            this.Combobox_service.Location = new System.Drawing.Point(407, 463);
            this.Combobox_service.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_service.Name = "Combobox_service";
            this.Combobox_service.Size = new System.Drawing.Size(160, 24);
            this.Combobox_service.TabIndex = 35;
            this.Combobox_service.Text = "Rodzaj serwisu";
            this.Combobox_service.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_other_service
            // 
            this.textBox_other_service.Location = new System.Drawing.Point(614, 463);
            this.textBox_other_service.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_other_service.Name = "textBox_other_service";
            this.textBox_other_service.Size = new System.Drawing.Size(132, 22);
            this.textBox_other_service.TabIndex = 36;
            this.textBox_other_service.Text = "Przyczyna serwisu";
            this.textBox_other_service.Visible = false;
            this.textBox_other_service.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox_other_service.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(407, 513);
            this.textBox_description.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(132, 22);
            this.textBox_description.TabIndex = 37;
            this.textBox_description.Text = "Opis problemu";
            // 
            // dataGridView_cars_on_service
            // 
            this.dataGridView_cars_on_service.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_cars_on_service.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_cars_on_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cars_on_service.Location = new System.Drawing.Point(451, 127);
            this.dataGridView_cars_on_service.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_cars_on_service.Name = "dataGridView_cars_on_service";
            this.dataGridView_cars_on_service.Size = new System.Drawing.Size(445, 146);
            this.dataGridView_cars_on_service.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(507, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Twoje auta w serwisie";
            // 
            // button_repaired
            // 
            this.button_repaired.BackColor = System.Drawing.Color.Yellow;
            this.button_repaired.FlatAppearance.BorderSize = 0;
            this.button_repaired.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_repaired.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_repaired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_repaired.Location = new System.Drawing.Point(583, 335);
            this.button_repaired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_repaired.Name = "button_repaired";
            this.button_repaired.Size = new System.Drawing.Size(187, 42);
            this.button_repaired.TabIndex = 41;
            this.button_repaired.Text = "Naprawiony";
            this.button_repaired.UseVisualStyleBackColor = false;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_model.Location = new System.Drawing.Point(101, 510);
            this.label_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(0, 24);
            this.label_model.TabIndex = 78;
            // 
            // label_brand
            // 
            this.label_brand.AutoSize = true;
            this.label_brand.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_brand.Location = new System.Drawing.Point(101, 460);
            this.label_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(0, 24);
            this.label_brand.TabIndex = 77;
            // 
            // label_desc_model
            // 
            this.label_desc_model.AutoSize = true;
            this.label_desc_model.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_model.Location = new System.Drawing.Point(29, 510);
            this.label_desc_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_model.Name = "label_desc_model";
            this.label_desc_model.Size = new System.Drawing.Size(70, 23);
            this.label_desc_model.TabIndex = 76;
            this.label_desc_model.Text = "Model:";
            // 
            // label_desc_brand
            // 
            this.label_desc_brand.AutoSize = true;
            this.label_desc_brand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_brand.Location = new System.Drawing.Point(29, 460);
            this.label_desc_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_brand.Name = "label_desc_brand";
            this.label_desc_brand.Size = new System.Drawing.Size(72, 23);
            this.label_desc_brand.TabIndex = 75;
            this.label_desc_brand.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(233, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 79;
            this.label2.Text = "Rodzaj serwisu:";
            // 
            // UserControl_menage_care_cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_model);
            this.Controls.Add(this.label_brand);
            this.Controls.Add(this.label_desc_model);
            this.Controls.Add(this.label_desc_brand);
            this.Controls.Add(this.button_repaired);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_cars_on_service);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_other_service);
            this.Controls.Add(this.Combobox_service);
            this.Controls.Add(this.button_unblocking);
            this.Controls.Add(this.button_blocked);
            this.Controls.Add(this.button_send_to_service);
            this.Controls.Add(this.label_your_cars_care);
            this.Controls.Add(this.dataGridView_care_car_DB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_menage_care_cars";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_care_car_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cars_on_service)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_care_car_DB;
        private System.Windows.Forms.Label label_your_cars_care;
        private System.Windows.Forms.Button button_send_to_service;
        private System.Windows.Forms.Button button_blocked;
        private System.Windows.Forms.Button button_unblocking;
        private System.Windows.Forms.ComboBox Combobox_service;
        private System.Windows.Forms.TextBox textBox_other_service;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.DataGridView dataGridView_cars_on_service;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_repaired;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_brand;
        private System.Windows.Forms.Label label_desc_model;
        private System.Windows.Forms.Label label_desc_brand;
        private System.Windows.Forms.Label label2;
    }
}
