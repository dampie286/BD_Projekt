namespace VMA
{
    partial class UserControl_my_reservation
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
            this.label_my_reservation = new System.Windows.Forms.Label();
            this.dataGridView_my_reservation = new System.Windows.Forms.DataGridView();
            this.button_rent = new System.Windows.Forms.Button();
            this.panel_with_myreservation = new System.Windows.Forms.Panel();
            this.button_delete_res = new System.Windows.Forms.Button();
            this.label_to = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_purpose = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.label_brand = new System.Windows.Forms.Label();
            this.label_desc_my_choice = new System.Windows.Forms.Label();
            this.label_desc_to = new System.Windows.Forms.Label();
            this.label_desc_purpose = new System.Windows.Forms.Label();
            this.label_desc_from = new System.Windows.Forms.Label();
            this.label_desc_model = new System.Windows.Forms.Label();
            this.label_desc_brand = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_my_reservation)).BeginInit();
            this.panel_with_myreservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_my_reservation
            // 
            this.label_my_reservation.AutoSize = true;
            this.label_my_reservation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_my_reservation.ForeColor = System.Drawing.Color.Yellow;
            this.label_my_reservation.Location = new System.Drawing.Point(25, 20);
            this.label_my_reservation.Margin = new System.Windows.Forms.Padding(0);
            this.label_my_reservation.Name = "label_my_reservation";
            this.label_my_reservation.Size = new System.Drawing.Size(214, 22);
            this.label_my_reservation.TabIndex = 47;
            this.label_my_reservation.Text = "TWOJE REZERWACJE";
            // 
            // dataGridView_my_reservation
            // 
            this.dataGridView_my_reservation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_my_reservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_my_reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_my_reservation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_my_reservation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_my_reservation.Location = new System.Drawing.Point(19, 73);
            this.dataGridView_my_reservation.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_my_reservation.Name = "dataGridView_my_reservation";
            this.dataGridView_my_reservation.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_my_reservation.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_my_reservation.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Yellow;
            this.dataGridView_my_reservation.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dataGridView_my_reservation.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_my_reservation.RowTemplate.Height = 24;
            this.dataGridView_my_reservation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_my_reservation.Size = new System.Drawing.Size(667, 188);
            this.dataGridView_my_reservation.TabIndex = 48;
            this.dataGridView_my_reservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_my_reservation_CellClick);
            // 
            // button_rent
            // 
            this.button_rent.BackColor = System.Drawing.Color.Yellow;
            this.button_rent.FlatAppearance.BorderSize = 0;
            this.button_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_rent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_rent.Location = new System.Drawing.Point(305, 181);
            this.button_rent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_rent.Name = "button_rent";
            this.button_rent.Size = new System.Drawing.Size(178, 34);
            this.button_rent.TabIndex = 56;
            this.button_rent.Text = "Wypożycz";
            this.button_rent.UseVisualStyleBackColor = false;
            this.button_rent.Click += new System.EventHandler(this.button_rent_Click);
            // 
            // panel_with_myreservation
            // 
            this.panel_with_myreservation.Controls.Add(this.comboBox1);
            this.panel_with_myreservation.Controls.Add(this.button_delete_res);
            this.panel_with_myreservation.Controls.Add(this.label_to);
            this.panel_with_myreservation.Controls.Add(this.label_from);
            this.panel_with_myreservation.Controls.Add(this.label_purpose);
            this.panel_with_myreservation.Controls.Add(this.label_model);
            this.panel_with_myreservation.Controls.Add(this.label_brand);
            this.panel_with_myreservation.Controls.Add(this.label_desc_my_choice);
            this.panel_with_myreservation.Controls.Add(this.label_desc_to);
            this.panel_with_myreservation.Controls.Add(this.label_desc_purpose);
            this.panel_with_myreservation.Controls.Add(this.label_desc_from);
            this.panel_with_myreservation.Controls.Add(this.label_desc_model);
            this.panel_with_myreservation.Controls.Add(this.label_desc_brand);
            this.panel_with_myreservation.Controls.Add(this.button_rent);
            this.panel_with_myreservation.Location = new System.Drawing.Point(19, 299);
            this.panel_with_myreservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_with_myreservation.Name = "panel_with_myreservation";
            this.panel_with_myreservation.Size = new System.Drawing.Size(667, 217);
            this.panel_with_myreservation.TabIndex = 57;
            // 
            // button_delete_res
            // 
            this.button_delete_res.BackColor = System.Drawing.Color.Yellow;
            this.button_delete_res.FlatAppearance.BorderSize = 0;
            this.button_delete_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_res.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delete_res.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_delete_res.Location = new System.Drawing.Point(487, 181);
            this.button_delete_res.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_delete_res.Name = "button_delete_res";
            this.button_delete_res.Size = new System.Drawing.Size(178, 34);
            this.button_delete_res.TabIndex = 68;
            this.button_delete_res.Text = "Usuń rezerwację";
            this.button_delete_res.UseVisualStyleBackColor = false;
            this.button_delete_res.Click += new System.EventHandler(this.button_delete_res_Click);
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_to.ForeColor = System.Drawing.Color.Yellow;
            this.label_to.Location = new System.Drawing.Point(293, 93);
            this.label_to.Margin = new System.Windows.Forms.Padding(0);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(0, 20);
            this.label_to.TabIndex = 67;
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_from.ForeColor = System.Drawing.Color.Yellow;
            this.label_from.Location = new System.Drawing.Point(293, 53);
            this.label_from.Margin = new System.Windows.Forms.Padding(0);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(0, 20);
            this.label_from.TabIndex = 66;
            // 
            // label_purpose
            // 
            this.label_purpose.AutoSize = true;
            this.label_purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_purpose.ForeColor = System.Drawing.Color.Yellow;
            this.label_purpose.Location = new System.Drawing.Point(80, 134);
            this.label_purpose.Margin = new System.Windows.Forms.Padding(0);
            this.label_purpose.Name = "label_purpose";
            this.label_purpose.Size = new System.Drawing.Size(0, 20);
            this.label_purpose.TabIndex = 65;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_model.Location = new System.Drawing.Point(80, 93);
            this.label_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(0, 20);
            this.label_model.TabIndex = 64;
            // 
            // label_brand
            // 
            this.label_brand.AutoSize = true;
            this.label_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_brand.Location = new System.Drawing.Point(80, 53);
            this.label_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(0, 20);
            this.label_brand.TabIndex = 63;
            // 
            // label_desc_my_choice
            // 
            this.label_desc_my_choice.AutoSize = true;
            this.label_desc_my_choice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc_my_choice.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_my_choice.Location = new System.Drawing.Point(6, 11);
            this.label_desc_my_choice.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_my_choice.Name = "label_desc_my_choice";
            this.label_desc_my_choice.Size = new System.Drawing.Size(130, 22);
            this.label_desc_my_choice.TabIndex = 62;
            this.label_desc_my_choice.Text = "MÓJ WYBÓR";
            // 
            // label_desc_to
            // 
            this.label_desc_to.AutoSize = true;
            this.label_desc_to.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_to.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_desc_to.Location = new System.Drawing.Point(280, 100);
            this.label_desc_to.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_to.Name = "label_desc_to";
            this.label_desc_to.Size = new System.Drawing.Size(70, 18);
            this.label_desc_to.TabIndex = 61;
            this.label_desc_to.Text = "Do kiedy";
            // 
            // label_desc_purpose
            // 
            this.label_desc_purpose.AutoSize = true;
            this.label_desc_purpose.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_purpose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_desc_purpose.Location = new System.Drawing.Point(78, 140);
            this.label_desc_purpose.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_purpose.Name = "label_desc_purpose";
            this.label_desc_purpose.Size = new System.Drawing.Size(32, 18);
            this.label_desc_purpose.TabIndex = 60;
            this.label_desc_purpose.Text = "Cel";
            // 
            // label_desc_from
            // 
            this.label_desc_from.AutoSize = true;
            this.label_desc_from.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_from.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_desc_from.Location = new System.Drawing.Point(280, 60);
            this.label_desc_from.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_from.Name = "label_desc_from";
            this.label_desc_from.Size = new System.Drawing.Size(70, 18);
            this.label_desc_from.TabIndex = 59;
            this.label_desc_from.Text = "Od kiedy";
            // 
            // label_desc_model
            // 
            this.label_desc_model.AutoSize = true;
            this.label_desc_model.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_desc_model.Location = new System.Drawing.Point(59, 100);
            this.label_desc_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_model.Name = "label_desc_model";
            this.label_desc_model.Size = new System.Drawing.Size(51, 18);
            this.label_desc_model.TabIndex = 58;
            this.label_desc_model.Text = "Model";
            // 
            // label_desc_brand
            // 
            this.label_desc_brand.AutoSize = true;
            this.label_desc_brand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc_brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_desc_brand.Location = new System.Drawing.Point(58, 60);
            this.label_desc_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_brand.Name = "label_desc_brand";
            this.label_desc_brand.Size = new System.Drawing.Size(52, 18);
            this.label_desc_brand.TabIndex = 57;
            this.label_desc_brand.Text = "Marka";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.Yellow;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Służbowo",
            "Prywatnie",
            "Naprawa"});
            this.comboBox1.Location = new System.Drawing.Point(120, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 69;
            // 
            // UserControl_my_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.panel_with_myreservation);
            this.Controls.Add(this.dataGridView_my_reservation);
            this.Controls.Add(this.label_my_reservation);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl_my_reservation";
            this.Size = new System.Drawing.Size(706, 533);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_my_reservation)).EndInit();
            this.panel_with_myreservation.ResumeLayout(false);
            this.panel_with_myreservation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_my_reservation;
        private System.Windows.Forms.DataGridView dataGridView_my_reservation;
        private System.Windows.Forms.Button button_rent;
        private System.Windows.Forms.Panel panel_with_myreservation;
        private System.Windows.Forms.Label label_desc_my_choice;
        private System.Windows.Forms.Label label_desc_to;
        private System.Windows.Forms.Label label_desc_purpose;
        private System.Windows.Forms.Label label_desc_from;
        private System.Windows.Forms.Label label_desc_model;
        private System.Windows.Forms.Label label_desc_brand;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_purpose;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_brand;
        private System.Windows.Forms.Button button_delete_res;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
