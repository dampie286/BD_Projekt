namespace VMA
{
    partial class UserControl_send_to_service
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
            this.label_information_about_car = new System.Windows.Forms.Label();
            this.dataGridView_care_car_DB = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.label_brand = new System.Windows.Forms.Label();
            this.label_desc_model = new System.Windows.Forms.Label();
            this.label_desc_brand = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.Combobox_service = new System.Windows.Forms.ComboBox();
            this.button_send_to_service = new System.Windows.Forms.Button();
            this.dataGridView_cars_on_service = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_repaired = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.comboBox_Company_name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_care_car_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cars_on_service)).BeginInit();
            this.SuspendLayout();
            // 
            // label_information_about_car
            // 
            this.label_information_about_car.AutoSize = true;
            this.label_information_about_car.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_information_about_car.ForeColor = System.Drawing.Color.Yellow;
            this.label_information_about_car.Location = new System.Drawing.Point(33, 25);
            this.label_information_about_car.Margin = new System.Windows.Forms.Padding(0);
            this.label_information_about_car.Name = "label_information_about_car";
            this.label_information_about_car.Size = new System.Drawing.Size(216, 29);
            this.label_information_about_car.TabIndex = 85;
            this.label_information_about_car.Text = "Wyślij do serwisu";
            // 
            // dataGridView_care_car_DB
            // 
            this.dataGridView_care_car_DB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_care_car_DB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_care_car_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_care_car_DB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_care_car_DB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_care_car_DB.Location = new System.Drawing.Point(38, 85);
            this.dataGridView_care_car_DB.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_care_car_DB.Name = "dataGridView_care_car_DB";
            this.dataGridView_care_car_DB.RowTemplate.Height = 24;
            this.dataGridView_care_car_DB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_care_car_DB.Size = new System.Drawing.Size(435, 175);
            this.dataGridView_care_car_DB.TabIndex = 86;
            this.dataGridView_care_car_DB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_care_car_DB_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(268, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 96;
            this.label3.Text = "Opisz problem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(238, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 95;
            this.label2.Text = "Rodzaj serwisu:";
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_model.Location = new System.Drawing.Point(106, 323);
            this.label_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(0, 25);
            this.label_model.TabIndex = 94;
            // 
            // label_brand
            // 
            this.label_brand.AutoSize = true;
            this.label_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_brand.Location = new System.Drawing.Point(106, 273);
            this.label_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(0, 25);
            this.label_brand.TabIndex = 93;
            // 
            // label_desc_model
            // 
            this.label_desc_model.AutoSize = true;
            this.label_desc_model.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_model.Location = new System.Drawing.Point(34, 323);
            this.label_desc_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_model.Name = "label_desc_model";
            this.label_desc_model.Size = new System.Drawing.Size(70, 23);
            this.label_desc_model.TabIndex = 92;
            this.label_desc_model.Text = "Model:";
            // 
            // label_desc_brand
            // 
            this.label_desc_brand.AutoSize = true;
            this.label_desc_brand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_brand.Location = new System.Drawing.Point(34, 273);
            this.label_desc_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_brand.Name = "label_desc_brand";
            this.label_desc_brand.Size = new System.Drawing.Size(72, 23);
            this.label_desc_brand.TabIndex = 91;
            this.label_desc_brand.Text = "Marka:";
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(412, 326);
            this.textBox_description.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(132, 22);
            this.textBox_description.TabIndex = 90;
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
            this.Combobox_service.Location = new System.Drawing.Point(412, 276);
            this.Combobox_service.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_service.Name = "Combobox_service";
            this.Combobox_service.Size = new System.Drawing.Size(160, 24);
            this.Combobox_service.TabIndex = 88;
            this.Combobox_service.Text = "Rodzaj serwisu";
            // 
            // button_send_to_service
            // 
            this.button_send_to_service.BackColor = System.Drawing.Color.Yellow;
            this.button_send_to_service.FlatAppearance.BorderSize = 0;
            this.button_send_to_service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_send_to_service.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_send_to_service.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_send_to_service.Location = new System.Drawing.Point(740, 316);
            this.button_send_to_service.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_send_to_service.Name = "button_send_to_service";
            this.button_send_to_service.Size = new System.Drawing.Size(187, 42);
            this.button_send_to_service.TabIndex = 87;
            this.button_send_to_service.Text = "Wyślij do serwisu";
            this.button_send_to_service.UseVisualStyleBackColor = false;
            this.button_send_to_service.Click += new System.EventHandler(this.button_send_to_service_Click);
            // 
            // dataGridView_cars_on_service
            // 
            this.dataGridView_cars_on_service.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_cars_on_service.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_cars_on_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cars_on_service.Location = new System.Drawing.Point(38, 454);
            this.dataGridView_cars_on_service.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_cars_on_service.Name = "dataGridView_cars_on_service";
            this.dataGridView_cars_on_service.Size = new System.Drawing.Size(588, 146);
            this.dataGridView_cars_on_service.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(33, 394);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 98;
            this.label1.Text = "Odbierz z serwisu";
            // 
            // button_repaired
            // 
            this.button_repaired.BackColor = System.Drawing.Color.Yellow;
            this.button_repaired.FlatAppearance.BorderSize = 0;
            this.button_repaired.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_repaired.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_repaired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_repaired.Location = new System.Drawing.Point(740, 519);
            this.button_repaired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_repaired.Name = "button_repaired";
            this.button_repaired.Size = new System.Drawing.Size(187, 42);
            this.button_repaired.TabIndex = 99;
            this.button_repaired.Text = "Naprawiony";
            this.button_repaired.UseVisualStyleBackColor = false;
            this.button_repaired.Click += new System.EventHandler(this.button_repaired_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(740, 480);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 22);
            this.textBox_price.TabIndex = 100;
            this.textBox_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_price_KeyPress);
            // 
            // comboBox_Company_name
            // 
            this.comboBox_Company_name.FormattingEnabled = true;
            this.comboBox_Company_name.Location = new System.Drawing.Point(740, 273);
            this.comboBox_Company_name.Name = "comboBox_Company_name";
            this.comboBox_Company_name.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Company_name.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(655, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 102;
            this.label4.Text = "Firma:";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Arial", 12F);
            this.label_price.ForeColor = System.Drawing.Color.Yellow;
            this.label_price.Location = new System.Drawing.Point(736, 442);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(146, 23);
            this.label_price.TabIndex = 103;
            this.label_price.Text = "Koszt naprawy:";
            // 
            // UserControl_send_to_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Company_name);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.button_repaired);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_cars_on_service);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_model);
            this.Controls.Add(this.label_brand);
            this.Controls.Add(this.label_desc_model);
            this.Controls.Add(this.label_desc_brand);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.Combobox_service);
            this.Controls.Add(this.button_send_to_service);
            this.Controls.Add(this.dataGridView_care_car_DB);
            this.Controls.Add(this.label_information_about_car);
            this.Name = "UserControl_send_to_service";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_care_car_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cars_on_service)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_information_about_car;
        private System.Windows.Forms.DataGridView dataGridView_care_car_DB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_brand;
        private System.Windows.Forms.Label label_desc_model;
        private System.Windows.Forms.Label label_desc_brand;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.ComboBox Combobox_service;
        private System.Windows.Forms.Button button_send_to_service;
        private System.Windows.Forms.DataGridView dataGridView_cars_on_service;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_repaired;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.ComboBox comboBox_Company_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_price;
    }
}
