using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using networktest.RJControls;
using System.Globalization;
using networktest.Classes;
namespace networktest
{
    public partial class Setting : Form
    {

        public static Setting instance;
        /*        EmployeesSalary Employees = new EmployeesSalary();*/
        ConnectionC connect= new ConnectionC();
        MainForm MainForm;
        bool isMain=false;
        public Setting(MainForm mainForm)
        {
            InitializeComponent();
            instance = this;
            text_server.setTextAlign(HorizontalAlignment.Center);
            rjTextBox_password.setTextAlign(HorizontalAlignment.Center);
            rjTextBox_userName.setTextAlign(HorizontalAlignment.Center);
            MainForm = mainForm;
            isMain = true;
        }
        public Setting()
        {
            InitializeComponent();
            instance = this;
            text_server.setTextAlign(HorizontalAlignment.Center);
            rjTextBox_password.setTextAlign(HorizontalAlignment.Center);
            rjTextBox_userName.setTextAlign(HorizontalAlignment.Center);
            isMain=false ;
            
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
        public void showAndHidePass(RJTextBox txt_pass, PictureBox passEye)
        {
            if (txt_pass.PasswordChar == true)
            {
                txt_pass.PasswordChar = false;
                passEye.Image = Properties.Resources.hide;
            }
            else
            {
                txt_pass.PasswordChar = true;
                passEye.Image = Properties.Resources.show;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = text_server;
            text_server.Focus();
        }

        private void rgRoundedButton1_Click(object sender, EventArgs e)
        {
            const string qu = "\"";
            String server = text_server.Texts;
            String userName=rjTextBox_userName.Texts;
            String password=rjTextBox_password.Texts;
            var constr = "metadata=res://*/NetworkDataBase.csdl|res://*/NetworkDataBase.ssdl|res://*/NetworkDataBase.msl;provider=System.Data.SqlClient;provider connection string="+qu+";data source=" + server + ";initial catalog=Network;persist security info=True;user id=" + userName + ";password=" + password + ";encrypt=False;MultipleActiveResultSets=True;App=EntityFramework&quot;";
            //Server = myServerAddress; Database = myDataBase; User Id = myUsername; Password = myPassword;
            String connection = "Server = " + server + "; Database = library; User Id = " + userName + "; Password = " + password + "";
           // String connection = "Server=" + server + ";Database=Network;Trusted_Connection=True";
           var config=ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["NetworkEntities1"].ConnectionString=constr;
            config.Save();
            ConfigurationManager.RefreshSection("connectionString");
            connect.setCon2(connection);
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

      

        private void rjTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = rjTextBox_userName;
                rjTextBox_userName.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void rjTextBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                save_button.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void rjTextBox_userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = rjTextBox_password;
                rjTextBox_password.Focus();
                passEye.Visible = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void passEye_Click(object sender, EventArgs e)
        {
            showAndHidePass(rjTextBox_password, passEye);
        }

        private void text_server_Click(object sender, EventArgs e)
        {
            passEye.Visible = false;
        }

        private void rjTextBox_userName_Click(object sender, EventArgs e)
        {
            passEye.Visible = false;
        }

        private void rjTextBox_password_Click(object sender, EventArgs e)
        {
            passEye.Visible = true;
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }
        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            if(isMain)
            {
                MainFormClass mainFormClass = new MainFormClass(MainForm);

                if (MainForm.sideParExpand)
                {
                    mainFormClass.minimizeWhenLeave();

                }
            }
            
        }
    }
}
