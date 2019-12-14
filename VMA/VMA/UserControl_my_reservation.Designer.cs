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
<<<<<<< HEAD
            this.button_delete_res = new System.Windows.Forms.Button();
=======
>>>>>>> parent of 6149cb7... 14.12
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_my_reservation)).BeginInit();
            this.panel_with_myreservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_my_reservation
            // 
            this.label_my_reservation.AutoSize = true;
            this.label_my_reservation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_my_reservation.ForeColor = System.Drawing.Color.Yellow;
            this.label_my_reservation.Location = new System.Drawing.Point(20, 16);
            this.label_my_reservation.Margin = new System.Windows.Forms.Padding(0);
            this.label_my_reservation.Name = "label_my_reservation";
            this.label_my_reservation.Size = new System.Drawing.Size(270, 29);
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
            this.dataGridView_my_reservation.Location = new System.Drawing.Point(25, 90);
            this.dataGridView_my_reservation.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_my_reservation.Name = "dataGridView_my_reservation";
            this.dataGridView_my_reservation.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_my_reservation.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_my_reservation.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Yellow;
            this.dataGridView_my_reservation.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dataGridView_my_reservation.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_my_reservation.RowTemplate.Height = 24;
            this.dataGridView_my_reservation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_my_reservation.Size = new System.Drawing.Size(889, 231);
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
            this.button_rent.Location = new System.Drawing.Point(406, 213);
            this.button_rent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_rent.Name = "button_rent";
            this.button_rent.Size = new System.Drawing.Size(237, 42);
            this.button_rent.TabIndex = 56;
            this.button_rent.Text = "Wypożycz";
            this.button_rent.UseVisualStyleBackColor = false;
            // 
            // panel_with_myreservation
            // 
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
            this.panel_with_myreservation.Location = new System.Drawing.Point(25, 368);
            this.panel_with_myreservation.Name = "panel_with_myreservation";
            this.panel_with_myreservation.Size = new System.Drawing.Size(889, 267);
            this.panel_with_myreservation.TabIndex = 57;
            // 
<<<<<<< HEAD
=======
            // button_delete_res
            // 
            this.button_delete_res.BackColor = System.Drawing.Color.Yellow;
            this.button_delete_res.FlatAppearance.BorderSize = 0;
            this.button_delete_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_res.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delete_res.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_delete_res.Location = new System.Drawing.Point(649, 213);
            this.button_delete_res.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete_res.Name = "button_delete_res";
            this.button_delete_res.Size = new System.Drawing.Size(237, 42);
            this.button_delete_res.TabIndex = 68;
            this.button_delete_res.Text = "Usuń rezerwacje";
            this.button_delete_res.UseVisualStyleBackColor = false;
            this.button_delete_res.Click += new System.EventHandler(this.button_delete_res_Click);
            // 
