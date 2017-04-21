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
    public partial class confirmTable : Form
    {
        int idTable = 1;
        MainForm f = null;
        public confirmTable(int idTable , MainForm f)
        {
            InitializeComponent();
            this.idTable = idTable;
            this.f = f;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            TableDDAO.Instance.SetStatusTableById(idTable);
            BillDAO.Instance.CreateNewBillForTable(idTable, int.Parse(txtNumber.Text));
            f.fBill = new BillForm(idTable);
            f.fBill.StartPosition = FormStartPosition.Manual;
            f.fBill.Name = "DrinkF";
            f.fBill.MdiParent = f;
            f.fBill.Show();
            this.Close();
        }
    }
}
