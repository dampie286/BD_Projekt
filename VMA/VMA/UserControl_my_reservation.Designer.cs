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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_my_reservation)).BeginInit();
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
            // 
            // button_rent
            // 
            this.button_rent.BackColor = System.Drawing.Color.Yellow;
            this.button_rent.FlatAppearance.BorderSize = 0;
            this.button_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_rent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_rent.Location = new System.Drawing.Point(653, 533);
            this.button_rent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_rent.Name = "button_rent";
            this.button_rent.Size = new System.Drawing.Size(237, 42);
            this.button_rent.TabIndex = 56;
            this.button_rent.Text = "Wypożycz";
            this.button_rent.UseVisualStyleBackColor = false;
            // 
            // UserControl_my_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.button_rent);
            this.Controls.Add(this.dataGridView_my_reservation);
            this.Controls.Add(this.label_my_reservation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_my_reservation";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_my_reservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_my_reservation;
        private System.Windows.Forms.DataGridView dataGridView_my_reservation;
        private System.Windows.Forms.Button button_rent;
    }
}
