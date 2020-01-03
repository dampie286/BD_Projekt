namespace VMA
{
    partial class UserControl_menage_all
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
            this.button_manage_keeper = new System.Windows.Forms.Button();
            this.button_raports_statistics = new System.Windows.Forms.Button();
            this.button_manage_services = new System.Windows.Forms.Button();
            this.label_choice_rent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_manage_keeper
            // 
            this.button_manage_keeper.BackColor = System.Drawing.Color.Yellow;
            this.button_manage_keeper.FlatAppearance.BorderSize = 0;
            this.button_manage_keeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manage_keeper.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_manage_keeper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_manage_keeper.Location = new System.Drawing.Point(238, 340);
            this.button_manage_keeper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_manage_keeper.Name = "button_manage_keeper";
            this.button_manage_keeper.Size = new System.Drawing.Size(230, 50);
            this.button_manage_keeper.TabIndex = 38;
            this.button_manage_keeper.Text = "Zarządanie opiekunami";
            this.button_manage_keeper.UseVisualStyleBackColor = false;
            this.button_manage_keeper.Click += new System.EventHandler(this.button_manage_keeper_Click);
            // 
            // button_raports_statistics
            // 
            this.button_raports_statistics.BackColor = System.Drawing.Color.Yellow;
            this.button_raports_statistics.FlatAppearance.BorderSize = 0;
            this.button_raports_statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_raports_statistics.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_raports_statistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_raports_statistics.Location = new System.Drawing.Point(238, 260);
            this.button_raports_statistics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_raports_statistics.Name = "button_raports_statistics";
            this.button_raports_statistics.Size = new System.Drawing.Size(230, 50);
            this.button_raports_statistics.TabIndex = 37;
            this.button_raports_statistics.Text = "Raporty i statystyki";
            this.button_raports_statistics.UseVisualStyleBackColor = false;
            this.button_raports_statistics.Click += new System.EventHandler(this.button_raports_statistics_Click);
            // 
            // button_manage_services
            // 
            this.button_manage_services.BackColor = System.Drawing.Color.Yellow;
            this.button_manage_services.FlatAppearance.BorderSize = 0;
            this.button_manage_services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manage_services.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_manage_services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_manage_services.Location = new System.Drawing.Point(238, 180);
            this.button_manage_services.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_manage_services.Name = "button_manage_services";
            this.button_manage_services.Size = new System.Drawing.Size(230, 50);
            this.button_manage_services.TabIndex = 36;
            this.button_manage_services.Text = "Zarządzanie serwisami warsztatowymi";
            this.button_manage_services.UseVisualStyleBackColor = false;
            this.button_manage_services.Click += new System.EventHandler(this.button_manage_services_Click);
            // 
            // label_choice_rent
            // 
            this.label_choice_rent.AutoSize = true;
            this.label_choice_rent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_choice_rent.ForeColor = System.Drawing.Color.Yellow;
            this.label_choice_rent.Location = new System.Drawing.Point(253, 140);
            this.label_choice_rent.Margin = new System.Windows.Forms.Padding(0);
            this.label_choice_rent.Name = "label_choice_rent";
            this.label_choice_rent.Size = new System.Drawing.Size(200, 22);
            this.label_choice_rent.TabIndex = 35;
            this.label_choice_rent.Text = "Funkcje kierownicze";
            // 
            // UserControl_menage_all
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.button_manage_keeper);
            this.Controls.Add(this.button_raports_statistics);
            this.Controls.Add(this.button_manage_services);
            this.Controls.Add(this.label_choice_rent);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl_menage_all";
            this.Size = new System.Drawing.Size(706, 533);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_manage_keeper;
        private System.Windows.Forms.Button button_raports_statistics;
        private System.Windows.Forms.Button button_manage_services;
        private System.Windows.Forms.Label label_choice_rent;
    }
}
