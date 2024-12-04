using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using networktest.Classes;
using networktest.Reports;
using Sipaa.Framework;
using static DevExpress.XtraBars.Docking2010.Views.BaseRegistrator;

namespace networktest
{
    public partial class Borrow : Form
    {
        DataTable St_dt;
        DataTable BK_dt;
        DataGridViewRow StudentSelectedRow;
        DataGridViewRow BookSelectedRow;
        Color color = Color.FromArgb(51, 51, 76);
        Color BlueColor = Color.FromArgb(35, 110, 184);
        Color gCl=Color.LightGray;
        SqlDataAdapter sda;
        String StName;
        String BkName;
        int student_id=0;
        int BId=0;
        DateTime dat=new DateTime();
        private Button currentButton;
        SqlConnection con = new SqlConnection();
        ConnectionC connect = new ConnectionC();
        MainForm MainForm;



        public ToolTipIcon ToolTipIcon { get; private set; }


        public Borrow(MainForm mainForm)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.f_logo_png_10;
            con = connect.getCon1();
            MainForm = mainForm;
      

            getAllStudentData();
            getAllBookData();
            GetComboBoxData();
            if (Properties.Settings.Default.job == "طالب" )
            {
                students_dataGridView.Visible=false;
            }



            }
        private void AcctiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = BlueColor;
                    if (currentButton.Text == "الكروت المطبوعة")
                    {
                        getAllStudentData();
                        GetComboBoxData();
                    }  
                }
            }
        }
        private void deleteCard()
        {
            object sender=new object();
            EventArgs e=new EventArgs();
            dat = DateTime.Now;
            String updatepkg = "update printedCards1 set amount =0,sold=0,remain=0,date=@date where pkg_id=@pkgId";
            SqlCommand cmd = new SqlCommand(updatepkg, con);
            //cmd.Parameters.AddWithValue("@pkgId", pkgName);
            cmd.Parameters.AddWithValue("@date", dat);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            getAllStudentData();
            ToastMessage toastMessage = new ToastMessage();
            toastMessage.deleted(sender, e);
            toastMessage.TopMost = true;
            toastMessage.Show();
        }

        private void GetComboBoxData()
        {
            var collection = new AutoCompleteStringCollection();
            string[] source = St_dt.AsEnumerable().Select<System.Data.DataRow, String>(x => x.Field<String>("name")).ToArray();
            collection.AddRange(source);

            textBox_St_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox_St_name.AutoCompleteCustomSource = collection;


            var Bkcollection = new AutoCompleteStringCollection();
            string[] Bksource = BK_dt.AsEnumerable().Select<System.Data.DataRow, String>(x => x.Field<String>("B_name")).ToArray();
            collection.AddRange(Bksource);

            textBox_Bk_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox_Bk_name.AutoCompleteCustomSource = Bkcollection;
        }
        private void getAllStudentData()
        {
            String sqlSelect = "select * from students";
            sda = new SqlDataAdapter(sqlSelect, con);
            St_dt = new DataTable();
            sda.Fill(St_dt);
            students_dataGridView.DataSource = St_dt;


        }
        private void getAllBookData()
        {
            String sqlSelect = "select B_id, B_name,author,page_no,content from Books";
            sda = new SqlDataAdapter(sqlSelect, con);
            BK_dt = new DataTable();
            sda.Fill(BK_dt);
            books_dataGridView.DataSource = BK_dt;
        }



        private void updateCard()
        {
            //pkgName = selectedRow.Cells["pkg_id"].Value.ToString();
            //DateTime.TryParse(selectedRow.Cells["date"].Value.ToString(), out dat);
            dat=DateTime.Now;
            object sender = new object();
            EventArgs e = new EventArgs();

            String updateQuery = "getSoldCards";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@pkgName", pkgName);
            cmd.Parameters.AddWithValue("@dat", dat);

            int soldCards;
            con.Open();
            soldCards = (int)cmd.ExecuteScalar();
            con.Close();
            //updateQuery = "update printedCards1 set amount = '" + editamount + "',remain='" + editremain + "',sold='" + soldCards + "',date=@date where pkg_id='" + pkgName + "'";
            //cmd = new SqlCommand(updateQuery, con);
            //cmd.Parameters.AddWithValue("@date", dat);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            //getAllPrintedCardsData();
            ToastMessage toastMessage = new ToastMessage();
            toastMessage.edited(sender, e);
            toastMessage.TopMost = true;
            toastMessage.Show();

        }

        private void PrintedCards_Load(object sender, EventArgs e)
        {
            //getAllPrintedCardsData();
            //textBox_amount.PlaceholderText = "اجباري";
            //label_mul_amount.Hide();

        }
       
     
        private void emp_button_Click(object sender, EventArgs e)
        {
            AcctiveButton(sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            getAllStudentData();
        }



 
        private void add_button_MouseEnter(object sender, EventArgs e)
        {
            Color btColor = BlueColor;
            Color topColor = color;
        }
        private void add_button_MouseLeave(object sender, EventArgs e)
        {
            Color btColor = BlueColor;
            Color topColor = color;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            rjRoundedGradientPanel1.Height = 516;
            panel4.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int isAvailable;
            ToastMessage toastMessage ;
            SqlCommand cmd;
            int Sid;
            label_mul_St_name.Visible = false;
            label_mul_B_name.Visible = false;

                if (textBox_St_name.Texts == "اجباري" || textBox_St_name.Texts == "" || textBox_Bk_name.Texts == "اجباري" || textBox_Bk_name.Texts == "")
                {
                    if (textBox_St_name.Texts == "اجباري" || textBox_St_name.Texts == "")
                        label_mul_St_name.Visible = true;
                    if (textBox_Bk_name.Texts == "اجباري" || textBox_Bk_name.Texts == "")
                        label_mul_B_name.Visible = true;
                }
                else
                {
                    if (BId == 0)
                    {
                        cmd = new SqlCommand("select B_id from Books where B_name='" + textBox_Bk_name.Texts + "'", con);
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            BId = dr.GetInt32(0);

                        }
                        else
                        {
                            toastMessage = new ToastMessage();
                            toastMessage.warning(sender, e);
                            toastMessage.MessageText("لايوجد كتاب بهذا الاسم");
                            toastMessage.TopMost = true;
                            toastMessage.Show();
                        }
                        con.Close();
                    }
                    if (student_id == 0)
                    {
                        cmd = new SqlCommand("select s_id from students where name='" + textBox_St_name.Texts + "'", con);
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            student_id = dr.GetInt32(0);

                        }
                        else
                        {
                            toastMessage = new ToastMessage();
                            toastMessage.warning(sender, e);
                            toastMessage.MessageText("لايوجد طالب بهذا الاسم");
                            toastMessage.TopMost = true;
                            toastMessage.Show();
                        }
                        con.Close();
                    }
                    if (student_id != 0 && BId != 0)
                    {
                        cmd = new SqlCommand("select isAvailable from Books where B_id='" + BId + "'", con);
                        con.Open();
                        isAvailable = (Int32)cmd.ExecuteScalar();
                        con.Close();
                        if (isAvailable == 1)
                        {

                            cmd = new SqlCommand("select s_id from costumers where s_id='" + student_id + "'", con);
                            con.Open();
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                Sid = dr.GetInt32(0);

                                toastMessage = new ToastMessage();
                                toastMessage.warning(sender, e);
                                toastMessage.MessageText("يجب استعادة الكتاب السابق من هذا الطالب");
                                toastMessage.TopMost = true;
                                toastMessage.Show();
                            }
                            else
                            {
                                con.Close();
                                DateTime date = new DateTime();
                                date = DateTime.Now;
                                String borrowQuery = "borrowBook";
                                cmd = new SqlCommand(borrowQuery, con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@s_id", student_id);
                                cmd.Parameters.AddWithValue("@B_id", BId);
                                cmd.Parameters.AddWithValue("@date", date);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                textBox_St_name.Texts = "";
                                textBox_Bk_name.Texts = "";
                                toastMessage = new ToastMessage();
                                toastMessage.added(sender, e);
                                toastMessage.MessageText("تمت الاعاره بنجاح");
                                toastMessage.TopMost = true;
                                toastMessage.Show();
                                getAllStudentData();
                                getAllBookData();

                            }
                            con.Close();
                        }
                        else
                        {
                            toastMessage = new ToastMessage();
                            toastMessage.warning(sender, e);
                            toastMessage.MessageText("هذا الكتاب غير متوفر في الوقت الحالي");
                            toastMessage.TopMost = true;
                            toastMessage.Show();
                        }

                    }
                }
        }
        private void rjComboBox41_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = textBox_St_name;
                textBox_St_name.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void textBox_amount_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                borrow_button.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                textBox_St_name.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                borrow_button.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void MonthlyUpdate_btn_Click(object sender, EventArgs e)
        {

            //CardsMontlyUpdate cardsMontlyUpdate = new CardsMontlyUpdate(this);
            //cardsMontlyUpdate.Show();
        }
        private void MonthlyUpdate_btn_MouseEnter(object sender, EventArgs e)
        {
            Color btColor = BlueColor;
            Color topColor = color;
        }
        private void MonthlyUpdate_btn_MouseLeave(object sender, EventArgs e)
        {
            Color btColor = BlueColor;
            Color topColor = color;
        }
        private void textBox_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }
        private void panel3_MouseEnter(object sender, EventArgs e)
        {

            MainFormClass mainFormClass = new MainFormClass(MainForm);

            if (MainForm.sideParExpand)
            {
                mainFormClass.minimizeWhenLeave();

            }
        }

        private void MonthlyUpdate_btn_MouseHover(object sender, EventArgs e)
        {
            ToolTip TlTip = new ToolTip();
            {
                ToolTipIcon = ToolTipIcon.Info;

            }
                //TlTip.SetToolTip(this.MonthlyUpdate_btn, "يتم استخدامها كل نهاية شهر,تقوم بأخذ الكروت المتبقية في الاجل +الكروت الغير مستخدمة وتضعها في الكمية المطبوعة");
        }

        private void books_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (books_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    /*تعبئة الحقول عند الضغط على صف في الجدول*/
                    books_dataGridView.CurrentRow.Selected = true;
                    BookSelectedRow = books_dataGridView.Rows[e.RowIndex];
                    Int32.TryParse(BookSelectedRow.Cells["B_id"].Value.ToString(), out BId);
                    BkName = BookSelectedRow.Cells["B_name"].Value.ToString();
                    textBox_Bk_name.Texts = BkName;

                }
            }
            catch
            {
                BookSelectedRow = null;
            }
        }

        private void student_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (students_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    /*تعبئة الحقول عند الضغط على صف في الجدول*/
                    students_dataGridView.CurrentRow.Selected = true;
                    StudentSelectedRow = students_dataGridView.Rows[e.RowIndex];
                    Int32.TryParse(StudentSelectedRow.Cells["s_id"].Value.ToString(), out student_id);
                    StName= StudentSelectedRow.Cells["name"].Value.ToString();
                    textBox_St_name.Texts = StName;

                }
            }
            catch
            {
                StudentSelectedRow = null;
            }
        }

        private void students_dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in students_dataGridView.Rows)
            {
                Color color = Color.FromArgb(51, 51, 76);
                r.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
                r.DefaultCellStyle.ForeColor = color;
                r.Height = 39;
            }
        }

        private void books_dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in books_dataGridView.Rows)
            {
                Color color = Color.FromArgb(51, 51, 76);
                r.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
                r.DefaultCellStyle.ForeColor = color;
                r.Height = 44;
            }
        }

        private void textBox_Bk_name_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = textBox_St_name;
                textBox_St_name.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
