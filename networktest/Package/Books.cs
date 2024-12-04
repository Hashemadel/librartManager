using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using networktest.Classes;
using Sipaa.Framework;

namespace networktest
{
    public partial class Books : Form
    {
        bool sideExpand=false;
        DataGridViewRow selectedRow;
        int BId;
        int BPG_no;
        int updatedBId;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        String BName = "";
        String BAuthor = "";
        String BContent = "";
        DataTable dt;
        SqlConnection con = new SqlConnection();
        ConnectionC connect = new ConnectionC();
        MainForm MainForm;
        bool isPos = true;
        bool updateIsPos = false;
        int is_Pos;

        public Books(MainForm mainForm)
        {
            InitializeComponent();
            con = connect.getCon1();
            MainForm = mainForm;
        }

        private void deleteBook(object sender, EventArgs e)
        {
            ToastMessage toastMessage = new ToastMessage();

            if (Properties.Settings.Default.job == "مدير" || Properties.Settings.Default.job == "موظف")
            {

                String deleteRow = "delete from Books where B_id='" + BId + "'";
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
                    toastMessage.warning(sender, e);
                    toastMessage.MessageText("لايمكنك حذف كتاب مستعار");
                    toastMessage.Show();
                }
                con.Close();
            }
            else
            {
                toastMessage.warning(sender, e);
                toastMessage.MessageText("هذة العملية ليست من صلاحياتك");
                toastMessage.Show();
            }

        }
        private void deleteMultyBook(object sender, EventArgs e)
        {
            ToastMessage toastMessage = new ToastMessage();
            if (Properties.Settings.Default.job == "مدير" || Properties.Settings.Default.job == "موظف")
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        Int32.TryParse(row.Cells["B_id"].Value.ToString(), out BId);

                        String deleteRow = "delete from Books where B_id='" + BId + "'";
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

                            toastMessage.warning(sender, e);
                            toastMessage.MessageText("لايمكنك حذف كتاب مستعار");
                            toastMessage.Show();
                        }
                        con.Close();

                    }

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
        private void selectAllData()
        {
            String sqlSelect = "select B_id,B_name,author,page_no,content,isAvailable from Books ";
            sda = new SqlDataAdapter(sqlSelect, con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void POS1_Load(object sender, EventArgs e)
        {
            con = connect.getCon1();
            selectAllData();
            if(Properties.Settings.Default.job=="مدير"|| Properties.Settings.Default.job == "موظف")
            {
                btn_add.Enabled = true;
            }
            else
                btn_add.Enabled=false;
            
        }

        private void rjRoundedGradientButton1_Click(object sender, EventArgs e)
        {
            Add_Book add=new Add_Book(this);
            add.Show();
                
                
            
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
        private void UpdateBook()
        {
            object sender=new object();
            EventArgs e=new EventArgs();
            ToastMessage toastMessage = new ToastMessage();
            if (Properties.Settings.Default.job == "مدير" || Properties.Settings.Default.job == "موظف")
            {


                SqlCommand cmd = new SqlCommand("updateBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BId", BId);
                cmd.Parameters.AddWithValue("@BName", BName);
                cmd.Parameters.AddWithValue("@author", BAuthor);
                cmd.Parameters.AddWithValue("@content", BContent);
                cmd.Parameters.AddWithValue("@pageNo", BPG_no);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    toastMessage.edited(sender, e);
                    toastMessage.Show();
                }
                catch
                {

                    toastMessage.warning(sender, e);
                    toastMessage.MessageText("رقم الكتاب مكررة");
                    toastMessage.Show();
                }
                con.Close();
                selectAllData();
            }
            else
            {
                toastMessage.warning(sender, e);
                toastMessage.MessageText("هذة العملية ليست من صلاحياتك");
                toastMessage.Show();
            }
        }
        private void UpdateMultyBook()
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            ToastMessage toastMessage = new ToastMessage();
            if (Properties.Settings.Default.job == "مدير" || Properties.Settings.Default.job == "موظف")
            {

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    Int32.TryParse(row.Cells["B_id"].Value.ToString(), out BId);
                    Int32.TryParse(row.Cells["page_no"].Value.ToString(), out BPG_no);
                    BName = row.Cells["B_name"].Value.ToString();
                    BAuthor = row.Cells["author"].Value.ToString();
                    BContent = row.Cells["content"].Value.ToString();
                    con.Open();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("updateBook", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@BId", BId);
                        cmd.Parameters.AddWithValue("@BName", BName);
                        cmd.Parameters.AddWithValue("@author", BAuthor);
                        cmd.Parameters.AddWithValue("@content", BContent);
                        cmd.Parameters.AddWithValue("@pageNo", BPG_no);
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

                selectAllData();
                toastMessage.Show();
            }
            else
            {
                toastMessage.warning(sender, e);
                toastMessage.MessageText("هذة العملية ليست من صلاحياتك");
                toastMessage.Show();
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "edit")
            {
                dataGridView2.CurrentRow.Selected = true;
                selectedRow = dataGridView2.Rows[e.RowIndex];
                Int32.TryParse(selectedRow.Cells["B_id"].Value.ToString(), out updatedBId);
                BName= selectedRow.Cells["B_name"].Value.ToString();
                Int32.TryParse(selectedRow.Cells["page_no"].Value.ToString(), out BPG_no);
                BAuthor = selectedRow.Cells["author"].Value.ToString();
                BContent = selectedRow.Cells["content"].Value.ToString();
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    UpdateBook();
                }
            }
            else if (dataGridView2.Columns[e.ColumnIndex].Name == "delete")
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    deleteBook(sender, e);

                    selectAllData();
                }
            }
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            Int32.TryParse(selectedRow.Cells["B_id"].Value.ToString(), out updatedBId);
            if (e.KeyCode == Keys.Back)
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    deleteMultyBook(sender, e);
                    selectAllData();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {

                    UpdateMultyBook();
                }
            }
        }
        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                Color color = Color.FromArgb(51, 51, 76);
                r.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
                r.DefaultCellStyle.ForeColor=color;
                r.Height = 44;
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
                    Int32.TryParse(selectedRow.Cells["B_id"].Value.ToString(), out BId);

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

        private void search_txt__TextChanged(object sender, EventArgs e)
        {
            String sqlSelect = "select B_id,B_name,author,page_no,content,isAvailable from Books where B_name LIKE'" + search_txt.Texts+ "%' or B_id LIKE'" + search_txt.Texts+ "' or author LIKE'" + search_txt.Texts+ "%'or content LIKE'" + search_txt.Texts+ "%' or page_no LIKE'" + search_txt.Texts+ "%'";
            sda = new SqlDataAdapter(sqlSelect, con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sideExpand)
            {
                searchBar.Width -= 10;
                if(searchBar.Width== searchBar.MinimumSize.Width)
                {
                    sideExpand = false;
                    timer1.Stop();
                }
            }
            else
            {
                searchBar.Width += 10;
                if(searchBar.Width == searchBar.MaximumSize.Width)
                {
                    sideExpand= true;
                    timer1.Stop();
                }
            }
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
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
