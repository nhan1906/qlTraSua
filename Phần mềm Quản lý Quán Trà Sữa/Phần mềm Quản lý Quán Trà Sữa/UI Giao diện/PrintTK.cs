using Microsoft.Reporting.WinForms;
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
    public partial class PrintTK : Form
    {
        DateTime date;
        public PrintTK(DateTime date)
        {
            InitializeComponent();
            this.date = date;
        }

        private void SetParameter(DateTime date)
        {
            ReportParameter rp = new ReportParameter();
            rp.Values.Add(date.ToString());
            reportViewer1.LocalReport.SetParameters(rp);
        }
        private void PrintTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtQLTraSuaDataSet.BC_DoanhSo' table. You can move, or remove it, as needed.
            this.bC_DoanhSoTableAdapter.Fill(this.dtQLTraSuaDataSet.BC_DoanhSo);
            SetParameter(date);
            this.reportViewer1.RefreshReport();
        }
    }
}
