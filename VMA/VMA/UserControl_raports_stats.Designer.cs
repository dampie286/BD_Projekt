namespace VMA
{
    partial class UserControl_raports_stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_raports_stats));
            this.button_workers = new System.Windows.Forms.Button();
            this.button_cars = new System.Windows.Forms.Button();
            this.label_menage_keepers = new System.Windows.Forms.Label();
            this.button_all = new System.Windows.Forms.Button();
            this.pictureBox_help = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).BeginInit();
            this.SuspendLayout();
            // 
            // button_workers
            // 
            this.button_workers.BackColor = System.Drawing.Color.Yellow;
            this.button_workers.FlatAppearance.BorderSize = 0;
            this.button_workers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_workers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_workers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_workers.Location = new System.Drawing.Point(317, 320);
            this.button_workers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_workers.Name = "button_workers";
            this.button_workers.Size = new System.Drawing.Size(307, 62);
            this.button_workers.TabIndex = 45;
            this.button_workers.Text = "Pracowników";
            this.button_workers.UseVisualStyleBackColor = false;
            this.button_workers.Click += new System.EventHandler(this.button_workers_Click);
            // 
            // button_cars
            // 
            this.button_cars.BackColor = System.Drawing.Color.Yellow;
            this.button_cars.FlatAppearance.BorderSize = 0;
            this.button_cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cars.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_cars.Location = new System.Drawing.Point(317, 222);
            this.button_cars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cars.Name = "button_cars";
            this.button_cars.Size = new System.Drawing.Size(307, 62);
            this.button_cars.TabIndex = 44;
            this.button_cars.Text = "Pojazdy";
            this.button_cars.UseVisualStyleBackColor = false;
            this.button_cars.Click += new System.EventHandler(this.button_cars_Click);
            // 
            // label_menage_keepers
            // 
            this.label_menage_keepers.AutoSize = true;
            this.label_menage_keepers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_menage_keepers.ForeColor = System.Drawing.Color.Yellow;
            this.label_menage_keepers.Location = new System.Drawing.Point(347, 172);
            this.label_menage_keepers.Margin = new System.Windows.Forms.Padding(0);
            this.label_menage_keepers.Name = "label_menage_keepers";
            this.label_menage_keepers.Size = new System.Drawing.Size(233, 29);
            this.label_menage_keepers.TabIndex = 43;
            this.label_menage_keepers.Text = "Raporty i statystyki";
            // 
            // button_all
            // 
            this.button_all.BackColor = System.Drawing.Color.Yellow;
            this.button_all.FlatAppearance.BorderSize = 0;
            this.button_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_all.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_all.Location = new System.Drawing.Point(317, 418);
            this.button_all.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(307, 62);
            this.button_all.TabIndex = 46;
            this.button_all.Text = "Ogólne";
            this.button_all.UseVisualStyleBackColor = false;
            this.button_all.Click += new System.EventHandler(this.button_all_Click);
            // 
            // pictureBox_help
            // 
            this.pictureBox_help.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_help.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_help.Image")));
            this.pictureBox_help.Location = new System.Drawing.Point(890, 18);
            this.pictureBox_help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_help.Name = "pictureBox_help";
            this.pictureBox_help.Size = new System.Drawing.Size(25, 23);
            this.pictureBox_help.TabIndex = 47;
            this.pictureBox_help.TabStop = false;
            this.pictureBox_help.Click += new System.EventHandler(this.pictureBox_help_Click);
            // 
            // UserControl_raports_stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.pictureBox_help);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.button_workers);
            this.Controls.Add(this.button_cars);
            this.Controls.Add(this.label_menage_keepers);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_raports_stats";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_workers;
        private System.Windows.Forms.Button button_cars;
        private System.Windows.Forms.Label label_menage_keepers;
        private System.Windows.Forms.Button button_all;
        private System.Windows.Forms.PictureBox pictureBox_help;
    }
}
