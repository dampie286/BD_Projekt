namespace VMA
{
    partial class Form_panel_manager
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_who_online = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_logout = new System.Windows.Forms.Button();
            this.userControl_veh_DB1 = new VMA.UserControl_veh_DB();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_statistic = new System.Windows.Forms.Button();
            this.button_rent = new System.Windows.Forms.Button();
            this.button_reservation = new System.Windows.Forms.Button();
            this.button_veh_DB = new System.Windows.Forms.Button();
            this.button_raports_stats = new System.Windows.Forms.Button();
            this.userControl_Welcome1 = new VMA.UserControl_Welcome();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_who_online
            // 
            this.label_who_online.AutoSize = true;
            this.label_who_online.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_who_online.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_who_online.Location = new System.Drawing.Point(429, 7);
            this.label_who_online.Name = "label_who_online";
            this.label_who_online.Size = new System.Drawing.Size(188, 15);
            this.label_who_online.TabIndex = 1;
            this.label_who_online.Text = "Zalogowany jako Imię i Nazwisko";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::VMA.Properties.Resources.LogoVMA;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(35, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.ForeColor = System.Drawing.Color.Yellow;
            this.button_logout.Location = new System.Drawing.Point(0, 517);
            this.button_logout.Margin = new System.Windows.Forms.Padding(0);
            this.button_logout.MaximumSize = new System.Drawing.Size(177, 35);
            this.button_logout.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(177, 35);
            this.button_logout.TabIndex = 24;
            this.button_logout.Text = "Wyloguj się";
            this.button_logout.UseVisualStyleBackColor = false;
            // 
            // userControl_veh_DB1
            // 
            this.userControl_veh_DB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_veh_DB1.Location = new System.Drawing.Point(177, 27);
            this.userControl_veh_DB1.Margin = new System.Windows.Forms.Padding(0);
            this.userControl_veh_DB1.Name = "userControl_veh_DB1";
            this.userControl_veh_DB1.Size = new System.Drawing.Size(941, 656);
            this.userControl_veh_DB1.TabIndex = 25;
            // 
            // button_settings
            // 
            this.button_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_settings.ForeColor = System.Drawing.Color.Yellow;
            this.button_settings.Location = new System.Drawing.Point(0, 362);
            this.button_settings.Margin = new System.Windows.Forms.Padding(0);
            this.button_settings.MaximumSize = new System.Drawing.Size(177, 35);
            this.button_settings.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(177, 35);
            this.button_settings.TabIndex = 30;
            this.button_settings.Text = "Ustawienia";
            this.button_settings.UseVisualStyleBackColor = false;
            // 
            // button_statistic
            // 
            this.button_statistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_statistic.FlatAppearance.BorderSize = 0;
            this.button_statistic.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_statistic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_statistic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_statistic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_statistic.ForeColor = System.Drawing.Color.Yellow;
            this.button_statistic.Location = new System.Drawing.Point(0, 311);
            this.button_statistic.Margin = new System.Windows.Forms.Padding(0);
            this.button_statistic.MaximumSize = new System.Drawing.Size(177, 35);
            this.button_statistic.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_statistic.Name = "button_statistic";
            this.button_statistic.Size = new System.Drawing.Size(177, 35);
            this.button_statistic.TabIndex = 29;
            this.button_statistic.Text = "Statystyki";
            this.button_statistic.UseVisualStyleBackColor = false;
            // 
            // button_rent
            // 
            this.button_rent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_rent.FlatAppearance.BorderSize = 0;
            this.button_rent.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_rent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_rent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_rent.ForeColor = System.Drawing.Color.Yellow;
            this.button_rent.Location = new System.Drawing.Point(0, 260);
            this.button_rent.Margin = new System.Windows.Forms.Padding(0);
            this.button_rent.MaximumSize = new System.Drawing.Size(177, 35);
            this.button_rent.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_rent.Name = "button_rent";
            this.button_rent.Size = new System.Drawing.Size(177, 35);
            this.button_rent.TabIndex = 27;
            this.button_rent.Text = "Wypożyczenia";
            this.button_rent.UseVisualStyleBackColor = false;
            // 
            // button_reservation
            // 
            this.button_reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_reservation.FlatAppearance.BorderSize = 0;
            this.button_reservation.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_reservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_reservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reservation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_reservation.ForeColor = System.Drawing.Color.Yellow;
            this.button_reservation.Location = new System.Drawing.Point(0, 209);
            this.button_reservation.Margin = new System.Windows.Forms.Padding(0);
            this.button_reservation.MaximumSize = new System.Drawing.Size(177, 35);
            this.button_reservation.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_reservation.Name = "button_reservation";
            this.button_reservation.Size = new System.Drawing.Size(177, 35);
            this.button_reservation.TabIndex = 28;
            this.button_reservation.Text = "Rezerwacje";
            this.button_reservation.UseVisualStyleBackColor = false;
            // 
            // button_veh_DB
            // 
            this.button_veh_DB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_veh_DB.FlatAppearance.BorderSize = 0;
            this.button_veh_DB.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_veh_DB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_veh_DB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_veh_DB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_veh_DB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_veh_DB.ForeColor = System.Drawing.Color.Yellow;
            this.button_veh_DB.Location = new System.Drawing.Point(0, 158);
            this.button_veh_DB.Margin = new System.Windows.Forms.Padding(0);
            this.button_veh_DB.MaximumSize = new System.Drawing.Size(177, 35);
            this.button_veh_DB.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_veh_DB.Name = "button_veh_DB";
            this.button_veh_DB.Size = new System.Drawing.Size(177, 35);
            this.button_veh_DB.TabIndex = 26;
            this.button_veh_DB.Text = "Baza pojazdów";
            this.button_veh_DB.UseVisualStyleBackColor = false;
            this.button_veh_DB.Click += new System.EventHandler(this.button_veh_DB_Click);
            // 
            // button_raports_stats
            // 
            this.button_raports_stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_raports_stats.FlatAppearance.BorderSize = 0;
            this.button_raports_stats.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_raports_stats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_raports_stats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_raports_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_raports_stats.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_raports_stats.ForeColor = System.Drawing.Color.Yellow;
            this.button_raports_stats.Location = new System.Drawing.Point(0, 413);
            this.button_raports_stats.Margin = new System.Windows.Forms.Padding(0);
            this.button_raports_stats.MaximumSize = new System.Drawing.Size(177, 70);
            this.button_raports_stats.Name = "button_raports_stats";
            this.button_raports_stats.Size = new System.Drawing.Size(177, 35);
            this.button_raports_stats.TabIndex = 31;
            this.button_raports_stats.Text = "Raporty i statystyki";
            this.button_raports_stats.UseVisualStyleBackColor = false;
            // 
            // userControl_Welcome1
            // 
            this.userControl_Welcome1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_Welcome1.Location = new System.Drawing.Point(177, 27);
            this.userControl_Welcome1.Margin = new System.Windows.Forms.Padding(0);
            this.userControl_Welcome1.Name = "userControl_Welcome1";
            this.userControl_Welcome1.Size = new System.Drawing.Size(941, 656);
            this.userControl_Welcome1.TabIndex = 32;
            // 
            // Form_panel_manager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.userControl_Welcome1);
            this.Controls.Add(this.button_raports_stats);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_statistic);
            this.Controls.Add(this.button_rent);
            this.Controls.Add(this.button_reservation);
            this.Controls.Add(this.button_veh_DB);
            this.Controls.Add(this.userControl_veh_DB1);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_who_online);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_panel_manager";
            this.Text = "Vehicles Management App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_panel_manager_FormClosed);
            this.Load += new System.EventHandler(this.Form_panel_manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_who_online;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_logout;
        private UserControl_veh_DB userControl_veh_DB1;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_statistic;
        private System.Windows.Forms.Button button_rent;
        private System.Windows.Forms.Button button_reservation;
        private System.Windows.Forms.Button button_veh_DB;
        private System.Windows.Forms.Button button_raports_stats;
        private UserControl_Welcome userControl_Welcome1;
    }
}