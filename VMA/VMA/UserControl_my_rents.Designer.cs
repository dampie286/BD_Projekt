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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label_rent.Location = new System.Drawing.Point(25, 20);
            this.label_rent.Margin = new System.Windows.Forms.Padding(0);
            this.label_rent.Name = "label_rent";
            this.label_rent.Size = new System.Drawing.Size(222, 22);
            this.label_rent.TabIndex = 47;
            this.label_rent.Text = "MOJE WYPOŻYCZENIA";
            // 
            // dataGridView_my_rents
            // 
            this.dataGridView_my_rents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_my_rents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_my_rents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_my_rents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_my_rents.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_my_rents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_my_rents.EnableHeadersVisualStyles = false;
            this.dataGridView_my_rents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_my_rents.Location = new System.Drawing.Point(25, 60);
            this.dataGridView_my_rents.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_my_rents.MultiSelect = false;
            this.dataGridView_my_rents.Name = "dataGridView_my_rents";
            this.dataGridView_my_rents.ReadOnly = true;
            this.dataGridView_my_rents.RowTemplate.Height = 24;
            this.dataGridView_my_rents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_my_rents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_my_rents.Size = new System.Drawing.Size(649, 215);
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
            this.panel_end_rent.Location = new System.Drawing.Point(29, 295);
            this.panel_end_rent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_end_rent.Name = "panel_end_rent";
            this.panel_end_rent.Size = new System.Drawing.Size(645, 210);
            this.panel_end_rent.TabIndex = 58;
            // 
            // button_confirm_end_rent
            // 
            this.button_confirm_end_rent.BackColor = System.Drawing.Color.Yellow;
            this.button_confirm_end_rent.FlatAppearance.BorderSize = 0;
            this.button_confirm_end_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirm_end_rent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_confirm_end_rent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_confirm_end_rent.Location = new System.Drawing.Point(456, 150);
            this.button_confirm_end_rent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_confirm_end_rent.Name = "button_confirm_end_rent";
            this.button_confirm_end_rent.Size = new System.Drawing.Size(187, 58);
            this.button_confirm_end_rent.TabIndex = 81;
            this.button_confirm_end_rent.Text = "Potwierdź zakończenie wypożyczenia";
            this.button_confirm_end_rent.UseVisualStyleBackColor = false;
            this.button_confirm_end_rent.Click += new System.EventHandler(this.button_confirm_end_rent_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Yellow;
            this.panel10.Location = new System.Drawing.Point(275, 171);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(130, 1);
            this.panel10.TabIndex = 80;
            // 
            // textBox_mileage
            // 
            this.textBox_mileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_mileage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_mileage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_mileage.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_mileage.Location = new System.Drawing.Point(275, 150);
            this.textBox_mileage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_mileage.MaximumSize = new System.Drawing.Size(150, 25);
            this.textBox_mileage.MinimumSize = new System.Drawing.Size(4, 18);
            this.textBox_mileage.Name = "textBox_mileage";
            this.textBox_mileage.Size = new System.Drawing.Size(130, 19);
            this.textBox_mileage.TabIndex = 79;
            this.textBox_mileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(58, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 78;
            this.label1.Text = "Przebieg po wypożyczeniu";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_to.ForeColor = System.Drawing.Color.Yellow;
            this.label_to.Location = new System.Drawing.Point(303, 65);
            this.label_to.Margin = new System.Windows.Forms.Padding(0);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(0, 20);
            this.label_to.TabIndex = 77;
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_from.ForeColor = System.Drawing.Color.Yellow;
            this.label_from.Location = new System.Drawing.Point(303, 24);
            this.label_from.Margin = new System.Windows.Forms.Padding(0);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(0, 20);
            this.label_from.TabIndex = 76;
            // 
            // label_purpose
            // 
            this.label_purpose.AutoSize = true;
            this.label_purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_purpose.ForeColor = System.Drawing.Color.Yellow;
            this.label_purpose.Location = new System.Drawing.Point(281, 110);
            this.label_purpose.Margin = new System.Windows.Forms.Padding(0);
            this.label_purpose.Name = "label_purpose";
            this.label_purpose.Size = new System.Drawing.Size(0, 20);
            this.label_purpose.TabIndex = 75;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_model.Location = new System.Drawing.Point(89, 66);
            this.label_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(0, 20);
            this.label_model.TabIndex = 74;
            // 
            // label_brand
            // 
            this.label_brand.AutoSize = true;
            this.label_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_brand.Location = new System.Drawing.Point(89, 25);
            this.label_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(0, 20);
            this.label_brand.TabIndex = 73;
            // 
            // label_desc_to
            // 
            this.label_desc_to.AutoSize = true;
            this.label_desc_to.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_to.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_desc_to.Location = new System.Drawing.Point(410, 70);
            this.label_desc_to.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_to.Name = "label_desc_to";
            this.label_desc_to.Size = new System.Drawing.Size(70, 18);
            this.label_desc_to.TabIndex = 72;
            this.label_desc_to.Text = "Do kiedy";
            // 
            // label_desc_mileage
            // 
            this.label_desc_mileage.AutoSize = true;
            this.label_desc_mileage.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_mileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_desc_mileage.Location = new System.Drawing.Point(23, 110);
            this.label_desc_mileage.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_mileage.Name = "label_desc_mileage";
            this.label_desc_mileage.Size = new System.Drawing.Size(226, 18);
            this.label_desc_mileage.TabIndex = 71;
            this.label_desc_mileage.Text = "Przebieg przed wypożyczeniem";
            // 
            // label_desc_from
            // 
            this.label_desc_from.AutoSize = true;
            this.label_desc_from.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_from.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_desc_from.Location = new System.Drawing.Point(410, 30);
            this.label_desc_from.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_from.Name = "label_desc_from";
            this.label_desc_from.Size = new System.Drawing.Size(70, 18);
            this.label_desc_from.TabIndex = 70;
            this.label_desc_from.Text = "Od kiedy";
            // 
            // label_desc_model
            // 
            this.label_desc_model.AutoSize = true;
            this.label_desc_model.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_desc_model.Location = new System.Drawing.Point(198, 70);
            this.label_desc_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_model.Name = "label_desc_model";
            this.label_desc_model.Size = new System.Drawing.Size(51, 18);
            this.label_desc_model.TabIndex = 69;
            this.label_desc_model.Text = "Model";
            // 
            // label_desc_brand
            // 
            this.label_desc_brand.AutoSize = true;
            this.label_desc_brand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc_brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_desc_brand.Location = new System.Drawing.Point(197, 30);
            this.label_desc_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_brand.Name = "label_desc_brand";
            this.label_desc_brand.Size = new System.Drawing.Size(52, 18);
            this.label_desc_brand.TabIndex = 68;
            this.label_desc_brand.Text = "Marka";
            // 
            // UserControl_my_rents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.panel_end_rent);
            this.Controls.Add(this.dataGridView_my_rents);
            this.Controls.Add(this.label_rent);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl_my_rents";
            this.Size = new System.Drawing.Size(706, 533);
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
