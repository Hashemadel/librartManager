using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts.Native;
using DGVPrinterHelper;
using networktest.Classes;
using System.Data;


namespace networktest.Reports
{
    public partial class PrintForm : Form
    {
        Color BlueColor = Color.FromArgb(35, 110, 184);
        int move;
        int movex;
        int movey;
        double Sum;
        PrintClass printClass = new PrintClass();
        MainForm MainForm;
        public PrintForm(MainForm mainForm)
        {
            InitializeComponent();
            //this.TopMost = true;
            MainForm = mainForm;

        }
        public PrintForm(int num, MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;

        }
   
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                Color color = Color.FromArgb(51, 51, 76);
                r.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
                //r.Height = 40;
                r.DefaultCellStyle.ForeColor = color;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
        private void PrintForm_Load(object sender, EventArgs e)
        {
           
        }
        private void checkBox_cost_CheckedChanged(object sender, EventArgs e)
        {
            if( checkBox_profit.Checked&& checkBox_printedC.Checked
                &&  checkBox_imp.Checked && checkBox_pays.Checked && checkBox_loans.Checked)
            {
                checkBox_all.Checked = true;
            }
            else
            {
                checkBox_all.Checked = false;
            }         
        }
        private void checkBox_all_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_all.Checked)
            {
                checkBox_profit.Checked = true; checkBox_printedC.Checked = true;
                 checkBox_imp.Checked = true; checkBox_pays.Checked = true;
                 checkBox_loans.Checked = true; 
            }      
        }
        private void checkBox_all_Click(object sender, EventArgs e)
        {
            if (!checkBox_all.Checked)
            {
                checkBox_profit.Checked = false; checkBox_printedC.Checked = false;
                checkBox_imp.Checked = false; checkBox_pays.Checked = false;
                 checkBox_loans.Checked = false; 
            }
        }
        private void checkBox_depts_MouseEnter(object sender, EventArgs e)
        {
            CheckBox current;
            current= (CheckBox)sender;
            current.ForeColor = BlueColor;
        }

        private void checkBox_depts_MouseLeave(object sender, EventArgs e)
        {
            CheckBox current;
            current = (CheckBox)sender;
            current.ForeColor = Color.LightGray;
        }
        public void GetSalesSum()
        {
            Sum = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                Sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }


        }
        public void PrintTakingForm()
        {
            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.LightGray;
            printClass.PerformShowAndPrint(dataGridView1, checkBox_profit, checkBox_printedC
            , checkBox_imp, checkBox_pays, checkBox_loans, checkBox_all);
        }

        private void rjRoundedButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.LightGray;
            printClass.PerformPrint(dataGridView1, checkBox_profit, checkBox_printedC
            , checkBox_imp, checkBox_pays, checkBox_loans, checkBox_all);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                bunifuElipse2.ElipseRadius = 0;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                bunifuElipse2.ElipseRadius = 30;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void panel3_MouseEnter(object sender, EventArgs e)
        {

            if (MainForm.sideParExpand)
            {
                MainForm.sidePanel.Width = MainForm.sidePanel.MinimumSize.Width;
                MainForm.panel2.Width = MainForm.panel3.Width - MainForm.sidePanel.Width;
                MainForm.label_job.TextAlign = ContentAlignment.MiddleLeft;
                MainForm.sideParExpand = false;
            }
        }


    }
}
