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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            this.nCalendar1.CateBackground[1] = 1;
            this.nCalendar1.CateBackground[29] = 2;
            this.nCalendar1.CateBackground[15] = 3;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
