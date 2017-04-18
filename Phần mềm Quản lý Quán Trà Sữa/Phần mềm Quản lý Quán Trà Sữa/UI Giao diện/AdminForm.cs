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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            IntiaDataGridView();
        }

        private void IntiaDataGridView()
        {
            //Color Background
            dtAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtAccount.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtAccount.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 11.25f, FontStyle.Bold);
            dtAccount.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dtAccount.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            dtAccount.RowHeadersVisible = false;

            //
            //Text font
            //
            dtAccount.DefaultCellStyle.Font = new Font("Cambria", 10.25f);
            dtAccount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtAccount.DefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);

            //Custom border
            dtAccount.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtAccount.BorderStyle = BorderStyle.None;
            //Color row
            dtAccount.RowsDefaultCellStyle.BackColor = Color.FromArgb(220, 238, 249);
            dtAccount.RowsDefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);
            dtAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(186, 223, 241);
            dtAccount.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(67, 72, 78);
            dtAccount.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(131, 193, 233);
            dtAccount.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(67, 72, 78);
        }

        BindingSource accountList = new BindingSource();
        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadView();
            LoadTypeAccount();
        }
        private void LoadTypeAccount()
        {
            cmbType.DataSource = TypeAccountDAO.Instance.GetListTypeAccount();
            cmbType.DisplayMember = "nameTypeAccount";
        }

        private void LoadView()
        {
            dtAccount.DataSource = accountList;
            accountList.DataSource = AccountDDAO.Instance.GetListAccountD();
            dtAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            AddAccountBinding();
            txtPassword.ReadOnly = true;
            txtConfirm.ReadOnly = true;
            txtDisplayName.ReadOnly = true;
            txtUserName.ReadOnly = true;
            btnAccept.Visible = false;
            btnCancel.Visible = false;
        }

        private void AddAccountBinding()
        {
            this.dtAccount.Columns[0].HeaderText = "Tên đăng nhập";
            this.dtAccount.Columns[1].HeaderText = "Tên hiển thị";
            this.dtAccount.Columns[2].HeaderText = "Loại tài khoản";
            txtUserName.DataBindings.Add(new Binding("Text", dtAccount.DataSource, "userName", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dtAccount.DataSource, "displayName", true, DataSourceUpdateMode.Never));
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            string name = dtAccount.SelectedCells[0].OwningRow.Cells["nameTypeAccount"].Value.ToString();
            TypeAccount type = TypeAccountDAO.Instance.GetTypeAccountByName(name);
            cmbType.SelectedIndex = cmbType.FindStringExact(type.NameTypeAccount);
        }
        private void LoadAccount()
        {
            accountList.DataSource = AccountDDAO.Instance.GetListAccountD();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = dtAccount.SelectedCells[0].OwningRow.Cells["userName"].Value.ToString();
            if (name.Equals("admin"))
            {
                MessageBox.Show("Không có quyền xóa admin");
                return;
            }
            if (TypeAccountDAO.Instance.DeleteAccountByUserName(name) == 1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }

            LoadAccount();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Thông tin sửa;
            txtDisplayName.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtConfirm.ReadOnly = false;
            btnAccept.Tag = 0;
            btnAccept.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if ((int)btnAccept.Tag == 0)
            {
                if (txtDisplayName.Text == "")
                {
                    MessageBox.Show("Nhập tên hiển thị");
                    return;
                }
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    MessageBox.Show("Không trùng mật khẩu");
                    txtConfirm.Text = txtPassword.Text = "";
                    return;
                }
                string name = dtAccount.SelectedCells[0].OwningRow.Cells["userName"].Value.ToString();
                int i = 0;
                if (txtPassword.Text == "")
                {
                    i = AccountDDAO.Instance.EditAccountByUserNameNoPass(name, txtDisplayName.Text, cmbType.SelectedIndex);
                }
                else
                {
                    i = AccountDDAO.Instance.EditAccountByUserName(name, txtDisplayName.Text, cmbType.SelectedIndex, txtPassword.Text);
                }

                if (i == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }

            }
            if ((int)btnAccept.Tag == 1)
            {
                if (txtUserName.Text == "" || (!AccountDDAO.Instance.CheckUserName(txtUserName.Text)))
                {
                    MessageBox.Show("Vui lòng chọn tên đăng nhập khác");
                    return;
                }
                if (txtDisplayName.Text == "")
                {
                    MessageBox.Show("Nhập tên hiển thị");
                    return;
                }
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Nhập mật khẩu");
                    return;
                }
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    MessageBox.Show("Không trùng mật khẩu");
                    txtConfirm.Text = txtPassword.Text = "";
                    return;
                }
                int i = AccountDDAO.Instance.AddAccountByUserName(txtUserName.Text, txtDisplayName.Text, cmbType.SelectedIndex, txtPassword.Text);

                if (i == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            txtUserName.ReadOnly = true;
            txtDisplayName.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtConfirm.ReadOnly = true;
            btnCancel.Visible = false;
            btnAccept.Visible = false;
            LoadAccount();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.ReadOnly = true;
            txtDisplayName.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtConfirm.ReadOnly = true;
            btnCancel.Visible = false;
            btnAccept.Visible = false;
            dtAccount.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtDisplayName.Text = "";
            txtDisplayName.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtConfirm.ReadOnly = false;
            txtUserName.ReadOnly = false;
            btnAccept.Tag = 1;
            btnAccept.Visible = true;
            btnCancel.Visible = true;
        }

    }
}
