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
    public partial class nTabButton : Button
    {
        #region Propeties
        private bool isClick = false;
        private Color clrClick = Color.Black;
        private Color clrMouseHover = Color.Black;
        private Color clrBackground = Color.SeaGreen;
        private Color clrShow = Color.Blue;
        private Color color = Color.SeaGreen;
        private Color clr2 = Color.Black;
        private int lengthLine = 5;
        private string nText = "";
        private int nTextX = 0;
        private int nTextY = 0;
        #region Getter, Setter

        public Color ClrClick
        {
            get
            {
                return clrClick;
            }

            set
            {
                clrClick = value;
                Invalidate();
            }
        }

        public Color ClrMouseHover
        {
            get
            {
                return clrMouseHover;
            }

            set
            {
                clrMouseHover = value;
                Invalidate();
            }
        }

        public bool IsClick
        {
            get
            {
                return isClick;
            }

            set
            {
                isClick = value;
                Invalidate();
            }
        }

        public Color ClrBackground
        {
            get
            {
                return clrBackground;
            }

            set
            {
                clrBackground = value;
                Invalidate();
            }
        }

        public Color ClrShow
        {
            get
            {
                return clrShow;
            }

            set
            {
                clrShow = value;
                Invalidate();
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

        public string NText
        {
            get
            {
                return nText;
            }

            set
            {
                nText = value;
            }
        }

        public int NTextX
        {
            get
            {
                return nTextX;
            }

            set
            {
                nTextX = value;
            }
        }

        public int NTextY
        {
            get
            {
                return nTextY;
            }

            set
            {
                nTextY = value;
            }
        }

        public Color Clr2
        {
            get
            {
                return clr2;
            }

            set
            {
                clr2 = value;
            }
        }


        #endregion
        #region Events
        //method mouse leave
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            color = clrBackground;
            clrBackground = clrMouseHover;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (!isClick)
                clrBackground = color;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            IsClick = true;
            clrBackground = clrClick;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (!isClick)
                clrBackground = color;
        }
        #endregion
        #endregion
        public nTabButton()
        {
            InitializeComponent();
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(clrBackground), ClientRectangle);


            Point p = new Point(NTextX, NTextY);
            pevent.Graphics.DrawString(NText, this.Font, new SolidBrush(this.ForeColor), p);
            if (isClick)
                pevent.Graphics.FillRectangle(new SolidBrush(ClrShow), new Rectangle(0, Height - lengthLine, Width, lengthLine));
            else
                pevent.Graphics.FillRectangle(new SolidBrush(Clr2), new Rectangle(0, Height - lengthLine, Width, lengthLine));
        }
    }
}
