using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networktest
{
    [DefaultEvent("Click")]
    public partial class RJEnimatedGradientButton2 : UserControl
    {
        private int borderRadius = 20;
        Timer t = new Timer();


        private float ang = 45;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;

        [Category("RJ code Advance")]
        public float Angle
        {
            get
            {
                return ang;
            }
            set
            {
                ang = value;
                this.Invalidate();
            }
        }
        [Category("RJ code Advance")]
        public Color GradientTopColor
        {
            get
            {
                return gradientTopColor;
            }
            set
            {
                gradientTopColor = value;
                this.Invalidate();
            }
        }
        [Category("RJ code Advance")]
        public Color GradientBottomColor
        {
            get
            {
                return gradientBottomColor;
            }
            set
            {
                gradientBottomColor = value;
                this.Invalidate();
            }
        }


        [Category("RJ code Advance")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }




        [Category("RJ code Advance")]
        public Color BackgroundColor
        {
            get
            {
                return this.BackColor;
            }
            set { this.BackColor = value; }
        }
        [Category("RJ code Advance")]
        public Color TextColor
        {
            get
            {
                return this.ForeColor;
            }
            set { this.ForeColor = value; }
        }
        public RJEnimatedGradientButton2()
        {
            DoubleBuffered = true;
            t.Interval = 60;
            t.Start();
            t.Tick += (s, e) => { Angle = Angle % 360 + 1; };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //border radius
            GraphicsPath gp = new GraphicsPath();

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            gp.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
            gp.AddArc(new Rectangle(Width - borderRadius, 0, borderRadius, borderRadius), -90, 90);
            gp.AddArc(new Rectangle(Width - borderRadius, Height - borderRadius, borderRadius, borderRadius), 0, 90);
            gp.AddArc(new Rectangle(0, Height - borderRadius, borderRadius, borderRadius), 90, 90);


            //Gradient
            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, gradientTopColor, gradientBottomColor, ang), gp);
        }
    }
}
