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
    public partial class DiscountForm : Form
    {
        private Form f = null;
        public DiscountForm(Form f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            (f as BillForm).Discount = float.Parse(txtDiscount.Text);
            this.Close();
        }
    }
}
