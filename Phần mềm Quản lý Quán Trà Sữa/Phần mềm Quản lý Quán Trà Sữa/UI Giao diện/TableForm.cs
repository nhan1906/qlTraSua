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
        public TableForm()
        {
            InitializeComponent();
            LoadTableDList();
        }

        #region
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
            ConfirmPassword f = new ConfirmPassword();
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
                cm.MenuItems.Add("Xóa Hóa Đơn", new EventHandler(DeleteBill));
                cm.Show(button, button.PointToClient(Cursor.Position));
            }
        }
        private void DisplayTableInfo(TableD table)
        {
            lbNameTb.Text = "No. " + table.NameTable;
            if(table.Status == 0)
            {
                lbPeople.Text = "Chưa có người";
            }
        }
        #endregion

        #region Events
        private void SeeBill(object sender, EventArgs e)
        {

        }
        private void CreateBill(object sender, EventArgs e)
        {
            TableDDAO.Instance.SetStatusTableById(1);
        }

        private void DeleteBill(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
