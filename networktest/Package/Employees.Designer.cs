namespace networktest
{
    partial class Employees
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_employees = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.add_button = new networktest.RJRoundedGradientButton();
            this.emp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.dataGridView_employees);
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(11, 59);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1092, 524);
            this.panel7.TabIndex = 46;
            this.panel7.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::networktest.Properties.Resources.rotate;
            this.pictureBox1.Location = new System.Drawing.Point(21, 495);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView_employees
            // 
            this.dataGridView_employees.AllowUserToAddRows = false;
            this.dataGridView_employees.AllowUserToResizeColumns = false;
            this.dataGridView_employees.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_employees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_employees.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_employees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_employees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_employees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_employees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_employees.ColumnHeadersHeight = 35;
            this.dataGridView_employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emp_id,
            this.emp_name,
            this.emp_job,
            this.edit,
            this.delete});
            this.dataGridView_employees.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_employees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_employees.EnableHeadersVisualStyles = false;
            this.dataGridView_employees.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView_employees.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_employees.Name = "dataGridView_employees";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_employees.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_employees.RowHeadersVisible = false;
            this.dataGridView_employees.RowHeadersWidth = 25;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("LBC", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_employees.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_employees.RowTemplate.Height = 29;
            this.dataGridView_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_employees.Size = new System.Drawing.Size(1092, 524);
            this.dataGridView_employees.TabIndex = 1;
            this.dataGridView_employees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            this.dataGridView_employees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            this.dataGridView_employees.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            this.dataGridView_employees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGrid_KeyDown);
            this.dataGridView_employees.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.panel7;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 30;
            this.bunifuElipse5.TargetControl = this.dataGridView_employees;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 30;
            this.bunifuElipse6.TargetControl = this;
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 30;
            this.bunifuElipse7.TargetControl = this;
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_button.BackColor = System.Drawing.Color.White;
            this.add_button.BackgroundColor = System.Drawing.Color.White;
            this.add_button.BorderRadius = 20;
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.GradientAngle = 45F;
            this.add_button.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(110)))), ((int)(((byte)(184)))));
            this.add_button.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.add_button.Location = new System.Drawing.Point(908, 12);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(187, 33);
            this.add_button.TabIndex = 51;
            this.add_button.Text = "إضافة موظف جديد";
            this.add_button.TextColor = System.Drawing.Color.White;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.rjRoundedGradientButton1_Click);
            this.add_button.MouseEnter += new System.EventHandler(this.add_button_MouseEnter);
            this.add_button.MouseLeave += new System.EventHandler(this.add_button_MouseLeave);
            // 
            // emp_id
            // 
            this.emp_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emp_id.DataPropertyName = "emp_id";
            this.emp_id.FillWeight = 80F;
            this.emp_id.HeaderText = "رقم الموظف";
            this.emp_id.MinimumWidth = 8;
            this.emp_id.Name = "emp_id";
            this.emp_id.ReadOnly = true;
            // 
            // emp_name
            // 
            this.emp_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emp_name.DataPropertyName = "emp_name";
            this.emp_name.FillWeight = 80F;
            this.emp_name.HeaderText = "اسم الموظف";
            this.emp_name.MinimumWidth = 8;
            this.emp_name.Name = "emp_name";
            // 
            // emp_job
            // 
            this.emp_job.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emp_job.DataPropertyName = "emp_job";
            this.emp_job.FillWeight = 80F;
            this.emp_job.HeaderText = "الوظيفة";
            this.emp_job.MinimumWidth = 8;
            this.emp_job.Name = "emp_job";
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.edit.HeaderText = "تعديل";
            this.edit.Image = global::networktest.Properties.Resources.edit;
            this.edit.MinimumWidth = 8;
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Width = 50;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.delete.HeaderText = "حذف";
            this.delete.Image = global::networktest.Properties.Resources.remove;
            this.delete.MinimumWidth = 8;
            this.delete.Name = "delete";
            this.delete.Width = 50;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1115, 595);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.panel7);
            this.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employees";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "HRForm";
            this.Load += new System.EventHandler(this.HRForm_Load);
            this.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private RJRoundedGradientButton add_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        public System.Windows.Forms.DataGridView dataGridView_employees;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_job;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}