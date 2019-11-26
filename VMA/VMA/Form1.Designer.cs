namespace VMA
{
    partial class Form_login
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
            this.textBox_login_name = new System.Windows.Forms.TextBox();
            this.textBox_login_password = new System.Windows.Forms.TextBox();
            this.button_sign_in = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBox_login_name
            // 
            this.textBox_login_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBox_login_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_login_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_login_name.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_login_name.Location = new System.Drawing.Point(96, 61);
            this.textBox_login_name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_login_name.Name = "textBox_login_name";
            this.textBox_login_name.Size = new System.Drawing.Size(130, 19);
            this.textBox_login_name.TabIndex = 0;
            this.textBox_login_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_login_password
            // 
            this.textBox_login_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBox_login_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_login_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_login_password.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_login_password.Location = new System.Drawing.Point(96, 118);
            this.textBox_login_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_login_password.Name = "textBox_login_password";
            this.textBox_login_password.PasswordChar = '*';
            this.textBox_login_password.Size = new System.Drawing.Size(130, 19);
            this.textBox_login_password.TabIndex = 1;
            this.textBox_login_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_sign_in
            // 
            this.button_sign_in.BackColor = System.Drawing.Color.Yellow;
            this.button_sign_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_sign_in.FlatAppearance.BorderSize = 0;
            this.button_sign_in.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.button_sign_in.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.button_sign_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sign_in.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_sign_in.Location = new System.Drawing.Point(72, 176);
            this.button_sign_in.Margin = new System.Windows.Forms.Padding(2);
            this.button_sign_in.Name = "button_sign_in";
            this.button_sign_in.Size = new System.Drawing.Size(154, 40);
            this.button_sign_in.TabIndex = 2;
            this.button_sign_in.Text = "Zaloguj się";
            this.button_sign_in.UseVisualStyleBackColor = false;
            this.button_sign_in.Click += new System.EventHandler(this.button_sign_in_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(72, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(72, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(72, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 5;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(288, 253);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_sign_in);
            this.Controls.Add(this.textBox_login_password);
            this.Controls.Add(this.textBox_login_name);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(304, 292);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(304, 292);
            this.Name = "Form_login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicles Management App";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login_name;
        private System.Windows.Forms.TextBox textBox_login_password;
        private System.Windows.Forms.Button button_sign_in;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

