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
            this.button_rent = new System.Windows.Forms.Button();
            this.button_reservation = new System.Windows.Forms.Button();
            this.button_databaseVeh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControl_raports_stats1 = new VMA.UserControl_raports_stats();
            this.userControl_menage_cars1 = new VMA.UserControl_menage_cars();
            this.userControl_veh_DB1 = new VMA.UserControl_veh_DB();
            this.userControl_delete_keeper1 = new VMA.UserControl_delete_keeper();
            this.userControl_addKeeper1 = new VMA.UserControl_addKeeper();
            this.userControl_manage_keeper1 = new VMA.UserControl_manage_keeper();
            this.userControl_modified_del_Workesrs1 = new VMA.UserControl_modified_del_Workesrs();
            this.userControl_addWorker1 = new VMA.UserControl_addWorker();
            this.userControl_menage_workers1 = new VMA.UserControl_menage_workers();
            this.userControl_modified_delet_car1 = new VMA.UserControl_modified_delet_car();
            this.userControl_add_Car1 = new VMA.UserControl_add_Car();
            this.userControl_raports_stats_cars1 = new VMA.UserControl_raports_stats_cars();
            this.userControl_raports_stats_workers1 = new VMA.UserControl_raports_stats_workers();
            this.pictureBox_help = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).BeginInit();
            this.SuspendLayout();
            // 
            // label_admin_is_online
            // 
            this.label_admin_is_online.AutoSize = true;
            this.label_admin_is_online.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_admin_is_online.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label_admin_is_online.Location = new System.Drawing.Point(429, 7);
            this.label_admin_is_online.Name = "label_admin_is_online";
            this.label_admin_is_online.Size = new System.Drawing.Size(204, 17);
            this.label_admin_is_online.TabIndex = 1;
            this.label_admin_is_online.Text = "Zalogowany jako Administrator";
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
            this.button_rent.Location = new System.Drawing.Point(0, 295);
            this.button_rent.Margin = new System.Windows.Forms.Padding(0);
            this.button_rent.MaximumSize = new System.Drawing.Size(177, 70);
            this.button_rent.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_rent.Name = "button_rent";
            this.button_rent.Size = new System.Drawing.Size(177, 70);
            this.button_rent.TabIndex = 13;
            this.button_rent.Text = "Zarządzanie pracownikami";
            this.button_rent.UseVisualStyleBackColor = false;
            this.button_rent.Click += new System.EventHandler(this.button_rent_Click);
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
            this.button_reservation.MaximumSize = new System.Drawing.Size(177, 70);
            this.button_reservation.MinimumSize = new System.Drawing.Size(177, 35);
            this.button_reservation.Name = "button_reservation";
            this.button_reservation.Size = new System.Drawing.Size(177, 70);
            this.button_reservation.TabIndex = 14;
            this.button_reservation.Text = "Zarządzanie pojazdami";
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
            this.button_databaseVeh.Location = new System.Drawing.Point(0, 158);
            this.button_databaseVeh.Margin = new System.Windows.Forms.Padding(0);
            this.button_databaseVeh.Name = "button_databaseVeh";
            this.button_databaseVeh.Size = new System.Drawing.Size(177, 35);
            this.button_databaseVeh.TabIndex = 12;
            this.button_databaseVeh.Text = "Baza pojazdów";
            this.button_databaseVeh.UseVisualStyleBackColor = false;
            this.button_databaseVeh.Click += new System.EventHandler(this.button_databaseVeh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::VMA.Properties.Resources.LogoVMA;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(35, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // userControl_raports_stats1
            // 
            this.userControl_raports_stats1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_raports_stats1.ForeColor = System.Drawing.Color.Black;
            this.userControl_raports_stats1.Location = new System.Drawing.Point(177, 27);
            this.userControl_raports_stats1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_raports_stats1.Name = "userControl_raports_stats1";
            this.userControl_raports_stats1.Size = new System.Drawing.Size(941, 656);
            this.userControl_raports_stats1.TabIndex = 30;
            // 
            // userControl_menage_cars1
            // 
            this.userControl_menage_cars1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_menage_cars1.Location = new System.Drawing.Point(177, 27);
            this.userControl_menage_cars1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_menage_cars1.Name = "userControl_menage_cars1";
            this.userControl_menage_cars1.Size = new System.Drawing.Size(941, 656);
            this.userControl_menage_cars1.TabIndex = 19;
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
            // userControl_delete_keeper1
            // 
            this.userControl_delete_keeper1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_delete_keeper1.Location = new System.Drawing.Point(177, 27);
            this.userControl_delete_keeper1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl_delete_keeper1.Name = "userControl_delete_keeper1";
            this.userControl_delete_keeper1.Size = new System.Drawing.Size(941, 656);
            this.userControl_delete_keeper1.TabIndex = 28;
            // 
            // userControl_addKeeper1
            // 
            this.userControl_addKeeper1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_addKeeper1.Location = new System.Drawing.Point(177, 27);
            this.userControl_addKeeper1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl_addKeeper1.Name = "userControl_addKeeper1";
            this.userControl_addKeeper1.Size = new System.Drawing.Size(941, 656);
            this.userControl_addKeeper1.TabIndex = 27;
            // 
            // userControl_manage_keeper1
            // 
            this.userControl_manage_keeper1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_manage_keeper1.ForeColor = System.Drawing.Color.Black;
            this.userControl_manage_keeper1.Location = new System.Drawing.Point(177, 27);
            this.userControl_manage_keeper1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl_manage_keeper1.Name = "userControl_manage_keeper1";
            this.userControl_manage_keeper1.Size = new System.Drawing.Size(941, 656);
            this.userControl_manage_keeper1.TabIndex = 26;
            // 
            // userControl_modified_del_Workesrs1
            // 
            this.userControl_modified_del_Workesrs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.userControl_modified_del_Workesrs1.Location = new System.Drawing.Point(177, 27);
            this.userControl_modified_del_Workesrs1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_modified_del_Workesrs1.Name = "userControl_modified_del_Workesrs1";
            this.userControl_modified_del_Workesrs1.Size = new System.Drawing.Size(941, 656);
            this.userControl_modified_del_Workesrs1.TabIndex = 25;
            // 
            // userControl_addWorker1
            // 
            this.userControl_addWorker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_addWorker1.Location = new System.Drawing.Point(177, 27);
            this.userControl_addWorker1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_addWorker1.Name = "userControl_addWorker1";
            this.userControl_addWorker1.Size = new System.Drawing.Size(941, 656);
            this.userControl_addWorker1.TabIndex = 24;
            // 
            // userControl_menage_workers1
            // 
            this.userControl_menage_workers1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_menage_workers1.Location = new System.Drawing.Point(177, 27);
            this.userControl_menage_workers1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_menage_workers1.Name = "userControl_menage_workers1";
            this.userControl_menage_workers1.Size = new System.Drawing.Size(941, 656);
            this.userControl_menage_workers1.TabIndex = 23;
            // 
            // userControl_modified_delet_car1
            // 
            this.userControl_modified_delet_car1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.userControl_modified_delet_car1.Location = new System.Drawing.Point(177, 27);
            this.userControl_modified_delet_car1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_modified_delet_car1.Name = "userControl_modified_delet_car1";
            this.userControl_modified_delet_car1.Size = new System.Drawing.Size(941, 656);
            this.userControl_modified_delet_car1.TabIndex = 22;
            // 
            // userControl_add_Car1
            // 
            this.userControl_add_Car1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_add_Car1.Location = new System.Drawing.Point(177, 27);
            this.userControl_add_Car1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_add_Car1.Name = "userControl_add_Car1";
            this.userControl_add_Car1.Size = new System.Drawing.Size(941, 656);
            this.userControl_add_Car1.TabIndex = 20;
            // 
            // userControl_raports_stats_cars1
            // 
            this.userControl_raports_stats_cars1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_raports_stats_cars1.Location = new System.Drawing.Point(177, 27);
            this.userControl_raports_stats_cars1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl_raports_stats_cars1.Name = "userControl_raports_stats_cars1";
            this.userControl_raports_stats_cars1.Size = new System.Drawing.Size(941, 656);
            this.userControl_raports_stats_cars1.TabIndex = 31;
            // 
            // userControl_raports_stats_workers1
            // 
            this.userControl_raports_stats_workers1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.userControl_raports_stats_workers1.Location = new System.Drawing.Point(177, 27);
            this.userControl_raports_stats_workers1.Margin = new System.Windows.Forms.Padding(2);
            this.userControl_raports_stats_workers1.Name = "userControl_raports_stats_workers1";
            this.userControl_raports_stats_workers1.Size = new System.Drawing.Size(941, 656);
            this.userControl_raports_stats_workers1.TabIndex = 32;
            // 
            // pictureBox_help
            // 
            this.pictureBox_help.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_help.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_help.Image")));
            this.pictureBox_help.Location = new System.Drawing.Point(857, 2);
            this.pictureBox_help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_help.Name = "pictureBox_help";
            this.pictureBox_help.Size = new System.Drawing.Size(25, 23);
            this.pictureBox_help.TabIndex = 33;
            this.pictureBox_help.TabStop = false;
            this.pictureBox_help.Click += new System.EventHandler(this.pictureBox_help_Click);
            // 
            // Form_panel_admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox_help);
            this.Controls.Add(this.userControl_raports_stats_workers1);
            this.Controls.Add(this.userControl_raports_stats_cars1);
            this.Controls.Add(this.userControl_raports_stats1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userControl_menage_cars1);
            this.Controls.Add(this.userControl_veh_DB1);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_rent);
            this.Controls.Add(this.button_reservation);
            this.Controls.Add(this.button_databaseVeh);
            this.Controls.Add(this.label_admin_is_online);
            this.Controls.Add(this.userControl_addKeeper1);
            this.Controls.Add(this.userControl_manage_keeper1);
            this.Controls.Add(this.userControl_modified_del_Workesrs1);
            this.Controls.Add(this.userControl_addWorker1);
            this.Controls.Add(this.userControl_menage_workers1);
            this.Controls.Add(this.userControl_modified_delet_car1);
            this.Controls.Add(this.userControl_add_Car1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_panel_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Vehicles Management App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_panel_admin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_admin_is_online;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_rent;
        private System.Windows.Forms.Button button_reservation;
        private System.Windows.Forms.Button button_databaseVeh;
        private UserControl_veh_DB userControl_veh_DB1;
        private UserControl_menage_cars userControl_menage_cars1;
        private UserControl_add_Car userControl_add_Car1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControl_modified_delet_car userControl_modified_delet_car1;
        private UserControl_menage_workers userControl_menage_workers1;
        private UserControl_addWorker userControl_addWorker1;
        private UserControl_modified_del_Workesrs userControl_modified_del_Workesrs1;
        private UserControl_manage_keeper userControl_manage_keeper1;
        private UserControl_addKeeper userControl_addKeeper1;
        private UserControl_delete_keeper userControl_delete_keeper1;
        private UserControl_raports_stats userControl_raports_stats1;
        private UserControl_raports_stats_cars userControl_raports_stats_cars1;
        private UserControl_raports_stats_workers userControl_raports_stats_workers1;
        private System.Windows.Forms.PictureBox pictureBox_help;
    }
}