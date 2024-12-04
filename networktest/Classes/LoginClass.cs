using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using networktest.RJControls;
using DevExpress.XtraCharts.Native;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace networktest
{
    internal class LoginClass
    {
        object sender=new object();
        EventArgs e=new EventArgs();
        SqlConnection con = new SqlConnection();
        ConnectionC connect = new ConnectionC();
        ToastMessage toastMessage = new ToastMessage();
        MainForm mainForm;
        public LoginClass()
        {
            con = connect.getCon1();
        }
        //دالة للتحقق من اذا كان المستخدم متصل ام لا
        public bool IsActive()
        {
           String userName = Properties.Settings.Default.username;
            SqlCommand cmd = new SqlCommand("select STATUS from users where user_name='" + userName + "'", con);
            con.Open();

            int isActive = (Int32)cmd.ExecuteScalar();
            con.Close();
            if (isActive == 1)
                return true;
            else
                return false;

        }



        //دالة تشغيل واجهة البداية
        public Boolean startingSplashLoad(Panel loadPanel,Timer timer1)
        {
            loadPanel.Width += 7;
            if (loadPanel.Width >= 460)
            {

                timer1.Stop();
                try
                {
                    if (connect.isConnected1() == true)
                    {
                        if (IsActive())
                        {
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                        }
                        else
                        {
                            Login login = new Login();
                            login.Show();
                        }
                    }
                    
                }
                catch(Exception ex) 
                {
                    ToastMessage toast = new ToastMessage();
                    toast.warning(sender, e);
                    toast.MessageText("يجب ادخال نص الاتصال");
                    toast.Show();
                    Setting setting = new Setting();
                    setting.Show();

                }
                timer1.Enabled = false;
                return true;

            }
        
                return false;
           
        }
        //show and hide password icon click
        public void showAndHidePass(RJTextBox txt_pass,PictureBox passEye)
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
        //Login button click
        public Boolean BtnLogin_Clic(RJTextBox txt_pass, RJTextBox txt_user_name, Label label_mul_pass, Label label_mul_userName)
        {
            toastMessage = new ToastMessage();
            try
            {
                if (connect.isConnected1() == true)
                {
                    label_mul_pass.Visible=false;
                    label_mul_userName.Visible = false;
                    if (txt_user_name.Texts == "" || txt_pass.Texts == "")
                    {
                        if (txt_user_name.Texts == "")
                        {
                            label_mul_userName.Show();

                        }
                        if (txt_pass.Texts == "")
                        {
                            label_mul_pass.Show();
                        }
                        return false;
                    }
                    else
                    {

                        String pass;
                        String userName = txt_user_name.Texts;
                        String inPass = txt_pass.Texts;
                        String name;
                        String job;
                        String select = "select password,user_name,job from users where user_name='" + userName + "'";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(select, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            pass = dr.GetString(0);
                            name = dr.GetString(1);
                            job = dr.GetString(2);

                            con.Close();
                            if (inPass == pass)
                            {
                                MainForm mainForm = new MainForm();
                                String insertStat = "update users set status=1 where user_name='" + userName + "'";
                                con.Open();
                                cmd = new SqlCommand(insertStat, con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                Properties.Settings.Default.pass = pass;
                                Properties.Settings.Default.username = userName;
                                Properties.Settings.Default.name = name;
                                Properties.Settings.Default.job = job;
                                Properties.Settings.Default.Save();
                                //mainForm.Show();
                                //this.Hide();
                                return true;

                            }
                            else
                            {
                                toastMessage.warning(sender, e);
                                toastMessage.MessageText("كلمة السر خاطئة");
                                toastMessage.Show();
                                return false;
                            }
                        }
                        else
                        {
                            toastMessage.warning(sender, e);
                            toastMessage.MessageText("اسم المستخدم هذا غير موجود");
                            toastMessage.Show();
                            con.Close();
                            return false;
                        }
                    }

                }
                else
                {
                    return false;
                }
            }
            catch
            {
                toastMessage.warning(sender, e);
                toastMessage.MessageText("يجب ادخال نص الاتصال او تشغيل المضيف");
                toastMessage.Show();
                return false;
            }
        }
    }
}
