namespace networktest
{
    partial class ToastMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToastMessage));
            this.colorPanel = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.Lbl_message = new System.Windows.Forms.Label();
            this.ToastTimer = new System.Windows.Forms.Timer(this.components);
            this.toastHide = new System.Windows.Forms.Timer(this.components);
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(114)))), ((int)(((byte)(15)))));
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPanel.Location = new System.Drawing.Point(502, 0);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(13, 65);
            this.colorPanel.TabIndex = 0;
            this.colorPanel.Click += new System.EventHandler(this.Lbl_message_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("LBC", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(79, 1);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTitle.Size = new System.Drawing.Size(378, 28);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "العنوان";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblTitle.Click += new System.EventHandler(this.Lbl_message_Click);
            // 
            // Lbl_message
            // 
            this.Lbl_message.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_message.Location = new System.Drawing.Point(0, 31);
            this.Lbl_message.Name = "Lbl_message";
            this.Lbl_message.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_message.Size = new System.Drawing.Size(460, 25);
            this.Lbl_message.TabIndex = 3;
            this.Lbl_message.Text = "مضمون الرسالة";
            this.Lbl_message.Click += new System.EventHandler(this.Lbl_message_Click);
            // 
            // ToastTimer
            // 
            this.ToastTimer.Interval = 10;
            this.ToastTimer.Tick += new System.EventHandler(this.ToastTimer_Tick);
            // 
            // toastHide
            // 
            this.toastHide.Interval = 10;
            this.toastHide.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::networktest.Properties.Resources.check_5610944;
            this.picIcon.Location = new System.Drawing.Point(462, 13);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(35, 35);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 2;
            this.picIcon.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // ToastMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 65);
            this.Controls.Add(this.Lbl_message);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.colorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(0, 65);
            this.Name = "ToastMessage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToastMessage";
            this.Load += new System.EventHandler(this.ToastMessage_Load);
            this.Click += new System.EventHandler(this.ToastMessage_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToastMessage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label Lbl_message;
        private System.Windows.Forms.Timer ToastTimer;
        private System.Windows.Forms.Timer toastHide;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
    }
}