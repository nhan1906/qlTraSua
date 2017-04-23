using Quản_Lý_Quán_Trà_Sữa.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            InitDtgv();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadView();
        }

        private void LoadView()
        {
            cmbCategoriesD.DataSource = CategoriesDDAO.Instance.GetListCategories();
            cmbCategoriesD.DisplayMember = "nameCategories";
        }

        private void InitDtgv()
        {

            //Color Background
            dtThongke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtThongke.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtThongke.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 11.25f, FontStyle.Bold);
            dtThongke.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dtThongke.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            dtThongke.RowHeadersVisible = false;

            //
            //Text font
            //
            dtThongke.DefaultCellStyle.Font = new Font("Cambria", 10.25f);
            dtThongke.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtThongke.DefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);

            //Custom border
            dtThongke.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtThongke.BorderStyle = BorderStyle.None;
            //Color row
            dtThongke.RowsDefaultCellStyle.BackColor = Color.FromArgb(220, 238, 249);
            dtThongke.RowsDefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);
            dtThongke.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(186, 223, 241);
            dtThongke.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);
            dtThongke.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(131, 193, 233);
            dtThongke.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(67, 72, 78);
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbType.SelectedIndex == 0)
            {
                dtThongke.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM BC_DoanhSo");
                this.dtThongke.Columns[0].HeaderText = "Số hóa đơn";
                this.dtThongke.Columns[1].HeaderText = "Ngày hóa đơn";
                this.dtThongke.Columns[2].HeaderText = "Tổng tiền";
                this.dtThongke.Columns[3].HeaderText = "Giảm giá";
                this.dtThongke.Columns[4].HeaderText = "Tổng tiền";

                dtThongke.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtThongke.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtThongke.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtThongke.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtThongke.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
