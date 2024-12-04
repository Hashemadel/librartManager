using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using networktest.Classes;

namespace networktest
{
    public partial class Student : Form
    {
        DataGridViewRow selectedRow;
        String Srudent_id;
        DataTable dt;
        StudentsClass studentClass=new StudentsClass();
        MainForm MainForm;
        
        public Student(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;

        }
        
        private void Add_PKG2_Load(object sender, EventArgs e)
        {
            studentClass.selectAlldata(dataGridView2);
            if (Properties.Settings.Default.job == "مدير")
            {
                btn.Enabled = true;
            }
            else
                btn.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    /*تعبئة الحقول عند الضغط على صف في الجدول*/
                    dataGridView2.CurrentRow.Selected = true;
                    selectedRow = dataGridView2.Rows[e.RowIndex];
                    Srudent_id = selectedRow.Cells["s_id"].Value.ToString();
                }
            }
            catch
            {
                selectedRow = null;
            }
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    //deletePkg(sender, e);
                    studentClass.deleteMultyPkg(dataGridView2);
                    studentClass.selectAlldata(dataGridView2);
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    
                    studentClass.UpdateMultyPkg(dataGridView2);
                    studentClass.selectAlldata(dataGridView2);

                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "edit")
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    studentClass.UpdateMultyPkg(dataGridView2);
                    studentClass.selectAlldata(dataGridView2);
                }
            }
            else if (dataGridView2.Columns[e.ColumnIndex].Name == "delete")
            {
                if (RJMessageBox.Shows() == DialogResult.OK)
                {
                    studentClass.deletePkg(Srudent_id);
                    studentClass.selectAlldata(dataGridView2);

                }
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                Color color = Color.FromArgb(51, 51, 76);
                r.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
                r.DefaultCellStyle.ForeColor=color;
                r.Height = 39;
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Add_student add_student = new Add_student(this);
            add_student.Show();
        }
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Color btColor = Color.FromArgb(35, 110, 184);
            Color topColor = Color.FromArgb(51, 51, 76);
            btn.GradientBottomColor = ThemeColor.ChangeColorBrightness(btColor, -0.3);
            btn.GradientTopColor = ThemeColor.ChangeColorBrightness(topColor, -0.3);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Color btColor = Color.FromArgb(35, 110, 184);
            Color topColor = Color.FromArgb(51, 51, 76);
            btn.GradientBottomColor = btColor;
            btn.GradientTopColor = topColor;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            studentClass.selectAlldata(dataGridView2);
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

            //if (coulmName == "delete" || coulmName == "edit")
            //{
            //    dataGridView2.Cursor = Cursors.Hand;
            //}
            //else
            //{
            //    dataGridView2.Cursor = Cursors.IBeam;
            //}
            
        }
    }
}
