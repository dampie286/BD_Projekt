namespace VMA
{
    partial class UserControl_addKeeper
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
            this.dataGridView_Worker = new System.Windows.Forms.DataGridView();
            this.dataGridView_veh = new System.Windows.Forms.DataGridView();
            this.add_care = new System.Windows.Forms.Button();
            this.label_information_about_car = new System.Windows.Forms.Label();
            this.label_surrname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_license = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.label_brand = new System.Windows.Forms.Label();
            this.label_desc_my_choice = new System.Windows.Forms.Label();
            this.label_desc_to = new System.Windows.Forms.Label();
            this.label_desc_purpose = new System.Windows.Forms.Label();
            this.label_desc_from = new System.Windows.Forms.Label();
            this.label_desc_model = new System.Windows.Forms.Label();
            this.label_desc_brand = new System.Windows.Forms.Label();
            this.label_postion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Worker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_veh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Worker
            // 
            this.dataGridView_Worker.AllowUserToAddRows = false;
            this.dataGridView_Worker.AllowUserToDeleteRows = false;
            this.dataGridView_Worker.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_Worker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Worker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Worker.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_Worker.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_Worker.Location = new System.Drawing.Point(0, 42);
            this.dataGridView_Worker.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_Worker.Name = "dataGridView_Worker";
            this.dataGridView_Worker.ReadOnly = true;
            this.dataGridView_Worker.RowTemplate.Height = 24;
            this.dataGridView_Worker.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Worker.Size = new System.Drawing.Size(407, 253);
            this.dataGridView_Worker.TabIndex = 46;
            this.dataGridView_Worker.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Worker_CellClick);
            // 
            // dataGridView_veh
            // 
            this.dataGridView_veh.AllowUserToAddRows = false;
            this.dataGridView_veh.AllowUserToDeleteRows = false;
            this.dataGridView_veh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_veh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_veh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_veh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_veh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_veh.Location = new System.Drawing.Point(540, 42);
            this.dataGridView_veh.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_veh.Name = "dataGridView_veh";
            this.dataGridView_veh.ReadOnly = true;
            this.dataGridView_veh.RowTemplate.Height = 24;
            this.dataGridView_veh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_veh.Size = new System.Drawing.Size(401, 253);
            this.dataGridView_veh.TabIndex = 47;
            this.dataGridView_veh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_veh_CellClick);
            // 
            // add_care
            // 
            this.add_care.BackColor = System.Drawing.Color.Yellow;
            this.add_care.FlatAppearance.BorderSize = 0;
            this.add_care.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_care.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_care.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.add_care.Location = new System.Drawing.Point(740, 592);
            this.add_care.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_care.Name = "add_care";
            this.add_care.Size = new System.Drawing.Size(173, 31);
            this.add_care.TabIndex = 83;
            this.add_care.Text = "Przypisz auto";
            this.add_care.UseVisualStyleBackColor = false;
            this.add_care.Click += new System.EventHandler(this.add_care_Click);
            // 
            // label_information_about_car
            // 
            this.label_information_about_car.AutoSize = true;
            this.label_information_about_car.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_information_about_car.ForeColor = System.Drawing.Color.Yellow;
            this.label_information_about_car.Location = new System.Drawing.Point(28, 0);
            this.label_information_about_car.Margin = new System.Windows.Forms.Padding(0);
            this.label_information_about_car.Name = "label_information_about_car";
            this.label_information_about_car.Size = new System.Drawing.Size(193, 29);
            this.label_information_about_car.TabIndex = 84;
            this.label_information_about_car.Text = "Dodaj opiekuna";
            // 
            // label_surrname
            // 
            this.label_surrname.AutoSize = true;
            this.label_surrname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_surrname.ForeColor = System.Drawing.Color.Yellow;
            this.label_surrname.Location = new System.Drawing.Point(478, 524);
            this.label_surrname.Margin = new System.Windows.Forms.Padding(0);
            this.label_surrname.Name = "label_surrname";
            this.label_surrname.Size = new System.Drawing.Size(0, 24);
            this.label_surrname.TabIndex = 95;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.ForeColor = System.Drawing.Color.Yellow;
            this.label_name.Location = new System.Drawing.Point(478, 474);
            this.label_name.Margin = new System.Windows.Forms.Padding(0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 24);
            this.label_name.TabIndex = 94;
            // 
            // label_license
            // 
            this.label_license.AutoSize = true;
            this.label_license.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_license.ForeColor = System.Drawing.Color.Yellow;
            this.label_license.Location = new System.Drawing.Point(193, 574);
            this.label_license.Margin = new System.Windows.Forms.Padding(0);
            this.label_license.Name = "label_license";
            this.label_license.Size = new System.Drawing.Size(0, 24);
            this.label_license.TabIndex = 93;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_model.Location = new System.Drawing.Point(193, 524);
            this.label_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(0, 24);
            this.label_model.TabIndex = 92;
            // 
            // label_brand
            // 
            this.label_brand.AutoSize = true;
            this.label_brand.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_brand.Location = new System.Drawing.Point(193, 474);
            this.label_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(0, 24);
            this.label_brand.TabIndex = 91;
            // 
            // label_desc_my_choice
            // 
            this.label_desc_my_choice.AutoSize = true;
            this.label_desc_my_choice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc_my_choice.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_my_choice.Location = new System.Drawing.Point(119, 409);
            this.label_desc_my_choice.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_my_choice.Name = "label_desc_my_choice";
            this.label_desc_my_choice.Size = new System.Drawing.Size(177, 29);
            this.label_desc_my_choice.TabIndex = 90;
            this.label_desc_my_choice.Text = "Nowy opiekun";
            // 
            // label_desc_to
            // 
            this.label_desc_to.AutoSize = true;
            this.label_desc_to.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_to.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_to.Location = new System.Drawing.Point(379, 524);
            this.label_desc_to.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_to.Name = "label_desc_to";
            this.label_desc_to.Size = new System.Drawing.Size(99, 23);
            this.label_desc_to.TabIndex = 89;
            this.label_desc_to.Text = "Nazwisko:";
            // 
            // label_desc_purpose
            // 
            this.label_desc_purpose.AutoSize = true;
            this.label_desc_purpose.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_purpose.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_purpose.Location = new System.Drawing.Point(76, 574);
            this.label_desc_purpose.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_purpose.Name = "label_desc_purpose";
            this.label_desc_purpose.Size = new System.Drawing.Size(115, 23);
            this.label_desc_purpose.TabIndex = 88;
            this.label_desc_purpose.Text = "Rejestracja:";
            // 
            // label_desc_from
            // 
            this.label_desc_from.AutoSize = true;
            this.label_desc_from.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_from.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_from.Location = new System.Drawing.Point(425, 474);
            this.label_desc_from.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_from.Name = "label_desc_from";
            this.label_desc_from.Size = new System.Drawing.Size(53, 23);
            this.label_desc_from.TabIndex = 87;
            this.label_desc_from.Text = "Imię:";
            // 
            // label_desc_model
            // 
            this.label_desc_model.AutoSize = true;
            this.label_desc_model.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_model.Location = new System.Drawing.Point(121, 524);
            this.label_desc_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_model.Name = "label_desc_model";
            this.label_desc_model.Size = new System.Drawing.Size(70, 23);
            this.label_desc_model.TabIndex = 86;
            this.label_desc_model.Text = "Model:";
            // 
            // label_desc_brand
            // 
            this.label_desc_brand.AutoSize = true;
            this.label_desc_brand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_brand.Location = new System.Drawing.Point(121, 474);
            this.label_desc_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_brand.Name = "label_desc_brand";
            this.label_desc_brand.Size = new System.Drawing.Size(72, 23);
            this.label_desc_brand.TabIndex = 85;
            this.label_desc_brand.Text = "Marka:";
            // 
            // label_postion
            // 
            this.label_postion.AutoSize = true;
            this.label_postion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_postion.ForeColor = System.Drawing.Color.Yellow;
            this.label_postion.Location = new System.Drawing.Point(478, 574);
            this.label_postion.Margin = new System.Windows.Forms.Padding(0);
            this.label_postion.Name = "label_postion";
            this.label_postion.Size = new System.Drawing.Size(0, 24);
            this.label_postion.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(394, 573);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 96;
            this.label4.Text = "Pozycja:";
            // 
            // UserControl_addKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.label_postion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_surrname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_license);
            this.Controls.Add(this.label_model);
            this.Controls.Add(this.label_brand);
            this.Controls.Add(this.label_desc_my_choice);
            this.Controls.Add(this.label_desc_to);
            this.Controls.Add(this.label_desc_purpose);
            this.Controls.Add(this.label_desc_from);
            this.Controls.Add(this.label_desc_model);
            this.Controls.Add(this.label_desc_brand);
            this.Controls.Add(this.label_information_about_car);
            this.Controls.Add(this.add_care);
            this.Controls.Add(this.dataGridView_veh);
            this.Controls.Add(this.dataGridView_Worker);
            this.Name = "UserControl_addKeeper";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Worker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_veh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Worker;
        private System.Windows.Forms.DataGridView dataGridView_veh;
        private System.Windows.Forms.Button add_care;
        private System.Windows.Forms.Label label_information_about_car;
        private System.Windows.Forms.Label label_surrname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_license;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_brand;
        private System.Windows.Forms.Label label_desc_my_choice;
        private System.Windows.Forms.Label label_desc_to;
        private System.Windows.Forms.Label label_desc_purpose;
        private System.Windows.Forms.Label label_desc_from;
        private System.Windows.Forms.Label label_desc_model;
        private System.Windows.Forms.Label label_desc_brand;
        private System.Windows.Forms.Label label_postion;
        private System.Windows.Forms.Label label4;
    }
}
