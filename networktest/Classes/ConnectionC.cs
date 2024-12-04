using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace networktest
{
    internal class ConnectionC
    {
        //SqlConnection con = new SqlConnection("Server=HASHEM-LAPTOP\\SQLEXPRESS;Database=Network;Trusted_Connection=True");
        SqlConnection con = new SqlConnection();
        public SqlConnection getCon1()
        {

            String conn = Properties.Settings.Default.phpserver;
            con = new SqlConnection(conn);
            return con;
        }

        public void setCon2(String conn)
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            con = new SqlConnection(conn);

            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    Properties.Settings.Default.phpserver = conn;
                    Properties.Settings.Default.Save();
                    ToastMessage toastMessage = new ToastMessage();
                    toastMessage.success(sender, e);
                    toastMessage.MessageText("تم انشاء نص الاتصال بنجاح");
                    toastMessage.Show();
                    //Application.Restart();
                }

            }
            catch
            {
                ToastMessage toastMessage = new ToastMessage();
                toastMessage.WrongConnect(sender, e);
                toastMessage.Show();
            }

        }
        public bool isConnected1()
        {
            con = getCon1();
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            return true;
        }

    }
}
