using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networktest
{
    public partial class FormMessageBox : Form
    {
        //Fields
        private Color primaryColor = Color.CornflowerBlue;
        private int borderSize = 2;
        public string result;
        MainForm MainForm;
        bool isPrint=false;
        //Properties
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set
            {
                primaryColor = value;
                this.BackColor = primaryColor;//Form Border Color
                this.panelTitleBar.BackColor = PrimaryColor;//Title Bar Back Color
            }
        }
        public FormMessageBox()
        {
            
            InitializeComponent();
            InitializeItems();
            this.Icon = Properties.Resources.f_logo_png_10;
            pictureBoxIcon.Image = Properties.Resources.question_mark;
            this.ActiveControl = button1;
            button1.Focus();
        }

        //عمل ظل للواجهة
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }
        public FormMessageBox(string text, string caption)
        {
            InitializeComponent();
            InitializeItems();
           // this.PrimaryColor = primaryColor;
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            this.Icon = Properties.Resources.f_logo_png_10;
            pictureBoxIcon.Image = Properties.Resources.question_mark;
            this.ActiveControl = button1;
            button1.Focus();
        }
        public FormMessageBox(string text, string caption,Image image)
        {
            InitializeComponent();
            InitializeItems();
            // this.PrimaryColor = primaryColor;
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            this.Icon = Properties.Resources.f_logo_png_10;
            pictureBoxIcon.Image = image;
            this.ActiveControl = button1;
            button1.Focus();
        }
        public FormMessageBox(string text)
        {
            InitializeComponent();
            InitializeItems();
            // this.PrimaryColor = primaryColor;
            this.labelMessage.Text = text;
            this.Icon = Properties.Resources.f_logo_png_10;
            pictureBoxIcon.Image = Properties.Resources.question_mark;
            this.ActiveControl = button1;
            button1.Focus();
        }
        //3loc 231, 15
        //3size 92, 39

        //1loc 300, 15
        //1size 154, 39

        //2loc 101, 15
        //2size 154, 39
        public FormMessageBox(string text, string caption, string button1Text,string button2Text,string button3Text,String name)
        {
            InitializeComponent();
            
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            button1.Text = button1Text;
            button2.Text = button2Text;
            button3.Text = button3Text;
            
            button3.Visible=true;
            
            isPrint=true;
            this.ActiveControl = button1;
            button1.Focus();
            if(name=="Main")
            {
                InitializeItems();
                button1.Location = new System.Drawing.Point(362, 15);
                button2.Location = new System.Drawing.Point(101, 15);
                button1.Size = new Size(92, 39);
                button2.Size = new Size(92, 39);
                pictureBoxIcon.Image = Properties.Resources.print;
            }
            else if(name=="delete")
            {
                //355
                //188
                //16
                InitializeItems2();
                button1.Size = new Size(180, 39);
                button2.Size = new Size(160,39);
                button3.Size = new Size(160, 39);
                button1.Location = new System.Drawing.Point(355, 15);
                button2.Location = new System.Drawing.Point(16, 15); 
                button3.Location = new System.Drawing.Point(186, 15);
                pictureBoxIcon.Image = Properties.Resources.question_mark;
            }
            else if (name == "pos")
            {
                //355
                //188
                //16
                InitializeItems2();
                button1.Size = new Size(160, 39);
                button2.Size = new Size(160, 39);
                button3.Size = new Size(160, 39);
                button1.Location = new System.Drawing.Point(355, 15);
                button2.Location = new System.Drawing.Point(16, 15);
                button3.Location = new System.Drawing.Point(186, 15);
                pictureBoxIcon.Image = Properties.Resources.question_mark;
            }

        }
        public FormMessageBox(string text, string button1Text, string button2Text)
        {
            InitializeComponent();
            InitializeItems();
            this.labelMessage.Text = text;
            button1.Text = button1Text;
            button1.BackColor = Color.FromArgb(155, 16, 21);
            button1.BorderColor = Color.FromArgb(155, 16, 21);
            button2.Text = button2Text;
            button2.BackColor = Color.FromArgb(22, 98, 164);
            button2.BorderColor = Color.FromArgb(22, 98, 164);
            this.ActiveControl = button1;
            button1.Focus();

        }
        public FormMessageBox(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            InitializeItems();
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
        }
        public FormMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
        }
        public FormMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();

            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            
        }
        //-> Private Methods
        private void InitializeItems()
        {
            this.button1.DialogResult = DialogResult.OK;
            this.button2.DialogResult = DialogResult.Ignore;
            this.button3.DialogResult = DialogResult.Cancel;
        }
        private void InitializeItems2()
        {
            this.button1.DialogResult = DialogResult.OK;
            this.button3.DialogResult = DialogResult.Ignore;
            this.button2.DialogResult = DialogResult.Cancel;
        }

        private void SetIcon(Image image)
        {
            pictureBoxIcon.Image = image;
        }
            private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.pictureBoxIcon.Image = Properties.Resources.warning_745419;
                    PrimaryColor = Color.FromArgb(224, 79, 95);
                   // this.btnClose.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    break;
                case MessageBoxIcon.Information: //Information
                    this.pictureBoxIcon.Image = Properties.Resources.info;
                    PrimaryColor = Color.FromArgb(38, 191, 166);
                    break;
                case MessageBoxIcon.Question://Question
                    this.pictureBoxIcon.Image = Properties.Resources.info;
                    PrimaryColor = Color.FromArgb(33, 148, 247);
                    break;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                button2.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
            else if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (!isPrint)
            {
                if (e.KeyCode == Keys.Left)
                {

                    this.ActiveControl=button2 ;
                    button2.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Left)
                {

                    this.ActiveControl = button3;
                    button3.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;

                }
            }


        }
        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button2.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
            else if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (!isPrint)
            {
                if (e.KeyCode == Keys.Right)
                {

                    this.ActiveControl = button1;
                    button1.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Right)
                {

                    this.ActiveControl = button3;
                    button3.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }
        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Right)
            {

                this.ActiveControl = button1;
                button1.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Left)
            {

                this.ActiveControl = button2;
                button2.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(22, 98, 164);
            button1.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
            button1.BorderColor = ThemeColor.ChangeColorBrightness(color, -0.5);
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            Color color = Color.Gold;
            button3.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
            button3.BorderColor = ThemeColor.ChangeColorBrightness(color, -0.5);
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(22, 98, 164);
            button1.BackColor = color;
            button1.BorderColor = color;
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            Color color = Color.Gold;
            button3.BackColor = color;
            button3.BorderColor = color;
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(155, 16, 21); 
            button2.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
            button2.BorderColor = ThemeColor.ChangeColorBrightness(color, -0.5);
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(155, 16, 21);
            button2.BackColor = color;
            button2.BorderColor = color;
        }
    }
}
