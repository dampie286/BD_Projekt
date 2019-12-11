namespace VMA
{
    partial class UserControl_menage_cars
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
            this.button_meng_or_del_car = new System.Windows.Forms.Button();
            this.button_add_car = new System.Windows.Forms.Button();
            this.label_menage_cars = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_meng_or_del_car
            // 
            this.button_meng_or_del_car.BackColor = System.Drawing.Color.Yellow;
            this.button_meng_or_del_car.FlatAppearance.BorderSize = 0;
            this.button_meng_or_del_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_meng_or_del_car.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_meng_or_del_car.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_meng_or_del_car.Location = new System.Drawing.Point(225, 281);
            this.button_meng_or_del_car.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_meng_or_del_car.Name = "button_meng_or_del_car";
            this.button_meng_or_del_car.Size = new System.Drawing.Size(232, 52);
            this.button_meng_or_del_car.TabIndex = 36;
            this.button_meng_or_del_car.Text = "Modyfikuj lub usuń pojazd";
            this.button_meng_or_del_car.UseVisualStyleBackColor = false;
            this.button_meng_or_del_car.Click += new System.EventHandler(this.button_meng_or_del_car_Click);
            // 
            // button_add_car
            // 
            this.button_add_car.BackColor = System.Drawing.Color.Yellow;
            this.button_add_car.FlatAppearance.BorderSize = 0;
            this.button_add_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_car.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add_car.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_add_car.Location = new System.Drawing.Point(225, 183);
            this.button_add_car.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_add_car.Name = "button_add_car";
            this.button_add_car.Size = new System.Drawing.Size(232, 52);
            this.button_add_car.TabIndex = 35;
            this.button_add_car.Text = "Dodaj pojazd";
            this.button_add_car.UseVisualStyleBackColor = false;
            this.button_add_car.Click += new System.EventHandler(this.button_add_car_Click);
            // 
            // label_menage_cars
            // 
            this.label_menage_cars.AutoSize = true;
            this.label_menage_cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold);
            this.label_menage_cars.ForeColor = System.Drawing.Color.Yellow;
            this.label_menage_cars.Location = new System.Drawing.Point(242, 127);
            this.label_menage_cars.Margin = new System.Windows.Forms.Padding(0);
            this.label_menage_cars.Name = "label_menage_cars";
            this.label_menage_cars.Size = new System.Drawing.Size(201, 24);
            this.label_menage_cars.TabIndex = 34;
            this.label_menage_cars.Text = "Zarządzaj pojazdami";
            // 
            // UserControl_menage_cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.button_meng_or_del_car);
            this.Controls.Add(this.button_add_car);
            this.Controls.Add(this.label_menage_cars);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl_menage_cars";
            this.Size = new System.Drawing.Size(706, 533);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_meng_or_del_car;
        private System.Windows.Forms.Button button_add_car;
        private System.Windows.Forms.Label label_menage_cars;
    }
}
