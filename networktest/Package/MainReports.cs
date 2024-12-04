using System;
using System.Drawing;
using System.Windows.Forms;
using networktest.Classes;
using networktest.Reports;

namespace networktest
{
    public partial class MainReports : Form
    {
        private Label currentLabel;
        private Form activeForm;
        Color color = Color.FromArgb(224, 224, 224);
        Color BlueColor2 = Color.FromArgb(2, 177, 228);
        ConnectionC connect= new ConnectionC();
        MainForm MainForm;
        public MainReports(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }
        private void ActivateButton(object labelSender)
        {
            if (labelSender != null)
            {
                if (currentLabel != (Label)labelSender)
                {
                    Color color = Color.FromArgb(2, 177, 228);
                    currentLabel = (Label)labelSender;
                    currentLabel.ForeColor = color;
                    lblTitle.Text = currentLabel.Text;
                }
            }
        }
        private void OpenChildForm(Form childForm, object labelSender)
        {

            if (activeForm != null)
                activeForm.Close();
            ActivateButton(labelSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Mainpanel.Controls.Add(childForm);
            this.Mainpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = "تخصيص";
            btn_backPanel.Visible = true;
        }
        private void Reset()
        {
            lblTitle.Text = "";
            currentLabel = null;
            btn_backPanel.Visible = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            btn_backPanel.Visible = false;
            lblTitle.Text = "";

        }

        private void rgRoundedButton1_Click(object sender, EventArgs e)
        {
            //String mysql = "server=127.0.0.1; user=root; database=Netowrk; password=";

            //if (connect.isConnected1() == true)
            //{
            //    ToastMessage toastMessage = new ToastMessage();
            //    toastMessage.success(sender, e);
            //    toastMessage.MessageText("تم الاتصال بنجاح");
            //    toastMessage.Show();
            //}
            //else
            //{
            //    ToastMessage toastMessage = new ToastMessage();
            //    toastMessage.warning(sender, e);
            //    toastMessage.MessageText("هذا السيرفر غير موجود");
            //    toastMessage.Show();
            //}


        }




        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = BlueColor2;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.LightGray;

        }


        private void label_pos_MouseEnter(object sender, EventArgs e)
        {
            label_pos.ForeColor = BlueColor2;
        }

        private void label_pos_MouseLeave(object sender, EventArgs e)
        {
            label_pos.ForeColor = Color.LightGray;
        }



        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btn_backPanel_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void label_pos_Click(object sender, EventArgs e)
        {
        }
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
