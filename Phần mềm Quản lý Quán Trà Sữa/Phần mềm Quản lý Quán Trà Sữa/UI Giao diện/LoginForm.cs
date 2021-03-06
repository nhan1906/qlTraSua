﻿using Phần_mềm_Quản_lý_Quán_Trà_Sữa.UI_Giao_diện;
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
            //Chưa nhập đầy đủ thông tin
            if(txtUserName.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (Login(userName, password))
            {
                mainForm = new MainForm(userName);
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
        }
        
        /*
         * Hàm xử lý thông tin đăng nhập
         */ 
        bool Login(string userName, string password)
        {
            return AccountDDAO.Instance.CheckLogin(userName, password);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
