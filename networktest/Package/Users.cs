using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using networktest.Classes;
using DevExpress.XtraReports.Templates;

namespace networktest
{
    public partial class Users : Form
    {
        int userId;
        String userName;
        String pass;
        int updatedUserId;
        DataGridViewRow selectedRow;
        private Button currentButton;
       private DataGridView currentDataGridView;
        private Button MouseHoverButton;
        private ComboBox currentComboBox;
        static Color color = Color.FromArgb(51, 51, 76);
        static Color BlueColor = Color.FromArgb(35, 110, 184);
        MainForm MainForm;
        SqlConnection con = new SqlConnection();
        ConnectionC connect = new ConnectionC();
        public Users(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            con = connect.getCon1();

        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView_users.Rows)
            {

                r.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
                r.DefaultCellStyle.ForeColor = color;
            }
        }
        private void UpdateUsers()
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            ToastMessage toastMessage = new ToastMessage();

            foreach (DataGridViewRow row in dataGridView_users.Rows)
            {
                Int32.TryParse(selectedRow.Cells["user_id"].Value.ToString(), out userId);
                userName = selectedRow.Cells["user_name"].Value.ToString();
                pass = selectedRow.Cells["password"].Value.ToString();
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("updateUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_Id", userId);
                    cmd.Parameters.AddWithValue("@user_name", userName);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.ExecuteNonQuery();
                    toastMessage.edited(sender, e);
                }
                catch
                {
                    toastMessage.warning(sender, e);
                    toastMessage.MessageText("رقم الكتاب مكررة");
                }
                con.Close();
            }

            SelectAlldata();
            toastMessage.Show();
        }
        private void deleteUser(object sender, EventArgs e)
        {
            ToastMessage toastMessage = new ToastMessage();
            foreach (DataGridViewRow row in dataGridView_users.SelectedRows)
            {
                if (row.Cells["user_name"].Value.ToString() != Properties.Settings.Default.name)
                {
                    if (!row.IsNewRow)
                    {
                        Int32.TryParse(row.Cells["user_id"].Value.ToString(), out userId);

                        String deleteRow = "delete from users where user_id='" + userId + "'";
                        SqlCommand cmd = new SqlCommand(deleteRow, con);
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            toastMessage.deleted(sender, e);
                            
                        }
                        catch (Exception ex)
                        {

                            toastMessage.warning(sender, e);
                            toastMessage.MessageText(ex.Message);
                            
                        }
                        con.Close();

                    }
                }
                else
                {
                    toastMessage.warning(sender, e);
                    toastMessage.MessageText("لايمكنك حذف المستخدم الذي تستخدمة");
                }
            }
            toastMessage.Show();

        }
        public void SelectAlldata()
        {
            String sqlSelect = "Select * from users";
            SqlDataAdapter sda = new SqlDataAdapter(sqlSelect, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_users.DataSource = dt;
        }
        private void AcctiveButton(object btnSender)
        {
            
        }
        
        private void HRForm_Load(object sender, EventArgs e)
        {
            SelectAlldata();
        }

        private void emp_button_Click(object sender, EventArgs e)
        {
            AcctiveButton(sender);
        }
        
        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_users.Columns[e.ColumnIndex].Name == "edit")
            {
                dataGridView_users.CurrentRow.Selected = true;
                selectedRow = dataGridView_users.Rows[e.RowIndex];
                Int32.TryParse(selectedRow.Cells["user_id"].Value.ToString(), out updatedUserId);
                userName = selectedRow.Cells["user_name"].Value.ToString();
                pass = selectedRow.Cells["password"].Value.ToString();
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    UpdateUsers();
                }
            }
            else if (dataGridView_users.Columns[e.ColumnIndex].Name == "delete")
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    deleteUser(sender, e);

                    SelectAlldata();
                }
            }
        }
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView_users.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    /*تعبئة الحقول عند الضغط على صف في الجدول*/
                    dataGridView_users.CurrentRow.Selected = true;
                    selectedRow = dataGridView_users.Rows[e.RowIndex];
                    Int32.TryParse(selectedRow.Cells["user_id"].Value.ToString(), out userId);

                }
            }
            catch
            {
                selectedRow = null;
            }
        }
        private void DataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            Int32.TryParse(selectedRow.Cells["user_id"].Value.ToString(), out updatedUserId);
            if (e.KeyCode == Keys.Back)
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    deleteUser(sender, e);
                    SelectAlldata();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {

                    UpdateUsers();
                }
            }
        }
        private void rjRoundedGradientButton1_Click(object sender, EventArgs e)
        {
            Add_user add_User = new Add_user(this);
            add_User.Show();
        }
        private void add_button_MouseEnter(object sender, EventArgs e)
        {
            Color btColor = BlueColor;
            Color topColor = color;
            add_button.GradientBottomColor = ThemeColor.ChangeColorBrightness(btColor, -0.3);
            add_button.GradientTopColor = ThemeColor.ChangeColorBrightness(topColor, -0.3);
        }
        private void add_button_MouseLeave(object sender, EventArgs e)
        {
            Color btColor = BlueColor;
            Color topColor = color;
            add_button.GradientBottomColor = btColor;
            add_button.GradientTopColor = topColor;
        }
        //زر التحديث
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SelectAlldata();
        }
        //زر اضافة القروض و السداد

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
