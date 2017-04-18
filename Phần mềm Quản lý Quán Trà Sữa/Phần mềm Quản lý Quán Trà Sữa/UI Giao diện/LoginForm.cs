using Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện;
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

namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa
{
    public partial class LoginForm : Form
    {
        MainForm mainForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (Login(userName, password))
            {
                mainForm = new MainForm(userName);
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
        }
        bool Login(string userName, string password)
        {
            return AccountDDAO.Instance.CheckLogin(userName, password);
        }
    }
}
