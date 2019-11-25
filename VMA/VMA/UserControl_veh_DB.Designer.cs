namespace VMA
{
    partial class UserControl_veh_DB
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
            this.textBox_brand = new System.Windows.Forms.TextBox();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.textBox_equipment = new System.Windows.Forms.TextBox();
            this.textBox_version = new System.Windows.Forms.TextBox();
            this.textBox_mileage = new System.Windows.Forms.TextBox();
            this.textBox_license = new System.Windows.Forms.TextBox();
            this.button_filter = new System.Windows.Forms.Button();
            this.dataGridView_veh_DB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_veh_DB)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_brand
            // 
            this.textBox_brand.Location = new System.Drawing.Point(27, 15);
            this.textBox_brand.Name = "textBox_brand";
            this.textBox_brand.Size = new System.Drawing.Size(80, 22);
            this.textBox_brand.TabIndex = 0;
            // 
            // textBox_model
            // 
            this.textBox_model.Location = new System.Drawing.Point(122, 15);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(80, 22);
            this.textBox_model.TabIndex = 1;
            // 
            // textBox_equipment
            // 
            this.textBox_equipment.Location = new System.Drawing.Point(217, 15);
            this.textBox_equipment.Name = "textBox_equipment";
            this.textBox_equipment.Size = new System.Drawing.Size(80, 22);
            this.textBox_equipment.TabIndex = 2;
            // 
            // textBox_version
            // 
            this.textBox_version.Location = new System.Drawing.Point(312, 15);
            this.textBox_version.Name = "textBox_version";
            this.textBox_version.Size = new System.Drawing.Size(80, 22);
            this.textBox_version.TabIndex = 3;
            // 
            // textBox_mileage
            // 
            this.textBox_mileage.Location = new System.Drawing.Point(407, 15);
            this.textBox_mileage.Name = "textBox_mileage";
            this.textBox_mileage.Size = new System.Drawing.Size(80, 22);
            this.textBox_mileage.TabIndex = 4;
            // 
            // textBox_license
            // 
            this.textBox_license.Location = new System.Drawing.Point(502, 15);
            this.textBox_license.Name = "textBox_license";
            this.textBox_license.Size = new System.Drawing.Size(80, 22);
            this.textBox_license.TabIndex = 5;
            // 
            // button_filter
            // 
            this.button_filter.BackColor = System.Drawing.Color.Yellow;
            this.button_filter.FlatAppearance.BorderSize = 0;
            this.button_filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_filter.Location = new System.Drawing.Point(597, 15);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(100, 28);
            this.button_filter.TabIndex = 6;
            this.button_filter.Text = "Filtruj";
            this.button_filter.UseVisualStyleBackColor = false;
            // 
            // dataGridView_veh_DB
            // 
            this.dataGridView_veh_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_veh_DB.Location = new System.Drawing.Point(27, 70);
            this.dataGridView_veh_DB.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_veh_DB.Name = "dataGridView_veh_DB";
            this.dataGridView_veh_DB.RowTemplate.Height = 24;
            this.dataGridView_veh_DB.Size = new System.Drawing.Size(679, 463);
            this.dataGridView_veh_DB.TabIndex = 7;
            this.dataGridView_veh_DB.UseWaitCursor = true;
            // 
            // UserControl_veh_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.dataGridView_veh_DB);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.textBox_license);
            this.Controls.Add(this.textBox_mileage);
            this.Controls.Add(this.textBox_version);
            this.Controls.Add(this.textBox_equipment);
            this.Controls.Add(this.textBox_model);
            this.Controls.Add(this.textBox_brand);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl_veh_DB";
            this.Size = new System.Drawing.Size(706, 533);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_veh_DB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_brand;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.TextBox textBox_equipment;
        private System.Windows.Forms.TextBox textBox_version;
        private System.Windows.Forms.TextBox textBox_mileage;
        private System.Windows.Forms.TextBox textBox_license;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.DataGridView dataGridView_veh_DB;
    }
}
