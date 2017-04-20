using Quản_Lý_Quán_Trà_Sữa.DAO;
using Quản_Lý_Quán_Trà_Sữa.DTO;
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
    public partial class BillForm : Form
    {
        private BindingSource bdDrink = new BindingSource();
        public BillForm(int idTable)
        {
            InitializeComponent();
            InitDtgv();
        }
        private void LoadView()
        {
            List<CategoriesD> list = CategoriesDDAO.Instance.GetListCategories();
            cmbCategories.DataSource = list;
            cmbCategories.DisplayMember = "nameCategories";
        }
        private void btnAcceptDrink_Click(object sender, EventArgs e)
        {

        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            LoadView();
        }

        private void InitDtgv()
        {

            //Color Background
            dtgvDrink.DataSource = bdDrink;
            dtgvDrink.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvDrink.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvDrink.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 11.25f, FontStyle.Bold);
            dtgvDrink.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dtgvDrink.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            dtgvDrink.RowHeadersVisible = false;

            //
            //Text font
            //
            dtgvDrink.DefaultCellStyle.Font = new Font("Cambria", 10.25f);
            dtgvDrink.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvDrink.DefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);

            //Custom border
            dtgvDrink.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgvDrink.BorderStyle = BorderStyle.None;
            //Color row
            dtgvDrink.RowsDefaultCellStyle.BackColor = Color.FromArgb(220, 238, 249);
            dtgvDrink.RowsDefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);
            dtgvDrink.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(186, 223, 241);
            dtgvDrink.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);
            dtgvDrink.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(131, 193, 233);
            dtgvDrink.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(67, 72, 78);
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            bdDrink.DataSource = DrinkDAO.Instance.GetListDrinkByIdCategory(cmbCategories.SelectedIndex + 1);
            dtgvDrink.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvDrink.Columns[0].HeaderText = "Thức uống";
            dtgvDrink.Refresh();
        }
    }
}
