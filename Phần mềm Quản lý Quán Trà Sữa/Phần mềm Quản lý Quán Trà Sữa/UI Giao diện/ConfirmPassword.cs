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
    public partial class ConfirmPassword : Form
    {
        int idDo = 0;
        Form f = null;
        public ConfirmPassword(int idDo , Form f)
        {
            InitializeComponent();
            this.idDo = idDo;
            this.f = f;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "19061995")
            {
                this.Hide();
                if(idDo == 2)
                    TableDDAO.Instance.AddTable();
                if(idDo == 1)
                {
                    
                    DiscountForm fDiscount = new DiscountForm(f);
                    
                    fDiscount.ShowDialog();
                }
            }
                
            this.Close();
        }
    }
}
