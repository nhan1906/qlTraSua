using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện
{
    public partial class nButton : Button
    {
        #region Propeties
        private Image nImage = null;
        private string nText = "";
        private bool isClick = false;
        private Color clrClick = Color.Black;
        private Color clrMouseHover = Color.Black;
        private Color clrBackground = Color.SeaGreen;
        private Color clrShow = Color.Blue;
        private Color color  = Color.SeaGreen;
        private int nTextX = 0;
        private int nTextY = 0;
        private int nImageX = 0;
        private int nImageY = 0;
        #region Getter, Setter
        public Image NImage
        {
            get
            {
                return nImage;
            }

            set
            {
                nImage = value;
                Invalidate();
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
                Invalidate();
            }
        }

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

        public int NTextX
        {
            get
            {
                return nTextX;
            }

            set
            {
                nTextX = value;
                Invalidate();
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
                Invalidate();
            }
        }

        public int NImageX
        {
            get
            {
                return nImageX;
            }

            set
            {
                nImageX = value;
                Invalidate();
            }
        }

        public int NImageY
        {
            get
            {
                return nImageY;
            }

            set
            {
                nImageY = value;
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
        public nButton()
        {
            InitializeComponent();
            //Set default button
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            //Background color
            pevent.Graphics.FillRectangle(new SolidBrush(clrBackground), ClientRectangle);
            //Drawing Image
            Point p = new Point(nImageX, nImageY);
            if (nImage != null)
            {
                pevent.Graphics.DrawImage(nImage, nImageX, nImageY , 15 , 15);
            }
            //Drawing Text
            p = new Point(nTextX, nTextY);
            pevent.Graphics.DrawString(nText, this.Font, new SolidBrush(this.ForeColor), p);
            if (isClick)
                pevent.Graphics.FillRectangle(new SolidBrush(ClrShow), new Rectangle(0, 0, 3, this.Height));
        }

    }
}
