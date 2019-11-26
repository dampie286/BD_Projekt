namespace VMA
{
    partial class UserControl_rent
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
            this.label_choice_rent = new System.Windows.Forms.Label();
            this.button_rent_with_DB = new System.Windows.Forms.Button();
            this.button1_rent_with_reservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_choice_rent
            // 
            this.label_choice_rent.AutoSize = true;
            this.label_choice_rent.Font = new System.Drawing.Font("Arial Narrow", 14.2F, System.Drawing.FontStyle.Bold);
            this.label_choice_rent.ForeColor = System.Drawing.Color.Yellow;
            this.label_choice_rent.Location = new System.Drawing.Point(221, 118);
            this.label_choice_rent.Margin = new System.Windows.Forms.Padding(0);
            this.label_choice_rent.Name = "label_choice_rent";
            this.label_choice_rent.Size = new System.Drawing.Size(379, 29);
            this.label_choice_rent.TabIndex = 22;
            this.label_choice_rent.Text = "Wybierz sposób wypożyczenia pojazdu";
            // 
            // button_rent_with_DB
            // 
            this.button_rent_with_DB.BackColor = System.Drawing.Color.Yellow;
            this.button_rent_with_DB.FlatAppearance.BorderSize = 0;
            this.button_rent_with_DB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rent_with_DB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_rent_with_DB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_rent_with_DB.Location = new System.Drawing.Point(290, 235);
            this.button_rent_with_DB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_rent_with_DB.Name = "button_rent_with_DB";
            this.button_rent_with_DB.Size = new System.Drawing.Size(276, 64);
            this.button_rent_with_DB.TabIndex = 32;
            this.button_rent_with_DB.Text = "Wypożyczenie z bazy";
            this.button_rent_with_DB.UseVisualStyleBackColor = false;
            this.button_rent_with_DB.Click += new System.EventHandler(this.button_rent_with_DB_Click);
            // 
            // button1_rent_with_reservation
            // 
            this.button1_rent_with_reservation.BackColor = System.Drawing.Color.Yellow;
            this.button1_rent_with_reservation.FlatAppearance.BorderSize = 0;
            this.button1_rent_with_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_rent_with_reservation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_rent_with_reservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button1_rent_with_reservation.Location = new System.Drawing.Point(290, 374);
            this.button1_rent_with_reservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1_rent_with_reservation.Name = "button1_rent_with_reservation";
            this.button1_rent_with_reservation.Size = new System.Drawing.Size(276, 64);
            this.button1_rent_with_reservation.TabIndex = 33;
            this.button1_rent_with_reservation.Text = "Wypożyczenie z rezerwacji";
            this.button1_rent_with_reservation.UseVisualStyleBackColor = false;
            this.button1_rent_with_reservation.Click += new System.EventHandler(this.button1_rent_with_reservation_Click);
            // 
            // UserControl_rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.button1_rent_with_reservation);
            this.Controls.Add(this.button_rent_with_DB);
            this.Controls.Add(this.label_choice_rent);
            this.Name = "UserControl_rent";
            this.Size = new System.Drawing.Size(941, 656);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_choice_rent;
        private System.Windows.Forms.Button button_rent_with_DB;
        private System.Windows.Forms.Button button1_rent_with_reservation;
    }
}
