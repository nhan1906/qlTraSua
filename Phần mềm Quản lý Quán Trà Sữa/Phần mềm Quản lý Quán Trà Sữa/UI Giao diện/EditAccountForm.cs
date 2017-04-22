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
    public partial class EditAccountForm : Form
    {
        private string userName = "";
        public EditAccountForm(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void EditAccountForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = userName;
            txtDisplayName.Text = AccountDDAO.Instance.GetDisplayNameByUserName(userName);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtDisplayName.Text == "" || txtPasswordOld.Text == "" || txtPasswordNew.Text == "" || txtConfirm.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (AccountDDAO.Instance.CheckOldPassword(txtUserName.Text, txtPasswordOld.Text) != 1)
            {
                MessageBox.Show("Sai mật khẩu cũ.");
                return;
            }
            if (!txtPasswordNew.Text.Equals(txtConfirm.Text))
            {
                MessageBox.Show("Mật khẩu mới không khớp.");
                return;
            }
            int i = AccountDDAO.Instance.EditAccountByUserNameNoType(txtUserName.Text, txtDisplayName.Text, txtPasswordNew.Text);


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
