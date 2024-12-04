namespace networktest
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_mul_pass = new System.Windows.Forms.Label();
            this.label_mul_userName = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.passEye = new System.Windows.Forms.PictureBox();
            this.txt_pass = new networktest.RJControls.RJTextBox();
            this.txt_user_name = new networktest.RJControls.RJTextBox();
            this.btn_feeding = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.panel3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label_mul_pass);
            this.panel3.Controls.Add(this.label_mul_userName);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.passEye);
            this.panel3.Controls.Add(this.txt_pass);
            this.panel3.Controls.Add(this.txt_user_name);
            this.panel3.Controls.Add(this.btn_feeding);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(22, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 346);
            this.panel3.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("LBC", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(121, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 51;
            this.label2.Text = "انشاء حساب؟";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label_mul_pass
            // 
            this.label_mul_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_mul_pass.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mul_pass.ForeColor = System.Drawing.Color.Red;
            this.label_mul_pass.Location = new System.Drawing.Point(77, 212);
            this.label_mul_pass.Name = "label_mul_pass";
            this.label_mul_pass.Size = new System.Drawing.Size(20, 20);
            this.label_mul_pass.TabIndex = 47;
            this.label_mul_pass.Text = "*";
            this.label_mul_pass.Visible = false;
            // 
            // label_mul_userName
            // 
            this.label_mul_userName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_mul_userName.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mul_userName.ForeColor = System.Drawing.Color.Red;
            this.label_mul_userName.Location = new System.Drawing.Point(77, 123);
            this.label_mul_userName.Name = "label_mul_userName";
            this.label_mul_userName.Size = new System.Drawing.Size(20, 20);
            this.label_mul_userName.TabIndex = 46;
            this.label_mul_userName.Text = "*";
            this.label_mul_userName.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::networktest.Properties.Resources.setting_771203;
            this.pictureBox4.Location = new System.Drawing.Point(570, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // passEye
            // 
            this.passEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passEye.Image = global::networktest.Properties.Resources.show;
            this.passEye.Location = new System.Drawing.Point(27, 213);
            this.passEye.Name = "passEye";
            this.passEye.Size = new System.Drawing.Size(31, 22);
            this.passEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passEye.TabIndex = 50;
            this.passEye.TabStop = false;
            this.passEye.Visible = false;
            this.passEye.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.txt_pass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(186)))));
            this.txt_pass.BorderRadius = 10;
            this.txt_pass.BorderSize = 2;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.LightGray;
            this.txt_pass.Location = new System.Drawing.Point(65, 204);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Multiline = false;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_pass.PasswordChar = true;
            this.txt_pass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_pass.PlaceholderText = "";
            this.txt_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_pass.SelectionStart = 0;
            this.txt_pass.Size = new System.Drawing.Size(256, 41);
            this.txt_pass.TabIndex = 49;
            this.txt_pass.Texts = "";
            this.txt_pass.UnderlinedStyle = false;
            this.txt_pass.Click += new System.EventHandler(this.txt_pass_Click);
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyDown_1);
            // 
            // txt_user_name
            // 
            this.txt_user_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_user_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_user_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_user_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.txt_user_name.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(186)))));
            this.txt_user_name.BorderRadius = 10;
            this.txt_user_name.BorderSize = 2;
            this.txt_user_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_name.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.ForeColor = System.Drawing.Color.LightGray;
            this.txt_user_name.Location = new System.Drawing.Point(65, 115);
            this.txt_user_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user_name.Multiline = false;
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_user_name.PasswordChar = false;
            this.txt_user_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_user_name.PlaceholderText = "";
            this.txt_user_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_user_name.SelectionStart = 0;
            this.txt_user_name.Size = new System.Drawing.Size(256, 41);
            this.txt_user_name.TabIndex = 48;
            this.txt_user_name.Texts = "";
            this.txt_user_name.UnderlinedStyle = false;
            this.txt_user_name.Click += new System.EventHandler(this.txt_user_name_Click);
            this.txt_user_name.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txt_user_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_user_name_KeyDown_1);
            // 
            // btn_feeding
            // 
            this.btn_feeding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_feeding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_feeding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_feeding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.btn_feeding.Location = new System.Drawing.Point(-2, 292);
            this.btn_feeding.Name = "btn_feeding";
            this.btn_feeding.Size = new System.Drawing.Size(637, 55);
            this.btn_feeding.TabIndex = 40;
            this.btn_feeding.Text = "تسجيل الدخول";
            this.btn_feeding.UseVisualStyleBackColor = true;
            this.btn_feeding.Click += new System.EventHandler(this.btn_feeding_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(203, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 26);
            this.label5.TabIndex = 43;
            this.label5.Text = "كلمة المرور";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(178, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 42;
            this.label3.Text = "اسم المستخدم";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("LBC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 64);
            this.label1.TabIndex = 41;
            this.label1.Text = "تسجيل الدخول";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::networktest.Properties.Resources.man_user_circle_black_icon2;
            this.pictureBox1.Location = new System.Drawing.Point(356, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::networktest.Properties.Resources.cancel__1_;
            this.pictureBox2.Location = new System.Drawing.Point(22, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 36);
            this.panel1.TabIndex = 43;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 406);
            this.panel2.TabIndex = 44;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(670, 406);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_feeding;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_mul_pass;
        private System.Windows.Forms.Label label_mul_userName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private RJControls.RJTextBox txt_pass;
        private RJControls.RJTextBox txt_user_name;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox passEye;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}