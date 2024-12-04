using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using DevExpress.Utils;
using networktest.Classes;
using System.Threading;
using networktest.Reports;
using System.Media;
using DevExpress.XtraCharts.Native;
namespace networktest
{
    public partial class MainForm : Form
    {
        public bool student_clic =false, books_clic = false, sales_clic = false, borrowed_clic = false;
        public bool emp_clic = false, users_clic = false, borrow_clic = false, profile_clic = false;
        public bool setting_clic = false, reports_click = false;
        public bool sideParExpand;
        public Form activeForm;
        DateTime currentDate = new DateTime();
         int move;
         int movex;
         int movey;
        int count = 0;
        public MainForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw,true);
        }
        //private void MainForm_Resize(object sender, EventArgs e)
        //{
        //    this.Invalidate();
        //}

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg==0x84)
            {
                Point pos=new Point(m.LParam.ToInt32());
                pos= this.PointToClient(pos);
                if(pos.Y<cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if(pos.X>= this.ClientSize.Width-cGrip&&pos.Y>= this.ClientSize.Height-cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);

        }
        private void MainForm1_Load(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            main.mainInerFace(sender, e);
            label_job.TextAlign = ContentAlignment.MiddleLeft;
            label_job.Text=Properties.Settings.Default.job;
            btn_name.Text = Properties.Settings.Default.name;
            timer1.Start();
            //main.newYear();

            if (label_job.Text == "مدير")
            {
                btn_students.Enabled = true;
                button_borrow.Enabled = true;
                btn_books.Enabled = true;
                button_borredB.Enabled = true;
                button_emp.Enabled = true;
                button_users.Enabled = true;
                button_reports.Enabled = true;
            }
            else if(label_job.Text == "موظف")
            {
                btn_students.Enabled = true;
                button_emp.Enabled = false;
                button_users.Enabled = false;
                button_borrow.Enabled = true;
                btn_books.Enabled = true;
                button_borredB.Enabled = true;
                button_reports.Enabled = false;


            }
            else 
            {
                btn_students.Enabled = false;
                button_borrow.Enabled = true;
                btn_books.Enabled = true;
                button_borredB.Enabled = false;
                button_emp.Enabled = false;
                button_users.Enabled = false;
                button_reports.Enabled = false;


            }

        }
        private void btn_add_pkg_MouseEnter(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            main.maximaizeWhenEnter();
            main.ActivateButton(sender);
        }
        private void MonthlyPrint(object sender, EventArgs e)
        {
      
        }

        private void btn_name_MouseLeave(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            main.ButtonMouseLeave(sender);
        }
        private void btn_name1_Click(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            main.conTestAndOpenForm(sender);
        }
        private void label_MouseLeave(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            main.LabelMouseLeave(sender);
        }
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            main.minimizeWhenLeave();
        }
        private void label1_Click1(object sender, EventArgs e)
        {

        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            main.LabelMouseEnter(sender);
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

        public ToolTipIcon ToolTipIcon { get; private set; }
        public ToolTipTitleItem ToolTipTitle { get; private set; }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
                this.Cursor=Cursors.NoMove2D;
            }
        }
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
            this.Cursor = Cursors.Default;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
            //con.Close();
            Application.Exit();
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
        private void Logout_button_Click(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            main.LogOutButton();     
        }
        private void button2_Click_2(object sender, EventArgs e)
        {
            SlideButton();
        }
        private void SlideButton()
        {
            MainFormClass main = new MainFormClass(this);
            main.SlideButton();
        }   
        private void button2_Click_1(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            if (activeForm != null)
                activeForm.Close();
            //main.mainInerFace(sender, e);
            main.Reset();
            main.clicButtonImage();
            main.btn_clic();
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.xicopy;
        }

        private void notesPicBox_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            
            count += 10;
            if(count==50)
            {
                timer1.Stop();
                MonthlyPrint(sender, e);
            }
        }

        private void label_job_MouseEnter(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            main.maximaizeWhenEnter();
        }

        private void bunifuCards8_MouseEnter(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            main.minimizeWhenLeave();
        }

        private void label_job_Click(object sender, EventArgs e)
        {
            //Console.Beep(10000, 500);
            SystemSounds.Asterisk.Play();
            //SystemSounds.Exclamation.Play();
            //SystemSounds.Hand.Play();
            //SystemSounds.Exclamation.Play();
        }

        private void save_button_MouseEnter(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            main.maximaizeWhenEnter();
            main.ActivateButton(sender);
            save_button.BorderColor = Color.Brown;
            save_button.ForeColor = Color.Brown;
        }

        private void save_button_MouseLeave(object sender, EventArgs e)
        {
            save_button.BorderColor = Color.FromArgb(0, 147, 186);
            save_button.ForeColor = Color.FromArgb(0, 147, 186);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (RJMessageBox.Shows("هل تريد تسجيل الخروج؟","تسجيل الخروج","بقاء") == DialogResult.OK)
            {
                MainFormClass main = new MainFormClass(this);
                main.LogOutButton();
                Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
            }
        }


        private void button_setting_MouseHover(object sender, EventArgs e)
        {
            ToolTip TlTip = new ToolTip();
            {
                ToolTipIcon = ToolTipIcon.Info;

            }
            TlTip.SetToolTip(this.button_setting, "تغير نص الاتصال");
        }
        private void btn_closePanel_MouseEnter(object sender, EventArgs e)
        {
            btn_closePanel.Image = Properties.Resources.home__6_;
        }

        private void btn_closePanel_MouseLeave(object sender, EventArgs e)
        {
            btn_closePanel.Image = Properties.Resources.home__4_;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            main.conTestAndOpenForm(sender);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            main.conTestAndOpenForm(sender);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.xi;
        }
        private void btn_name_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-sa"));
        }
        private void button5_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }
        private void sidePanel_MouseEnter(object sender, EventArgs e)
        {
            MainFormClass main = new MainFormClass(this);
            main.maximaizeWhenEnter();
        }  
        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            PictureBox currentPicture;
            currentPicture=(PictureBox)sender;
            if (currentPicture.Name == "calculatorPicBox")
                currentPicture.Image = Properties.Resources.calculator_9127053;
            else if (currentPicture.Name == "notesPicBox")
                currentPicture.Image = Properties.Resources.post_it__1_;
            else if (currentPicture.Name == "feedPicBox")
                currentPicture.Image = Properties.Resources.take_profit__2_;
            else if (currentPicture.Name == "searchPicBox")
                currentPicture.Image = Properties.Resources.loupe__1_;
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            PictureBox currentPicture;
            currentPicture = (PictureBox)sender;
            if (currentPicture.Name == "calculatorPicBox")
                currentPicture.Image = Properties.Resources.calculator_9127037;
            else if (currentPicture.Name == "notesPicBox")
                currentPicture.Image = Properties.Resources.post_it;
            else if (currentPicture.Name == "feedPicBox")
                currentPicture.Image = Properties.Resources.take_profit__1_;
            else if (currentPicture.Name == "searchPicBox")
                currentPicture.Image = Properties.Resources.loupe;
        }    
    }
}
