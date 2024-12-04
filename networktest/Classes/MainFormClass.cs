using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using networktest.Reports;

namespace networktest.Classes
{
    internal class MainFormClass
    {
        ConnectionC connect = new ConnectionC();
        SqlConnection con = new SqlConnection();
        Color color = Color.FromArgb(224, 224, 224);
        Color BlueColor2 = Color.FromArgb(2, 177, 228);
        private Button currentButton;
        private Label currentLabel;
        MainForm MainForm;
        private Button MouseHoverButton;
        private Label MouseHoverLabel;
        int year = Properties.Settings.Default.year;

        public MainFormClass(MainForm mainForm)
        {
            con = connect.getCon1();
            MainForm = mainForm;

        }
        // دالة تقوم بانشاء حقول جديدة في قاعدة البيانات في الارباح الشهريه للسنة الجديدة
        public void SlideButton()
        {
            if (MainForm.sidePanel.Width == 60)
            {
                MainForm.sidePanel.Width = MainForm.sidePanel.MaximumSize.Width;
                MainForm.panel2.Width = MainForm.panel3.Width - MainForm.sidePanel.MaximumSize.Width;
                MainForm.label_job.TextAlign = ContentAlignment.MiddleCenter;

            }
            else
            {
                MainForm.sidePanel.Width = MainForm.sidePanel.MinimumSize.Width;
                MainForm.panel2.Width = MainForm.panel3.Width - MainForm.sidePanel.Width;
                MainForm.label_job.TextAlign = ContentAlignment.MiddleLeft;
            }
        }
        public void LogOutButton()
        {
            String name = Properties.Settings.Default.name;
            String insertStat = "update users set status=0 where user_name='" + name + "'";
            con.Open();

            SqlCommand cmd = new SqlCommand(insertStat, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MainForm.Hide();
            Login login = new Login();
            login.Show();
        }
        public void btn_clic()
        {
            MainForm.student_clic = false;
            MainForm.books_clic = false;
            MainForm.sales_clic = false;
            MainForm.borrowed_clic = false;
            MainForm.borrow_clic = false;
            MainForm.emp_clic = false;
            MainForm.users_clic = false;
            MainForm.profile_clic = false;
            MainForm.setting_clic = false;
            MainForm.reports_click = false;
        }
        public void Reset()
        {
            DisableButton();
            MainForm.lblTitle.Text = "الرئيسية";
            currentButton = null;
            MainForm.btn_closePanel.Visible = false;
            currentLabel = null;
        }
        public void mainInerFace(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int availableBooks, borredBooks, students, users, employees, devices,
                printedMega;
            double pays, bank;
            decimal Loans;
            con = connect.getCon1();
            SqlCommand cmd = new SqlCommand("MainInterFace", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                borredBooks = dr.GetInt32(0);
                availableBooks = dr.GetInt32(1);
                students = dr.GetInt32(2);
                users = dr.GetInt32(3);
                employees = dr.GetInt32(4);
                //bank = dr.GetDouble(5);
                //devices = dr.GetInt32(6);
                //Loans = Convert.ToInt32(dr.GetDecimal(7));
                //printedMega = (dr.GetInt32(8) / 1024);
                MainForm.availBookShow_label.Text = availableBooks.ToString("N0");
                MainForm.labe_BorredBook.Text = borredBooks.ToString("N0");
                MainForm.label_students.Text = students.ToString("N0");
                MainForm.users_label.Text = users.ToString("N0");
                MainForm.label_emp.Text = employees.ToString("N0");
                //MainForm.label_depts.Text = dept.ToString("N1") +" $";
                //MainForm.label_usedGiga.Text = usedMega.ToString("N0");
                //MainForm.bank_label.Text = bank.ToString("N0");
                //MainForm.DevicesCount_label.Text = devices.ToString("N0");
                //MainForm.loansShow_label.Text = Loans.ToString("N0");
                //MainForm.printedMGShow_label.Text = printedMega.ToString("N0");
            }
            con.Close();
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in MainForm.sidePanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.ForeColor = color;
                }
            }
            btn_clic();
        }
        public void clicButtonImage()
        {
            MainForm.btn_students.Image = Properties.Resources.graduated;
            MainForm.button_borrow.Image = Properties.Resources.borrow__3_;
            MainForm.btn_books.Image = Properties.Resources.book;
            MainForm.button_borredB.Image = Properties.Resources.payment;
            MainForm.btn_name.Image = Properties.Resources.settings_10010484;
            MainForm.button_setting.Image = Properties.Resources.setting_771203;
            MainForm.button_emp.Image = Properties.Resources.employee__2_;
            MainForm.button_users.Image = Properties.Resources.team__1_;
            MainForm.button_reports.Image = Properties.Resources.analytics_6884182;

        }
        public void ActivateButton(object btnSender)
        {
            MouseHoverButton = (Button)btnSender;
            MouseHoverButton.ForeColor = BlueColor2;

            if (MouseHoverButton.Name == "btn_name")
            {
                MainForm.btn_name.Image = Properties.Resources.user_protection_6672445;
            }
            else if (MouseHoverButton.Name == "btn_students")
            {
                MainForm.btn_students.Image = Properties.Resources.graduated__1_;
            }
            else if (MouseHoverButton.Name == "button_borrow")
            {
                MainForm.button_borrow.Image = Properties.Resources.borrow__4_;
            }
            else if (MouseHoverButton.Name == "btn_books")
            {
                MainForm.btn_books.Image = Properties.Resources.book__1_;
            }
            else if (MouseHoverButton.Name == "button_borredB")
            {
                MainForm.button_borredB.Image = Properties.Resources.payment__1_;
            }
            else if (MouseHoverButton.Name == "button_setting")
            {
                MainForm.button_setting.Image = Properties.Resources.setting_771152_copy;
            }
            else if (MouseHoverButton.Name == "button_reports")
            {
                MainForm.button_reports.Image = Properties.Resources.analytics_6883516;
            }
            else if (MouseHoverButton.Name == "button_emp")
            {
                MainForm.button_emp.Image = Properties.Resources.employee__1_;
            }
            else if (MouseHoverButton.Name == "button_users")
            {
                MainForm.button_users.Image = Properties.Resources.team;
            }
        }
        public void conTestAndOpenForm(object sender)
        {
            EventArgs e = new EventArgs();
            try
            {
                if (connect.isConnected1() == true)
                {

                    OpenChildForm(sender);

                }
            }
            catch
            {
                ToastMessage toastMessage = new ToastMessage();
                toastMessage.warning(sender, e);
                toastMessage.MessageText("هذا السيرفر غير موجود");
                toastMessage.Show();
                MainForm.btn_closePanel.PerformClick();
            }
        }
        private void OpenChildForm(object btnSender)
        {
            String title = "";
            Form childForm = new Form();
                if (currentButton != (Button)btnSender)
                {
                    clicButtonImage();
                    DisableButton();
                    Color color = Color.FromArgb(2, 177, 228);
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = color;
                if (currentButton.Name == "btn_name")
                {
                    childForm = new Profile(MainForm);
                    title = "الحساب الشخصي";
                    MainForm.profile_clic = true;
                    MainForm.btn_name.Image = Properties.Resources.user_protection_6672445;
                    if (MainForm.activeForm != null)
                        MainForm.activeForm.Close();
                    MainForm.activeForm = childForm;
                }
                if (currentButton.Name == "btn_students")
                    {
                        childForm = new Student(MainForm);
                        title = "إدارة الطلاب";
                        MainForm.student_clic = true;
                        MainForm.btn_students.Image = Properties.Resources.graduated__1_;
                        if (MainForm.activeForm != null)
                                MainForm.activeForm.Close();
                            MainForm.activeForm = childForm;

                    }
                    else if (currentButton.Name == "button_borrow")
                    {

                        childForm = new Borrow(MainForm);
                        title = "اعارة الكتب";
                        MainForm.borrow_clic = true;
                        MainForm.button_borrow.Image = Properties.Resources.borrow__4_;


                    if (MainForm.activeForm != null)
                            MainForm.activeForm.Close();
                        MainForm.activeForm = childForm;

                    }
                    else if (currentButton.Name == "btn_books")
                    {
                        childForm = new Books(MainForm);
                        title = "إدارة الكتب";
                        MainForm.books_clic = true;
                        MainForm.btn_books.Image = Properties.Resources.book__1_;

                    if (MainForm.activeForm != null)
                            MainForm.activeForm.Close();
                        MainForm.activeForm = childForm;
                    }
                    else if (currentButton.Name == "button_borredB")
                    {
                        childForm = new BookReturn(MainForm);
                        title = "الكتب المستعارة";
                        MainForm.borrowed_clic = true;
                        MainForm.button_borredB.Image = Properties.Resources.payment__1_;
                        if (MainForm.activeForm != null)
                            MainForm.activeForm.Close();
                        MainForm.activeForm = childForm;
                    }
                else if (currentButton.Name == "button_emp")
                {
                    childForm = new Employees(MainForm);
                    title = "الموظفين";
                    MainForm.emp_clic = true;
                    MainForm.button_emp.Image = Properties.Resources.employee__1_;
                    if (MainForm.activeForm != null)
                        MainForm.activeForm.Close();
                    MainForm.activeForm = childForm;
                }
                else if (currentButton.Name == "button_users")
                {
                    childForm = new Users(MainForm);
                    title = "المستخدمين";
                    MainForm.users_clic = true;
                    MainForm.button_users.Image = Properties.Resources.team;
                    if (MainForm.activeForm != null)
                        MainForm.activeForm.Close();
                    MainForm.activeForm = childForm;
                }
                else if (currentButton.Name == "button_setting")
                    {
                        Setting setting = new Setting(MainForm);
                        childForm = setting;
                        title = "الاعدادات";
                        setting.pictureBox2.Hide();
                        MainForm.setting_clic = true;
                        MainForm.button_setting.Image = Properties.Resources.setting_771152_copy;
                        if (MainForm.activeForm != null)
                            MainForm.activeForm.Close();
                        MainForm.activeForm = childForm;
                    }
                    else if (currentButton.Name == "button_reports")
                    {
                        childForm = new PrintForm(MainForm);
                        title = "التقارير";
                        MainForm.reports_click = true;
                        MainForm.button_reports.Image = Properties.Resources.analytics_6883516;
                        if (MainForm.activeForm != null)
                            MainForm.activeForm.Close();
                        MainForm.activeForm = childForm;
                    }
                else if (currentButton.Name == "button1")
                {
                    childForm = new Test(MainForm);
                    title = "تجربه";
                    MainForm.button_emp.Image = Properties.Resources.analytics_6883516;
                    if (MainForm.activeForm != null)
                        MainForm.activeForm.Close();
                    MainForm.activeForm = childForm;
                    currentButton.ForeColor = Color.LightGray;
                }
                MainForm.lblTitle.Text = title;
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    MainForm.MainPanel.Controls.Add(childForm);
                    MainForm.MainPanel.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                    MainForm.btn_closePanel.Visible = true;
                }

            
        }
        public void ButtonMouseLeave(object btnSender)
        {
            MouseHoverButton = (Button)btnSender;
            if (MouseHoverButton.Name == "btn_name")
            {
                if (MainForm.profile_clic == false)
                {
                    MainForm.btn_name.Image = Properties.Resources.settings_10010484;
                    MainForm.btn_name.ForeColor = Color.LightGray;
                }
            }
            else if (MouseHoverButton.Name == "btn_students")
            {
                if (MainForm.student_clic == false)
                {
                    MainForm.btn_students.Image = Properties.Resources.graduated;
                    MainForm.btn_students.ForeColor = Color.LightGray;
                }

            }
            else if (MouseHoverButton.Name == "button_borrow")
            {

                if (MainForm.borrow_clic == false)
                {
                    MainForm.button_borrow.Image = Properties.Resources.borrow__3_;
                    MainForm.button_borrow.ForeColor = Color.LightGray;
                }
            }
            else if (MouseHoverButton.Name == "btn_books")
            {
                if (MainForm.books_clic == false)
                {
                    MainForm.btn_books.Image = Properties.Resources.book;
                    MainForm.btn_books.ForeColor = Color.LightGray;
                }
            }
            else if (MouseHoverButton.Name == "button_borredB")
            {
                if (MainForm.borrowed_clic == false)
                {
                    MainForm.button_borredB.Image = Properties.Resources.payment;
                    MainForm.button_borredB.ForeColor = Color.LightGray;
                }
            }
            else if (MouseHoverButton.Name == "button_setting")
            {
                if (MainForm.setting_clic == false)
                {
                    MainForm.button_setting.Image = Properties.Resources.setting_771203;
                    MainForm.button_setting.ForeColor = Color.LightGray;

                }
            }
            else if (MouseHoverButton.Name == "button_reports")
            {
                if (MainForm.reports_click == false)
                {
                    MainForm.button_reports.Image = Properties.Resources.analytics_6884182;
                    MainForm.button_reports.ForeColor = Color.LightGray;
                }
            }
            else if (MouseHoverButton.Name == "button_emp")
            {
                if (MainForm.emp_clic == false)
                {
                    MainForm.button_emp.Image = Properties.Resources.employee__2_;
                    MainForm.button_emp.ForeColor = Color.LightGray;
                }
            }
            else if (MouseHoverButton.Name == "button_users")
            {
                if (MainForm.users_clic == false)
                {
                    MainForm.button_users.Image = Properties.Resources.team__1_;
                    MainForm.button_users.ForeColor = Color.LightGray;
                }
            }


        }

