using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.Templates;
using networktest.Classes;

namespace networktest
{
    public partial class Add_employee : Form
    {
        int move;
        int movex;
        int movey;
        SqlConnection con = new SqlConnection();
        ConnectionC connect = new ConnectionC();
        Employees Emp;

        public Add_employee(Employees emp)
        {
            InitializeComponent();
            this.ActiveControl = txt_name;
            txt_name.Focus();
            label_mul_name.Hide();
            con = connect.getCon1();
            this.Emp = emp;
            comboBox1.SelectedIndex = 0;
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
            String name = txt_name.Texts;
            String job=comboBox1.Text;
            label_mul_name.Hide();
            if (txt_name.Texts == "" || txt_name.Texts == "اجباري")
            {
                label_mul_name.Show();
            }
            else
            {
                String sql = "insert into employees (emp_name,emp_job) values(@emp_name,@job)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@emp_name", name);
                cmd.Parameters.AddWithValue("@job", job);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txt_name.Texts = "";
                    String sqlSelect = "Select * from employees ";
                    SqlDataAdapter sda = new SqlDataAdapter(sqlSelect, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Emp.dataGridView_employees.DataSource = dt;
                    ToastMessage toastMessage = new ToastMessage();
                    toastMessage.added(sender, e);
                    toastMessage.Show();
                    this.ActiveControl = txt_name;
                    txt_name.Focus();
                }
                catch (Exception ex)
                {
                    ToastMessage toastMessage = new ToastMessage();
                    toastMessage.warning(sender, e);
                    toastMessage.MessageText("رقم الموظف هذا موجود بالفعل");
                    toastMessage.Show();
                }

                con.Close();

            }

        }

        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex=e.X;
            movey = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
            this.Cursor = Cursors.Default;
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

        private void txt_name_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = comboBox1;
                comboBox1.Focus();
                comboBox1.DroppedDown = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

  

        private void TextBox_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-sa"));
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
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
