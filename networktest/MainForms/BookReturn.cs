using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using networktest.Classes;

namespace networktest
{
    public partial class BookReturn : Form
    {
        SqlConnection con = new SqlConnection();
        ConnectionC connect = new ConnectionC();
        MainForm MainForm;
        String StName;
        String BkName;
        int student_id = 0;
        int BId = 0;
        DataGridViewRow selectedRow;
        public BookReturn(MainForm mainForm)
        {
            InitializeComponent();
            con = connect.getCon1();
            MainForm = mainForm;
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            getAllData();
        }
        private void deleteMultyRows()
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                String qurey = "delete from operations where No=@No";
                SqlCommand cmd = new SqlCommand(qurey, con);
                con.Open();
                cmd.Parameters.AddWithValue("@No", row.Cells["No"].Value);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            getAllData();
            ToastMessage toast = new ToastMessage();
            toast.deleted(sender, e);
            toast.Show();
        }
        private void getAllData()
        {
            String sqlSelect = "select c.c_id, s.s_id,s.name,b.B_id,b.B_name,c.date from costumers c join students s on(c.s_id=s.s_id) join Books b on (c.B_id=b.B_id)";
            SqlDataAdapter sda = new SqlDataAdapter(sqlSelect, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                Color color = Color.FromArgb(51, 51, 76);
                r.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
                r.DefaultCellStyle.ForeColor=color;
            }
        }
        
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if(RJMessageBox.Shows()==DialogResult.OK)
                {
                    deleteMultyRows();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            getAllData();
        }

        private void rjRoundedGradientPanel1_MouseEnter(object sender, EventArgs e)
        {
            MainFormClass mainFormClass = new MainFormClass(MainForm);

            if (MainForm.sideParExpand)
            {
                mainFormClass.minimizeWhenLeave();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    /*تعبئة الحقول عند الضغط على صف في الجدول*/
                    dataGridView1.CurrentRow.Selected = true;
                    selectedRow = dataGridView1.Rows[e.RowIndex];
                    Int32.TryParse(selectedRow.Cells["B_id"].Value.ToString(), out BId);
                    BkName = selectedRow.Cells["B_name"].Value.ToString();
                    textBox_Bk_name.Texts = BkName;
                    Int32.TryParse(selectedRow.Cells["s_id"].Value.ToString(), out student_id);
                    StName = selectedRow.Cells["name"].Value.ToString();
                    textBox_St_name.Texts = StName;

                }
            }
            catch
            {
                selectedRow = null;
            }
        }

        private void borrow_button_Click(object sender, EventArgs e)
        {
            int isAvailable;
            ToastMessage toastMessage;
            SqlCommand cmd;
            int Sid;
            label_mul_St_name.Visible = false;
            label_mul_B_name.Visible = false;
            if (Properties.Settings.Default.job == "مدير" || Properties.Settings.Default.job == "موظف")
            {
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
                        DateTime date = new DateTime();
                        date = DateTime.Now;
                        String borrowQuery = "returnBook";
                        cmd = new SqlCommand(borrowQuery, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@s_id", student_id);
                        cmd.Parameters.AddWithValue("@B_id", BId);
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            con.Close();
                            textBox_St_name.Texts = "";
                            textBox_Bk_name.Texts = "";
                            toastMessage = new ToastMessage();
                            toastMessage.added(sender, e);
                            toastMessage.MessageText("تمت استعادة الكتاب بنجاح");
                            toastMessage.TopMost = true;
                            toastMessage.Show();
                            getAllData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                toastMessage = new ToastMessage();
                toastMessage.warning(sender, e);
                toastMessage.MessageText("هذة العملية ليست من صلاحياتك");
                toastMessage.Show();
            }
        }

        private void textBox_St_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                borrow_button.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBox_Bk_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = textBox_St_name;
                textBox_St_name.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
