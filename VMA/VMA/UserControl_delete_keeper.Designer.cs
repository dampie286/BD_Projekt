namespace VMA
{
    partial class UserControl_delete_keeper
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_delete_keeper));
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView_keepers_DB = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_filter = new System.Windows.Forms.Button();
            this.textBox_licence_plate = new System.Windows.Forms.TextBox();
            this.textBox_surrname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.pictureBox_help = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_keepers_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).BeginInit();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Yellow;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_delete.Location = new System.Drawing.Point(788, 572);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(133, 41);
            this.button_delete.TabIndex = 86;
            this.button_delete.Text = "Usuń";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dataGridView_keepers_DB
            // 
            this.dataGridView_keepers_DB.AllowUserToAddRows = false;
            this.dataGridView_keepers_DB.AllowUserToDeleteRows = false;
            this.dataGridView_keepers_DB.AllowUserToResizeColumns = false;
            this.dataGridView_keepers_DB.AllowUserToResizeRows = false;
            this.dataGridView_keepers_DB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_keepers_DB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_keepers_DB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_keepers_DB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_keepers_DB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_keepers_DB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_keepers_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_keepers_DB.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_keepers_DB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_keepers_DB.EnableHeadersVisualStyles = false;
            this.dataGridView_keepers_DB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_keepers_DB.Location = new System.Drawing.Point(24, 65);
            this.dataGridView_keepers_DB.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_keepers_DB.MultiSelect = false;
            this.dataGridView_keepers_DB.Name = "dataGridView_keepers_DB";
            this.dataGridView_keepers_DB.ReadOnly = true;
            this.dataGridView_keepers_DB.RowHeadersVisible = false;
            this.dataGridView_keepers_DB.RowTemplate.Height = 24;
            this.dataGridView_keepers_DB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_keepers_DB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_keepers_DB.Size = new System.Drawing.Size(744, 574);
            this.dataGridView_keepers_DB.TabIndex = 84;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(317, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 1);
            this.panel3.TabIndex = 82;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(171, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 1);
            this.panel2.TabIndex = 83;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(24, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 1);
            this.panel1.TabIndex = 81;
            // 
            // button_filter
            // 
            this.button_filter.BackColor = System.Drawing.Color.Yellow;
            this.button_filter.FlatAppearance.BorderSize = 0;
            this.button_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_filter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_filter.Location = new System.Drawing.Point(464, 12);
            this.button_filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(133, 41);
            this.button_filter.TabIndex = 80;
            this.button_filter.Text = "Filtruj";
            this.button_filter.UseVisualStyleBackColor = false;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // textBox_licence_plate
            // 
            this.textBox_licence_plate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_licence_plate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_licence_plate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_licence_plate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_licence_plate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_licence_plate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.textBox_licence_plate.Location = new System.Drawing.Point(317, 23);
            this.textBox_licence_plate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_licence_plate.MaximumSize = new System.Drawing.Size(120, 25);
            this.textBox_licence_plate.MinimumSize = new System.Drawing.Size(5, 15);
            this.textBox_licence_plate.Name = "textBox_licence_plate";
            this.textBox_licence_plate.Size = new System.Drawing.Size(120, 19);
            this.textBox_licence_plate.TabIndex = 79;
            this.textBox_licence_plate.Text = "Rejestracja";
            this.textBox_licence_plate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_licence_plate.Enter += new System.EventHandler(this.textBox_position_Enter);
            this.textBox_licence_plate.Leave += new System.EventHandler(this.textBox_position_Leave);
            // 
            // textBox_surrname
            // 
            this.textBox_surrname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox_surrname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_surrname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_surrname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_surrname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_surrname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.textBox_surrname.Location = new System.Drawing.Point(171, 23);
            this.textBox_surrname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_surrname.MaximumSize = new System.Drawing.Size(120, 25);
            this.textBox_surrname.MinimumSize = new System.Drawing.Size(5, 15);
            this.textBox_surrname.Name = "textBox_surrname";
            this.textBox_surrname.Size = new System.Drawing.Size(120, 19);
            this.textBox_surrname.TabIndex = 78;
            this.textBox_surrname.Text = "Nazwisko";
            this.textBox_surrname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_surrname.Enter += new System.EventHandler(this.textBox_surrname_Enter);
            this.textBox_surrname.Leave += new System.EventHandler(this.textBox_surrname_Leave);
            // 
            // textBox_name
            // 
            this.textBox_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_name.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.textBox_name.Location = new System.Drawing.Point(24, 23);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_name.MaximumSize = new System.Drawing.Size(120, 25);
            this.textBox_name.MinimumSize = new System.Drawing.Size(5, 15);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(120, 19);
            this.textBox_name.TabIndex = 77;
            this.textBox_name.Text = "Imię";
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_name.Enter += new System.EventHandler(this.textBox_name_Enter);
            this.textBox_name.Leave += new System.EventHandler(this.textBox_name_Leave);
            // 
            // pictureBox_help
            // 
            this.pictureBox_help.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_help.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_help.Image")));
            this.pictureBox_help.Location = new System.Drawing.Point(896, 12);
            this.pictureBox_help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_help.Name = "pictureBox_help";
            this.pictureBox_help.Size = new System.Drawing.Size(25, 23);
            this.pictureBox_help.TabIndex = 87;
            this.pictureBox_help.TabStop = false;
            this.pictureBox_help.Click += new System.EventHandler(this.pictureBox_help_Click);
            // 
            // UserControl_delete_keeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.pictureBox_help);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.dataGridView_keepers_DB);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.textBox_licence_plate);
            this.Controls.Add(this.textBox_surrname);
            this.Controls.Add(this.textBox_name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_delete_keeper";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_keepers_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dataGridView_keepers_DB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.TextBox textBox_licence_plate;
        private System.Windows.Forms.TextBox textBox_surrname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.PictureBox pictureBox_help;
    }
}