        public void LabelMouseLeave(object btnSender)
        {
            if (MouseHoverLabel != (Label)btnSender)
            {
                MouseHoverLabel = (Label)btnSender;
                MouseHoverLabel.ForeColor = color;
            }
        }
        public void LabelMouseEnter(object btnSender)
        {
            if (MouseHoverLabel != (Label)btnSender)
            {
                MouseHoverLabel = (Label)btnSender;
                MouseHoverLabel.ForeColor = BlueColor2;
            }
        }
        public void maximaizeWhenEnter()
        {
            if (!MainForm.sideParExpand)
            {
                MainForm.sidePanel.Width = MainForm.sidePanel.MaximumSize.Width;
                MainForm.panel2.Width = MainForm.panel3.Width - MainForm.sidePanel.MaximumSize.Width;
                MainForm.label_job.TextAlign = ContentAlignment.MiddleCenter;

                MainForm.save_button.Size = new System.Drawing.Size(160, 40);
                MainForm.save_button.Location = new Point(38, 610);
                MainForm.save_button.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
                MainForm.save_button.Text = "تسجيل الخروج";

                MainForm.sideParExpand = true;
            }

        }
        public void minimizeWhenLeave()
        {
            if (MainForm.sideParExpand)
            {
                MainForm.sidePanel.Width = MainForm.sidePanel.MinimumSize.Width;
                MainForm.panel2.Width = MainForm.panel3.Width - MainForm.sidePanel.Width;
                MainForm.label_job.TextAlign = ContentAlignment.MiddleLeft;
                MainForm.save_button.Text = "";
                MainForm.save_button.Location = new Point(7, 610);
                MainForm.save_button.Size = new System.Drawing.Size(43, 40);
                MainForm.save_button.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
                MainForm.sideParExpand = false;


            }
        }
    }
    
}
