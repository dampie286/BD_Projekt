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
            this.SuspendLayout();
            // 
            // textBox_login_name
            // 
            this.textBox_login_name.Location = new System.Drawing.Point(74, 63);
            this.textBox_login_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_login_name.MaximumSize = new System.Drawing.Size(154, 38);
            this.textBox_login_name.MinimumSize = new System.Drawing.Size(154, 38);
            this.textBox_login_name.Name = "textBox_login_name";
            this.textBox_login_name.Size = new System.Drawing.Size(154, 20);
            this.textBox_login_name.TabIndex = 0;
            // 
            // textBox_login_password
            // 
            this.textBox_login_password.Location = new System.Drawing.Point(74, 117);
            this.textBox_login_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_login_password.MaximumSize = new System.Drawing.Size(154, 38);
            this.textBox_login_password.MinimumSize = new System.Drawing.Size(154, 38);
            this.textBox_login_password.Name = "textBox_login_password";
            this.textBox_login_password.PasswordChar = '*';
            this.textBox_login_password.Size = new System.Drawing.Size(154, 20);
            this.textBox_login_password.TabIndex = 1;
            // 
            // button_sign_in
            // 
            this.button_sign_in.Location = new System.Drawing.Point(90, 184);
            this.button_sign_in.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_sign_in.MaximumSize = new System.Drawing.Size(121, 32);
            this.button_sign_in.MinimumSize = new System.Drawing.Size(121, 32);
            this.button_sign_in.Name = "button_sign_in";
            this.button_sign_in.Size = new System.Drawing.Size(121, 32);
            this.button_sign_in.TabIndex = 2;
            this.button_sign_in.Text = "Zaloguj się";
            this.button_sign_in.UseVisualStyleBackColor = true;
            this.button_sign_in.Click += new System.EventHandler(this.button_sign_in_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(288, 253);
            this.Controls.Add(this.button_sign_in);
            this.Controls.Add(this.textBox_login_password);
            this.Controls.Add(this.textBox_login_name);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

