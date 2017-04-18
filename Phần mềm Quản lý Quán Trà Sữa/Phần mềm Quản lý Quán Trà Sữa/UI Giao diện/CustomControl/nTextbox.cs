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
    public partial class nTextbox : TextBox
    {
        private Color clrBorder = Color.SeaGreen;
        public override bool AutoSize
        {
            get
            {
                return base.AutoSize;
            }

            set
            {
                base.AutoSize = value;
            }
        }
        public nTextbox()
        {
            InitializeComponent();
            this.AutoSize = false;
            this.Top = this.Height - this.Height / 2;
        }

        public Color ClrBorder
        {
            get
            {
                return clrBorder;
            }

            set
            {
                clrBorder = value;
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);
        private const int WM_NCPAINT = 0x85;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (this.Focused)
            {
                var dc = GetWindowDC(Handle);
                using (Graphics g = Graphics.FromHdc(dc))
                {
                    g.DrawRectangle(new Pen(clrBorder), 0, 0, Width - 2, Height - 2);
                }
            }
        }
    }
}
