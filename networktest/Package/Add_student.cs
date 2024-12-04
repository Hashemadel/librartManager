using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using networktest.Classes;
using System.Globalization;
using DevExpress.XtraReports.Templates;

namespace networktest
{
    public partial class Add_student : Form
    {
        int move;
        int movex;
        int movey;
        SqlDataAdapter sda;
        DataTable pdt;
        SqlConnection con = new SqlConnection();
        ConnectionC connect = new ConnectionC();


        Student Student;

        public Add_student(Student student)
        {
            InitializeComponent();
            con = connect.getCon1();
            Student = student;
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
        private void Pays_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_name;
            txt_name.Focus();

            label_mul_details.Hide();
            label_mul_total.Hide();
            txt_spec.PlaceholderText = "اجباري";
            txt_name.PlaceholderText = "اجباري";

            con.Close();
        }
       
        private void txt_details_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_spec.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txt_total_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_feeding.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            
        }
        private void btn_feeding_Click(object sender, EventArgs e)
        {
            label_mul_details.Hide();
            label_mul_total.Hide();
            String name = txt_name.Texts;
            String spec = txt_spec.Texts;


            if (txt_spec.Texts == "اجباري" || txt_spec.Texts == "")
            {
                label_mul_total.Show();
            }
            else if (txt_name.Texts == "اجباري" || txt_name.Texts == "")
            {
                label_mul_details.Show();
            }
            else
            {
                String sql = "insert into students (name,specialty) values(@name,@specialty)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@specialty", spec);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txt_spec.Texts = "";
                    txt_name.Texts = "";
                    String sqlSelect = "Select * from students ";
                    SqlDataAdapter sda = new SqlDataAdapter(sqlSelect, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Student.dataGridView2.DataSource = dt;
                    ToastMessage toastMessage = new ToastMessage();
                    toastMessage.added(sender, e);
                    toastMessage.Show();
                    this.ActiveControl = txt_name;
                    txt_name.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //ToastMessage toastMessage = new ToastMessage();
                    //toastMessage.warning(sender, e);
                    //toastMessage.MessageText("رقم الكتاب هذا موجود بالفعل");
                    //toastMessage.Show();
                }

                con.Close();
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
                bunifuElipse2.ElipseRadius = 0;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                bunifuElipse2.ElipseRadius = 30;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
            this.Cursor = Cursors.Default;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            
        }

        

        private void txt_total_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_details_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
                this.Cursor = Cursors.NoMove2D;
            }
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-sa"));
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_feeding.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
