namespace VMA
{
    partial class UserControl_my_rents
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
            this.label_rent = new System.Windows.Forms.Label();
            this.dataGridView_my_rents = new System.Windows.Forms.DataGridView();
            this.panel_end_rent = new System.Windows.Forms.Panel();
            this.button_confirm_end_rent = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox_mileage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_purpose = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.label_brand = new System.Windows.Forms.Label();
            this.label_desc_to = new System.Windows.Forms.Label();
            this.label_desc_mileage = new System.Windows.Forms.Label();
            this.label_desc_from = new System.Windows.Forms.Label();
            this.label_desc_model = new System.Windows.Forms.Label();
            this.label_desc_brand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_my_rents)).BeginInit();
            this.panel_end_rent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_rent
            // 
            this.label_rent.AutoSize = true;
            this.label_rent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_rent.ForeColor = System.Drawing.Color.Yellow;
            this.label_rent.Location = new System.Drawing.Point(32, 49);
            this.label_rent.Margin = new System.Windows.Forms.Padding(0);
            this.label_rent.Name = "label_rent";
            this.label_rent.Size = new System.Drawing.Size(277, 29);
            this.label_rent.TabIndex = 47;
            this.label_rent.Text = "MOJE WYPOŻYCZENIA";
            // 
            // dataGridView_my_rents
            // 
            this.dataGridView_my_rents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_my_rents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_my_rents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_my_rents.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_my_rents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_my_rents.Location = new System.Drawing.Point(37, 145);
            this.dataGridView_my_rents.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_my_rents.Name = "dataGridView_my_rents";
            this.dataGridView_my_rents.RowTemplate.Height = 24;
            this.dataGridView_my_rents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_my_rents.Size = new System.Drawing.Size(653, 167);
            this.dataGridView_my_rents.TabIndex = 48;
            this.dataGridView_my_rents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_my_rents_CellClick);
            // 
            // panel_end_rent
            // 
            this.panel_end_rent.Controls.Add(this.button_confirm_end_rent);
            this.panel_end_rent.Controls.Add(this.panel10);
            this.panel_end_rent.Controls.Add(this.textBox_mileage);
            this.panel_end_rent.Controls.Add(this.label1);
            this.panel_end_rent.Controls.Add(this.label_to);
            this.panel_end_rent.Controls.Add(this.label_from);
            this.panel_end_rent.Controls.Add(this.label_purpose);
            this.panel_end_rent.Controls.Add(this.label_model);
            this.panel_end_rent.Controls.Add(this.label_brand);
            this.panel_end_rent.Controls.Add(this.label_desc_to);
            this.panel_end_rent.Controls.Add(this.label_desc_mileage);
            this.panel_end_rent.Controls.Add(this.label_desc_from);
            this.panel_end_rent.Controls.Add(this.label_desc_model);
            this.panel_end_rent.Controls.Add(this.label_desc_brand);
            this.panel_end_rent.Location = new System.Drawing.Point(37, 357);
            this.panel_end_rent.Name = "panel_end_rent";
            this.panel_end_rent.Size = new System.Drawing.Size(904, 258);
            this.panel_end_rent.TabIndex = 58;
            // 
            // button_confirm_end_rent
            // 
            this.button_confirm_end_rent.BackColor = System.Drawing.Color.Yellow;
            this.button_confirm_end_rent.FlatAppearance.BorderSize = 0;
            this.button_confirm_end_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirm_end_rent.Font = new System.Drawing.Font("Arial", 9.75F);
            this.button_confirm_end_rent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_confirm_end_rent.Location = new System.Drawing.Point(682, 169);
            this.button_confirm_end_rent.Name = "button_confirm_end_rent";
            this.button_confirm_end_rent.Size = new System.Drawing.Size(207, 57);
            this.button_confirm_end_rent.TabIndex = 81;
            this.button_confirm_end_rent.Text = "Potwierdź zakończenie wypożyczenia";
            this.button_confirm_end_rent.UseVisualStyleBackColor = false;
            this.button_confirm_end_rent.Click += new System.EventHandler(this.button_confirm_end_rent_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Yellow;
            this.panel10.Location = new System.Drawing.Point(315, 206);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(173, 1);
            this.panel10.TabIndex = 80;
            // 
            // textBox_mileage
            // 
            this.textBox_mileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_mileage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_mileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_mileage.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_mileage.Location = new System.Drawing.Point(315, 186);
            this.textBox_mileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_mileage.MaximumSize = new System.Drawing.Size(200, 25);
            this.textBox_mileage.MinimumSize = new System.Drawing.Size(5, 18);
            this.textBox_mileage.Name = "textBox_mileage";
            this.textBox_mileage.Size = new System.Drawing.Size(173, 19);
            this.textBox_mileage.TabIndex = 79;
            this.textBox_mileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(47, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 78;
            this.label1.Text = "Przebieg po wypożyczeniem:";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_to.ForeColor = System.Drawing.Color.Yellow;
            this.label_to.Location = new System.Drawing.Point(404, 80);
            this.label_to.Margin = new System.Windows.Forms.Padding(0);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(0, 24);
            this.label_to.TabIndex = 77;
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_from.ForeColor = System.Drawing.Color.Yellow;
            this.label_from.Location = new System.Drawing.Point(404, 30);
            this.label_from.Margin = new System.Windows.Forms.Padding(0);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(0, 24);
            this.label_from.TabIndex = 76;
            // 
            // label_purpose
            // 
            this.label_purpose.AutoSize = true;
            this.label_purpose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_purpose.ForeColor = System.Drawing.Color.Yellow;
            this.label_purpose.Location = new System.Drawing.Point(375, 136);
            this.label_purpose.Margin = new System.Windows.Forms.Padding(0);
            this.label_purpose.Name = "label_purpose";
            this.label_purpose.Size = new System.Drawing.Size(0, 24);
            this.label_purpose.TabIndex = 75;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_model.Location = new System.Drawing.Point(119, 81);
            this.label_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(0, 24);
            this.label_model.TabIndex = 74;
            // 
            // label_brand
            // 
            this.label_brand.AutoSize = true;
            this.label_brand.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_brand.Location = new System.Drawing.Point(119, 31);
            this.label_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(0, 24);
            this.label_brand.TabIndex = 73;
            // 
            // label_desc_to
            // 
            this.label_desc_to.AutoSize = true;
            this.label_desc_to.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_to.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_to.Location = new System.Drawing.Point(309, 81);
            this.label_desc_to.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_to.Name = "label_desc_to";
            this.label_desc_to.Size = new System.Drawing.Size(93, 23);
            this.label_desc_to.TabIndex = 72;
            this.label_desc_to.Text = "Do kiedy:";
            // 
            // label_desc_mileage
            // 
            this.label_desc_mileage.AutoSize = true;
            this.label_desc_mileage.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_mileage.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_mileage.Location = new System.Drawing.Point(47, 136);
            this.label_desc_mileage.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_mileage.Name = "label_desc_mileage";
            this.label_desc_mileage.Size = new System.Drawing.Size(291, 23);
            this.label_desc_mileage.TabIndex = 71;
            this.label_desc_mileage.Text = "Przebieg przed wypożyczeniem:";
            // 
            // label_desc_from
            // 
            this.label_desc_from.AutoSize = true;
            this.label_desc_from.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_from.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_from.Location = new System.Drawing.Point(309, 31);
            this.label_desc_from.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_from.Name = "label_desc_from";
            this.label_desc_from.Size = new System.Drawing.Size(95, 23);
            this.label_desc_from.TabIndex = 70;
            this.label_desc_from.Text = "Od kiedy:";
            // 
            // label_desc_model
            // 
            this.label_desc_model.AutoSize = true;
            this.label_desc_model.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_model.Location = new System.Drawing.Point(47, 81);
            this.label_desc_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_model.Name = "label_desc_model";
            this.label_desc_model.Size = new System.Drawing.Size(70, 23);
            this.label_desc_model.TabIndex = 69;
            this.label_desc_model.Text = "Model:";
            // 
            // label_desc_brand
            // 
            this.label_desc_brand.AutoSize = true;
            this.label_desc_brand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_brand.Location = new System.Drawing.Point(47, 31);
            this.label_desc_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_brand.Name = "label_desc_brand";
            this.label_desc_brand.Size = new System.Drawing.Size(72, 23);
            this.label_desc_brand.TabIndex = 68;
            this.label_desc_brand.Text = "Marka:";
            // 
            // UserControl_my_rents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.panel_end_rent);
            this.Controls.Add(this.dataGridView_my_rents);
            this.Controls.Add(this.label_rent);
            this.Name = "UserControl_my_rents";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_my_rents)).EndInit();
            this.panel_end_rent.ResumeLayout(false);
            this.panel_end_rent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_rent;
        private System.Windows.Forms.DataGridView dataGridView_my_rents;
        private System.Windows.Forms.Panel panel_end_rent;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_purpose;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_brand;
        private System.Windows.Forms.Label label_desc_to;
        private System.Windows.Forms.Label label_desc_mileage;
        private System.Windows.Forms.Label label_desc_from;
        private System.Windows.Forms.Label label_desc_model;
        private System.Windows.Forms.Label label_desc_brand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_confirm_end_rent;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox_mileage;
    }
}
