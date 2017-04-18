using Phần_mềm_Quản_lý_Quán_Trà_Sữa.DAO;
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
    public partial class ScheduleForm : Form
    {
        private BindingSource bdNV = new BindingSource();
        public ScheduleForm()
        {
            InitializeComponent();
            Initdtgv();
        }
        private void ScheduleForm_Load(object sender, System.EventArgs e)
        {
            LoadDrinkList();
        }

        //Load View
        private void Initdtgv()
        {


            //Color Background
            dtgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvNV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvNV.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 11.25f, FontStyle.Bold);
            dtgvNV.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dtgvNV.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            dtgvNV.RowHeadersVisible = false;

            //
            //Text font
            //
            dtgvNV.DefaultCellStyle.Font = new Font("Cambria", 10.25f);
            dtgvNV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvNV.DefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);

            //Custom border
            dtgvNV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgvNV.BorderStyle = BorderStyle.None;
            //Color row
            dtgvNV.RowsDefaultCellStyle.BackColor = Color.FromArgb(220, 238, 249);
            dtgvNV.RowsDefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);
            dtgvNV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(186, 223, 241);
            dtgvNV.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);
            dtgvNV.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(131, 193, 233);
            dtgvNV.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(67, 72, 78);
        }
        private void LoadDrinkList()
        {
            dtgvNV.DataSource = bdNV;
            Loaddtgv();
            //
            //Thêm checkbox
            //
            DataGridViewCheckBoxColumn chk1 = new DataGridViewCheckBoxColumn();
            chk1.HeaderText = "Ca 1";
            chk1.Name = "Ca1";
            dtgvNV.Columns.Add(chk1);

            DataGridViewCheckBoxColumn chk2 = new DataGridViewCheckBoxColumn();
            chk2.HeaderText = "Ca 2";
            chk2.Name = "Ca2";
            dtgvNV.Columns.Add(chk2);

            DataGridViewCheckBoxColumn chk3 = new DataGridViewCheckBoxColumn();
            chk3.HeaderText = "Ca 3";
            chk3.Name = "Ca3";
            dtgvNV.Columns.Add(chk3);

            dtgvNV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvNV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvNV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvNV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgvNV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            AddBingNV();
        }
        private void AddBingNV()
        {
            this.dtgvNV.Columns[0].HeaderText = "Tên nhân viên";
            this.dtgvNV.Columns[1].HeaderText = "Loại nhân viên";


            //Binding text
        }
        private void Loaddtgv()
        {
            bdNV.DataSource = NhanVienDAO.Instance.GetListNhanVien();
        }

        private void dtgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
