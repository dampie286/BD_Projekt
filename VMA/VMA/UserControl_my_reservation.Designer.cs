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
            this.label_my_reservation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_my_reservation.ForeColor = System.Drawing.Color.Yellow;
            this.label_my_reservation.Location = new System.Drawing.Point(15, 13);
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
            this.dataGridView_my_reservation.Size = new System.Drawing.Size(667, 429);
            this.dataGridView_my_reservation.TabIndex = 48;
            // 
            // UserControl_my_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.dataGridView_my_reservation);
            this.Controls.Add(this.label_my_reservation);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl_my_reservation";
            this.Size = new System.Drawing.Size(706, 533);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_my_reservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_my_reservation;
        private System.Windows.Forms.DataGridView dataGridView_my_reservation;
    }
}
