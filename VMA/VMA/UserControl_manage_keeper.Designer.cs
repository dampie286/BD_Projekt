namespace VMA
{
    partial class UserControl_manage_keeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_manage_keeper));
            this.button_meng_or_del_keeper = new System.Windows.Forms.Button();
            this.button_add_keeper = new System.Windows.Forms.Button();
            this.label_menage_keepers = new System.Windows.Forms.Label();
            this.pictureBox_help = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).BeginInit();
            this.SuspendLayout();
            // 
            // button_meng_or_del_keeper
            // 
            this.button_meng_or_del_keeper.BackColor = System.Drawing.Color.Yellow;
            this.button_meng_or_del_keeper.FlatAppearance.BorderSize = 0;
            this.button_meng_or_del_keeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_meng_or_del_keeper.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_meng_or_del_keeper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_meng_or_del_keeper.Location = new System.Drawing.Point(317, 320);
            this.button_meng_or_del_keeper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_meng_or_del_keeper.Name = "button_meng_or_del_keeper";
            this.button_meng_or_del_keeper.Size = new System.Drawing.Size(307, 62);
            this.button_meng_or_del_keeper.TabIndex = 42;
            this.button_meng_or_del_keeper.Text = "Modyfikuj lub usuń opiekuna";
            this.button_meng_or_del_keeper.UseVisualStyleBackColor = false;
            this.button_meng_or_del_keeper.Click += new System.EventHandler(this.button_meng_or_del_keeper_Click);
            // 
            // button_add_keeper
            // 
            this.button_add_keeper.BackColor = System.Drawing.Color.Yellow;
            this.button_add_keeper.FlatAppearance.BorderSize = 0;
            this.button_add_keeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_keeper.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add_keeper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_add_keeper.Location = new System.Drawing.Point(317, 222);
            this.button_add_keeper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add_keeper.Name = "button_add_keeper";
            this.button_add_keeper.Size = new System.Drawing.Size(307, 62);
            this.button_add_keeper.TabIndex = 41;
            this.button_add_keeper.Text = "Dodaj opiekuna";
            this.button_add_keeper.UseVisualStyleBackColor = false;
            this.button_add_keeper.Click += new System.EventHandler(this.button_add_keeper_Click);
            // 
            // label_menage_keepers
            // 
            this.label_menage_keepers.AutoSize = true;
            this.label_menage_keepers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_menage_keepers.ForeColor = System.Drawing.Color.Yellow;
            this.label_menage_keepers.Location = new System.Drawing.Point(329, 172);
            this.label_menage_keepers.Margin = new System.Windows.Forms.Padding(0);
            this.label_menage_keepers.Name = "label_menage_keepers";
            this.label_menage_keepers.Size = new System.Drawing.Size(262, 29);
            this.label_menage_keepers.TabIndex = 40;
            this.label_menage_keepers.Text = "Zarządzaj opiekunami";
            // 
            // pictureBox_help
            // 
            this.pictureBox_help.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_help.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_help.Image")));
            this.pictureBox_help.Location = new System.Drawing.Point(883, 22);
            this.pictureBox_help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_help.Name = "pictureBox_help";
            this.pictureBox_help.Size = new System.Drawing.Size(25, 23);
            this.pictureBox_help.TabIndex = 43;
            this.pictureBox_help.TabStop = false;
            this.pictureBox_help.Click += new System.EventHandler(this.pictureBox_help_Click);
            // 
            // UserControl_manage_keeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.pictureBox_help);
            this.Controls.Add(this.button_meng_or_del_keeper);
            this.Controls.Add(this.button_add_keeper);
            this.Controls.Add(this.label_menage_keepers);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_manage_keeper";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_meng_or_del_keeper;
        private System.Windows.Forms.Button button_add_keeper;
        private System.Windows.Forms.Label label_menage_keepers;
        private System.Windows.Forms.PictureBox pictureBox_help;
    }
}
