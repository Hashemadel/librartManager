using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace networktest
{
    public partial class Login : Form
    {
        int move;
        int movex;
        int movey;
        
        LoginClass login = new LoginClass();
        public Login()
        {
            InitializeComponent();
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
        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_user_name;
            txt_user_name.Focus();

        }
        private void btn_feeding_Click(object sender, EventArgs e)
        {
            if(login.BtnLogin_Clic( txt_pass,  txt_user_name,  label_mul_pass,label_mul_userName))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_user_name_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pass.Focus();
                passEye.Visible = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_pass_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_feeding.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                txt_user_name.Focus();
                passEye.Visible = false;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            login.showAndHidePass(txt_pass, passEye);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
            //this.Hide();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
                this.Cursor = Cursors.NoMove2D;
            }
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            move = 0;
            this.Cursor = Cursors.Default;
        }

        private void txt_pass_Click(object sender, EventArgs e)
        {
            passEye.Show();
        }

        private void txt_user_name_Click(object sender, EventArgs e)
        {
            passEye.Visible = false;

        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.setting_771152_copy;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.setting_771203;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(0, 147, 186);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkGray;

        }
    }
}
