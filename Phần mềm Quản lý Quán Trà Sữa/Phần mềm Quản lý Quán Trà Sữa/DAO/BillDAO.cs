using Quản_Lý_Quán_Trà_Sữa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Quán_Trà_Sữa.DAO
{
    public class BillDAO
    {
        #region Singleton
        private static BillDAO instance;
        private BillDAO() { }
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        #endregion

        public int GetUncheckedBillIdByTableId(int idTableD)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE idTableD = " + idTableD + " AND statusBill = 0");
            if(data.Rows.Count > 0)
            {
                Bill bill = new DTO.Bill(data.Rows[0]);
                return bill.IdBill;
            }
            return -1;
        }
        public int CreateNewBillForTable(int idTableD)
        {
            return DataProvider.Instance.ExecuteNonQuery("USP_InsertNewBillTable @idTableD", new object[] { idTableD });

        }
    }
}
