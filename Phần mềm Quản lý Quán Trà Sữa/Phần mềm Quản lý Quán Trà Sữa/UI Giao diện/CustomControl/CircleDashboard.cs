using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện.CustomControl
{
    public partial class CircleDashboard : UserControl
    {
        private float percentItem = 0;
        private Color colorBackground = Color.White;
        private Color colorProcess = Color.FromArgb(183, 227, 178);
        private Color colorMain = Color.FromArgb(226, 220, 224);
        private Color lineColor = Color.Black;
        private int lengthLine = 2;

        public CircleDashboard()
        {
            InitializeComponent();
        }


        public float PercentItem
        {
            get
            {
                return percentItem;
            }

            set
            {
                percentItem = value;
            }
        }

        public Color ColorBackground
        {
            get
            {
                return colorBackground;
            }

            set
            {
                colorBackground = value;
            }
        }

        public Color ColorProcess
        {
            get
            {
                return colorProcess;
            }

            set
            {
                colorProcess = value;
            }
        }

        public Color ColorMain
        {
            get
            {
                return colorMain;
            }

            set
            {
                colorMain = value;
            }
        }

        public Color LineColor
        {
            get
            {
                return lineColor;
            }

            set
            {
                lineColor = value;
            }
        }

        public int LengthLine
        {
            get
            {
                return lengthLine;
            }

            set
            {
                lengthLine = value;
            }
        }

        private void CircleDashboard_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Circle in
            Pen obj_pen = new Pen(ColorMain);
            Rectangle rect = new Rectangle(0 - this.Width / 2 + 20, 0 - this.Height / 2 + 20, this.Width - 40, this.Height - 40);
            e.Graphics.DrawPie(obj_pen, rect, 0, 360);
            e.Graphics.FillPie(new SolidBrush(ColorMain), rect, 0, 360);

            obj_pen = new Pen(ColorProcess);
            rect = new Rectangle(0 - this.Width / 2 + 20, 0 - this.Height / 2 + 20, this.Width - 40, this.Height - 40);
            e.Graphics.DrawPie(obj_pen, rect, -45, PercentItem);
            e.Graphics.FillPie(new SolidBrush(ColorProcess), rect, -45, PercentItem);

            //Circle out

            obj_pen = new Pen(ColorBackground);
            rect = new Rectangle(0 - this.Width / 2 + 30, 0 - this.Height / 2 + 30, this.Width - 60, this.Height - 60);
            e.Graphics.DrawPie(obj_pen, rect, 0, 360);
            e.Graphics.FillPie(new SolidBrush(ColorBackground), rect, 0, 360);

            // Draw line
            e.Graphics.DrawLine(new Pen(lineColor , lengthLine) , new Point(30,-30) , new Point(35, -35));
            e.Graphics.DrawLine(new Pen(lineColor, lengthLine), new Point(35, -35), new Point(300, -35));
            e.Graphics.DrawLine(new Pen(lineColor, lengthLine), new Point(-30, 30), new Point(-35, 35));
            e.Graphics.DrawLine(new Pen(lineColor, lengthLine), new Point(-35, 35), new Point(-300, 35));
        }
    }
}
