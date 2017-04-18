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
    public partial class nCalendar : DataGridView
    {
        private int[] cateBackground = new int[36];
        private Color clrBackground = Color.LightBlue;
        private Color clr1 = Color.LightBlue;
        private Color clr2 = Color.LightSalmon;
        private Color clr3 = Color.LightYellow;
        private int nWidth;
        public nCalendar()
        {
            InitializeComponent();
            InitView();
        }
        private void InitView()
        {
            this.Columns.Add("CN", "CN");
            this.Columns.Add("T2", "T2");
            this.Columns.Add("T3", "T3");
            this.Columns.Add("T4", "T4");
            this.Columns.Add("T5", "T5");
            this.Columns.Add("T6", "T6");
            this.Columns.Add("T7", "T7");

            this.Columns[0].Width = 40;
            this.Columns[1].Width = 40;
            this.Columns[2].Width = 40;
            this.Columns[3].Width = 40;
            this.Columns[4].Width = 40;
            this.Columns[5].Width = 40;
            this.Columns[6].Width = 40;

            //5 rows
            this.Rows.Add("1", "2", "3", "4", "5", "6", "7");
            this.Rows.Add("8", "9", "10", "11", "12", "13", "14");
            this.Rows.Add("15", "16", "17", "18", "19", "20", "21");
            this.Rows.Add("22", "23", "24", "25", "26", "27", "28");
            this.Rows.Add("29", "30", "31", "", "", "", "");

            this.Rows[0].Height = 40;
            this.Rows[1].Height = 40;
            this.Rows[2].Height = 40;
            this.Rows[3].Height = 40;
            this.Rows[4].Height = 40;

            //Color Background
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 11.25f, FontStyle.Bold);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            this.RowHeadersVisible = false;

            //
            //Text font
            //
            this.DefaultCellStyle.Font = new Font("Cambria", 10.25f);
            this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DefaultCellStyle.ForeColor = Color.Black;

            //Custom border
            this.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.BorderStyle = BorderStyle.None;
            //Color row
            this.RowsDefaultCellStyle.BackColor = Color.White;
            this.RowsDefaultCellStyle.ForeColor = Color.Black;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            this.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;


            //
            this.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            this.ColumnHeadersVisible = false;
            this.ScrollBars = ScrollBars.None;
            this.Width = 280;
            this.Height = 200;
            this.CellPainting += NCalendar_CellPainting;
        }

        private void NCalendar_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {
                //Pen for left and top borders
                using (var backGroundPen = new Pen(e.CellStyle.BackColor, 1))
                //Pen for bottom and right borders
                using (var gridlinePen = new Pen(this.GridColor, 1))
                //Pen for selected cell borders
                using (var selectedPen = new Pen(Color.Red, 1))
                {
                    var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
                    var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
                    var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);

                    //Draw selected cells here
                    if (this[e.ColumnIndex, e.RowIndex].Selected)
                    {
                        //Paint all parts except borders.
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        //Handled painting for this cell, Stop default rendering.
                        e.Handled = true;
                    }
                    //Draw non-selected cells here
                    else
                    {
                        //Paint all parts except borders.
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        //Top border of first row cells should be in background color
                        if (e.RowIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, topRightPoint);

                        //Left border of first column cells should be in background color
                        if (e.ColumnIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, bottomleftPoint);

                        //Bottom border of last row cells should be in gridLine color
                        if (e.RowIndex == this.RowCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, bottomleftPoint);
                        else  //Bottom border of non-last row cells should be in background color
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, bottomleftPoint);

                        //Right border of last column cells should be in gridLine color
                        if (e.ColumnIndex == this.ColumnCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, topRightPoint);
                        else //Right border of non-last column cells should be in background color
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, topRightPoint);

                        //Top border of non-first row cells should be in gridLine color, and they should be drawn here after right border
                        if (e.RowIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, topRightPoint);

                        //Left border of non-first column cells should be in gridLine color, and they should be drawn here after bottom border
                        if (e.ColumnIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, bottomleftPoint);

                        //We handled painting for this cell, Stop default rendering.
                        e.Handled = true;
                    }

                    if (e.RowIndex == 4 && (e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6))
                        return;
                    int iIndex = e.RowIndex * 7 + e.ColumnIndex + 1;
                    //Draw selected cells border here
                    if (CateBackground[iIndex] == 0)
                        return;
                    if (CateBackground[iIndex] == 1)
                        clrBackground = clr1;
                    if (CateBackground[iIndex] == 2)
                        clrBackground = clr2;
                    if (CateBackground[iIndex] == 3)
                        clrBackground = clr3;
                    e.Graphics.FillRectangle(new SolidBrush(clrBackground), new Rectangle(e.CellBounds.Left, e.CellBounds.Bottom - 5, e.CellBounds.Width - 1, 5));

                }
            }
            //DataGridViewCell cell = sender as DataGridViewCell;
            //Point bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
            //Point bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);
            //e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(bottomleftPoint.X + 5, bottomleftPoint.Y + 5, cell.Size.Width, 5));
        }

        public int NWidth
        {
            get
            {
                return nWidth;
            }

            set
            {
                nWidth = value;
            }
        }
        

        public Color Clr1
        {
            get
            {
                return clr1;
            }

            set
            {
                clr1 = value;
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

        public Color Clr3
        {
            get
            {
                return clr3;
            }

            set
            {
                clr3 = value;
            }
        }

        public int[] CateBackground
        {
            get
            {
                return cateBackground;
            }

            set
            {
                cateBackground = value;
            }
        }
    }
}
