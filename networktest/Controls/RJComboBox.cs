using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networktest
{
    //
    [DefaultEvent("OnSelectedIndexChanged")]
    //
    public partial class RJComboBox : UserControl
    {
        //
        public event EventHandler OnSelectedIndexChanged;//Default event
        //

        int i = 0;
        
        private ComboBox cmbList;
        public RJComboBox()
        {
            InitializeComponent();

            cmbList = new ComboBox();
        }
        /*public string[] Data;
        public string[] DataSource
        {
            get => Data;
            set
            {
                foreach (var item in value)
                {
                    Label label = new Label();
                    label.Text = item.ToString();
                    label.ForeColor = Color.White;
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.Height = 25;
                    label.Width = FLPItem.Width - 25;

                    label.MouseClick += new MouseEventHandler(Label_Selected);
                    FLPItem.Controls.Add(label);
                }
                Data = value;
                Invalidate();
            }
        }*/


        public DataTable DataSourse { get ; set; }

        public void PopulateLabels()
        {
            FLPItem.Controls.Clear(); // Clear existing controls

            if (DataSourse != null && DataSourse.Rows.Count > 0)
            {
                foreach (DataRow row in DataSourse.Rows)
                {
                    Label label = new Label();
                    label.Text = row[0].ToString(); // Assuming the first column is the text
                    label.ForeColor = Color.White;
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.Height = 25;
                    label.Width = FLPItem.Width - 25;

                    label.MouseClick += new MouseEventHandler(Label_Selected);
                    FLPItem.Controls.Add(label);
                }
            }
        }


        /*public object DataSource
        {
            get { return cmbList.DataSource; }
            set { cmbList.DataSource = value; }
        }*/

        public string Title
        {

            get=> LblTitle.Text; 
            set
            {
                LblTitle.Text = value;Invalidate();
            }
        }

        public int Radius
        {
            get => PnlTitle.BorderRadius;
            set { PnlTitle.BorderRadius = value; Invalidate(); }

        }
        public Image Icon
        {

            get => iconComboBox.Image;
            set { iconComboBox.Image = value; Invalidate(); }
        }


private void Label_Selected(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            foreach (var item in FLPItem.Controls.OfType<Label>())
                item.BackColor = Color.FromArgb(30, 32, 34);
            label.BackColor = Color.FromArgb(46, 239, 221);
            TextComboBox.Text = label.Text;
            i = 0;
            TimerItem2.Start();
        }
        private void picComboBox_Click(object sender, EventArgs e)
        {
            i = 0;
            if(Height<=60)TimerItem.Start();
            else TimerItem2.Start();
        }

        private void TimerItem_Tick(object sender, EventArgs e)
        {
            picComboBox.Image = Image.FromFile("C:\\sqlImages\\upIcon.png");
            if(Height<269)
            {
                Height = Height + i;
                i++;
            }
            else TimerItem.Stop();
            PnlIem.BorderRadius = 30;
        }

        private void TimerItem2_Tick(object sender, EventArgs e)
        {
            picComboBox.Image = Image.FromFile("C:\\sqlImages\\downIcon.png");
            if (Height > 61)
            {
                Height = Height - i;
                i++;
            }
            else TimerItem2.Stop();
            PnlIem.BorderRadius = 30;
        }
        public void dropDown()
        {
            i = 0;
            if (Height <= 60) TimerItem.Start();
            else TimerItem2.Start();
        }
    }
}
