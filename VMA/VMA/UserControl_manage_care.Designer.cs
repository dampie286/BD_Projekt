namespace VMA
{
    partial class UserControl_manage_care
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_manage_care));
            this.button_reserve_block_car = new System.Windows.Forms.Button();
            this.button_send_receive_car = new System.Windows.Forms.Button();
            this.label_menage_keepers = new System.Windows.Forms.Label();
            this.pictureBox_help = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).BeginInit();
            this.SuspendLayout();
            // 
            // button_reserve_block_car
            // 
            this.button_reserve_block_car.BackColor = System.Drawing.Color.Yellow;
            this.button_reserve_block_car.FlatAppearance.BorderSize = 0;
            this.button_reserve_block_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reserve_block_car.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_reserve_block_car.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_reserve_block_car.Location = new System.Drawing.Point(317, 320);
            this.button_reserve_block_car.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_reserve_block_car.Name = "button_reserve_block_car";
            this.button_reserve_block_car.Size = new System.Drawing.Size(307, 62);
            this.button_reserve_block_car.TabIndex = 45;
            this.button_reserve_block_car.Text = "Rezerwuj / blokuj samochód";
            this.button_reserve_block_car.UseVisualStyleBackColor = false;
            this.button_reserve_block_car.Click += new System.EventHandler(this.button_reserve_block_car_Click);
            // 
            // button_send_receive_car
            // 
            this.button_send_receive_car.BackColor = System.Drawing.Color.Yellow;
            this.button_send_receive_car.FlatAppearance.BorderSize = 0;
            this.button_send_receive_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_send_receive_car.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_send_receive_car.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_send_receive_car.Location = new System.Drawing.Point(317, 222);
            this.button_send_receive_car.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_send_receive_car.Name = "button_send_receive_car";
            this.button_send_receive_car.Size = new System.Drawing.Size(307, 62);
            this.button_send_receive_car.TabIndex = 44;
            this.button_send_receive_car.Text = "Wyślij pojazd do serwisu";
            this.button_send_receive_car.UseVisualStyleBackColor = false;
            this.button_send_receive_car.Click += new System.EventHandler(this.button_send_receive_car_Click);
            // 
            // label_menage_keepers
            // 
            this.label_menage_keepers.AutoSize = true;
            this.label_menage_keepers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_menage_keepers.ForeColor = System.Drawing.Color.Yellow;
            this.label_menage_keepers.Location = new System.Drawing.Point(337, 172);
            this.label_menage_keepers.Margin = new System.Windows.Forms.Padding(0);
            this.label_menage_keepers.Name = "label_menage_keepers";
            this.label_menage_keepers.Size = new System.Drawing.Size(246, 29);
            this.label_menage_keepers.TabIndex = 43;
            this.label_menage_keepers.Text = "Zarządzaj pojazdami";
            // 
            // pictureBox_help
            // 
            this.pictureBox_help.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_help.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_help.Image")));
            this.pictureBox_help.Location = new System.Drawing.Point(898, 15);
            this.pictureBox_help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_help.Name = "pictureBox_help";
            this.pictureBox_help.Size = new System.Drawing.Size(25, 23);
            this.pictureBox_help.TabIndex = 46;
            this.pictureBox_help.TabStop = false;
            this.pictureBox_help.Click += new System.EventHandler(this.pictureBox_help_Click);
            // 
            // UserControl_manage_care
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.pictureBox_help);
            this.Controls.Add(this.button_reserve_block_car);
            this.Controls.Add(this.button_send_receive_car);
            this.Controls.Add(this.label_menage_keepers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_manage_care";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_reserve_block_car;
        private System.Windows.Forms.Button button_send_receive_car;
        private System.Windows.Forms.Label label_menage_keepers;
        private System.Windows.Forms.PictureBox pictureBox_help;
    }
}
