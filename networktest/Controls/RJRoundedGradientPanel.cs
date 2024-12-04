using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Panel = System.Windows.Forms.Panel;

namespace networktest
{
    public class RJRoundedGradientPanel : Panel
    {
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;
        private Color borderColor = Color.Transparent;

        //Constructor
        public RJRoundedGradientPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor=Color.Black;
            this.Size = new Size(226, 638);
            this.borderColor = Color.Transparent;
        }

        //properties
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public int BorderRadius
        { 
            get => borderRadius; 
            set => borderRadius = value;
        }
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
        //Methods
        private GraphicsPath GetArtenPath(RectangleF rect,float radius)
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
        //Overriding method
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //Gradient
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            LinearGradientBrush brushArten=new LinearGradientBrush(this.ClientRectangle,this.gradientTopColor,this.gradientBottomColor,this.GradientAngle);
            Graphics graphicArten = pevent.Graphics;
            graphicArten.FillRectangle(brushArten,ClientRectangle);


            //Border radius
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            

            if (borderRadius > 2)  //Rounded Button
            {
                using (GraphicsPath pathSurface = GetArtenPath(rectSurface, borderRadius))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                }
            }
            else  //Normal Button
            {
                //Button surface
                this.Region = new Region(rectSurface);
            }
        }
    }
    
}
