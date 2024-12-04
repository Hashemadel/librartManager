using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using networktest.Classes;

namespace networktest
{
    public partial class Test : Form
    {
        bool sideExpand=false;
        DataGridViewRow selectedRow;
        int posId;
        int updatedPosId;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        String POSName = "";
        DataTable dt;
        SqlConnection con = new SqlConnection();
        ConnectionC connect = new ConnectionC();
        MainForm MainForm;
        TextBox text_name;
        TextBox text_id;
        TextBox page_number;
        bool isPos = true;
        bool updateIsPos = false;
        int is_Pos;

        public Test(MainForm mainForm)
        {
            InitializeComponent();
            con = connect.getCon1();
            MainForm = mainForm;
        }

        private void deletePOS(object sender, EventArgs e)
        {


            String deleteRow = "delete from test where id='" + posId + "'";

            SqlCommand cmd = new SqlCommand(deleteRow, con);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                ToastMessage toastMessage = new ToastMessage();
                toastMessage.deleted(sender, e);
                toastMessage.Show();
            }
            catch
            {
            }
            con.Close();
            
        }
        private void deleteMultyPOS(object sender, EventArgs e)
        {
            ToastMessage toastMessage = new ToastMessage();
            foreach(DataGridViewRow row in dataGridView2.SelectedRows)
            {
                if(!row.IsNewRow)
                {
                    String deleteRow = "delete from test where id='" + posId + "'";
                    SqlCommand cmd = new SqlCommand(deleteRow, con);
                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        toastMessage.deleted(sender, e);
                        toastMessage.Show();
                    }
                    catch 
                    {

                    }
                    con.Close();

                }
            }
            toastMessage.Show();
        }
        private void selectAllData()
        {
            String sqlSelect = "select * from test ";
            sda = new SqlDataAdapter(sqlSelect, con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void POS1_Load(object sender, EventArgs e)
        {
            con = connect.getCon1();
            selectAllData();
            label_mul_amount.Hide();
            sTextBox1.PlaceholderColor = Color.LightGray;
            sTextBox1.PlaceholderText = "الاسم";
            //search_txt.PlaceholderText = "البحث...";
            
        }

        private void sTextBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_add.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void rjRoundedGradientButton1_Click(object sender, EventArgs e)
        {
            label_mul_amount.Hide();
            String posName = sTextBox1.Texts;
            int count = 0;
            SqlCommand cmd;
            String sql;
            if (sTextBox1.Texts == "" || sTextBox1.Texts == "الاسم")
            {
                label_mul_amount.Show();
            }
            else
            {
                sql = "select count(id) from test";
                cmd = new SqlCommand(sql, con);
                con.Open();
                count = (int)cmd.ExecuteScalar();
                con.Close();
                count += 1;
                sql = "insert into test (id,name) values(@id,@name)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", count);
                cmd.Parameters.AddWithValue("@name", posName);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                    
                ToastMessage toastMessage = new ToastMessage();
                toastMessage.added(sender, e);
                toastMessage.Show();

                selectAllData();
                sTextBox1.Texts = "";
                sTextBox1.Focus();
                
                
            }
        }
        private void rjRoundedGradientButton1_MouseEnter(object sender, EventArgs e)
        {
            Color btColor = Color.FromArgb(35, 110, 184);
            Color topColor = Color.FromArgb(51, 51, 76);
            btn_add.GradientBottomColor = ThemeColor.ChangeColorBrightness(btColor, -0.3);
            btn_add.GradientTopColor = ThemeColor.ChangeColorBrightness(topColor, -0.3);
        }

        private void rjRoundedGradientButton1_MouseLeave(object sender, EventArgs e)
        {
            Color btColor = Color.FromArgb(35, 110, 184);
            Color topColor = Color.FromArgb(51, 51, 76);
            btn_add.GradientBottomColor = btColor;
            btn_add.GradientTopColor = topColor;
        }
      
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectAllData();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "delete")
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    deletePOS(sender, e);

                    selectAllData();
                }
            }
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            Int32.TryParse(selectedRow.Cells["id"].Value.ToString(), out updatedPosId);
            if (e.KeyCode == Keys.Back)
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    deleteMultyPOS(sender, e);
                    selectAllData();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                Color color = Color.FromArgb(51, 51, 76);
                r.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
                r.DefaultCellStyle.ForeColor = color;
                r.Height = 39;
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    /*تعبئة الحقول عند الضغط على صف في الجدول*/
                    dataGridView2.CurrentRow.Selected = true;
                    selectedRow = dataGridView2.Rows[e.RowIndex];
                    Int32.TryParse(selectedRow.Cells["id"].Value.ToString(), out posId);

                }
            }
            catch
            {
                selectedRow = null;
            }
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-sa"));
        }
        private void panel3_MouseEnter(object sender, EventArgs e)
        {

            MainFormClass mainFormClass = new MainFormClass(MainForm);

            if (MainForm.sideParExpand)
            {
                mainFormClass.minimizeWhenLeave();

            }
        }


      

        private void dataGridView2_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //string coulmName = dataGridView2.Columns[e.ColumnIndex].Name;
            //if(coulmName =="POS_id")
            //{
            //    dataGridView2.Cursor = Cursors.Default;
            //}
            //else if (coulmName == "POS_name")
            //{
            //    dataGridView2.Cursor = Cursors.IBeam;
            //}
            //else 
            //{
            //    dataGridView2.Cursor = Cursors.Hand;
            //}
        }
    }
}
