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
            this.button_meng_or_del_keeper = new System.Windows.Forms.Button();
            this.button_add_keeper = new System.Windows.Forms.Button();
            this.label_menage_keepers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_meng_or_del_keeper
            // 
            this.button_meng_or_del_keeper.BackColor = System.Drawing.Color.Yellow;
            this.button_meng_or_del_keeper.FlatAppearance.BorderSize = 0;
            this.button_meng_or_del_keeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_meng_or_del_keeper.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_meng_or_del_keeper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_meng_or_del_keeper.Location = new System.Drawing.Point(287, 325);
            this.button_meng_or_del_keeper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_meng_or_del_keeper.Name = "button_meng_or_del_keeper";
            this.button_meng_or_del_keeper.Size = new System.Drawing.Size(310, 64);
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
            this.button_add_keeper.Location = new System.Drawing.Point(287, 220);
            this.button_add_keeper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add_keeper.Name = "button_add_keeper";
            this.button_add_keeper.Size = new System.Drawing.Size(310, 64);
            this.button_add_keeper.TabIndex = 41;
            this.button_add_keeper.Text = "Dodaj opiekuna";
            this.button_add_keeper.UseVisualStyleBackColor = false;
            this.button_add_keeper.Click += new System.EventHandler(this.button_add_keeper_Click);
            // 
            // label_menage_keepers
            // 
            this.label_menage_keepers.AutoSize = true;
            this.label_menage_keepers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold);
            this.label_menage_keepers.ForeColor = System.Drawing.Color.Yellow;
            this.label_menage_keepers.Location = new System.Drawing.Point(312, 157);
            this.label_menage_keepers.Margin = new System.Windows.Forms.Padding(0);
            this.label_menage_keepers.Name = "label_menage_keepers";
            this.label_menage_keepers.Size = new System.Drawing.Size(267, 29);
            this.label_menage_keepers.TabIndex = 40;
            this.label_menage_keepers.Text = "Zarządzaj opiekunami";
            // 
            // UserControl_manage_keeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.button_meng_or_del_keeper);
            this.Controls.Add(this.button_add_keeper);
            this.Controls.Add(this.label_menage_keepers);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UserControl_manage_keeper";
            this.Size = new System.Drawing.Size(941, 656);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_meng_or_del_keeper;
        private System.Windows.Forms.Button button_add_keeper;
        private System.Windows.Forms.Label label_menage_keepers;
    }
}
