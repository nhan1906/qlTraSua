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
    public partial class TableForm : Form
    {
        MainForm f = null;
        public TableForm(MainForm f)
        {
            InitializeComponent();
            pnInfoTable.Tag = 1;
            this.f = f;
        }

        private void TableForm_Load(object sender, EventArgs e)
        {

            LoadTableDList();
        }


        #region

        private void TableForm_Activated(object sender, EventArgs e)
        {
            LoadTableDList();
        }

        private void LoadTableDList()
        {
            flpnTable.Controls.Clear();
            flpnTable.BackColor = Color.White;
            List<TableD> lTableD = TableDDAO.Instance.GetListTableD();
            //
            //Take away
            //
            Button btnTakeaway = new Button();
            btnTakeaway.Width = 115;
            btnTakeaway.Height = 85;
            btnTakeaway.FlatAppearance.BorderSize = 0;
            btnTakeaway.BackColor = Color.SeaGreen;
            btnTakeaway.FlatStyle = FlatStyle.Flat;
            btnTakeaway.Font = new System.Drawing.Font("Cambria", 9.75F, FontStyle.Bold);
            btnTakeaway.ForeColor = Color.White;
            btnTakeaway.Text = "Take away";
            btnTakeaway.TextAlign = ContentAlignment.MiddleCenter;
            btnTakeaway.Click += btnTakeaway_Click;
            flpnTable.Controls.Add(btnTakeaway);
            //
            //Tabel list
            //
            foreach (TableD table in lTableD)
            {
                // Hien text
                Button btnTable = new Button();
                btnTable.Width = 115;
                btnTable.Height = 85;
                btnTable.FlatAppearance.BorderSize = 0;
                btnTable.BackColor = Color.FromArgb(197, 221, 231);
                btnTable.FlatStyle = FlatStyle.Flat;
                if (table.Status == 1)
                {
                    btnTable.Image = Image.FromFile(@"C:\Users\Nhan\Desktop\New folder\hass.png");
                    btnTable.ImageAlign = ContentAlignment.TopRight;
                }
                else
                {
                    //nothing
                }
                btnTable.Font = new System.Drawing.Font("Cambria", 9.75F, FontStyle.Bold);
                btnTable.ForeColor = Color.FromArgb(67, 72, 78);
                btnTable.Text = "No. " + table.NameTable;
                btnTable.TextAlign = ContentAlignment.BottomCenter;
                btnTable.Click += btnTable_Click;
                btnTable.Tag = table;
                flpnTable.Controls.Add(btnTable);
            }
            //
            //Thêm table
            //
            Button btnAdd = new Button();
            btnAdd.Width = 115;
            btnAdd.Height = 85;
            btnAdd.BackColor = Color.Black;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.BackgroundImage = Image.FromFile(@"C:\Users\Nhan\Desktop\New folder\add.png");
            btnAdd.BackgroundImageLayout = ImageLayout.Center;
            btnAdd.Click += btnAdd_Click;
            flpnTable.Controls.Add(btnAdd);

            //Load thông tin table
            int totalTable = TableDDAO.Instance.GetTotalTable();
            int nmNooneTable = TableDDAO.Instance.GetNooneTable();
            lbStillTable.Text = nmNooneTable + " bàn trống";
            lbsumTable.Text = totalTable + " bàn";
            int percent = nmNooneTable*100 / totalTable;
            lbpercentTable.Text = percent + "%";
            processTable.PercentItem = nmNooneTable * 360 / (totalTable);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ConfirmPassword f = new ConfirmPassword(2 , this);
            f.ShowDialog();
            LoadTableDList();            
        }

        private void btnTakeaway_Click(object sender, EventArgs e)
        {

        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            TableD table = button.Tag as TableD;
            //
            //Hiện table info
            //
            DisplayTableInfo(table);

            if (table.Status == 0)
            {
                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Add("Tạo Hóa Đơn", new EventHandler(CreateBill));
                cm.Show(button, button.PointToClient(Cursor.Position));
            }
            else
            {
                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Add("Xem hóa đơn", new EventHandler(SeeBill));
                cm.Show(button, button.PointToClient(Cursor.Position));
            }
        }
        private void DisplayTableInfo(TableD table)
        {
            pnInfoTable.Tag = table.IdTableD;
            lbNameTb.Text = "No. " + table.NameTable;
            if(table.Status == 0)
            {
                lbPeople.Text = "Chưa có người";
                lbMoney.Text = "0 VNĐ";
            }
            else if(table.Status == 1)
            {
                int[] bill = TableDDAO.Instance.HowManyPeople(table.IdTableD);
                lbPeople.Text = bill[0].ToString();
                lbMoney.Text = BillDAO.Instance.GetTotalPriceByIdBill(bill[1]).ToString() + " VNĐ";
            }
            //Hien thi so nguoi , thanh toan
            
        }
        #endregion

        #region Events
        private void SeeBill(object sender, EventArgs e)
        {
            f.fBill = new BillForm((int)pnInfoTable.Tag);
            f.fBill.StartPosition = FormStartPosition.Manual;
            f.fBill.Name = "DrinkF";
            f.fBill.MdiParent = f;
            f.fBill.Show();
        }
        private void CreateBill(object sender, EventArgs e)
        {
            int idTableD = (int)pnInfoTable.Tag;
            TableDDAO.Instance.SetStatusTableById(idTableD);
            confirmTable confirm = new confirmTable(idTableD, f);
            confirm.ShowDialog();
        }
        #endregion

    }
}
