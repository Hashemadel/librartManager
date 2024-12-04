namespace networktest
{
    partial class RJComboBox
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
            this.components = new System.ComponentModel.Container();
            this.TimerItem = new System.Windows.Forms.Timer(this.components);
            this.TimerItem2 = new System.Windows.Forms.Timer(this.components);
            this.PnlIem = new networktest.RJRoundedGradientPanel();
            this.FLPItem = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlTitle = new networktest.RJRoundedGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextComboBox = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.iconComboBox = new System.Windows.Forms.PictureBox();
            this.picComboBox = new System.Windows.Forms.PictureBox();
            this.PnlIem.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerItem
            // 
            this.TimerItem.Interval = 1;
            this.TimerItem.Tick += new System.EventHandler(this.TimerItem_Tick);
            // 
            // TimerItem2
            // 
            this.TimerItem2.Interval = 1;
            this.TimerItem2.Tick += new System.EventHandler(this.TimerItem2_Tick);
            // 
            // PnlIem
            // 
            this.PnlIem.BackColor = System.Drawing.Color.White;
            this.PnlIem.BorderColor = System.Drawing.Color.Transparent;
            this.PnlIem.BorderRadius = 30;
            this.PnlIem.Controls.Add(this.FLPItem);
            this.PnlIem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlIem.Font = new System.Drawing.Font("LBC", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlIem.ForeColor = System.Drawing.Color.Black;
            this.PnlIem.GradientAngle = 90F;
            this.PnlIem.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.PnlIem.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.PnlIem.Location = new System.Drawing.Point(0, 60);
            this.PnlIem.Margin = new System.Windows.Forms.Padding(0);
            this.PnlIem.Name = "PnlIem";
            this.PnlIem.Padding = new System.Windows.Forms.Padding(5);
            this.PnlIem.Size = new System.Drawing.Size(300, 0);
            this.PnlIem.TabIndex = 1;
            // 
            // FLPItem
            // 
            this.FLPItem.BackColor = System.Drawing.Color.Transparent;
            this.FLPItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPItem.Location = new System.Drawing.Point(5, 5);
            this.FLPItem.Margin = new System.Windows.Forms.Padding(0);
            this.FLPItem.Name = "FLPItem";
            this.FLPItem.Size = new System.Drawing.Size(290, 0);
            this.FLPItem.TabIndex = 0;
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.PnlTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.PnlTitle.BorderRadius = 50;
            this.PnlTitle.Controls.Add(this.label1);
            this.PnlTitle.Controls.Add(this.TextComboBox);
            this.PnlTitle.Controls.Add(this.LblTitle);
            this.PnlTitle.Controls.Add(this.iconComboBox);
            this.PnlTitle.Controls.Add(this.picComboBox);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Font = new System.Drawing.Font("LBC", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlTitle.ForeColor = System.Drawing.Color.Black;
            this.PnlTitle.GradientAngle = 90F;
            this.PnlTitle.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.PnlTitle.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(300, 60);
            this.PnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 4);
            this.label1.TabIndex = 4;
            // 
            // TextComboBox
            // 
            this.TextComboBox.BackColor = System.Drawing.Color.Transparent;
            this.TextComboBox.Font = new System.Drawing.Font("LBC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.TextComboBox.Location = new System.Drawing.Point(46, 26);
            this.TextComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.TextComboBox.Name = "TextComboBox";
            this.TextComboBox.Size = new System.Drawing.Size(198, 22);
            this.TextComboBox.TabIndex = 3;
            this.TextComboBox.Text = "قم بالأختيار..";
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.LblTitle.Location = new System.Drawing.Point(103, -2);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(153, 25);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "العنوان";
            // 
            // iconComboBox
            // 
            this.iconComboBox.BackColor = System.Drawing.Color.Transparent;
            this.iconComboBox.Location = new System.Drawing.Point(258, 15);
            this.iconComboBox.Name = "iconComboBox";
            this.iconComboBox.Size = new System.Drawing.Size(30, 30);
            this.iconComboBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconComboBox.TabIndex = 1;
            this.iconComboBox.TabStop = false;
            // 
            // picComboBox
            // 
            this.picComboBox.BackColor = System.Drawing.Color.Transparent;
            this.picComboBox.Location = new System.Drawing.Point(13, 15);
            this.picComboBox.Name = "picComboBox";
            this.picComboBox.Size = new System.Drawing.Size(30, 30);
            this.picComboBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComboBox.TabIndex = 0;
            this.picComboBox.TabStop = false;
            this.picComboBox.Click += new System.EventHandler(this.picComboBox_Click);
            // 
            // RJComboBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PnlIem);
            this.Controls.Add(this.PnlTitle);
            this.Font = new System.Drawing.Font("LBC", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RJComboBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(300, 60);
            this.PnlIem.ResumeLayout(false);
            this.PnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJRoundedGradientPanel PnlTitle;
        private RJRoundedGradientPanel PnlIem;
        private System.Windows.Forms.FlowLayoutPanel FLPItem;
        private System.Windows.Forms.PictureBox picComboBox;
        private System.Windows.Forms.PictureBox iconComboBox;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerItem;
        private System.Windows.Forms.Timer TimerItem2;
        public System.Windows.Forms.Label TextComboBox;
    }
}
