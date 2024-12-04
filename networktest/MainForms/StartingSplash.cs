using System;
using System.Windows.Forms;

namespace networktest
{
    public partial class StartingSplash : Form
    {
        int move ;
        int movex ;
        int movey ;
        LoginClass login = new LoginClass();

        public StartingSplash()
        {
            InitializeComponent();
        }
        //عمل ظل للواجهة
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (login.startingSplashLoad(loadPanel, timer1))
            {
                this.Hide();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
                this.Cursor = Cursors.NoMove2D;
            }
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            move = 0;
            this.Cursor = Cursors.Default;
        }

        
    }
}
