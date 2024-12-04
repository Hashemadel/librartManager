using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.Drawing;
using static DevExpress.Utils.HashCodeHelper;


namespace networktest.Classes
{
    internal class PrintClass
    {

        SqlConnection con = new SqlConnection();
        ConnectionC connection = new ConnectionC();
        DateTime currdate = DateTime.Now;
        double Sum;
        int year = Properties.Settings.Default.year;


        public PrintClass()
        {
            con = connection.getCon1();
        }
      
        public void PerformShowAndPrint(DataGridView dataGridView1,CheckBox checkBox_profit, CheckBox checkBox_printedC
            , CheckBox checkBox_imp, CheckBox checkBox_pays, CheckBox checkBox_loans, CheckBox checkBox_all)
        {
            object sender=new object();
            EventArgs e=new EventArgs();
            if (!checkBox_all.Checked)

            {
                Properties.Settings.Default.isPrinted = true;
                Properties.Settings.Default.Save();
                if (checkBox_profit.Checked)
                {

                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "الكتب المتاحة";//Header
                    printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    GetAllAvailableBooks(dataGridView1);
                    printer.PrintPreviewNoDisplay(dataGridView1);
                }
                if (checkBox_printedC.Checked)
                {

                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "الموظفين";//Header
                    printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    GetAllPrintedCardsData(dataGridView1);
                    printer.PrintPreviewNoDisplay(dataGridView1);

                }
           

                if (checkBox_imp.Checked)
                {

                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "الكتب المستعارة";//Header
                    printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.printDocument.DefaultPageSettings.Landscape = true;
                    GetBorredBooks(dataGridView1);
                    printer.PrintPreviewNoDisplay(dataGridView1);
                }
                if (checkBox_pays.Checked)
                {

                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "المستخدمين";//Header
                    printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    // printer.Footer = "هاشم";//Footer
                    // printer.FooterSpacing = 15;
                    printer.printDocument.DefaultPageSettings.Landscape = true;

                    GetAllPays(dataGridView1);
                    printer.PrintPreviewNoDisplay(dataGridView1);
                }
                if (checkBox_loans.Checked)
                {

                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "الطلاب";//Header
                    printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    GetAllEmployeeLoans(dataGridView1);
                    printer.printDocument.DefaultPageSettings.Landscape = true;


                    printer.PrintPreviewNoDisplay(dataGridView1);
                }
                
                else
                {
                    Properties.Settings.Default.isPrinted = false;
                    Properties.Settings.Default.Save();
                }
                
            }
            else if (checkBox_all.Checked)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "الكتب المتاحة";//Header
                printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                GetAllAvailableBooks(dataGridView1);
                printer.PrintPreviewNoDisplay(dataGridView1);           

                printer = new DGVPrinter();
                printer.Title = "الموظفين";//Header
                printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                GetAllPrintedCardsData(dataGridView1);
                printer.PrintPreviewNoDisplay(dataGridView1);


                printer = new DGVPrinter();
                printer.Title = "الكتب المستعارة";//Header
                printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.printDocument.DefaultPageSettings.Landscape = true;
                GetBorredBooks(dataGridView1);
                printer.PrintPreviewNoDisplay(dataGridView1);

                printer = new DGVPrinter();
                printer.Title = "المستخدمين";//Header
                printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                GetAllPays(dataGridView1);
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintPreviewNoDisplay(dataGridView1);


                printer = new DGVPrinter();
                printer.Title = "الطلاب";//Header
                printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                GetAllEmployeeLoans(dataGridView1);
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintPreviewNoDisplay(dataGridView1);

                

                Properties.Settings.Default.isPrinted = true;
                Properties.Settings.Default.Save();
            }
            
        }
        public void PerformPrint(DataGridView dataGridView1, CheckBox checkBox_profit, CheckBox checkBox_printedC
            , CheckBox checkBox_imp, CheckBox checkBox_pays, CheckBox checkBox_loans, CheckBox checkBox_all)
        {
            object sender = new object();
            EventArgs e = new EventArgs();
            if (!checkBox_all.Checked)

            {
                Properties.Settings.Default.isPrinted = true;
                Properties.Settings.Default.Save();
                if (checkBox_profit.Checked)
                {

                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "الكتب المتاحة";//Header
                    printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    //printer.Footer = "هاشم";//Footer
                    //printer.FooterSpacing = 15;

                    GetAllAvailableBooks(dataGridView1);
                    printer.PrintNoDisplay(dataGridView1);
                    //printer.PrintPreviewDataGridView(dataGridView1);
                }
                if (checkBox_printedC.Checked)
                {

                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "الموظفين";//Header
                    printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    //printer.Footer = "هاشم";//Footer
                    //printer.FooterSpacing = 15;
                    GetAllPrintedCardsData(dataGridView1);

                    printer.PrintNoDisplay(dataGridView1);

                }
                if (checkBox_imp.Checked)
                {

                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "الكتب المستعارة";//Header
                    printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.printDocument.DefaultPageSettings.Landscape = true;
                    GetBorredBooks(dataGridView1);
                    printer.PrintNoDisplay(dataGridView1);
                }
                if (checkBox_pays.Checked)
                {

                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "المستخدمين";//Header
                    printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.printDocument.DefaultPageSettings.Landscape = true;

                    GetAllPays(dataGridView1);
                    printer.PrintNoDisplay(dataGridView1);
                }
                if (checkBox_loans.Checked)
                {

                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "الطلاب";//Header
                    printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    GetAllEmployeeLoans(dataGridView1);
                    printer.printDocument.DefaultPageSettings.Landscape = true;


                    printer.PrintNoDisplay(dataGridView1);
                }
                
                else
                {
                    Properties.Settings.Default.isPrinted = false;
                    Properties.Settings.Default.Save();
                }

            }
            else if (checkBox_all.Checked)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "الكتب المتاحة";//Header
                printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                GetAllAvailableBooks(dataGridView1);
                printer.PrintNoDisplay(dataGridView1);



                printer = new DGVPrinter();
                printer.Title = "الموظفين";//Header
                printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                GetAllPrintedCardsData(dataGridView1);
                printer.PrintNoDisplay(dataGridView1);

                printer = new DGVPrinter();
                printer.Title = "الكتب المستعارة";//Header
                printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.printDocument.DefaultPageSettings.Landscape = true;
                GetBorredBooks(dataGridView1);
                printer.PrintNoDisplay(dataGridView1);

                printer = new DGVPrinter();
                printer.Title = "المستخدمين";//Header
                printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                GetAllPays(dataGridView1);
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintNoDisplay(dataGridView1);


                printer = new DGVPrinter();
                printer.Title = "الطلاب";//Header
                printer.SubTitle = string.Format(DateTime.Now.Date.ToString());
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                GetAllEmployeeLoans(dataGridView1);
                printer.printDocument.DefaultPageSettings.Landscape = true;

                printer.PrintNoDisplay(dataGridView1);

                

                Properties.Settings.Default.isPrinted = true;
                Properties.Settings.Default.Save();
            }

        }
        private void GetAllAvailableBooks(DataGridView dataGridView1)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "B_id", DataPropertyName = "B_id", HeaderText = " " });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "B_name", DataPropertyName = "B_name", HeaderText = "اسم الكتاب" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "author", DataPropertyName = "author", HeaderText = "المؤلف" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "page_no", DataPropertyName = "page_no", HeaderText = "عدد الصفحات" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "content", DataPropertyName = "content", HeaderText = "المحتوى" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "isAvailable", DataPropertyName = "isAvailable", HeaderText = "",Visible=false} );
            SqlCommand cmd = new SqlCommand("select * from books where isAvailable=1", con);
            SqlDataAdapter sdaprof = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdaprof.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void GetBorredBooks(DataGridView dataGridView1)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "B_id", DataPropertyName = "B_id", HeaderText = " " });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "B_name", DataPropertyName = "B_name", HeaderText = "اسم الكتاب" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "author", DataPropertyName = "author", HeaderText = "المؤلف" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "page_no", DataPropertyName = "page_no", HeaderText = "عدد الصفحات" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "content", DataPropertyName = "content", HeaderText = "المحتوى" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "isAvailable", DataPropertyName = "isAvailable", HeaderText = "", Visible = false });
            SqlCommand cmd = new SqlCommand("select * from books where isAvailable=0", con);
            SqlDataAdapter sdaprof = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdaprof.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void GetAllPrintedCardsData(DataGridView dataGridView1)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "emp_id", DataPropertyName = "emp_id", HeaderText = " " });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "emp_name", DataPropertyName = "emp_name", HeaderText = "اسم الموظف" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "emp_job", DataPropertyName = "emp_job", HeaderText = "الوظيفة" });

            SqlDataAdapter sda = new SqlDataAdapter("select * from employees", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

 
        private void GetAllPays(DataGridView dataGridView1)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "user_id", DataPropertyName = "user_id", HeaderText = " " });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "user_name", DataPropertyName = "user_name", HeaderText = "اسم المستخدم" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "password", DataPropertyName = "password", HeaderText = "كلمة السر" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "job", DataPropertyName = "job", HeaderText = "الوظيفة" });
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "متصل؟" });

            SqlDataAdapter sda = new SqlDataAdapter("select * from users", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void GetAllEmployeeLoans(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "s_id", DataPropertyName = "s_id", HeaderText = " " });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "name", DataPropertyName = "name", HeaderText = "اسم الطالب" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "specialty", DataPropertyName = "specialty", HeaderText = "التخصص" });

            SqlDataAdapter sda = new SqlDataAdapter("select * from students", con);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            dataGridView.DataSource = dt;

        }
        
    }

}
