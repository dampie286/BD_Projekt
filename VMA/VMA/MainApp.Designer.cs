namespace VMA
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.label_who_online = new System.Windows.Forms.Label();
            this.button_databaseVeh = new System.Windows.Forms.Button();
            this.button_reservation = new System.Windows.Forms.Button();
            this.button_rent = new System.Windows.Forms.Button();
            this.button_statistic = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.userControl_settings1 = new VMA.UserControl_settings();
            this.userControl_myStatics1 = new VMA.UserControl_myStatics();
            this.userControl_my_reservation1 = new VMA.UserControl_my_reservation();
            this.userControl_rent_with_DB1 = new VMA.UserControl_rent_with_DB();
            this.userControl_rent1 = new VMA.UserControl_rent();
            this.userControl_reservation1 = new VMA.UserControl_reservation();
            this.userControl_Welcome2 = new VMA.UserControl_Welcome();
            this.userControl_veh_DB2 = new VMA.UserControl_veh_DB();
            this.pictureBox_main_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_who_online
            // 
            this.label_who_online.AutoSize = true;
            this.label_who_online.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_who_online.ForeColor = System.Drawing.Color.Yellow;
            this.label_who_online.Location = new System.Drawing.Point(429, 7);
            this.label_who_online.Name = "label_who_online";
            this.label_who_online.Size = new System.Drawing.Size(188, 15);
            this.label_who_online.TabIndex = 0;
            this.label_who_online.Text = "Zalogowany jako Imię i Nazwisko";
            // 
            // button_databaseVeh
            // 
            this.button_databaseVeh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_databaseVeh.FlatAppearance.BorderSize = 0;
            this.button_databaseVeh.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_databaseVeh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_databaseVeh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_databaseVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_databaseVeh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_databaseVeh.ForeColor = System.Drawing.Color.Yellow;
            this.button_databaseVeh.Location = new System.Drawing.Point(0, 173);
            this.button_databaseVeh.Margin = new System.Windows.Forms.Padding(0);
            this.button_databaseVeh.MaximumSize = new System.Drawing.Size(177, 35);
            this.button_databaseVeh.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_databaseVeh.Name = "button_databaseVeh";
            this.button_databaseVeh.Size = new System.Drawing.Size(177, 35);
            this.button_databaseVeh.TabIndex = 6;
            this.button_databaseVeh.Text = "Baza pojazdów";
            this.button_databaseVeh.UseVisualStyleBackColor = false;
            this.button_databaseVeh.Click += new System.EventHandler(this.button_databaseVeh_Click);
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
            this.button_reservation.Location = new System.Drawing.Point(0, 224);
            this.button_reservation.Margin = new System.Windows.Forms.Padding(0);
            this.button_reservation.MaximumSize = new System.Drawing.Size(177, 35);
            this.button_reservation.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_reservation.Name = "button_reservation";
            this.button_reservation.Size = new System.Drawing.Size(177, 35);
            this.button_reservation.TabIndex = 7;
            this.button_reservation.Text = "Rezerwacje";
            this.button_reservation.UseVisualStyleBackColor = false;
            this.button_reservation.Click += new System.EventHandler(this.button_reservation_Click);
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
            this.button_rent.Location = new System.Drawing.Point(0, 275);
            this.button_rent.Margin = new System.Windows.Forms.Padding(0);
            this.button_rent.MaximumSize = new System.Drawing.Size(177, 35);
            this.button_rent.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_rent.Name = "button_rent";
            this.button_rent.Size = new System.Drawing.Size(177, 35);
            this.button_rent.TabIndex = 7;
            this.button_rent.Text = "Wypożyczenia";
            this.button_rent.UseVisualStyleBackColor = false;
            this.button_rent.Click += new System.EventHandler(this.button_rent_Click);
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
            this.button_statistic.Location = new System.Drawing.Point(0, 326);
            this.button_statistic.Margin = new System.Windows.Forms.Padding(0);
            this.button_statistic.MaximumSize = new System.Drawing.Size(177, 35);
            this.button_statistic.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_statistic.Name = "button_statistic";
            this.button_statistic.Size = new System.Drawing.Size(177, 35);
            this.button_statistic.TabIndex = 8;
            this.button_statistic.Text = "Statystyki";
            this.button_statistic.UseVisualStyleBackColor = false;
            this.button_statistic.Click += new System.EventHandler(this.button_statistic_Click);
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
            this.button_settings.Location = new System.Drawing.Point(0, 377);
            this.button_settings.Margin = new System.Windows.Forms.Padding(0);
            this.button_settings.MaximumSize = new System.Drawing.Size(177, 35);
            this.button_settings.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(177, 35);
            this.button_settings.TabIndex = 9;
            this.button_settings.Text = "Ustawienia";
            this.button_settings.UseVisualStyleBackColor = false;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
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
            this.button_logout.TabIndex = 11;
            this.button_logout.Text = "Wyloguj się";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // userControl_settings1
            // 
            this.userControl_settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_settings1.Location = new System.Drawing.Point(177, 27);
            this.userControl_settings1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_settings1.Name = "userControl_settings1";
            this.userControl_settings1.Size = new System.Drawing.Size(941, 656);
            this.userControl_settings1.TabIndex = 19;
            // 
            // userControl_myStatics1
            // 
            this.userControl_myStatics1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_myStatics1.Location = new System.Drawing.Point(177, 27);
            this.userControl_myStatics1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_myStatics1.Name = "userControl_myStatics1";
            this.userControl_myStatics1.Size = new System.Drawing.Size(941, 656);
            this.userControl_myStatics1.TabIndex = 18;
            // 
            // userControl_my_reservation1
            // 
            this.userControl_my_reservation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_my_reservation1.Location = new System.Drawing.Point(177, 27);
            this.userControl_my_reservation1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_my_reservation1.Name = "userControl_my_reservation1";
            this.userControl_my_reservation1.Size = new System.Drawing.Size(941, 656);
            this.userControl_my_reservation1.TabIndex = 17;
            // 
            // userControl_rent_with_DB1
            // 
            this.userControl_rent_with_DB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_rent_with_DB1.Location = new System.Drawing.Point(177, 27);
            this.userControl_rent_with_DB1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_rent_with_DB1.Name = "userControl_rent_with_DB1";
            this.userControl_rent_with_DB1.Size = new System.Drawing.Size(941, 656);
            this.userControl_rent_with_DB1.TabIndex = 16;
            // 
            // userControl_rent1
            // 
            this.userControl_rent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_rent1.Location = new System.Drawing.Point(177, 27);
            this.userControl_rent1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_rent1.Name = "userControl_rent1";
            this.userControl_rent1.Size = new System.Drawing.Size(941, 656);
            this.userControl_rent1.TabIndex = 15;
            // 
            // userControl_reservation1
            // 
            this.userControl_reservation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_reservation1.Location = new System.Drawing.Point(177, 27);
            this.userControl_reservation1.Margin = new System.Windows.Forms.Padding(0);
            this.userControl_reservation1.Name = "userControl_reservation1";
            this.userControl_reservation1.Size = new System.Drawing.Size(941, 656);
            this.userControl_reservation1.TabIndex = 14;
            // 
            // userControl_Welcome2
            // 
            this.userControl_Welcome2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_Welcome2.Location = new System.Drawing.Point(177, 27);
            this.userControl_Welcome2.Margin = new System.Windows.Forms.Padding(0);
            this.userControl_Welcome2.Name = "userControl_Welcome2";
            this.userControl_Welcome2.Size = new System.Drawing.Size(706, 533);
            this.userControl_Welcome2.TabIndex = 13;
            // 
            // userControl_veh_DB2
            // 
            this.userControl_veh_DB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_veh_DB2.Location = new System.Drawing.Point(177, 27);
            this.userControl_veh_DB2.Margin = new System.Windows.Forms.Padding(0);
            this.userControl_veh_DB2.Name = "userControl_veh_DB2";
            this.userControl_veh_DB2.Size = new System.Drawing.Size(706, 533);
            this.userControl_veh_DB2.TabIndex = 12;
            // 
            // pictureBox_main_logo
            // 
            this.pictureBox_main_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_main_logo.ErrorImage = null;
            this.pictureBox_main_logo.Image = global::VMA.Properties.Resources.LogoVMA;
            this.pictureBox_main_logo.InitialImage = null;
            this.pictureBox_main_logo.Location = new System.Drawing.Point(36, 46);
            this.pictureBox_main_logo.Name = "pictureBox_main_logo";
            this.pictureBox_main_logo.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_main_logo.TabIndex = 20;
            this.pictureBox_main_logo.TabStop = false;
            // 
            // MainApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox_main_logo);
            this.Controls.Add(this.userControl_settings1);
            this.Controls.Add(this.userControl_myStatics1);
            this.Controls.Add(this.userControl_my_reservation1);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_statistic);
            this.Controls.Add(this.button_rent);
            this.Controls.Add(this.button_reservation);
            this.Controls.Add(this.button_databaseVeh);
            this.Controls.Add(this.label_who_online);
            this.Controls.Add(this.userControl_rent_with_DB1);
            this.Controls.Add(this.userControl_rent1);
            this.Controls.Add(this.userControl_reservation1);
            this.Controls.Add(this.userControl_Welcome2);
            this.Controls.Add(this.userControl_veh_DB2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicles Management App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainApp_FormClosed);
            this.Load += new System.EventHandler(this.MainApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_who_online;
        private System.Windows.Forms.Button button_databaseVeh;
        private System.Windows.Forms.Button button_reservation;
        private System.Windows.Forms.Button button_rent;
        private System.Windows.Forms.Button button_statistic;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_logout;
       
        private UserControl_veh_DB userControl_veh_DB2;
        private UserControl_Welcome userControl_Welcome2;
        private UserControl_reservation userControl_reservation1;
        private UserControl_rent userControl_rent1;
        private UserControl_rent_with_DB userControl_rent_with_DB1;
        private UserControl_my_reservation userControl_my_reservation1;
        private UserControl_myStatics userControl_myStatics1;
        private UserControl_settings userControl_settings1;
        private System.Windows.Forms.PictureBox pictureBox_main_logo;
    }
}