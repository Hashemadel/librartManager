using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.ComponentModel;

namespace networktest
{
    public class RJRoundedGradientButton : Button
    {
        private int borderRadius = 20;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.FromArgb(51, 51, 76);
        private Color gradientBottomColor = Color.FromArgb(96, 130, 159);

        [Category("RJ code Advance")]
        public float GradientAngle
        {
            get
            {
                return gradientAngle;
            }
            set
            {
                gradientAngle = value;
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

        public RJRoundedGradientButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.Size = new Size(150, 35);
            this.ForeColor = Color.White;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brushArten = new LinearGradientBrush(this.ClientRectangle, this.gradientTopColor, this.gradientBottomColor, this.GradientAngle);
            Graphics graphicArten = pevent.Graphics;
            graphicArten.FillRectangle(brushArten, ClientRectangle);
            SizeF TextSize=pevent.Graphics.MeasureString(this.Text,this.Font);
            pevent.Graphics.DrawString(this.Text, this.Font,
            new SolidBrush(this.ForeColor), (Width - TextSize.Width) / 2,
            (Height - TextSize.Height) / 2);

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);

            if (borderRadius > 2)  //Rounded Button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                {
                    //Button surface
                    this.Region = new Region(pathSurface);
                    // Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    //Button border
                    
                }
            }
            else  //Normal Button
            {
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                

            }
        }
    }
}
