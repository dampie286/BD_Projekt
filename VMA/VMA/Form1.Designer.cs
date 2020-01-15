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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.textBox_login_name = new System.Windows.Forms.TextBox();
            this.textBox_login_password = new System.Windows.Forms.TextBox();
            this.button_sign_in = new System.Windows.Forms.Button();
            this.panel_underline_pass = new System.Windows.Forms.Panel();
            this.panel_underline_login = new System.Windows.Forms.Panel();
            this.pictureBox_pass_symbol = new System.Windows.Forms.PictureBox();
            this.pictureBox_login_symbol = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pass_symbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login_symbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_login_name
            // 
            this.textBox_login_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBox_login_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_login_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_login_name.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_login_name.Location = new System.Drawing.Point(93, 61);
            this.textBox_login_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_login_name.Name = "textBox_login_name";
            this.textBox_login_name.Size = new System.Drawing.Size(133, 19);
            this.textBox_login_name.TabIndex = 0;
            this.textBox_login_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_login_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_login_name_KeyPress);
            // 
            // textBox_login_password
            // 
            this.textBox_login_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBox_login_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_login_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_login_password.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_login_password.Location = new System.Drawing.Point(93, 118);
            this.textBox_login_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_login_password.Name = "textBox_login_password";
            this.textBox_login_password.PasswordChar = '*';
            this.textBox_login_password.Size = new System.Drawing.Size(133, 19);
            this.textBox_login_password.TabIndex = 1;
            this.textBox_login_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_login_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_login_password_KeyPress);
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
            this.button_sign_in.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_sign_in.Name = "button_sign_in";
            this.button_sign_in.Size = new System.Drawing.Size(154, 40);
            this.button_sign_in.TabIndex = 2;
            this.button_sign_in.Text = "Zaloguj się";
            this.button_sign_in.UseVisualStyleBackColor = false;
            this.button_sign_in.Click += new System.EventHandler(this.button_sign_in_Click);
            this.button_sign_in.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_sign_in_KeyDown);
            // 
            // panel_underline_pass
            // 
            this.panel_underline_pass.BackColor = System.Drawing.Color.Yellow;
            this.panel_underline_pass.Location = new System.Drawing.Point(72, 140);
            this.panel_underline_pass.Name = "panel_underline_pass";
            this.panel_underline_pass.Size = new System.Drawing.Size(154, 1);
            this.panel_underline_pass.TabIndex = 3;
            // 
            // panel_underline_login
            // 
            this.panel_underline_login.BackColor = System.Drawing.Color.Yellow;
            this.panel_underline_login.Location = new System.Drawing.Point(72, 83);
            this.panel_underline_login.Name = "panel_underline_login";
            this.panel_underline_login.Size = new System.Drawing.Size(154, 1);
            this.panel_underline_login.TabIndex = 4;
            // 
            // pictureBox_pass_symbol
            // 
            this.pictureBox_pass_symbol.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_pass_symbol.ErrorImage = null;
            this.pictureBox_pass_symbol.Image = global::VMA.Properties.Resources._lock;
            this.pictureBox_pass_symbol.InitialImage = null;
            this.pictureBox_pass_symbol.Location = new System.Drawing.Point(72, 118);
            this.pictureBox_pass_symbol.Name = "pictureBox_pass_symbol";
            this.pictureBox_pass_symbol.Size = new System.Drawing.Size(19, 19);
            this.pictureBox_pass_symbol.TabIndex = 6;
            this.pictureBox_pass_symbol.TabStop = false;
            // 
            // pictureBox_login_symbol
            // 
            this.pictureBox_login_symbol.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_login_symbol.ErrorImage = null;
            this.pictureBox_login_symbol.Image = global::VMA.Properties.Resources.user_alt;
            this.pictureBox_login_symbol.InitialImage = null;
            this.pictureBox_login_symbol.Location = new System.Drawing.Point(72, 61);
            this.pictureBox_login_symbol.Name = "pictureBox_login_symbol";
            this.pictureBox_login_symbol.Size = new System.Drawing.Size(19, 19);
            this.pictureBox_login_symbol.TabIndex = 5;
            this.pictureBox_login_symbol.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(287, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_pass_symbol);
            this.Controls.Add(this.pictureBox_login_symbol);
            this.Controls.Add(this.panel_underline_login);
            this.Controls.Add(this.panel_underline_pass);
            this.Controls.Add(this.button_sign_in);
            this.Controls.Add(this.textBox_login_password);
            this.Controls.Add(this.textBox_login_name);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(303, 291);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(303, 291);
            this.Name = "Form_login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicles Management App";
            this.Load += new System.EventHandler(this.Form_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pass_symbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login_symbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login_name;
        private System.Windows.Forms.TextBox textBox_login_password;
        private System.Windows.Forms.Button button_sign_in;
        private System.Windows.Forms.Panel panel_underline_pass;
        private System.Windows.Forms.Panel panel_underline_login;
        private System.Windows.Forms.PictureBox pictureBox_login_symbol;
        private System.Windows.Forms.PictureBox pictureBox_pass_symbol;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

