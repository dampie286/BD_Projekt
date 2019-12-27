namespace VMA
{
    partial class UserControl_rent_with_DB
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
            this.button_rent = new System.Windows.Forms.Button();
            this.label_to_date_reserv = new System.Windows.Forms.Label();
            this.dateTimePicker_to_date_rent = new System.Windows.Forms.DateTimePicker();
            this.label_from_date = new System.Windows.Forms.Label();
            this.dateTimePicker_from_date_rent = new System.Windows.Forms.DateTimePicker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_rent = new System.Windows.Forms.Label();
            this.dataGridView_veh_DB = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_mileage = new System.Windows.Forms.TextBox();
            this.textBox_version = new System.Windows.Forms.TextBox();
            this.textBox_equipment = new System.Windows.Forms.TextBox();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.textBox_brand = new System.Windows.Forms.TextBox();
            this.button_show_available_cars = new System.Windows.Forms.Button();
            this.comboBox_purpose_of_rent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_veh_DB)).BeginInit();
            this.SuspendLayout();
            // 
            // button_rent
            // 
            this.button_rent.BackColor = System.Drawing.Color.Yellow;
            this.button_rent.FlatAppearance.BorderSize = 0;
            this.button_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rent.Font = new System.Drawing.Font("Arial", 9.75F);
            this.button_rent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_rent.Location = new System.Drawing.Point(612, 468);
            this.button_rent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_rent.Name = "button_rent";
            this.button_rent.Size = new System.Drawing.Size(237, 42);
            this.button_rent.TabIndex = 55;
            this.button_rent.Text = "Wypożycz";
            this.button_rent.UseVisualStyleBackColor = false;
            this.button_rent.Visible = false;
            this.button_rent.Click += new System.EventHandler(this.button_rent_Click);
            // 
            // label_to_date_reserv
            // 
            this.label_to_date_reserv.AutoSize = true;
            this.label_to_date_reserv.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label_to_date_reserv.ForeColor = System.Drawing.Color.Yellow;
            this.label_to_date_reserv.Location = new System.Drawing.Point(343, 105);
            this.label_to_date_reserv.Margin = new System.Windows.Forms.Padding(0);
            this.label_to_date_reserv.Name = "label_to_date_reserv";
            this.label_to_date_reserv.Size = new System.Drawing.Size(74, 19);
            this.label_to_date_reserv.TabIndex = 54;
            this.label_to_date_reserv.Text = "Do kiedy";
            // 
            // dateTimePicker_to_date_rent
            // 
            this.dateTimePicker_to_date_rent.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_to_date_rent.CalendarForeColor = System.Drawing.Color.Yellow;
            this.dateTimePicker_to_date_rent.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_to_date_rent.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_to_date_rent.Location = new System.Drawing.Point(451, 106);
            this.dateTimePicker_to_date_rent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_to_date_rent.Name = "dateTimePicker_to_date_rent";
            this.dateTimePicker_to_date_rent.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_to_date_rent.TabIndex = 53;
            this.dateTimePicker_to_date_rent.Leave += new System.EventHandler(this.dateTimePicker_to_date_rent_Leave);
            // 
            // label_from_date
            // 
            this.label_from_date.AutoSize = true;
            this.label_from_date.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label_from_date.ForeColor = System.Drawing.Color.Yellow;
            this.label_from_date.Location = new System.Drawing.Point(20, 105);
            this.label_from_date.Margin = new System.Windows.Forms.Padding(0);
            this.label_from_date.Name = "label_from_date";
            this.label_from_date.Size = new System.Drawing.Size(74, 19);
            this.label_from_date.TabIndex = 52;
            this.label_from_date.Text = "Od kiedy";
            // 
            // dateTimePicker_from_date_rent
            // 
            this.dateTimePicker_from_date_rent.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_from_date_rent.CalendarForeColor = System.Drawing.Color.Yellow;
            this.dateTimePicker_from_date_rent.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker_from_date_rent.Enabled = false;
            this.dateTimePicker_from_date_rent.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_from_date_rent.Location = new System.Drawing.Point(128, 106);
            this.dateTimePicker_from_date_rent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_from_date_rent.Name = "dateTimePicker_from_date_rent";
            this.dateTimePicker_from_date_rent.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_from_date_rent.TabIndex = 51;
            this.dateTimePicker_from_date_rent.ValueChanged += new System.EventHandler(this.dateTimePicker_from_date_rent_ValueChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Yellow;
            this.panel7.Location = new System.Drawing.Point(305, 498);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(173, 1);
            this.panel7.TabIndex = 48;
            // 
            // label_rent
            // 
            this.label_rent.AutoSize = true;
            this.label_rent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_rent.ForeColor = System.Drawing.Color.Yellow;
            this.label_rent.Location = new System.Drawing.Point(19, 397);
            this.label_rent.Margin = new System.Windows.Forms.Padding(0);
            this.label_rent.Name = "label_rent";
            this.label_rent.Size = new System.Drawing.Size(321, 29);
            this.label_rent.TabIndex = 46;
            this.label_rent.Text = "WYPOŻYCZANIE POJAZDU";
            // 
            // dataGridView_veh_DB
            // 
            this.dataGridView_veh_DB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_veh_DB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_veh_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_veh_DB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_veh_DB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_veh_DB.Location = new System.Drawing.Point(59, 200);
            this.dataGridView_veh_DB.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_veh_DB.Name = "dataGridView_veh_DB";
            this.dataGridView_veh_DB.RowTemplate.Height = 24;
            this.dataGridView_veh_DB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_veh_DB.Size = new System.Drawing.Size(799, 167);
            this.dataGridView_veh_DB.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Yellow;
            this.panel5.Location = new System.Drawing.Point(531, 47);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 1);
            this.panel5.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Location = new System.Drawing.Point(404, 47);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 1);
            this.panel4.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(277, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 1);
            this.panel3.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(151, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 1);
            this.panel2.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(24, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 1);
            this.panel1.TabIndex = 39;
            // 
            // textBox_mileage
            // 
            this.textBox_mileage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox_mileage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_mileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_mileage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_mileage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_mileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.textBox_mileage.Location = new System.Drawing.Point(531, 23);
            this.textBox_mileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_mileage.MaximumSize = new System.Drawing.Size(120, 25);
            this.textBox_mileage.MinimumSize = new System.Drawing.Size(5, 15);
            this.textBox_mileage.Name = "textBox_mileage";
            this.textBox_mileage.Size = new System.Drawing.Size(120, 19);
            this.textBox_mileage.TabIndex = 36;
            this.textBox_mileage.Text = "Typ paliwa";
            this.textBox_mileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_mileage.Enter += new System.EventHandler(this.textBox_mileage_Enter);
            this.textBox_mileage.Leave += new System.EventHandler(this.textBox_mileage_Leave);
            // 
            // textBox_version
            // 
            this.textBox_version.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox_version.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_version.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_version.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.textBox_version.Location = new System.Drawing.Point(404, 23);
            this.textBox_version.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_version.MaximumSize = new System.Drawing.Size(120, 25);
            this.textBox_version.MinimumSize = new System.Drawing.Size(5, 15);
            this.textBox_version.Name = "textBox_version";
            this.textBox_version.Size = new System.Drawing.Size(120, 19);
            this.textBox_version.TabIndex = 35;
            this.textBox_version.Text = "Wersja";
            this.textBox_version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_version.Enter += new System.EventHandler(this.textBox_version_Enter);
            this.textBox_version.Leave += new System.EventHandler(this.textBox_version_Leave);
            // 
            // textBox_equipment
            // 
            this.textBox_equipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_equipment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_equipment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_equipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.textBox_equipment.Location = new System.Drawing.Point(277, 23);
            this.textBox_equipment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_equipment.MaximumSize = new System.Drawing.Size(120, 25);
            this.textBox_equipment.MinimumSize = new System.Drawing.Size(5, 15);
            this.textBox_equipment.Name = "textBox_equipment";
            this.textBox_equipment.Size = new System.Drawing.Size(120, 19);
            this.textBox_equipment.TabIndex = 34;
            this.textBox_equipment.Text = "Spalanie";
            this.textBox_equipment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_equipment.Enter += new System.EventHandler(this.textBox_equipment_Enter);
            this.textBox_equipment.Leave += new System.EventHandler(this.textBox_equipment_Leave);
            // 
            // textBox_model
            // 
            this.textBox_model.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox_model.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_model.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.textBox_model.Location = new System.Drawing.Point(151, 23);
            this.textBox_model.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_model.MaximumSize = new System.Drawing.Size(120, 25);
            this.textBox_model.MinimumSize = new System.Drawing.Size(5, 15);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(120, 19);
            this.textBox_model.TabIndex = 33;
            this.textBox_model.Text = "Model";
            this.textBox_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_model.Enter += new System.EventHandler(this.textBox_model_Enter);
            this.textBox_model.Leave += new System.EventHandler(this.textBox_model_Leave);
            // 
            // textBox_brand
            // 
            this.textBox_brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox_brand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_brand.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.textBox_brand.Location = new System.Drawing.Point(24, 23);
            this.textBox_brand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_brand.MaximumSize = new System.Drawing.Size(120, 25);
            this.textBox_brand.MinimumSize = new System.Drawing.Size(5, 15);
            this.textBox_brand.Name = "textBox_brand";
            this.textBox_brand.Size = new System.Drawing.Size(120, 19);
            this.textBox_brand.TabIndex = 32;
            this.textBox_brand.Text = "Marka";
            this.textBox_brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_brand.Enter += new System.EventHandler(this.textBox_brand_Enter);
            this.textBox_brand.Leave += new System.EventHandler(this.textBox_brand_Leave);
            // 
            // button_show_available_cars
            // 
            this.button_show_available_cars.BackColor = System.Drawing.Color.Yellow;
            this.button_show_available_cars.FlatAppearance.BorderSize = 0;
            this.button_show_available_cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show_available_cars.Font = new System.Drawing.Font("Arial", 9.75F);
            this.button_show_available_cars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_show_available_cars.Location = new System.Drawing.Point(706, 86);
            this.button_show_available_cars.Name = "button_show_available_cars";
            this.button_show_available_cars.Size = new System.Drawing.Size(207, 57);
            this.button_show_available_cars.TabIndex = 56;
            this.button_show_available_cars.Text = "Wyświetl dostępne pojazdy";
            this.button_show_available_cars.UseVisualStyleBackColor = false;
            this.button_show_available_cars.Click += new System.EventHandler(this.button_show_available_cars_Click);
            // 
            // comboBox_purpose_of_rent
            // 
            this.comboBox_purpose_of_rent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_purpose_of_rent.FormattingEnabled = true;
            this.comboBox_purpose_of_rent.Items.AddRange(new object[] {
            "Prywatny",
            "Służbowy ",
            "Delegacja"});
            this.comboBox_purpose_of_rent.Location = new System.Drawing.Point(305, 479);
            this.comboBox_purpose_of_rent.Name = "comboBox_purpose_of_rent";
            this.comboBox_purpose_of_rent.Size = new System.Drawing.Size(173, 24);
            this.comboBox_purpose_of_rent.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(124, 480);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "Cel wypożyczenia";
            // 
            // UserControl_rent_with_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_purpose_of_rent);
            this.Controls.Add(this.button_show_available_cars);
            this.Controls.Add(this.button_rent);
            this.Controls.Add(this.label_to_date_reserv);
            this.Controls.Add(this.dateTimePicker_to_date_rent);
            this.Controls.Add(this.label_from_date);
            this.Controls.Add(this.dateTimePicker_from_date_rent);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label_rent);
            this.Controls.Add(this.dataGridView_veh_DB);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_mileage);
            this.Controls.Add(this.textBox_version);
            this.Controls.Add(this.textBox_equipment);
            this.Controls.Add(this.textBox_model);
            this.Controls.Add(this.textBox_brand);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_rent_with_DB";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_veh_DB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_rent;
        private System.Windows.Forms.Label label_to_date_reserv;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to_date_rent;
        private System.Windows.Forms.Label label_from_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from_date_rent;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label_rent;
        private System.Windows.Forms.DataGridView dataGridView_veh_DB;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_mileage;
        private System.Windows.Forms.TextBox textBox_version;
        private System.Windows.Forms.TextBox textBox_equipment;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.TextBox textBox_brand;
        private System.Windows.Forms.Button button_show_available_cars;
        private System.Windows.Forms.ComboBox comboBox_purpose_of_rent;
        private System.Windows.Forms.Label label2;
    }
}
