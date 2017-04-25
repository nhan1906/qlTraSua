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
    public partial class PrintHoaDon : Form
    {
        private int idBill = 0;

        public PrintHoaDon(int idBill)
        {
            InitializeComponent();
            this.idBill = idBill;
           

        }
        private void SetParameters(int idBill)
        {
            ReportParameter rp = new ReportParameter("idBill");
            rp.Values.Add(idBill.ToString());
            reportViewer1.LocalReport.SetParameters(rp);
        }
        private void PrintHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtQLTraSuaDataSet.HD_HoaDon' table. You can move, or remove it, as needed.
            this.hD_HoaDonTableAdapter.Fill(this.dtQLTraSuaDataSet.HD_HoaDon);
            SetParameters(idBill);
            this.reportViewer1.RefreshReport();
        }
    }
}
