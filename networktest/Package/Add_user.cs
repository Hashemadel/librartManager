using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using networktest.Classes;
using System.Globalization;
using DevExpress.XtraEditors.TextEditController.Win32;
using System.Drawing;

namespace networktest
{
    public partial class Add_user : Form
    {
        int move;
        int movex;
        int movey;
        Users User;
        SqlConnection con = new SqlConnection();
        ConnectionC connect = new ConnectionC();
        public Add_user(Users users)
        {
            InitializeComponent();
            this.User = users;
            this.ActiveControl = txt_imp_name;
            txt_imp_name.Focus();
            this.Icon = Properties.Resources.f_logo_png_10;
            con = connect.getCon1();
        }

        private void btn_feeding_Click(object sender, EventArgs e)
        {
            label_mul_pass.Hide();
            label_mul_userName.Hide();
            label_mul_name.Hide();

            int sId;
            String name= txt_imp_name.Texts;
            String userName= txt_user_name.Texts;
            String pass= txt_pass.Texts;
            String job;
            if (txt_imp_name.Texts == "" || txt_imp_name.Texts == "اجباري"
                || txt_user_name.Texts == "" || txt_user_name.Texts == "اجباري"
                || txt_pass.Texts == "" || txt_pass.Texts == "اجباري")
            {
                if (txt_imp_name.Texts == "" || txt_imp_name.Texts == "اجباري")
                    label_mul_name.Show();
                if (txt_user_name.Texts == "" || txt_user_name.Texts == "اجباري")
                    label_mul_userName.Show();
                if (txt_pass.Texts == "" || txt_pass.Texts == "اجباري")
                    label_mul_pass.Show();
            }
            else
            {
                if(label6.Text=="موظف")
                {
                    SqlCommand cmd = new SqlCommand("select emp_job from employees where emp_name='" + name + "'", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        job = dr.GetString(0);
                        con.Close();
                        String sql = "insert into users (user_name,password,job,Status) values(@user_name,@password,@job,@Status)";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@user_name", userName);
                        cmd.Parameters.AddWithValue("@password", pass);
                        cmd.Parameters.AddWithValue("@Status", 0);
                        cmd.Parameters.AddWithValue("@job", job);
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            con.Close();
                            txt_imp_name.Texts = "";
                            txt_user_name.Texts = "";
                            txt_pass.Texts = "";
                            label6.Text = "طالب";
                            label6.BackColor = Color.FromArgb(0, 184, 186);
                            String sqlSelect = "Select * from users ";
                            SqlDataAdapter sda = new SqlDataAdapter(sqlSelect, con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            User.dataGridView_users.DataSource = dt;
                            ToastMessage toastMessage = new ToastMessage();
                            toastMessage.added(sender, e);
                            toastMessage.Show();
                            this.ActiveControl = txt_imp_name;
                            txt_imp_name.Focus();
                        }
                        catch (Exception ex)
                        {
                            ToastMessage toastMessage = new ToastMessage();
                            toastMessage.warning(sender, e);
                            toastMessage.MessageText("اسم المستخدم هذا موجود بالفعل");
                            toastMessage.Show();
                        }

                    }
                    else
                    {
                        con.Close();

                        ToastMessage toastMessage = new ToastMessage();
                        toastMessage.warning(sender, e);
                        toastMessage.MessageText("لايوجد موظف بهذا الاسم");
                        toastMessage.Show();
                    }
                }
                else if (label6.Text == "طالب")
                {
                    SqlCommand cmd = new SqlCommand("select s_id from students where name='" + name + "'", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        sId = dr.GetInt32(0);
                        con.Close();
                        String sql = "insert into users (user_name,password,job,Status) values(@user_name,@password,'طالب',@Status)";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@user_name", userName);
                        cmd.Parameters.AddWithValue("@password", pass);
                        cmd.Parameters.AddWithValue("@Status", 0);
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            con.Close();
                            txt_imp_name.Texts = "";
                            txt_user_name.Texts = "";
                            txt_pass.Texts = "";
                            txt_pass.Texts = "";
                            label6.Text = "طالب";
                            String sqlSelect = "Select * from users ";
                            SqlDataAdapter sda = new SqlDataAdapter(sqlSelect, con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            User.dataGridView_users.DataSource = dt;
                            ToastMessage toastMessage = new ToastMessage();
                            toastMessage.added(sender, e);
                            toastMessage.Show();
                            this.ActiveControl = txt_imp_name;
                            txt_imp_name.Focus();
                        }
                        catch (Exception ex)
                        {
                            ToastMessage toastMessage = new ToastMessage();
                            toastMessage.warning(sender, e);
                            toastMessage.MessageText("اسم المستخدم هذا موجود بالفعل");
                            toastMessage.Show();
                        }

                    }
                    else
                    {
                        con.Close();

                        ToastMessage toastMessage = new ToastMessage();
                        toastMessage.warning(sender, e);
                        toastMessage.MessageText("لايوجد موظف بهذا الاسم");
                        toastMessage.Show();
                    }
                }

            }

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
   

        private void Add_user_Load(object sender, EventArgs e)
        {
            label_mul_name.Hide();
            label_mul_pass.Hide();
            label_mul_userName.Hide();

            txt_imp_name.PlaceholderText = "اجباري";
            txt_pass.PlaceholderText = "اجباري";
            txt_user_name.PlaceholderText = "اجباري";
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
                bunifuElipse1.ElipseRadius = 30;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txt_imp_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_user_name.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_user_name_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pass.Focus();
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
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
        private void TextBox_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-sa"));
        }
        private void TextBox2_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void MTypeToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (MTypeToggle.Checked)
            {
                label6.Text = "موظف";
                label6.BackColor = Color.FromArgb(0, 184, 186);
            }
            else
            {
                label6.Text = "طالب";
                label6.BackColor = Color.FromArgb(0, 147, 186);
            }
        }
    }
}
