using Microsoft.Reporting.WinForms;
using Quản_Lý_Quán_Trà_Sữa.DAO;
using Quản_Lý_Quán_Trà_Sữa.DTO;
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
            ReportParameter[] listParameter = new ReportParameter[6];
            ReportParameter rp = new ReportParameter("idBill");
            ReportParameter rpMaBill = new ReportParameter("maBill");
            ReportParameter rpTable = new ReportParameter("table");
            ReportParameter rpGetin = new ReportParameter("getin");
            ReportParameter rpGetout = new ReportParameter("getout");
            ReportParameter rpName = new ReportParameter("name");
            /*
             *  Lấy thông tin Bill hiện tại
             */
            Bill billCurrent = BillDAO.Instance.GetBillByIdBill(idBill);

            /*
             * truyền thông tin vào parameter
             */
            rp.Values.Add(idBill.ToString());
            rpTable.Values.Add(billCurrent.IdTableD.ToString());
            rpGetin.Values.Add(billCurrent.GetIn.ToString());
            rpGetout.Values.Add(billCurrent.GetOut.ToString());
            rpName.Values.Add("Truyền NV");
            rpMaBill.Values.Add(billCurrent.MaBill);
            /*
             * mảng parameter 
             */
            listParameter[0] = rp;
            listParameter[1] = rpMaBill;
            listParameter[2] = rpGetin;
            listParameter[3] = rpGetout;
            listParameter[4] = rpTable;
            listParameter[5] = rpName;

            reportViewer1.LocalReport.SetParameters(listParameter);
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
