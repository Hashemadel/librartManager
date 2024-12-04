using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using networktest.Classes;

namespace networktest
{
    public partial class Employees : Form
    {
        int userId;
        String userName;
        String job;
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
        public Employees(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            con = connect.getCon1();

        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView_employees.Rows)
            {
                r.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
                r.DefaultCellStyle.ForeColor = color;
            }
        }
        private void UpdateEmps()
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            ToastMessage toastMessage = new ToastMessage();

            foreach (DataGridViewRow row in dataGridView_employees.Rows)
            {
                Int32.TryParse(selectedRow.Cells["emp_id"].Value.ToString(), out userId);
                userName = selectedRow.Cells["emp_name"].Value.ToString();
                job = selectedRow.Cells["emp_job"].Value.ToString();
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("updatEmp", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@emp_Id", userId);
                    cmd.Parameters.AddWithValue("@emp_name", userName);
                    cmd.Parameters.AddWithValue("@job", job);
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
        private void deleteEmp(object sender, EventArgs e)
        {

            ToastMessage toastMessage = new ToastMessage();
            foreach (DataGridViewRow row in dataGridView_employees.SelectedRows)
            {
                
                if (!row.IsNewRow)
                {
                    Int32.TryParse(row.Cells["emp_id"].Value.ToString(), out userId);

                    String deleteRow = "delete from employees where emp_id='" + userId + "'";
                    SqlCommand cmd = new SqlCommand(deleteRow, con);
                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        toastMessage.deleted(sender, e);
                        toastMessage.Show();
                    }
                    catch (Exception ex)
                    {

                        toastMessage.warning(sender, e);
                        toastMessage.MessageText(ex.Message);
                        toastMessage.Show();
                    }
                    con.Close();

                }
            }
            toastMessage.Show();
        }
        private void HRForm_Load(object sender, EventArgs e)
        {
            SelectAlldata();
        }
        public void SelectAlldata()
        {
            String sqlSelect = "Select * from employees";
            SqlDataAdapter sda = new SqlDataAdapter(sqlSelect, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_employees.DataSource = dt;
        }
        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_employees.Columns[e.ColumnIndex].Name == "edit")
            {
                dataGridView_employees.CurrentRow.Selected = true;
                selectedRow = dataGridView_employees.Rows[e.RowIndex];
                Int32.TryParse(selectedRow.Cells["emp_id"].Value.ToString(), out updatedUserId);
                userName = selectedRow.Cells["emp_name"].Value.ToString();
                job = selectedRow.Cells["emp_job"].Value.ToString();
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    UpdateEmps();
                }
            }
            else if (dataGridView_employees.Columns[e.ColumnIndex].Name == "delete")
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    deleteEmp(sender, e);

                    SelectAlldata();
                }
            }
        }
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView_employees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    /*تعبئة الحقول عند الضغط على صف في الجدول*/
                    dataGridView_employees.CurrentRow.Selected = true;
                    selectedRow = dataGridView_employees.Rows[e.RowIndex];
                    Int32.TryParse(selectedRow.Cells["emp_id"].Value.ToString(), out userId);

                }
            }
            catch
            {
                selectedRow = null;
            }
        }
        private void DataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            Int32.TryParse(selectedRow.Cells["emp_id"].Value.ToString(), out updatedUserId);
            if (e.KeyCode == Keys.Back)
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    deleteEmp(sender, e);
                    SelectAlldata();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {

                    UpdateEmps();
                }
            }
        }
        private void rjRoundedGradientButton1_Click(object sender, EventArgs e)
        {

                Add_employee add_employee = new Add_employee(this);
                add_employee.Show();
            
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
