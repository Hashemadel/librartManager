using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Media;
using System.Windows.Forms;
using DevExpress.CodeParser;
using DevExpress.Export.Xl;
using DevExpress.XtraCharts.Native;
using networktest.Classes;

namespace networktest
{

    public partial class SignUp : Form
    {
        int id;
        int move, movex, movey;
        String mType = "", name = "",user_name="",pass="";
        object sender = new object();
        EventArgs e=new EventArgs();
        ToastMessage toastMessage = new ToastMessage();
        DateTime date;
        SqlConnection con = new SqlConnection();
        ConnectionC connect = new ConnectionC();
        bool isAddBill=false;
        int year = Properties.Settings.Default.year;

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
        public SignUp()
        {
            InitializeComponent();
            con = connect.getCon1();
        }
        private void SetTxtBoxEmpty()
        {
            txt_name.Texts = "";
            txt_user_name.Texts = "";
            text_password.Texts = "";
            MTypeToggle.Checked = false;
            txt_name.PlaceholderText = "اجباري";
            //txt_price.PlaceholderText = "اجباري";
            txt_name.Focus();

        }
        private void SetAddProcedur()
        {
            if (label6.Text == "طالب")
            {
                SqlCommand cmd = new SqlCommand("select s_id from students where name='" + txt_name.Texts + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    con.Close();
                    String borrowQuery = "createAccount";
                    cmd = new SqlCommand(borrowQuery, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_name", user_name);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@job", label6.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txt_name.Texts = "";
                    text_password.Texts = "";
                    txt_user_name.Texts = "";
                    toastMessage = new ToastMessage();
                    toastMessage.added(sender, e);
                    toastMessage.MessageText("تم الانشاء بنجاح");
                    toastMessage.TopMost = true;
                    toastMessage.Show();
                }
                else
                {
                    con.Close();
                    toastMessage = new ToastMessage();
                    toastMessage.warning(sender, e);
                    toastMessage.MessageText("لايوجد طالب بهذا الاسم");
                    toastMessage.TopMost = true;
                    toastMessage.Show();

                }
            }
            else if(label6.Text == "موظف")
            {
                SqlCommand cmd = new SqlCommand("select emp_id from employees where emp_name='" + txt_name.Texts + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    con.Close();
                    String borrowQuery = "createAccount";
                    cmd = new SqlCommand(borrowQuery, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_name", user_name);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@job", label6.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txt_name.Texts = "";
                    text_password.Texts = "";
                    txt_user_name.Texts = "";
                    toastMessage = new ToastMessage();
                    toastMessage.added(sender, e);
                    toastMessage.MessageText("تم الانشاء بنجاح");
                    toastMessage.TopMost = true;
                    toastMessage.Show();
                }
                else
                {
                    con.Close();

                    toastMessage = new ToastMessage();
                    toastMessage.warning(sender, e);
                    toastMessage.MessageText("لايوجد موظف بهذا الاسم");
                    toastMessage.TopMost = true;
                    toastMessage.Show();

                }
            }
        }
     
        private Boolean EnsureFillTxtBox()
        {
            label_mul_details.Hide();
            label_mul_price.Hide();
            label_mul_pass.Hide();
            if (txt_name.Texts == "" || txt_name.Texts == "اجباري"
                || txt_user_name.Texts == "" || txt_user_name.Texts == "اجباري"
                || text_password.Texts == "" || text_password.Texts == "اجباري")
            {
                if (txt_name.Texts == "" || txt_name.Texts == "اجباري")
                {
                    label_mul_details.Show();
                }
                if (txt_user_name.Texts == "" || txt_user_name.Texts == "اجباري")
                {
                    label_mul_price.Show();
                }
                if (text_password.Texts == "" || text_password.Texts == "اجباري")
                {
                    label_mul_pass.Show();
                }
                return false;
            }
            else
            return true;
        }

   

        private void createAccount(object sender, EventArgs e)
        {
            name = txt_name.Texts;
            pass = text_password.Texts;
            user_name = txt_user_name.Texts;
            if(EnsureFillTxtBox())
            {
                    SetAddProcedur();
                    
                    SetTxtBoxEmpty();
                
            }
        }
        private void Add_pay_Load(object sender, EventArgs e)
        {
            SetTxtBoxEmpty();
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
            movey=e.Y;
        }
        private void btn_feeding_Click(object sender, EventArgs e)
        {

            createAccount(sender, e);
           
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y)
            {
                MTypeToggle.Checked = false;
                label6.Text = "يمني";
                label6.BackColor = Color.FromArgb(0, 147, 186);
                MTypeToggle.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.D)
            {
                MTypeToggle.Checked = true;
                label6.Text = "دولار";
                label6.BackColor = Color.FromArgb(0, 184, 186);
                MTypeToggle.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btn_feeding.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.T)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
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

        private void txt_price__TextChanged(object sender, EventArgs e)
        {
            
            //num = 0;
        }



        private void txt_details_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_user_name.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txt_price_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_password.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void text_amount_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_feeding.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            //else if (e.KeyCode == Keys.S)
            //{
            //    MTypeToggle.Checked = false;
            //    label6.Text = "طالب";
            //    label6.BackColor = Color.FromArgb(0, 147, 186);
            //    e.Handled = true;
            //    e.SuppressKeyPress = true;
            //}
            //else if (e.KeyCode == Keys.D)
            //{
            //    MTypeToggle.Checked = true;
            //    label6.Text = "موظف";
            //    label6.BackColor = Color.FromArgb(0, 184, 186);
            //    e.Handled = true;
            //    e.SuppressKeyPress = true;
            //}

        }
        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_user_name_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));

        }

        private void text_password_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void text_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void text_exPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
        private void MTypeToggle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_feeding.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                MTypeToggle.Checked = false;
                label6.Text = "طالب";
                label6.BackColor = Color.FromArgb(0, 147, 186);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.D)
            {
                MTypeToggle.Checked = true;
                label6.Text = "موظف";
                label6.BackColor = Color.FromArgb(0, 184, 186);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.T)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-sa"));
        }
    }
}
