namespace VMA
{
    partial class UserControl_addKeeper
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
            this.dataGridView_work_DB = new System.Windows.Forms.DataGridView();
            this.dataGridView_veh_DB = new System.Windows.Forms.DataGridView();
            this.button_add_keeper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_work_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_veh_DB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_work_DB
            // 
            this.dataGridView_work_DB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_work_DB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_work_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_work_DB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_work_DB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_work_DB.Location = new System.Drawing.Point(22, 28);
            this.dataGridView_work_DB.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_work_DB.Name = "dataGridView_work_DB";
            this.dataGridView_work_DB.RowTemplate.Height = 24;
            this.dataGridView_work_DB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_work_DB.Size = new System.Drawing.Size(889, 167);
            this.dataGridView_work_DB.TabIndex = 46;
            // 
            // dataGridView_veh_DB
            // 
            this.dataGridView_veh_DB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_veh_DB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_veh_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_veh_DB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_veh_DB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_veh_DB.Location = new System.Drawing.Point(22, 260);
            this.dataGridView_veh_DB.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_veh_DB.Name = "dataGridView_veh_DB";
            this.dataGridView_veh_DB.RowTemplate.Height = 24;
            this.dataGridView_veh_DB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_veh_DB.Size = new System.Drawing.Size(889, 167);
            this.dataGridView_veh_DB.TabIndex = 47;
            // 
            // button_add_keeper
            // 
            this.button_add_keeper.BackColor = System.Drawing.Color.Yellow;
            this.button_add_keeper.FlatAppearance.BorderSize = 0;
            this.button_add_keeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_keeper.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add_keeper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_add_keeper.Location = new System.Drawing.Point(365, 507);
            this.button_add_keeper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add_keeper.Name = "button_add_keeper";
            this.button_add_keeper.Size = new System.Drawing.Size(173, 31);
            this.button_add_keeper.TabIndex = 81;
            this.button_add_keeper.Text = "Dodaj opiekuna";
            this.button_add_keeper.UseVisualStyleBackColor = false;
            // 
            // UserControl_addKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.button_add_keeper);
            this.Controls.Add(this.dataGridView_veh_DB);
            this.Controls.Add(this.dataGridView_work_DB);
            this.Name = "UserControl_addKeeper";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_work_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_veh_DB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_work_DB;
        private System.Windows.Forms.DataGridView dataGridView_veh_DB;
        private System.Windows.Forms.Button button_add_keeper;
    }
}
