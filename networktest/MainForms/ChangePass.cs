using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using networktest.RJControls;

namespace networktest
{
    public partial class ChangePass : Form
    {
        int move;
        int movex;
        int movey;
        SqlConnection con = new SqlConnection();
        ConnectionC connect = new ConnectionC();
        public static ChangePass instance;
        public RJTextBox name;
        public String Sname;
        String currentPass;
        String inCurrentPass;
        String newPass;
        String conPass;
        public ChangePass()
        {
            Sname= Properties.Settings.Default.name;
            InitializeComponent();
            instance = this;
            name=text_currentPass;
            this.ActiveControl = text_currentPass;
            text_currentPass.Focus();
            this.Icon = Properties.Resources.f_logo_png_10;
            con=connect.getCon1();
            
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
        private void btn_feeding_Click(object sender, EventArgs e)
        {
            label_conPass.Hide();
            label_currentPass.Hide();
            label_newPass.Hide();
            if(text_currentPass.Texts=="")
            {
                label_currentPass.Show();
            }
            if(text_newPass.Texts=="")
            {

            label_newPass.Show();
            }
            if(text_conPass.Texts=="")
            {

            label_conPass.Show(); 
            }
        

            else
            {
                inCurrentPass = text_currentPass.Texts;
                newPass = text_newPass.Texts;
                conPass = text_conPass.Texts;

                String getIp = "select imp_id from employees where imp_name='" + Sname + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(getIp, con);
                int id = (int)cmd.ExecuteScalar();
                con.Close();

                String selectPass = "select u.password from users u join employees e on(u.imp_id=e.imp_id) where imp_name='" + Sname + "'";
                con.Open();
                cmd = new SqlCommand(selectPass, con);
                currentPass = (String)cmd.ExecuteScalar();
                con.Close();
                if (currentPass == inCurrentPass)
                {
                    if (newPass == conPass)
                    {

                        con.Open();
                        String editPass = "update users set password ='" + newPass + "'where imp_id='" + id + "'";
                        cmd = new SqlCommand(editPass, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        String insertStat = "update users set status=0 where imp_id='" + id + "'";
                        con.Open();
                        cmd = new SqlCommand(insertStat, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ToastMessage toastMessage = new ToastMessage();
                        toastMessage.edited(sender, e);
                        toastMessage.Show();
                    }
                    else
                    {
                        label_newPass.Show();
                        label_conPass.Show();
                    }
                    
                    
                }
                else
                {
                    ToastMessage toastMessage = new ToastMessage();
                    toastMessage.warning(sender, e);
                    toastMessage.MessageText("كلمة السر الحالية خاطئة");
                    toastMessage.Show();
                }
            }
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            label_conPass.Hide();
            label_currentPass.Hide();
            label_newPass.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                bunifuElipse1.ElipseRadius = 0;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                bunifuElipse1.ElipseRadius = 50;

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_currentPass_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_newPass.Focus();
                pictureBox1.Hide();
                pictureBox5.Show();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void text_newPass_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_conPass.Focus();
                pictureBox5.Hide();
                pictureBox6.Show();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void text_conPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_feeding.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(text_currentPass.PasswordChar ==true)
            {
                text_currentPass.PasswordChar = false;
            }
            else
            text_currentPass.PasswordChar=true;
        }

        private void text_currentPass__TextChanged(object sender, EventArgs e)
        {

        }

        private void text_currentPass_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();

            pictureBox5.Hide();
            pictureBox6.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(text_newPass.PasswordChar ==true)
            {
                text_newPass.PasswordChar = false;
            }
            else
            text_newPass.PasswordChar = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (text_conPass.PasswordChar == true)
            {
                text_conPass.PasswordChar = false;
            }
            else
                text_conPass.PasswordChar = true;
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (text_currentPass.PasswordChar == true)
            {
                text_currentPass.PasswordChar = false;
                pictureBox1.Image =Properties.Resources.hide;
            }
            else
            {
                text_currentPass.PasswordChar = true;
                pictureBox1.Image = Properties.Resources.show;
            }
                
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            if (text_newPass.PasswordChar == true)
            {
                text_newPass.PasswordChar = false;
                pictureBox5.Image = Properties.Resources.hide;
            }
            else
            {
                text_newPass.PasswordChar = true;
                pictureBox5.Image = Properties.Resources.show;
            }
                
        }

        private void pictureBox7_Click_2(object sender, EventArgs e)
        {
            if (text_conPass.PasswordChar == true)
            {
                text_conPass.PasswordChar = false;
                pictureBox6.Image = Properties.Resources.hide;
            }
            else
            {
                text_conPass.PasswordChar = true;
                pictureBox6.Image = Properties.Resources.show;
            }
                
        }

        private void text_newPass_Click(object sender, EventArgs e)
        {
            pictureBox5.Show();
            pictureBox6.Hide();
            pictureBox1.Hide();
        }

        private void text_conPass_Click(object sender, EventArgs e)
        {
            pictureBox5.Hide();
            pictureBox6.Show();
            pictureBox1.Hide();
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
                this.Cursor = Cursors.NoMove2D;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
            this.Cursor = Cursors.Default;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

    }
}