>>>>>>> parent of 6149cb7... 14.12
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_to.ForeColor = System.Drawing.Color.Yellow;
            this.label_to.Location = new System.Drawing.Point(391, 115);
            this.label_to.Margin = new System.Windows.Forms.Padding(0);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(0, 24);
            this.label_to.TabIndex = 67;
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_from.ForeColor = System.Drawing.Color.Yellow;
            this.label_from.Location = new System.Drawing.Point(391, 65);
            this.label_from.Margin = new System.Windows.Forms.Padding(0);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(0, 24);
            this.label_from.TabIndex = 66;
            // 
            // label_purpose
            // 
            this.label_purpose.AutoSize = true;
            this.label_purpose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_purpose.ForeColor = System.Drawing.Color.Yellow;
            this.label_purpose.Location = new System.Drawing.Point(106, 165);
            this.label_purpose.Margin = new System.Windows.Forms.Padding(0);
            this.label_purpose.Name = "label_purpose";
            this.label_purpose.Size = new System.Drawing.Size(0, 24);
            this.label_purpose.TabIndex = 65;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_model.Location = new System.Drawing.Point(106, 115);
            this.label_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(0, 24);
            this.label_model.TabIndex = 64;
            // 
            // label_brand
            // 
            this.label_brand.AutoSize = true;
            this.label_brand.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_brand.Location = new System.Drawing.Point(106, 65);
            this.label_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(0, 24);
            this.label_brand.TabIndex = 63;
            // 
            // label_desc_my_choice
            // 
            this.label_desc_my_choice.AutoSize = true;
            this.label_desc_my_choice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc_my_choice.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_my_choice.Location = new System.Drawing.Point(32, 0);
            this.label_desc_my_choice.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_my_choice.Name = "label_desc_my_choice";
            this.label_desc_my_choice.Size = new System.Drawing.Size(162, 29);
            this.label_desc_my_choice.TabIndex = 62;
            this.label_desc_my_choice.Text = "MÓJ WYBÓR";
            // 
            // label_desc_to
            // 
            this.label_desc_to.AutoSize = true;
            this.label_desc_to.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_to.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_to.Location = new System.Drawing.Point(296, 115);
            this.label_desc_to.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_to.Name = "label_desc_to";
            this.label_desc_to.Size = new System.Drawing.Size(93, 23);
            this.label_desc_to.TabIndex = 61;
            this.label_desc_to.Text = "Do kiedy:";
            // 
            // label_desc_purpose
            // 
            this.label_desc_purpose.AutoSize = true;
            this.label_desc_purpose.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_purpose.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_purpose.Location = new System.Drawing.Point(59, 165);
            this.label_desc_purpose.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_purpose.Name = "label_desc_purpose";
            this.label_desc_purpose.Size = new System.Drawing.Size(45, 23);
            this.label_desc_purpose.TabIndex = 60;
            this.label_desc_purpose.Text = "Cel:";
            // 
            // label_desc_from
            // 
            this.label_desc_from.AutoSize = true;
            this.label_desc_from.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_from.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_from.Location = new System.Drawing.Point(296, 65);
            this.label_desc_from.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_from.Name = "label_desc_from";
            this.label_desc_from.Size = new System.Drawing.Size(95, 23);
            this.label_desc_from.TabIndex = 59;
            this.label_desc_from.Text = "Od kiedy:";
            // 
            // label_desc_model
            // 
            this.label_desc_model.AutoSize = true;
            this.label_desc_model.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_model.Location = new System.Drawing.Point(34, 115);
            this.label_desc_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_model.Name = "label_desc_model";
            this.label_desc_model.Size = new System.Drawing.Size(70, 23);
            this.label_desc_model.TabIndex = 58;
            this.label_desc_model.Text = "Model:";
            // 
            // label_desc_brand
            // 
            this.label_desc_brand.AutoSize = true;
            this.label_desc_brand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_brand.Location = new System.Drawing.Point(34, 65);
            this.label_desc_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_brand.Name = "label_desc_brand";
            this.label_desc_brand.Size = new System.Drawing.Size(72, 23);
            this.label_desc_brand.TabIndex = 57;
            this.label_desc_brand.Text = "Marka:";
<<<<<<< HEAD
            // 
            // button_delete_res
            // 
            this.button_delete_res.BackColor = System.Drawing.Color.Yellow;
            this.button_delete_res.FlatAppearance.BorderSize = 0;
            this.button_delete_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_res.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delete_res.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_delete_res.Location = new System.Drawing.Point(649, 213);
            this.button_delete_res.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete_res.Name = "button_delete_res";
            this.button_delete_res.Size = new System.Drawing.Size(237, 42);
            this.button_delete_res.TabIndex = 68;
            this.button_delete_res.Text = "Usuń rezerwacje";
            this.button_delete_res.UseVisualStyleBackColor = false;
=======
>>>>>>> parent of 6149cb7... 14.12
            // 
            // UserControl_my_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.panel_with_myreservation);
            this.Controls.Add(this.dataGridView_my_reservation);
            this.Controls.Add(this.label_my_reservation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_my_reservation";
            this.Size = new System.Drawing.Size(941, 656);
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
    }
}
