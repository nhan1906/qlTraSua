using Quản_Lý_Quán_Trà_Sữa.DAO;
using Quản_Lý_Quán_Trà_Sữa.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện
{
    public partial class BillForm : Form
    {
        private BindingSource bdDrink = new BindingSource();
        private MainForm fMain = null;
        private int stt = 1;
        private int idTable = 0;
        private float discount = 0;

        public float Discount
        {
            get
            {
                return discount;
            }

            set
            {
                discount = value;
            }
        }

        public BillForm(int idTable , MainForm f)
        {
            InitializeComponent();
            btnL.IsClick = true;
            btnL.ClrBackground = Color.FromArgb(215, 160, 61);
            InitDtgv();
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            lsvBillInfo.FullRowSelect = true;
            this.idTable = idTable;
            fMain = f;
        }
        private void LoadView()
        {
            List<CategoriesD> list = CategoriesDDAO.Instance.GetListCategories();
            cmbCategories.DataSource = list;
            cmbCategories.DisplayMember = "nameCategories";
            ShowBill(idTable);
            if(idTable != 0)
                lbTable.Text = "Bàn " + idTable;
            else
            {
                lbTable.Text = "Take away";
            }
            totalPrice();
        }

        private void ShowBill(int idTable)
        {
            stt = 1;
            lsvBillInfo.Items.Clear();
            List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBillInfoByIdBill(BillDAO.Instance.GetUncheckedBillIdByTableId(idTable));
            
            foreach (BillInfo bill in listBillInfo)
            {
                ListViewItem litem = new ListViewItem("" +stt);
                litem.SubItems.Add(DrinkDAO.Instance.GetFullNameByIdDrink(bill.IdDrink));
                litem.SubItems.Add(bill.CountD.ToString());
                litem.SubItems.Add(bill.Price.ToString());
                lsvBillInfo.Items.Add(litem);
                stt++;
            }
        }
        private void btnAcceptDrink_Click(object sender, EventArgs e)
        {

        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            LoadView();
            txtBinding.DataBindings.Add(new Binding("Text", dtgvDrink.DataSource, "nameDrink", true, DataSourceUpdateMode.Never));
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
            dtgvDrink.Refresh();
            bdDrink.DataSource = DrinkDAO.Instance.GetListDrinkByIdCategory(cmbCategories.SelectedIndex + 1);
            dtgvDrink.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvDrink.Columns[0].HeaderText = (cmbCategories.SelectedItem as CategoriesD).NameCategories;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int size = 1;
            if (btnL.IsClick == true)
            {
                size = 1;
            }
            else if (btnNho.IsClick == true)
            {
                size = 3;
            }
            else
            {
                size = 2;
            }
            Drink drink = DrinkDAO.Instance.GetDrinkByName(txtBinding.Text, size);
            
            int idBill = BillDAO.Instance.GetUncheckedBillIdByTableId(idTable);
            int idDrink = drink.IdDrink;
            int countD = Convert.ToInt32(txtnm.Text);
            int idBillInfo = BillInfoDAO.Instance.GetIdBillInfoByFullName(idDrink, idBill);
            if (idBillInfo == -1)
            {
                BillInfoDAO.Instance.AddBillInfoByIdBill(idBill, idDrink, countD, drink.Price * countD);
                //Hien thi danh sach billinfo len listview
                ListViewItem litem = new ListViewItem("" + stt++);
                if (size == 1)
                {
                    litem.SubItems.Add(drink.NameDrink + " - L");
                }
                else if (size == 2)
                {
                    litem.SubItems.Add(drink.NameDrink + " - TB");
                }
                else if (size == 3)
                {
                    litem.SubItems.Add(drink.NameDrink + " - Nho");
                }
                litem.SubItems.Add(txtnm.Text);
                litem.SubItems.Add(drink.Price.ToString());
                lsvBillInfo.Items.Add(litem);
            }
            else
            {
                BillInfoDAO.Instance.UpdateBillInfoByIdBill(countD, drink.Price * countD , idBillInfo);
                ShowBill(idTable);
            }

            //so luong va btn
            txtnm.Text = "1";
            lsvBillInfo.Refresh();
            totalPrice();
            //Xoa the
        }

        private void txtBinding_TextChanged(object sender, EventArgs e)
        {

            btnL.IsClick = false;
            btnNho.IsClick = false;
            btnTb.IsClick = false;
            btnL.ClrBackground = Color.FromArgb(215, 160, 61);
            btnNho.ClrBackground = Color.FromArgb(215, 160, 61);
            btnTb.ClrBackground = Color.FromArgb(215, 160, 61);

            int[] sizeDrink = new int[3];
            sizeDrink = DrinkDAO.Instance.GetSizeDrinkByName(txtBinding.Text);
            if (sizeDrink[0] == 0)
                btnL.Enabled = false;
            else
            {
                btnL.Enabled = true;
                btnL.IsClick = true;
                btnL.ClrBackground = Color.Khaki;
            }
                
            
            if (sizeDrink[1] == 0)
                btnTb.Enabled = false;
            else
            {
                btnTb.Enabled = true;
                if(btnL.Enabled != true)
                {
                    btnTb.IsClick = true;
                    btnTb.ClrBackground = Color.Khaki;
                }
            }

            if (sizeDrink[2] == 0)
                btnNho.Enabled = false;
            else
            {
                btnNho.Enabled = true;
                if (btnL.Enabled != true && btnNho.Enabled != true)
                {
                    btnNho.IsClick = true;
                    btnNho.ClrBackground = Color.Khaki;
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int number = (Convert.ToInt32(txtnm.Text));
            ++number;
            txtnm.Text = "" + number;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int number = (Convert.ToInt32(txtnm.Text));
            if (number == 1)
            {
                return;
            }
            else
            {
                --number;
                txtnm.Text = "" + number;
            }
        }


        private void btnL_Click(object sender, EventArgs e)
        {
            btnNho.IsClick = false;
            btnTb.IsClick = false;
            btnNho.ClrBackground = Color.FromArgb(215, 160, 61);
            btnTb.ClrBackground = Color.FromArgb(215, 160, 61);
        }

        private void btnNho_Click(object sender, EventArgs e)
        {
            btnL.IsClick = false;
            btnTb.IsClick = false;
            btnL.ClrBackground = Color.FromArgb(215, 160, 61);
            btnTb.ClrBackground = Color.FromArgb(215, 160, 61);
        }

        private void btnTb_Click(object sender, EventArgs e)
        {
            btnNho.IsClick = false;
            btnL.IsClick = false;
            btnNho.ClrBackground = Color.FromArgb(215, 160, 61);
            btnL.ClrBackground = Color.FromArgb(215, 160, 61);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvBillInfo.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvBillInfo.SelectedItems[0];
                int index = lsvBillInfo.Items.IndexOf(item);
                string name = item.SubItems[1].Text;
                string[] result = name.Split('-');
                result[0] = result[0].Trim();
                result[1] = result[1].Trim();
                int size = 1;
                if (result[1].Equals("L"))
                    size = 1;
                else if (result[1].Equals("N"))
                    size = 3;
                else
                    size = 2;
                Drink idrink = DrinkDAO.Instance.GetDrinkByName(result[0], size);
                int idBill = BillDAO.Instance.GetUncheckedBillIdByTableId(idTable);
                lsvBillInfo.Items[index].Remove();
                int idBillInfo = BillInfoDAO.Instance.GetIdBillInfoByFullName(idrink.IdDrink, idBill);
                BillInfoDAO.Instance.DeleteBillInfoByIdBillInfo(idBillInfo);
                ShowBill(idTable);
                totalPrice();
            }
        }

        private void totalPrice()
        {
            float total = 0.0f;
            total = BillDAO.Instance.GetTotalPriceByIdBill(BillDAO.Instance.GetUncheckedBillIdByTableId(idTable));
            txtTotalPrice.Text = total.ToString("c");
            Discount = float.Parse(txtDiscount.Text);
            txtCashout.Text = (total * (1 - discount / 100)).ToString("c");
        }

        private void txtDiscount_Click(object sender, EventArgs e)
        {
            ConfirmPassword f = new ConfirmPassword(1 , this);
            f.ShowDialog();
            this.Show();
            txtDiscount.Text = "" + discount;
            float total = BillDAO.Instance.GetTotalPriceByIdBill(BillDAO.Instance.GetUncheckedBillIdByTableId(idTable));
            txtCashout.Text = (total * (1 - discount / 100)).ToString("c");
        }

        private void btnCashout_Click(object sender, EventArgs e)
        {
            //Thanh toan
            int idCurrentBill = BillDAO.Instance.GetUncheckedBillIdByTableId(idTable);
            float sale = float.Parse(txtDiscount.Text);
            float totalPrice = float.Parse(txtCashout.Text.Remove(txtCashout.Text.Length - 1));
            DateTime now = DateTime.Now;
            int result = BillDAO.Instance.CashoutBillByid(idCurrentBill, sale, totalPrice, now);
            if (result == 1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            if(idTable != 0)
                TableDDAO.Instance.CleanTableByIdTable(idTable);
            //tra lai ban
            fMain.fTable.Show();
            fMain.btnTable_Click(new object(), new EventArgs());
            fMain.BtnBill.Enabled = false;
        }
        
    }
}
