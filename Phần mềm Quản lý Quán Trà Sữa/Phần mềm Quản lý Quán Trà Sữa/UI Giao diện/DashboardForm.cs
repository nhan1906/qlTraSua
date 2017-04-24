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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            InitDtgv();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadView(DateTime.Now);
        }

        private void LoadView(DateTime date)
        {
            cmbCategoriesD.SelectedIndex = 1;
            cmbType.SelectedIndex = 0;
        }

        private void InitDtgv()
        {
            //cmb
            cmbCategoriesD.DataSource = CategoriesDDAO.Instance.GetListCategories();
            cmbCategoriesD.DisplayMember = "nameCategories";

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
            if(cmbType.SelectedIndex == 0 || cmbType.SelectedIndex == 1 || cmbType.SelectedIndex == 2)
            {
                int nmHoadon = 0;
                float total = 0;
                float discount = 0;
                float totalprice = 0;
                if(cmbType.SelectedIndex == 0)
                {
                    lbTK.Text = "Doanh thu ngày " + dt.Value.Date.ToString("dd-MM-yyyy");
                    dtThongke.DataSource = DataProvider.Instance.ExecuteQuery("BC_DoanhThuNgay @date" , new object[] { dt.Value.Date});
                    this.dtThongke.Columns[0].HeaderText = "Mã hóa đơn";
                    this.dtThongke.Columns[1].HeaderText = "Tổng tiền";
                    this.dtThongke.Columns[2].HeaderText = "Giảm giá";
                    this.dtThongke.Columns[3].HeaderText = "Tổng tiền hóa đơn";
                    this.dtThongke.Columns[4].HeaderText = "Ngày hóa đơn";

                    dtThongke.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtThongke.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtThongke.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtThongke.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtThongke.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    foreach (DataRow item in ((DataTable)dtThongke.DataSource).Rows)
                    {
                        nmHoadon++;
                        total += float.Parse(item["tongtien"].ToString());
                        discount += float.Parse(item["sale"].ToString());
                        totalprice += float.Parse(item["totalprice"].ToString());
                    }
                    DataRow row2 = ((DataTable)dtThongke.DataSource).NewRow();
                    row2["MaBill"] = "Tổng : " + nmHoadon;
                    row2["tongtien"] = total;
                    row2["sale"] = discount;
                    row2["totalprice"] = totalprice;

                    ((DataTable)dtThongke.DataSource).Rows.Add(row2);
                    return;
                }
                if (cmbType.SelectedIndex == 1)
                {
                    lbTK.Text = "Doanh thu tuần từ ngày " + dt.Value.Date.AddDays(-6).ToString("dd-MM-yyyy") + " tới ngày : " + dt.Value.Date.ToString("dd-MM-yyyy");
                    dtThongke.DataSource = DataProvider.Instance.ExecuteQuery("BC_DoanhThuTuan @days", new object[] {dt.Value.Date });
                }
                if (cmbType.SelectedIndex == 2)
                {
                    lbTK.Text = "Doanh thu tháng " + dt.Value.Date.ToString("MM-yyyy");
                    dtThongke.DataSource = DataProvider.Instance.ExecuteQuery("BC_DoanhThuThang @date", new object[] { dt.Value.Date });
                }


                foreach (DataRow item in ((DataTable)dtThongke.DataSource).Rows)
                {
                    nmHoadon += (int)item["soBill"];
                    total += float.Parse(item["tongtien"].ToString());
                    discount += float.Parse(item["sale"].ToString());
                    totalprice += float.Parse(item["totalprice"].ToString());
                }
                DataRow row1 = ((DataTable)dtThongke.DataSource).NewRow();
                row1["soBill"] = nmHoadon;
                row1["tongtien"] = total;
                row1["sale"] = discount;
                row1["totalprice"] = totalprice;

                ((DataTable)dtThongke.DataSource).Rows.Add(row1);

                this.dtThongke.Columns[0].HeaderText = "Số hóa đơn";
                this.dtThongke.Columns[1].HeaderText = "Ngày hóa đơn";
                this.dtThongke.Columns[2].HeaderText = "Tổng tiền";
                this.dtThongke.Columns[3].HeaderText = "Giảm giá";
                this.dtThongke.Columns[4].HeaderText = "Tổng tiền hóa đơn";

                dtThongke.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtThongke.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtThongke.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtThongke.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtThongke.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (cmbType.SelectedIndex == 3 || cmbType.SelectedIndex == 4 || cmbType.SelectedIndex == 5)
            {
                lbTK.Text = "Thống kê sản phẩm : " + dt.Value.Date.ToString("dd-MM-yyyy");
                if (cmbType.SelectedIndex == 3)
                {
                    string query = "SELECT * FROM DrinkPerTime WHERE DATEPART(MM, days) = " + dt.Value.Date.Month + " AND DATEPART(YYYY, days) = " + dt.Value.Date.Year + " AND DATEPART(dd, days) = " + dt.Value.Date.Day + " ORDER BY soLuong DESC";
                    dtThongke.DataSource = DataProvider.Instance.ExecuteQuery(query);
                }
                if (cmbType.SelectedIndex == 4)
                {
                    lbTK.Text = "Thống kê sản phẩm : " + dt.Value.Date.AddDays(-6).ToString("dd-MM-yyyy") + " tới ngày : " + dt.Value.Date.ToString("dd-MM-yyyy");
                    DateTime now = dt.Value.Date;
                    dtThongke.DataSource = DataProvider.Instance.ExecuteQuery("DrinkPerWeek @days " , new object[] { now });
                    this.dtThongke.Columns[0].HeaderText = "Mã Sản Phẩm";
                    this.dtThongke.Columns[1].HeaderText = "Sản phẩm";
                    this.dtThongke.Columns[1].HeaderText = "Số lượng";
                    dtThongke.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dtThongke.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtThongke.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    int sl = 0;
                    foreach (DataRow item in ((DataTable)dtThongke.DataSource).Rows)
                    {
                        sl += (int)item["soLuong"];
                    }
                    DataRow row1 = ((DataTable)dtThongke.DataSource).NewRow();
                    row1["MaDrink"] = "Tổng kết";
                    row1["nameDrink"] = "Tổng số lượng :";
                    row1["soLuong"] = sl;
                    ((DataTable)dtThongke.DataSource).Rows.Add(row1);
                    return;
                }
                if (cmbType.SelectedIndex == 5)
                {
                    lbTK.Text = "Thống kê sản phẩm tháng : " + dt.Value.Date.ToString("MM-yyyy");
                    string query = "SELECT  MaDrink , nameDrink as nameDrink , SUM(soLuong) as soLuong , AVG(DATEPART(MM , days)) as month FROM DrinkPerTime WHERE DATEPART(MM, days) = " + dt.Value.Date.Month + " AND DATEPART(YYYY, days) =  " + dt.Value.Date.Year + " GROUP By nameDrink , MaDrink ORDER BY soLuong DESC";
                    dtThongke.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    this.dtThongke.Columns[0].HeaderText = "Mã Sản phẩm";
                    this.dtThongke.Columns[1].HeaderText = "Tên Sản phẩm";
                    this.dtThongke.Columns[2].HeaderText = "Số lượng";
                    this.dtThongke.Columns[3].HeaderText = "Tháng";
                    dtThongke.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dtThongke.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtThongke.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtThongke.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    int sl = 0;
                    foreach (DataRow item in ((DataTable)dtThongke.DataSource).Rows)
                    {
                        sl += (int)item["soLuong"];
                    }
                    DataRow row1 = ((DataTable)dtThongke.DataSource).NewRow();
                    row1["nameDrink"] = "Tổng số lượng :";
                    row1["soLuong"] = sl;
                    ((DataTable)dtThongke.DataSource).Rows.Add(row1);
                    return;
                }
                int soluong = 0;
                foreach(DataRow item in ((DataTable)dtThongke.DataSource).Rows)
                {
                    soluong += (int)item["soLuong"];
                }
                DataRow row = ((DataTable)dtThongke.DataSource).NewRow();
                row["nameDrink"] = "Tổng số lượng :";
                row["soLuong"] = soluong;
                ((DataTable)dtThongke.DataSource).Rows.Add(row);




                this.dtThongke.Columns[0].HeaderText = "Mã sản phẩm";
                this.dtThongke.Columns[1].HeaderText = "Tên sản phẩm";
                this.dtThongke.Columns[2].HeaderText = "Số lượng";
                this.dtThongke.Columns[3].HeaderText = "Ngày bán";

                dtThongke.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtThongke.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtThongke.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtThongke.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            }

            if(cmbType.SelectedIndex == 6)
            {
                lbTK.Text = "Thống kê Takeaway";
                dtThongke.DataSource = DataProvider.Instance.ExecuteQuery("USP_TKTakeAway");
                this.dtThongke.Columns[0].HeaderText = "Số hóa đơn takeaway";
                this.dtThongke.Columns[1].HeaderText = "Tổng hóa đơn";
                this.dtThongke.Columns[2].HeaderText = "Ngày bán";

                dtThongke.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtThongke.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtThongke.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            if(cmbType.SelectedIndex == 7)
            {
                lbTK.Text = "Thống kê lương Nhân viên tháng : " + dt.Value.Date.ToString("MM-yyyy");
                dtThongke.DataSource = DataProvider.Instance.ExecuteQuery("BC_LuongNV @date" , new object[] { dt.Value.Date });
                float totalLuong = 0;
                float uncheckLuong = 0;
                float checkLuong = 0;
                foreach (DataRow item in ((DataTable)dtThongke.DataSource).Rows)
                {
                    totalLuong += float.Parse(item["totalLuong"].ToString());
                    uncheckLuong += float.Parse(item["uncheckLuong"].ToString());
                    checkLuong += float.Parse(item["checkLuong"].ToString());
                }
                DataRow row2 = ((DataTable)dtThongke.DataSource).NewRow();
                row2["tenNhanVien"] = "Thống kê lương : ";
                row2["totalLuong"] = totalLuong;
                row2["uncheckLuong"] = uncheckLuong;
                row2["checkLuong"] = checkLuong;

                ((DataTable)dtThongke.DataSource).Rows.Add(row2);

                this.dtThongke.Columns[0].HeaderText = "Tên Nhân viên";
                this.dtThongke.Columns[1].HeaderText = "Lương tháng";
                this.dtThongke.Columns[2].HeaderText = "Còn nợ";
                this.dtThongke.Columns[3].HeaderText = "Đã thanh toán";

                dtThongke.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtThongke.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtThongke.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dtThongke.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            }
        }

        private void cmbCategoriesD_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hiện drink
            lbTKDrink.Text = "Thống kê sản phẩm ngày : " + dt.Value.Date.ToString("dd-MM-yyyy");
            CategoriesD currentCate = (CategoriesD)cmbCategoriesD.SelectedItem;
            int idCategory = currentCate.IdCategoriesD;
            cmbDrink.DataSource = DrinkDAO.Instance.GetListDrinkByIdCategory(idCategory);
            cmbDrink.DisplayMember = "nameDrink";
            //Thống kê
            float percentItem = 0;
            int nmCategory = 0;
            int nmAll = 1;
            if(true)
            {
                if (DataProvider.Instance.ExecuteScalar("NumberCategoriesOnAll @idCategoriesD , @getIn", new object[] { idCategory , dt.Value.Date}).ToString() == "")
                {
                    tkCategories.PercentItem = percentItem;
                    tkCategories.Refresh();
                    lbCateName.Text = lbCate.Text = currentCate.NameCategories;
                    lbpercentCate.Text = (100 * nmCategory / nmAll).ToString("0.0") + "%";
                    return;
                }
                    
                nmCategory = (int)DataProvider.Instance.ExecuteScalar("NumberCategoriesOnAll @idCategoriesD , @getIn", new object[] { idCategory , dt.Value.Date});
                nmAll = (int)DataProvider.Instance.ExecuteScalar("AllProductsSale @getIn" , new object[] { dt.Value.Date});
                percentItem = 360 * nmCategory / nmAll;
            }
            tkCategories.PercentItem = percentItem;
            tkCategories.Refresh();
            lbCateName.Text = lbCate.Text = currentCate.NameCategories;
            lbpercentCate.Text = (100 * nmCategory / nmAll).ToString("0.0") + "%";


        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {
            cmbType_SelectedIndexChanged(new object(), new EventArgs());
            cmbCategoriesD_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void cmbDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameDrink = cmbDrink.Text;
            lbDrink.Text = nameDrink;
            CategoriesD currentCate = (CategoriesD)cmbCategoriesD.SelectedItem;
            int idCategory = currentCate.IdCategoriesD;
            int nmCategory = 1;
            int nmDrink = 0;
            if (DataProvider.Instance.ExecuteScalar("NumberCategoriesOnAll @idCategoriesD , @getIn", new object[] { idCategory , dt.Value.Date }).ToString() == "")
            {
                lbPercentDrink.Text = (100 * nmDrink / nmCategory).ToString("0.0") + "%";
                lbDrink.Text = nameDrink;
                tkDrink.PercentItem = 360 * nmDrink / nmCategory;
                tkDrink.Refresh();
                return;
            }
            else
                nmCategory = (int)DataProvider.Instance.ExecuteScalar("NumberCategoriesOnAll @idCategoriesD , @getIn", new object[] { idCategory , dt.Value.Date});
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT soLuong FROM DrinkPerTime WHERE nameDrink = N'" + nameDrink + "'");
            
            foreach(DataRow item  in data.Rows)
            {
                nmDrink += (int)item["soLuong"];
            }
            lbPercentDrink.Text = (100 * nmDrink / nmCategory).ToString("0.0") + "%";
            lbDrink.Text = nameDrink;
            tkDrink.PercentItem = 360 * nmDrink / nmCategory;
            tkDrink.Refresh();
        }
    }
}
