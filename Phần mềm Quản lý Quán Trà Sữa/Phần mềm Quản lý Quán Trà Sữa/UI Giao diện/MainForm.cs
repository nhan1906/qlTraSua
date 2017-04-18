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
    public partial class MainForm : Form
    {
        //
        // Form chính chứa 6 form con
        //
        private TableForm tableF;
        private BillForm billF;
        private DrinkForm drinkF;
        private ScheduleForm scheduleF;
        private DashboardForm dashboardF;
        private AdminForm adminF;
        //
        //Khởi tạo Form
        //
        public MainForm(string userName)
        {
            InitializeComponent();
            lbUserName.Text = "Chào , " + AccountDDAO.Instance.GetDisplayNameByUserName(userName);
            LoadFormChild();
        }
        //
        //Tạo 6 form con
        //
        #region Load Form Child
        private void LoadFormChild()
        {
            if (!CheckExistForm("TableF"))
            {
                tableF = new TableForm();
                tableF.Name = "TableF";
                tableF.MdiParent = this;
                tableF.Show();
            }
            else
                ActivateChildForm("TableF");

            if (!CheckExistForm("DrinkF"))
            {
                drinkF = new DrinkForm();
                drinkF.Name = "DrinkF";
                drinkF.MdiParent = this;
                drinkF.Show();
            }
            else
                ActivateChildForm("DrinkF");

            if (!CheckExistForm("ScheduleF"))
            {
                scheduleF = new ScheduleForm();
                scheduleF.Name = "ScheduleF";
                scheduleF.MdiParent = this;
                scheduleF.Show();
            }
            else
                ActivateChildForm("ScheduleF");

            if (!CheckExistForm("DashboardF"))
            {
                dashboardF = new DashboardForm();
                dashboardF.Name = "DashboardF";
                dashboardF.MdiParent = this;
                dashboardF.Show();
            }
            else
                ActivateChildForm("DashboardF");

            if (!CheckExistForm("AdminF"))
            {
                adminF = new AdminForm();
                adminF.Name = "AdminF";
                adminF.MdiParent = this;
                adminF.Show();
            }
            else
                ActivateChildForm("AdminF");

            if (!CheckExistForm("BillF"))
            {
                billF = new BillForm(1);
                billF.Name = "BillF";
                billF.MdiParent = this;
                billF.Show();
            }
            else
                ActivateChildForm("BillF");


        }
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActivateChildForm(string name)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            // Set default click and background
            btnSchedule.IsClick = false;
            btnBill.IsClick = false;
            btnAdmin.IsClick = false;
            btnDrink.IsClick = false;
            btnDashboard.IsClick = false;
            btnBill.ClrBackground = Color.FromArgb(42, 49, 68);
            btnDashboard.ClrBackground = Color.FromArgb(42, 49, 68);
            btnDrink.ClrBackground = Color.FromArgb(42, 49, 68);
            btnSchedule.ClrBackground = Color.FromArgb(42, 49, 68);
            btnAdmin.ClrBackground = Color.FromArgb(42, 49, 68);
            tableF.Activate();
            lbCategories.Text = "DANH SÁCH BÀN";
            
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            // Set default click and background
            btnTable.IsClick = false;
            btnSchedule.IsClick = false;
            btnAdmin.IsClick = false;
            btnDrink.IsClick = false;
            btnDashboard.IsClick = false;
            btnTable.ClrBackground = Color.FromArgb(42, 49, 68);
            btnDashboard.ClrBackground = Color.FromArgb(42, 49, 68);
            btnDrink.ClrBackground = Color.FromArgb(42, 49, 68);
            btnSchedule.ClrBackground = Color.FromArgb(42, 49, 68);
            btnAdmin.ClrBackground = Color.FromArgb(42, 49, 68);
            billF.Activate();
            lbCategories.Text = "HÓA ĐƠN BÀN";

        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            // Set default click and background
            btnTable.IsClick = false;
            btnBill.IsClick = false;
            btnAdmin.IsClick = false;
            btnSchedule.IsClick = false;
            btnDashboard.IsClick = false;
            btnTable.ClrBackground = Color.FromArgb(42, 49, 68);
            btnBill.ClrBackground = Color.FromArgb(42, 49, 68);
            btnDashboard.ClrBackground = Color.FromArgb(42, 49, 68);
            btnSchedule.ClrBackground = Color.FromArgb(42, 49, 68);
            btnAdmin.ClrBackground = Color.FromArgb(42, 49, 68);
            // Show form
            drinkF.Activate();
            lbCategories.Text = "DANH SÁCH THỨC UỐNG";
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            // Set default click and background
            btnTable.IsClick = false;
            btnBill.IsClick = false;
            btnAdmin.IsClick = false;
            btnDrink.IsClick = false;
            btnDashboard.IsClick = false;
            btnTable.ClrBackground = Color.FromArgb(42, 49, 68);
            btnBill.ClrBackground = Color.FromArgb(42, 49, 68);
            btnDashboard.ClrBackground = Color.FromArgb(42, 49, 68);
            btnDrink.ClrBackground = Color.FromArgb(42, 49, 68);
            btnAdmin.ClrBackground = Color.FromArgb(42, 49, 68);
            // Show form
            scheduleF.Activate();
            lbCategories.Text = "LỊCH LÀM VIỆC NHÂN VIÊN";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Set default click and background
            btnTable.IsClick = false;
            btnBill.IsClick = false;
            btnAdmin.IsClick = false;
            btnDrink.IsClick = false;
            btnSchedule.IsClick = false;
            btnTable.ClrBackground = Color.FromArgb(42, 49, 68);
            btnBill.ClrBackground = Color.FromArgb(42, 49, 68);
            btnAdmin.ClrBackground = Color.FromArgb(42, 49, 68);
            btnDrink.ClrBackground = Color.FromArgb(42, 49, 68);
            btnSchedule.ClrBackground = Color.FromArgb(42, 49, 68);
            // Show form
            dashboardF.Activate();
            lbCategories.Text = "THỐNG KẾ DOANH THU";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Set default click and background
            btnTable.IsClick = false;
            btnBill.IsClick = false;
            btnDashboard.IsClick = false;
            btnDrink.IsClick = false;
            btnSchedule.IsClick = false;
            btnTable.ClrBackground = Color.FromArgb(42, 49, 68);
            btnBill.ClrBackground = Color.FromArgb(42, 49, 68);
            btnDashboard.ClrBackground = Color.FromArgb(42, 49, 68);
            btnDrink.ClrBackground = Color.FromArgb(42, 49, 68);
            btnSchedule.ClrBackground = Color.FromArgb(42, 49, 68);
            // Show form
            adminF.Activate();
            lbCategories.Text = "DANH SÁCH TÀI KHOẢN";
        }
        #endregion
    }
}
