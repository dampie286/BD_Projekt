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
            this.label_who_online = new System.Windows.Forms.Label();
            this.label_name_reservation = new System.Windows.Forms.Label();
            this.label_name_statistic = new System.Windows.Forms.Label();
            this.button_databaseVeh = new System.Windows.Forms.Button();
            this.button_reservation = new System.Windows.Forms.Button();
            this.button_rent = new System.Windows.Forms.Button();
            this.button_statistic = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.userControl_veh_DB2 = new VMA.UserControl_veh_DB();
            this.userControl_Welcome2 = new VMA.UserControl_Welcome();
            this.SuspendLayout();
            // 
            // label_who_online
            // 
            this.label_who_online.AutoSize = true;
            this.label_who_online.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_who_online.ForeColor = System.Drawing.Color.Yellow;
            this.label_who_online.Location = new System.Drawing.Point(429, 5);
            this.label_who_online.Name = "label_who_online";
            this.label_who_online.Size = new System.Drawing.Size(253, 20);
            this.label_who_online.TabIndex = 0;
            this.label_who_online.Text = "Zalogowany jako Imię i Nazwisko";
            // 
            // label_name_reservation
            // 
            this.label_name_reservation.AutoSize = true;
            this.label_name_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name_reservation.ForeColor = System.Drawing.Color.Yellow;
            this.label_name_reservation.Location = new System.Drawing.Point(31, 261);
            this.label_name_reservation.MaximumSize = new System.Drawing.Size(108, 22);
            this.label_name_reservation.MinimumSize = new System.Drawing.Size(108, 22);
            this.label_name_reservation.Name = "label_name_reservation";
            this.label_name_reservation.Size = new System.Drawing.Size(108, 22);
            this.label_name_reservation.TabIndex = 2;
            this.label_name_reservation.Text = "Rezerwacja";
            this.label_name_reservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_name_statistic
            // 
            this.label_name_statistic.AutoSize = true;
            this.label_name_statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name_statistic.ForeColor = System.Drawing.Color.Yellow;
            this.label_name_statistic.Location = new System.Drawing.Point(38, 373);
            this.label_name_statistic.MaximumSize = new System.Drawing.Size(94, 22);
            this.label_name_statistic.MinimumSize = new System.Drawing.Size(94, 22);
            this.label_name_statistic.Name = "label_name_statistic";
            this.label_name_statistic.Size = new System.Drawing.Size(94, 22);
            this.label_name_statistic.TabIndex = 4;
            this.label_name_statistic.Text = "Statystyki";
            this.label_name_statistic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_databaseVeh
            // 
            this.button_databaseVeh.BackColor = System.Drawing.Color.DimGray;
            this.button_databaseVeh.FlatAppearance.BorderSize = 0;
            this.button_databaseVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_databaseVeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_databaseVeh.ForeColor = System.Drawing.Color.Yellow;
            this.button_databaseVeh.Location = new System.Drawing.Point(18, 205);
            this.button_databaseVeh.Margin = new System.Windows.Forms.Padding(0);
            this.button_databaseVeh.MaximumSize = new System.Drawing.Size(144, 28);
            this.button_databaseVeh.MinimumSize = new System.Drawing.Size(144, 28);
            this.button_databaseVeh.Name = "button_databaseVeh";
            this.button_databaseVeh.Size = new System.Drawing.Size(144, 28);
            this.button_databaseVeh.TabIndex = 6;
            this.button_databaseVeh.Text = "Baza pojazdów";
            this.button_databaseVeh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_databaseVeh.UseVisualStyleBackColor = false;
            this.button_databaseVeh.Click += new System.EventHandler(this.button_databaseVeh_Click);
            // 
            // button_reservation
            // 
            this.button_reservation.BackColor = System.Drawing.Color.DimGray;
            this.button_reservation.FlatAppearance.BorderSize = 0;
            this.button_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_reservation.ForeColor = System.Drawing.Color.Yellow;
            this.button_reservation.Location = new System.Drawing.Point(31, 261);
            this.button_reservation.Margin = new System.Windows.Forms.Padding(0);
            this.button_reservation.MaximumSize = new System.Drawing.Size(108, 28);
            this.button_reservation.MinimumSize = new System.Drawing.Size(108, 28);
            this.button_reservation.Name = "button_reservation";
            this.button_reservation.Size = new System.Drawing.Size(108, 28);
            this.button_reservation.TabIndex = 7;
            this.button_reservation.Text = "Rezerwacja";
            this.button_reservation.UseVisualStyleBackColor = false;
            // 
            // button_rent
            // 
            this.button_rent.BackColor = System.Drawing.Color.DimGray;
            this.button_rent.FlatAppearance.BorderSize = 0;
            this.button_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_rent.ForeColor = System.Drawing.Color.Yellow;
            this.button_rent.Location = new System.Drawing.Point(17, 317);
            this.button_rent.Margin = new System.Windows.Forms.Padding(0);
            this.button_rent.MaximumSize = new System.Drawing.Size(136, 28);
            this.button_rent.MinimumSize = new System.Drawing.Size(136, 28);
            this.button_rent.Name = "button_rent";
            this.button_rent.Size = new System.Drawing.Size(136, 28);
            this.button_rent.TabIndex = 7;
            this.button_rent.Text = "Wypożyczenie";
            this.button_rent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_rent.UseVisualStyleBackColor = false;
            // 
            // button_statistic
            // 
            this.button_statistic.BackColor = System.Drawing.Color.DimGray;
            this.button_statistic.FlatAppearance.BorderSize = 0;
            this.button_statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_statistic.ForeColor = System.Drawing.Color.Yellow;
            this.button_statistic.Location = new System.Drawing.Point(38, 373);
            this.button_statistic.Margin = new System.Windows.Forms.Padding(0);
            this.button_statistic.MaximumSize = new System.Drawing.Size(94, 28);
            this.button_statistic.MinimumSize = new System.Drawing.Size(94, 28);
            this.button_statistic.Name = "button_statistic";
            this.button_statistic.Size = new System.Drawing.Size(94, 28);
            this.button_statistic.TabIndex = 8;
            this.button_statistic.Text = "Statystyki";
            this.button_statistic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_statistic.UseVisualStyleBackColor = false;
            // 
            // button_settings
            // 
            this.button_settings.BackColor = System.Drawing.Color.DimGray;
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_settings.ForeColor = System.Drawing.Color.Yellow;
            this.button_settings.Location = new System.Drawing.Point(33, 429);
            this.button_settings.Margin = new System.Windows.Forms.Padding(0);
            this.button_settings.MaximumSize = new System.Drawing.Size(104, 28);
            this.button_settings.MinimumSize = new System.Drawing.Size(104, 28);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(104, 28);
            this.button_settings.TabIndex = 9;
            this.button_settings.Text = "Statystyki";
            this.button_settings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_settings.UseVisualStyleBackColor = false;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.DimGray;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.ForeColor = System.Drawing.Color.Yellow;
            this.button_logout.Location = new System.Drawing.Point(18, 81);
            this.button_logout.Margin = new System.Windows.Forms.Padding(0);
            this.button_logout.MaximumSize = new System.Drawing.Size(144, 28);
            this.button_logout.MinimumSize = new System.Drawing.Size(144, 28);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(144, 28);
            this.button_logout.TabIndex = 11;
            this.button_logout.Text = "Wyloguj się";
            this.button_logout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // userControl_veh_DB2
            // 
            this.userControl_veh_DB2.BackColor = System.Drawing.Color.Gray;
            this.userControl_veh_DB2.Location = new System.Drawing.Point(177, 27);
            this.userControl_veh_DB2.Margin = new System.Windows.Forms.Padding(0);
            this.userControl_veh_DB2.Name = "userControl_veh_DB2";
            this.userControl_veh_DB2.Size = new System.Drawing.Size(706, 533);
            this.userControl_veh_DB2.TabIndex = 12;
            // 
            // userControl_Welcome2
            // 
            this.userControl_Welcome2.BackColor = System.Drawing.Color.Gray;
            this.userControl_Welcome2.Location = new System.Drawing.Point(177, 27);
            this.userControl_Welcome2.Margin = new System.Windows.Forms.Padding(0);
            this.userControl_Welcome2.Name = "userControl_Welcome2";
            this.userControl_Welcome2.Size = new System.Drawing.Size(706, 533);
            this.userControl_Welcome2.TabIndex = 13;
            // 
            // MainApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.userControl_Welcome2);
            this.Controls.Add(this.userControl_veh_DB2);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_statistic);
            this.Controls.Add(this.button_rent);
            this.Controls.Add(this.button_reservation);
            this.Controls.Add(this.button_databaseVeh);
            this.Controls.Add(this.label_name_statistic);
            this.Controls.Add(this.label_name_reservation);
            this.Controls.Add(this.label_who_online);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VM Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainApp_FormClosed);
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_who_online;
        private System.Windows.Forms.Label label_name_reservation;
        private System.Windows.Forms.Label label_name_statistic;
        private System.Windows.Forms.Button button_databaseVeh;
        private System.Windows.Forms.Button button_reservation;
        private System.Windows.Forms.Button button_rent;
        private System.Windows.Forms.Button button_statistic;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_logout;
       
        private UserControl_veh_DB userControl_veh_DB2;
        private UserControl_Welcome userControl_Welcome2;
    }
}