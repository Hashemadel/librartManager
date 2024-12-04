namespace networktest
{
    partial class Add_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_user));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_pass = new networktest.RJControls.RJTextBox();
            this.txt_user_name = new networktest.RJControls.RJTextBox();
            this.txt_imp_name = new networktest.RJControls.RJTextBox();
            this.btn_feeding = new System.Windows.Forms.Button();
            this.label_mul_pass = new System.Windows.Forms.Label();
            this.label_mul_userName = new System.Windows.Forms.Label();
            this.label_mul_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.MTypeToggle = new Sipaa.Framework.SToggleButton();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.MTypeToggle);
            this.panel3.Controls.Add(this.txt_pass);
            this.panel3.Controls.Add(this.txt_user_name);
            this.panel3.Controls.Add(this.txt_imp_name);
            this.panel3.Controls.Add(this.btn_feeding);
            this.panel3.Controls.Add(this.label_mul_pass);
            this.panel3.Controls.Add(this.label_mul_userName);
            this.panel3.Controls.Add(this.label_mul_name);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(12, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 350);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txt_pass
            // 
            this.txt_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.txt_pass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(186)))));
            this.txt_pass.BorderRadius = 10;
            this.txt_pass.BorderSize = 2;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Font = new System.Drawing.Font("LBC", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.LightGray;
            this.txt_pass.Location = new System.Drawing.Point(122, 239);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Multiline = false;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_pass.PasswordChar = false;
            this.txt_pass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_pass.PlaceholderText = "";
            this.txt_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_pass.SelectionStart = 0;
            this.txt_pass.Size = new System.Drawing.Size(268, 38);
            this.txt_pass.TabIndex = 52;
            this.txt_pass.Texts = "";
            this.txt_pass.UnderlinedStyle = false;
            this.txt_pass.Enter += new System.EventHandler(this.TextBox2_Enter);
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyDown_1);
            // 
            // txt_user_name
            // 
            this.txt_user_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_user_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_user_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_user_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_user_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.txt_user_name.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(186)))));
            this.txt_user_name.BorderRadius = 10;
            this.txt_user_name.BorderSize = 2;
            this.txt_user_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_name.Font = new System.Drawing.Font("LBC", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.ForeColor = System.Drawing.Color.LightGray;
            this.txt_user_name.Location = new System.Drawing.Point(122, 163);
            this.txt_user_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user_name.Multiline = false;
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_user_name.PasswordChar = false;
            this.txt_user_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_user_name.PlaceholderText = "";
            this.txt_user_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_user_name.SelectionStart = 0;
            this.txt_user_name.Size = new System.Drawing.Size(268, 38);
            this.txt_user_name.TabIndex = 51;
            this.txt_user_name.Texts = "";
            this.txt_user_name.UnderlinedStyle = false;
            this.txt_user_name.Enter += new System.EventHandler(this.TextBox2_Enter);
            this.txt_user_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_user_name_KeyDown_1);
            // 
            // txt_imp_name
            // 
            this.txt_imp_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_imp_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_imp_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_imp_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_imp_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.txt_imp_name.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(186)))));
            this.txt_imp_name.BorderRadius = 10;
            this.txt_imp_name.BorderSize = 2;
            this.txt_imp_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_imp_name.Font = new System.Drawing.Font("LBC", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_imp_name.ForeColor = System.Drawing.Color.LightGray;
            this.txt_imp_name.Location = new System.Drawing.Point(122, 87);
            this.txt_imp_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_imp_name.Multiline = false;
            this.txt_imp_name.Name = "txt_imp_name";
            this.txt_imp_name.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_imp_name.PasswordChar = false;
            this.txt_imp_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_imp_name.PlaceholderText = "";
            this.txt_imp_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_imp_name.SelectionStart = 0;
            this.txt_imp_name.Size = new System.Drawing.Size(268, 38);
            this.txt_imp_name.TabIndex = 50;
            this.txt_imp_name.Texts = "";
            this.txt_imp_name.UnderlinedStyle = false;
            this.txt_imp_name.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txt_imp_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_imp_name_KeyDown);
            // 
            // btn_feeding
            // 
            this.btn_feeding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_feeding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_feeding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.btn_feeding.Location = new System.Drawing.Point(-12, 302);
            this.btn_feeding.Name = "btn_feeding";
            this.btn_feeding.Size = new System.Drawing.Size(543, 48);
            this.btn_feeding.TabIndex = 2;
            this.btn_feeding.Text = "إضافة";
            this.btn_feeding.UseVisualStyleBackColor = true;
            this.btn_feeding.Click += new System.EventHandler(this.btn_feeding_Click);
            // 
            // label_mul_pass
            // 
            this.label_mul_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_mul_pass.AutoSize = true;
            this.label_mul_pass.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mul_pass.ForeColor = System.Drawing.Color.Red;
            this.label_mul_pass.Location = new System.Drawing.Point(86, 246);
            this.label_mul_pass.Name = "label_mul_pass";
            this.label_mul_pass.Size = new System.Drawing.Size(23, 31);
            this.label_mul_pass.TabIndex = 33;
            this.label_mul_pass.Text = "*";
            this.label_mul_pass.Visible = false;
            // 
            // label_mul_userName
            // 
            this.label_mul_userName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_mul_userName.AutoSize = true;
            this.label_mul_userName.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mul_userName.ForeColor = System.Drawing.Color.Red;
            this.label_mul_userName.Location = new System.Drawing.Point(86, 170);
            this.label_mul_userName.Name = "label_mul_userName";
            this.label_mul_userName.Size = new System.Drawing.Size(23, 31);
            this.label_mul_userName.TabIndex = 32;
            this.label_mul_userName.Text = "*";
            this.label_mul_userName.Visible = false;
            // 
            // label_mul_name
            // 
            this.label_mul_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_mul_name.AutoSize = true;
            this.label_mul_name.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mul_name.ForeColor = System.Drawing.Color.Red;
            this.label_mul_name.Location = new System.Drawing.Point(86, 94);
            this.label_mul_name.Name = "label_mul_name";
            this.label_mul_name.Size = new System.Drawing.Size(23, 31);
            this.label_mul_name.TabIndex = 31;
            this.label_mul_name.Text = "*";
            this.label_mul_name.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(304, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "كلمة المرور";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(283, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "اسم المستخدم";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(288, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "اسم الموظف";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 30);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::networktest.Properties.Resources.minimize_5423950;
            this.pictureBox3.Location = new System.Drawing.Point(81, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::networktest.Properties.Resources.expand;
            this.pictureBox4.Location = new System.Drawing.Point(47, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::networktest.Properties.Resources.cancel__1_;
            this.pictureBox2.Location = new System.Drawing.Point(14, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(394, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "إضافة مستخدم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.panel3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.label6.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(230, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "طالب";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MTypeToggle
            // 
            this.MTypeToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MTypeToggle.ForeColor = System.Drawing.Color.White;
            this.MTypeToggle.Location = new System.Drawing.Point(188, 23);
            this.MTypeToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.MTypeToggle.Name = "MTypeToggle";
            this.MTypeToggle.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.MTypeToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.MTypeToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(186)))));
            this.MTypeToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.MTypeToggle.Size = new System.Drawing.Size(144, 22);
            this.MTypeToggle.TabIndex = 63;
            this.MTypeToggle.UseVisualStyleBackColor = true;
            this.MTypeToggle.CheckedChanged += new System.EventHandler(this.MTypeToggle_CheckedChanged);
            // 
            // Add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(546, 399);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_user";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_user";
            this.Load += new System.EventHandler(this.Add_user_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_mul_pass;
        private System.Windows.Forms.Label label_mul_userName;
        private System.Windows.Forms.Label label_mul_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_feeding;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private RJControls.RJTextBox txt_imp_name;
        private RJControls.RJTextBox txt_user_name;
        private RJControls.RJTextBox txt_pass;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private Sipaa.Framework.SToggleButton MTypeToggle;
    }
}