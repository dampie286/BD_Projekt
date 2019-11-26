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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_my_reservation)).BeginInit();
            this.SuspendLayout();
            // 
            // label_my_reservation
            // 
            this.label_my_reservation.AutoSize = true;
            this.label_my_reservation.Font = new System.Drawing.Font("Arial Narrow", 14.2F, System.Drawing.FontStyle.Bold);
            this.label_my_reservation.ForeColor = System.Drawing.Color.Yellow;
            this.label_my_reservation.Location = new System.Drawing.Point(20, 16);
            this.label_my_reservation.Margin = new System.Windows.Forms.Padding(0);
            this.label_my_reservation.Name = "label_my_reservation";
            this.label_my_reservation.Size = new System.Drawing.Size(225, 29);
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
            this.dataGridView_my_reservation.RowTemplate.Height = 24;
            this.dataGridView_my_reservation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_my_reservation.Size = new System.Drawing.Size(889, 295);
            this.dataGridView_my_reservation.TabIndex = 48;
            // 
            // UserControl_my_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.dataGridView_my_reservation);
            this.Controls.Add(this.label_my_reservation);
            this.Name = "UserControl_my_reservation";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_my_reservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_my_reservation;
        private System.Windows.Forms.DataGridView dataGridView_my_reservation;
    }
}
