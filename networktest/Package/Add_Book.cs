using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using DevExpress.Pdf;


namespace networktest
{
    public partial class Add_Book : Form
    {
        int move;
        int movex;
        int movey;
        //public static Add_PKG instance;
        Student addPKG;
        Books Pos;
        SqlConnection con = new SqlConnection();
        ConnectionC connect = new ConnectionC();
        public Add_Book(Student addpk)
        {
            InitializeComponent();
            this.addPKG = addpk;
            this.ActiveControl= text_B_name;
            text_B_name.Focus();
            this.Icon = Properties.Resources.f_logo_png_10;
            con=connect.getCon1();

        }
        public Add_Book(Books pos)
        {
            InitializeComponent();
            this.Pos = pos;
            this.ActiveControl = text_B_name;
            text_B_name.Focus();
            this.Icon = Properties.Resources.f_logo_png_10;
            con = connect.getCon1();

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
  
        private void btn_add_Click(object sender, EventArgs e)
        {
            String name= text_B_name.Texts;
            String author = text_author.Texts;
            String content = textBox_Content.Texts;
            int PG_no=Convert.ToInt32(text_PG_no.Texts);



            label_mul_name.Hide();
            label_mul_price.Hide();
            label_mul_meg.Hide();

            if (text_B_name.Texts == "" || text_B_name.Texts== "اجباري")
            {
                label_mul_name.Show();
            }
            else if (text_author.Texts == "" || text_author.Texts== "اجباري")
            {
                label_mul_price.Show();
            }
            else if (text_PG_no.Texts == "" || text_PG_no.Texts == "اجباري")
            {
                label_mul_meg.Show(); 
            }
            else
            {
               String sql = "insert into Books (B_name,isAvailable,author,page_no,content) values(@B_name,@isAvailable,@author,@page_no,@content)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@B_name", name);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@page_no", PG_no);
                cmd.Parameters.AddWithValue("@content", content);
                cmd.Parameters.AddWithValue("@isAvailable", 1);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    text_author.Texts = "";
                    text_B_name.Texts = "";
                    text_PG_no.Texts = "";
                    textBox_Content.Texts= "";
                    String sqlSelect = "Select * from Books ";
                    SqlDataAdapter sda = new SqlDataAdapter(sqlSelect, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Pos.dataGridView2.DataSource = dt;
                    ToastMessage toastMessage = new ToastMessage();
                    toastMessage.added(sender, e);
                    toastMessage.Show();
                    this.ActiveControl = text_B_name;
                    text_B_name.Focus();
                }
                catch (Exception ex)
                {
                    ToastMessage toastMessage = new ToastMessage();
                    toastMessage.warning(sender, e);
                    toastMessage.MessageText("رقم الكتاب هذا موجود بالفعل");
                    toastMessage.Show();
                }
                
                con.Close();
            }

        }

        private void networktest_load(object sender, EventArgs e)
        {
            label_mul_name.Hide();
            label_mul_price.Hide();
            label_mul_meg.Hide();
            text_author.PlaceholderText = "اجباري";
            text_B_name.PlaceholderText= "اجباري";
            textBox_Content.PlaceholderText= "اجباري";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else { 
                WindowState = FormWindowState.Normal;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Minimized;
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
                this.Cursor = Cursors.NoMove2D;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //this.Hide();
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

        private void text_pkg_id_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_B_name.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void text_pkg_name_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_author.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void text_price_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_PG_no.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void text_days_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_Content.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBox_meg_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        private void text_price_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_meg_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void text_days_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_hours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_pkg_name_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }
    }
}
