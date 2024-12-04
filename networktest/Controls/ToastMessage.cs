using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Charts.WinForms.Properties;
using Sipaa.Framework;
using System.Media;

namespace networktest
{
    public partial class ToastMessage : Form
    {
        int y = 150;
        int toastx, toastY;

        public ToastMessage()
        {
            InitializeComponent();
        }

        private void Lbl_message_Click(object sender, EventArgs e)
        {
            ToastTimer.Stop();
            timer1.Start();
        }

        private void ToastMessage_Load(object sender, EventArgs e)
        {
            position();
            this.BringToFront();
            ToastTimer.Start();
            this.TopMost = true;

        }



        public void TitleText(string text) 
        {
            LblTitle.Text = text;
        }

        public void SetPictureIcon(Image image)
        {
            picIcon.Image = image;
        }


        public void MessageText(string text) 
        {
            Lbl_message.Text = text;
        }



        private void ToastTimer_Tick(object sender, EventArgs e)
        {
            toastY += 2;
            this.Location = new Point(toastx, toastY);
            if (toastY >= 18)
            {
                ToastTimer.Stop();
                toastHide.Start();
            }
        }

        private void ToastMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ToastTimer.Stop();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ToastMessage_Click(object sender, EventArgs e)
        {
            //ToastTimer.Start();
        }

        public void success(object sender, EventArgs e)
        {
            picIcon.Image=Properties.Resources.check_5610944;
            colorPanel.BackColor = Color.FromArgb(1, 114, 15);
            LblTitle.Text = "عملية ناجحة...";
            Lbl_message.Text = "تمت العملية بنجاح";

        }
        public void WrongConnect(object sender, EventArgs e)
        {

            picIcon.Image = Properties.Resources.warning_745419;
            colorPanel.BackColor = Color.FromArgb(229, 2, 31);
            LblTitle.Text = "خطأ...نص الاتصال غير صحيح";
            Lbl_message.Text = "نص الاتصال غير صحيح";
            SystemSounds.Asterisk.Play();
        }

        public void deleted(object sender, EventArgs e)
        {
            
            picIcon.Image = Properties.Resources.check_5610944;
            colorPanel.BackColor = Color.FromArgb(1, 114, 15);
            LblTitle.Text = "عملية ناجحة...";
            Lbl_message.Text = "تم الحذف بنجاح";

        }
        public void added(object sender, EventArgs e)
        {
            
            picIcon.Image = Properties.Resources.check_5610944;
            colorPanel.BackColor = Color.FromArgb(1, 114, 15);
            LblTitle.Text = "عملية ناجحة...";
            Lbl_message.Text = "تمت الاضافة بنجاح";
        }

        public void edited(object sender, EventArgs e)
        {
            picIcon.Image = Properties.Resources.pencil;
            colorPanel.BackColor = Color.FromArgb(255, 181, 33);
            LblTitle.Text = "عملية ناجحة...";
            Lbl_message.Text = "تمت التعديل بنجاح";
            

        }
        //public void TitleMessage()
        public string TitleMessage
        {
            get { return LblTitle.Text; }
            set { LblTitle.Text = value; }
        }

        public void warning(object sender, EventArgs e)
        {
            picIcon.Image = Properties.Resources.warning_745419;
            colorPanel.BackColor = Color.FromArgb(229, 2, 31);
            LblTitle.Text = "خطأ...";
            Lbl_message.Text = "يرجى اعادة المحاولة بعد تصحيح الخطأ";
            SystemSounds.Asterisk.Play();
        }
        public void Focuse(object sender, EventArgs e)
        {
            picIcon.Image = Properties.Resources.warning;
            colorPanel.BackColor = Color.FromArgb(255, 215, 100);
            LblTitle.Text = "انتباه...";
            Lbl_message.Text = "غير مكتمل بعد";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                toastY -= 2;
                this.Location=new Point(toastx,toastY );
                if(toastY <= -50)
                {
                    toastHide.Stop();
                    y = 100;
                    this.Close();
                }
                
            }


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toastY -= 2;
            this.Location = new Point(toastx, toastY);
            if (toastY <= -50)
            {
                toastHide.Stop();
               // y = 100;
                this.Close();
            }
        }

        private void position()
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            toastx = screenWidth - this.Width -50;
            toastY = screenHeight - this.Height -640;//==-42
            this.Location = new Point(toastx, toastY);
            //int screenWidth=Screen.PrimaryScreen.WorkingArea.Width;
            //int screenHeight=Screen.PrimaryScreen.WorkingArea.Height;
            //toastx = screenWidth-this.Width+275;
            //toastY = screenHeight-this.Height-620;
            //this.Location=new Point(toastx,toastY);
        }
    }
}
