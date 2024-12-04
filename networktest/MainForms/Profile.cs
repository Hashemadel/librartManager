using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using networktest.Classes;

namespace networktest
{
    public partial class Profile : Form
    {
        SqlConnection con = new SqlConnection();
        ConnectionC connection = new ConnectionC();
        ChangePass changePass=new ChangePass();
        MainForm MainForm;
        public Profile(MainForm mainForm)
        {
            con=connection.getCon1();
            InitializeComponent();
            text_name.Texts = Properties.Settings.Default.name;
            text_user_name.Texts = Properties.Settings.Default.name;
            //name = text_name.Texts;
            text_pass.Texts= Properties.Settings.Default.pass;
            text_job.Texts = Properties.Settings.Default.job ;
            text_name.ReadOnly(true);
            text_user_name.ReadOnly(true) ;
            text_job.ReadOnly(true) ;
            text_pass.ReadOnly(true) ;
            MainForm = mainForm;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            userName_panel.Hide();
            ChangePass changePas = new ChangePass();
            changePas.Show();
            
        }

        private void Profile_Load(object sender, EventArgs e)
        {
           userName_panel.Hide();

            //try
            //{
            //    comboBox1.Text = Properties.Settings.Default.year.ToString();
            //}
            //catch
            //{
                //comboBox1.SelectedIndex = 0;
            //}

        }

        private void button_userNameCh_Click(object sender, EventArgs e)
        {
            userName_panel.Show();
            this.ActiveControl = text_newUserName;
            text_newUserName.Focus();
        }

        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            String oldUserName=text_user_name.Texts;
            String newUserName=text_newUserName.Texts;

            String checkUserName = "select user_name from users where user_name='" + newUserName + "'";
            SqlCommand cmd= new SqlCommand(checkUserName,con);
            con.Open();
            SqlDataReader dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                ToastMessage toastMessage = new ToastMessage();
                toastMessage.warning(sender, e);
                toastMessage.TitleMessage = "اسم المستخدم هذا مستخدم";
                toastMessage.MessageText("يجب اختيار اسم مستخدم فريد");
                toastMessage.Show();
            }
            else
            {
                con.Close();
                String editUserName = "update users set user_name ='" + newUserName + "' where user_name='" + oldUserName + "'";
                cmd = new SqlCommand(editUserName, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Properties.Settings.Default.username = newUserName;
                Properties.Settings.Default.Save();
                newUserName = Properties.Settings.Default.username;
                text_user_name.Texts = newUserName;
                String insertStat = "update users set status=0 where user_name='" + newUserName + "'";
                con.Open();
                cmd = new SqlCommand(insertStat, con);
                cmd.ExecuteNonQuery();
                con.Close();
                ToastMessage toastMessage = new ToastMessage();
                toastMessage.edited(sender, e);
                toastMessage.Show();
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            userName_panel.Hide();
        }

        private void text_newUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_edit.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
                
        }

        private void button_userNameCh_MouseEnter(object sender, EventArgs e)
        {
            button_userNameCh.ForeColor = Color.FromArgb(0, 184, 186);

        }

        private void button_userNameCh_MouseLeave(object sender, EventArgs e)
        {
            button_userNameCh.ForeColor = Color.DeepSkyBlue;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(0, 184, 186);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.DeepSkyBlue;
        }
        private void panel3_MouseEnter(object sender, EventArgs e)
        {

            MainFormClass mainFormClass = new MainFormClass(MainForm);

            if (MainForm.sideParExpand)
            {
                mainFormClass.minimizeWhenLeave();

            }
        }


    }
}
