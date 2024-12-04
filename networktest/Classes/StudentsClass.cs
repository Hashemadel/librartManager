using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils.Gesture;
using System.Windows.Forms;
using Sipaa.Framework;

namespace networktest.Classes
{
    internal class StudentsClass
    {
        DataTable dt;
        SqlDataAdapter sda; 
        SqlConnection con = new SqlConnection();
        ConnectionC connect = new ConnectionC();
        public StudentsClass()
        {
            con = connect.getCon1();
        }
        public void selectAlldata(DataGridView dataGridView2)
        {
            String sqlSelect = "Select * from students";
            sda = new SqlDataAdapter(sqlSelect, con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        public void UpdateMultyPkg(DataGridView dataGridView2)
        {
            ToastMessage toastMessage = new ToastMessage();
            object sender = new object();
            EventArgs e = new EventArgs();
            if (Properties.Settings.Default.job == "مدير")
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    SqlCommand cmd = new SqlCommand("updateStudent", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", row.Cells["s_id"].Value.ToString());
                    cmd.Parameters.AddWithValue("@name", row.Cells["name"].Value.ToString());
                    cmd.Parameters.AddWithValue("@specialty", row.Cells["specialty"].Value);
                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        toastMessage = new ToastMessage();
                        toastMessage.edited(sender, e);

                    }
                    catch (Exception ex)
                    {
                        toastMessage = new ToastMessage();
                        toastMessage.warning(sender, e);
                        toastMessage.MessageText(ex.Message);
                    }
                    con.Close();
                }
                toastMessage.Show();
            }
            else
            {
                toastMessage.warning(sender, e);
                toastMessage.MessageText("هذة العملية ليست من صلاحياتك");
                toastMessage.Show();
            }
        }
        public void deletePkg(String Srudent_id)
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            if (Properties.Settings.Default.job == "مدير")
            {
                String deleteRow = "delete from students where s_id =@s_id";
                SqlCommand cmd = new SqlCommand(deleteRow, con);
                cmd.Parameters.AddWithValue("@s_id", Srudent_id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ToastMessage toastMessage = new ToastMessage();
                toastMessage.deleted(sender, e);
                toastMessage.Show();
            }
            else
            {
                ToastMessage toastMessage = new ToastMessage();
                toastMessage.warning(sender, e);
                toastMessage.MessageText("هذة العملية ليست من صلاحياتك");
                toastMessage.Show();
            }
        }
        public void deleteMultyPkg(DataGridView dataGridView2)
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            if (Properties.Settings.Default.job == "مدير")
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        String deleteRow = "delete from students where s_id =@s_id";
                        SqlCommand cmd = new SqlCommand(deleteRow, con);
                        cmd.Parameters.AddWithValue("@s_id", row.Cells["s_id"].Value);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                ToastMessage toastMessage = new ToastMessage();
                toastMessage.deleted(sender, e);
                toastMessage.Show();
            }
            else
            {
                ToastMessage toastMessage = new ToastMessage();
                toastMessage.warning(sender, e);
                toastMessage.MessageText("هذة العملية ليست من صلاحياتك");
                toastMessage.Show();
            }
        }
    }
}
