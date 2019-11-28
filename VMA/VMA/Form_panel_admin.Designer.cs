namespace VMA
{
    partial class Form_panel_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_panel_admin));
            this.label_admin_is_online = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_rent = new System.Windows.Forms.Button();
            this.button_reservation = new System.Windows.Forms.Button();
            this.button_databaseVeh = new System.Windows.Forms.Button();
            this.userControl_veh_DB1 = new VMA.UserControl_veh_DB();
            this.userControl_menage_cars1 = new VMA.UserControl_menage_cars();
            this.userControl_add_Car1 = new VMA.UserControl_add_Car();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_admin_is_online
            // 
            this.label_admin_is_online.AutoSize = true;
            this.label_admin_is_online.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_admin_is_online.ForeColor = System.Drawing.Color.Yellow;
            this.label_admin_is_online.Location = new System.Drawing.Point(429, 7);
            this.label_admin_is_online.Name = "label_admin_is_online";
            this.label_admin_is_online.Size = new System.Drawing.Size(148, 15);
            this.label_admin_is_online.TabIndex = 1;
            this.label_admin_is_online.Text = "Zalogowany Administrator";
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
            this.button_logout.TabIndex = 17;
            this.button_logout.Text = "Wyloguj się";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
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
            this.button_settings.Location = new System.Drawing.Point(0, 401);
            this.button_settings.Margin = new System.Windows.Forms.Padding(0);
            this.button_settings.MaximumSize = new System.Drawing.Size(177, 35);
            this.button_settings.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(177, 35);
            this.button_settings.TabIndex = 16;
            this.button_settings.Text = "Ustawienia";
            this.button_settings.UseVisualStyleBackColor = false;
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
            this.button_rent.Location = new System.Drawing.Point(0, 310);
            this.button_rent.Margin = new System.Windows.Forms.Padding(0);
            this.button_rent.MaximumSize = new System.Drawing.Size(177, 70);
            this.button_rent.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_rent.Name = "button_rent";
            this.button_rent.Size = new System.Drawing.Size(177, 70);
            this.button_rent.TabIndex = 13;
            this.button_rent.Text = "Zarządzanie pracownikami";
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
            this.button_reservation.Location = new System.Drawing.Point(0, 224);
            this.button_reservation.Margin = new System.Windows.Forms.Padding(0);
            this.button_reservation.MaximumSize = new System.Drawing.Size(177, 70);
            this.button_reservation.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_reservation.Name = "button_reservation";
            this.button_reservation.Size = new System.Drawing.Size(177, 70);
            this.button_reservation.TabIndex = 14;
            this.button_reservation.Text = "Zarządzanie Pojazdami";
            this.button_reservation.UseVisualStyleBackColor = false;
            this.button_reservation.Click += new System.EventHandler(this.button_reservation_Click);
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
            this.button_databaseVeh.TabIndex = 12;
            this.button_databaseVeh.Text = "Baza pojazdów";
            this.button_databaseVeh.UseVisualStyleBackColor = false;
            this.button_databaseVeh.Click += new System.EventHandler(this.button_databaseVeh_Click);
            // 
            // userControl_veh_DB1
            // 
            this.userControl_veh_DB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_veh_DB1.Location = new System.Drawing.Point(177, 27);
            this.userControl_veh_DB1.Margin = new System.Windows.Forms.Padding(0);
            this.userControl_veh_DB1.Name = "userControl_veh_DB1";
            this.userControl_veh_DB1.Size = new System.Drawing.Size(941, 656);
            this.userControl_veh_DB1.TabIndex = 18;
            // 
            // userControl_menage_cars1
            // 
            this.userControl_menage_cars1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.userControl_menage_cars1.Location = new System.Drawing.Point(177, 27);
            this.userControl_menage_cars1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_menage_cars1.Name = "userControl_menage_cars1";
            this.userControl_menage_cars1.Size = new System.Drawing.Size(941, 656);
            this.userControl_menage_cars1.TabIndex = 19;
            // 
            // userControl_add_Car1
            // 
            this.userControl_add_Car1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.userControl_add_Car1.Location = new System.Drawing.Point(177, 27);
            this.userControl_add_Car1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_add_Car1.Name = "userControl_add_Car1";
            this.userControl_add_Car1.Size = new System.Drawing.Size(941, 656);
            this.userControl_add_Car1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::VMA.Properties.Resources.LogoVMA;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(36, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form_panel_admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userControl_add_Car1);
            this.Controls.Add(this.userControl_menage_cars1);
            this.Controls.Add(this.userControl_veh_DB1);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_rent);
            this.Controls.Add(this.button_reservation);
            this.Controls.Add(this.button_databaseVeh);
            this.Controls.Add(this.label_admin_is_online);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_panel_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicles Management App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_panel_admin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_admin_is_online;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_rent;
        private System.Windows.Forms.Button button_reservation;
        private System.Windows.Forms.Button button_databaseVeh;
        private UserControl_veh_DB userControl_veh_DB1;
        private UserControl_menage_cars userControl_menage_cars1;
        private UserControl_add_Car userControl_add_Car1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}