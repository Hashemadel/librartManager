using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace networktest.RJControls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public partial class RJComboBox4 : UserControl
    {
        //Fields

        private Color borderColor = Color.FromArgb(0, 147, 186);
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.FromArgb(0, 184, 186);
        private bool isFocused = false;
        private Color ComboBoxBackColor=Color.Transparent;
        private int borderRadius = 0;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;
        private AutoCompleteStringCollection autoCompleteCustomSource;
        private AutoCompleteMode autoCompleteMode = AutoCompleteMode.None;
        private AutoCompleteSource autoCompleteSource = AutoCompleteSource.None;
        //private bool droppedDown = false;
        public RJComboBox4()
        {
            InitializeComponent();
            comboBox1.Click += new EventHandler(comboBox1_Click);//Open dropdown list
            comboBox1.TextChanged += new EventHandler(comboBox1_TextChanged);
        }
        public event EventHandler OnSelectedIndexChanged;//Default event

        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }
        public object SelectedItem
        {
            get { return comboBox1.SelectedItem; }
            set { comboBox1.SelectedItem = value; }
        }

        public bool DroppedDown
        {
            get { return comboBox1.DroppedDown; }
            set { comboBox1.DroppedDown = value; }
        }
        public object SelectedValue
        {
            get { return comboBox1.SelectedValue; }
            set { comboBox1.SelectedValue = value; }
        }


        public int SelectedIndex
        {
            get { return comboBox1.SelectedIndex; }
            set { comboBox1.SelectedIndex = value; }
        }

        public string DisplayMember
        {
            get { return comboBox1.DisplayMember; }
            set { comboBox1.DisplayMember = value; }
        }

        public string ValueMember
        {
            get { return comboBox1.ValueMember; }
            set { comboBox1.ValueMember = value; }
        }
        public object DataSource
        {
            get { return comboBox1.DataSource; }
            set { comboBox1.DataSource = value; }
        }
        public Color comboBoxBackColor
        {
            get
            {
                return ComboBoxBackColor;
            }
            set
            {
                ComboBoxBackColor = value;
                this.Invalidate();
            }
        }




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
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get
            {
                return comboBox1.AutoCompleteCustomSource;
            }
            set
            {
                comboBox1.AutoCompleteCustomSource = value;
                this.Invalidate();
            }
        }
        public AutoCompleteMode AutoCompleteMode
        {
            get
            {
                return comboBox1.AutoCompleteMode;
            }
            set
            {
                comboBox1.AutoCompleteMode = value;
                this.Invalidate();
            }
        }
        public AutoCompleteSource AutoCompleteSource
        {
            get
            {
                return comboBox1.AutoCompleteSource;
            }
            set
            {
                comboBox1.AutoCompleteSource = value;
                this.Invalidate();
            }
        }
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }


        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                comboBox1.BackColor = value;
            }
        }
        [Category("RJ Code Advance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                comboBox1.ForeColor = value;
            }
        }
        [Category("RJ Code Advance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                comboBox1.Font = value;

            }
        }
        [Category("RJ Code Advance")]
        public string Texts
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }
        [Category("RJ Code Advance")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//Redraw control
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            if (borderRadius > 1)//Rounded TextBox
            {
                comboBox1.BackColor=ComboBoxBackColor;
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                    graph.SmoothingMode = SmoothingMode.HighQuality;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    if (underlinedStyle) //Line Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.HighQuality;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Square/Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;

                pathTxt = GetFigurePath(comboBox1.ClientRectangle, borderSize * 2);
                comboBox1.Region = new Region(pathTxt);
            pathTxt.Dispose();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(OnSelectedIndexChanged!=null)
            this.OnSelectedIndexChanged.Invoke(sender, e);
           // if (OnSelectedIndexChanged != null)
                //OnSelectedIndexChanged.Invoke(sender, e);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            this.OnTextChanged(e);
        }
    }
}
