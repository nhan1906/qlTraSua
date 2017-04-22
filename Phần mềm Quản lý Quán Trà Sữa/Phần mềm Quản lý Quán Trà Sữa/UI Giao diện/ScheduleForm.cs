using Phần_mềm_Quản_lý_Quán_Trà_Sữa.DAO;
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
    public partial class ScheduleForm : Form
    {
        private BindingSource bdNV = new BindingSource();
        public ScheduleForm()
        {
            InitializeComponent();
            Initdtgv();
        }
        private void InitView(int idNhanVien)
        {
            int ca1 = 0, ca2 = 0, ca3 = 0;
            int day = DateTime.Now.Day;
            calendar.CurrentDay = day;
            calendar.CurrentCell = calendar[day % 7 , day / 7];
            DataTable dtCalendar = DataProvider.Instance.ExecuteQuery("Select ngay , cateL from NgayLuong Where idNhanVien = " + idNhanVien);
            int[] daysCl = new int [] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            foreach(DataRow row in dtCalendar.Rows)
            {
                int date = 0;
                DateTime dttime = (DateTime)row["ngay"];
                if (dttime.Month == DateTime.Now.Month && dttime.Year == DateTime.Now.Year)
                    date = dttime.Day;
                int cateL = (int)row["cateL"];
                daysCl[date] = cateL;
                if (cateL == 1)
                    ca1++;
                if (cateL == 2)
                    ca2++;
                if (cateL == 3)
                    ca3++;
            }
            calendar.CateBackground = daysCl;
            lb1Ca.Text = ca1.ToString();
            lb2Ca.Text = ca2.ToString();
            lb3Ca.Text = ca3.ToString();
            calendar.Refresh();
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
            txtNv.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "tenNhanVien", true, DataSourceUpdateMode.Never));


            //Binding text
        }
        private void Loaddtgv()
        {
            bdNV.DataSource = NhanVienDAO.Instance.GetListNhanVien();
        }

        private void txtNv_TextChanged(object sender, EventArgs e)
        {
            InitView(NhanVienDAO.Instance.GetIdByName(txtNv.Text));
            TinhLuongThangNhanVien(NhanVienDAO.Instance.GetIdByName(txtNv.Text));
            txtMoneyDay.Text = NgayLuongDAO.Instance.GetNgayLuongByNhanVien(NhanVienDAO.Instance.GetIdByName(txtNv.Text));
        }

        private void btnChamCa_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dtgvNV.Rows)
            {
                int cateL = 0;
                if (row.Cells["tenNhanVien"].Value == null)
                    return;
                string tenNhanVien = row.Cells["tenNhanVien"].Value.ToString();
                int idNhanVien = NhanVienDAO.Instance.GetIdByName(tenNhanVien);
                bool isCa1 = Convert.ToBoolean((row.Cells["Ca1"] as DataGridViewCheckBoxCell).Value);
                bool isCa2 = Convert.ToBoolean((row.Cells["Ca2"] as DataGridViewCheckBoxCell).Value);
                bool isCa3 = Convert.ToBoolean((row.Cells["Ca3"] as DataGridViewCheckBoxCell).Value);

                if(isCa1 && isCa2 && isCa3)
                {
                    cateL = 3;
                }
                else if((isCa1 && isCa2) || (isCa2 && isCa3 ) || (isCa3 && isCa1))
                {
                    cateL = 2;
                }
                else if(isCa1 || isCa2 || isCa3)
                {
                    cateL = 1;
                }

                bool isExits = NgayLuongDAO.Instance.IsExistNgayLuongByNameAndDay(idNhanVien, DateTime.Now);
                if(isExits)
                {
                    //Update
                    int result = NgayLuongDAO.Instance.UpdateLuongNgay(idNhanVien , cateL , float.Parse(txtMoneyCa.Text) * cateL);
                    if (result == 1)
                    {
                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
                else
                {
                    //insert
                    int result = NgayLuongDAO.Instance.InsertLuongNgay(idNhanVien, cateL, float.Parse(txtMoneyCa.Text) * cateL);
                    if (result == 1)
                    {
                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
        }

        private void TinhLuongThangNhanVien(int idNhanVien)
        {
            txtMoneyMonth.Text = NgayLuongDAO.Instance.LuongByNhanVien(idNhanVien).ToString();
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            int idNhanVien = NhanVienDAO.Instance.GetIdByName(txtNv.Text);
            int i = DataProvider.Instance.ExecuteNonQuery("DELETE FROM NhanVien WHERE idNhanVien = " + idNhanVien);
            if (i == 1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            this.dtgvNV.Refresh();
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            AddNhanVienForm fAdd = new AddNhanVienForm();
            fAdd.ShowDialog();
            bdNV.DataSource = NhanVienDAO.Instance.GetListNhanVien(); ;
        }
    }
}
