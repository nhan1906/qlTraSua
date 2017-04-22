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
    public partial class AddNhanVienForm : Form
    {
        public AddNhanVienForm()
        {
            InitializeComponent();
            cmbType.DataSource = DataProvider.Instance.ExecuteQuery("Select * from cateNhanVien");
            cmbType.DisplayMember = "cateNhanVien";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txttenNhanVien.Text;
            int idCateNV = cmbType.SelectedIndex + 1;
            int i = NhanVienDAO.Instance.InsertNhanVien(tenNhanVien, idCateNV);
            if (i == 1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            this.Close();
        }
    }
}
