﻿namespace VMA
{
    partial class UserControl_menage_workers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_menage_workers));
            this.button_meng_or_del_car = new System.Windows.Forms.Button();
            this.button_add_worker = new System.Windows.Forms.Button();
            this.label_menage_workers = new System.Windows.Forms.Label();
            this.pictureBox_help = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).BeginInit();
            this.SuspendLayout();
            // 
            // button_meng_or_del_car
            // 
            this.button_meng_or_del_car.BackColor = System.Drawing.Color.Yellow;
            this.button_meng_or_del_car.FlatAppearance.BorderSize = 0;
            this.button_meng_or_del_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_meng_or_del_car.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_meng_or_del_car.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_meng_or_del_car.Location = new System.Drawing.Point(317, 320);
            this.button_meng_or_del_car.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_meng_or_del_car.Name = "button_meng_or_del_car";
            this.button_meng_or_del_car.Size = new System.Drawing.Size(307, 62);
            this.button_meng_or_del_car.TabIndex = 39;
            this.button_meng_or_del_car.Text = "Modyfikuj lub usuń pracownika";
            this.button_meng_or_del_car.UseVisualStyleBackColor = false;
            this.button_meng_or_del_car.Click += new System.EventHandler(this.button_meng_or_del_car_Click);
            // 
            // button_add_worker
            // 
            this.button_add_worker.BackColor = System.Drawing.Color.Yellow;
            this.button_add_worker.FlatAppearance.BorderSize = 0;
            this.button_add_worker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_worker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add_worker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_add_worker.Location = new System.Drawing.Point(317, 222);
            this.button_add_worker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add_worker.Name = "button_add_worker";
            this.button_add_worker.Size = new System.Drawing.Size(307, 62);
            this.button_add_worker.TabIndex = 38;
            this.button_add_worker.Text = "Dodaj pracownika";
            this.button_add_worker.UseVisualStyleBackColor = false;
            this.button_add_worker.Click += new System.EventHandler(this.button_add_worker_Click);
            // 
            // label_menage_workers
            // 
            this.label_menage_workers.AutoSize = true;
            this.label_menage_workers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_menage_workers.ForeColor = System.Drawing.Color.Yellow;
            this.label_menage_workers.Location = new System.Drawing.Point(315, 172);
            this.label_menage_workers.Margin = new System.Windows.Forms.Padding(0);
            this.label_menage_workers.Name = "label_menage_workers";
            this.label_menage_workers.Size = new System.Drawing.Size(288, 29);
            this.label_menage_workers.TabIndex = 37;
            this.label_menage_workers.Text = "Zarządzaj pracownikami";
            // 
            // pictureBox_help
            // 
            this.pictureBox_help.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_help.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_help.Image")));
            this.pictureBox_help.Location = new System.Drawing.Point(897, 16);
            this.pictureBox_help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_help.Name = "pictureBox_help";
            this.pictureBox_help.Size = new System.Drawing.Size(25, 23);
            this.pictureBox_help.TabIndex = 40;
            this.pictureBox_help.TabStop = false;
            this.pictureBox_help.Click += new System.EventHandler(this.pictureBox_help_Click);
            // 
            // UserControl_menage_workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.pictureBox_help);
            this.Controls.Add(this.button_meng_or_del_car);
            this.Controls.Add(this.button_add_worker);
            this.Controls.Add(this.label_menage_workers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_menage_workers";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_meng_or_del_car;
        private System.Windows.Forms.Button button_add_worker;
        private System.Windows.Forms.Label label_menage_workers;
        private System.Windows.Forms.PictureBox pictureBox_help;
    }
}
