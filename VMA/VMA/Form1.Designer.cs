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
            this.textBox_login_name.Location = new System.Drawing.Point(98, 77);
            this.textBox_login_name.MaximumSize = new System.Drawing.Size(204, 38);
            this.textBox_login_name.MinimumSize = new System.Drawing.Size(204, 38);
            this.textBox_login_name.Name = "textBox_login_name";
            this.textBox_login_name.Size = new System.Drawing.Size(204, 22);
            this.textBox_login_name.TabIndex = 0;
            // 
            // textBox_login_password
            // 
            this.textBox_login_password.Location = new System.Drawing.Point(98, 144);
            this.textBox_login_password.MaximumSize = new System.Drawing.Size(204, 38);
            this.textBox_login_password.MinimumSize = new System.Drawing.Size(204, 38);
            this.textBox_login_password.Name = "textBox_login_password";
            this.textBox_login_password.PasswordChar = '*';
            this.textBox_login_password.Size = new System.Drawing.Size(204, 22);
            this.textBox_login_password.TabIndex = 1;
            // 
            // button_sign_in
            // 
            this.button_sign_in.Location = new System.Drawing.Point(120, 226);
            this.button_sign_in.MaximumSize = new System.Drawing.Size(161, 40);
            this.button_sign_in.MinimumSize = new System.Drawing.Size(161, 40);
            this.button_sign_in.Name = "button_sign_in";
            this.button_sign_in.Size = new System.Drawing.Size(161, 40);
            this.button_sign_in.TabIndex = 2;
            this.button_sign_in.Text = "Zaloguj się";
            this.button_sign_in.UseVisualStyleBackColor = true;
            this.button_sign_in.Click += new System.EventHandler(this.button_sign_in_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(382, 303);
            this.Controls.Add(this.button_sign_in);
            this.Controls.Add(this.textBox_login_password);
            this.Controls.Add(this.textBox_login_name);
            this.MaximumSize = new System.Drawing.Size(400, 350);
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VM Application";
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

