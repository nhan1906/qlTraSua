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
        public int CreateNewBillForTable(int idTableD , int nmPeople)
        {
            return DataProvider.Instance.ExecuteNonQuery("USP_InsertNewBillTable @idTableD , @nmPeople", new object[] { idTableD , nmPeople });
        }

        public float GetTotalPriceByIdBill(int idBill)
        {
            float total = 0;
            string query = "SELECT price FROM Bill INNER JOIN BillInfo ON Bill.idBill = BillInfo.idBill WHERE Bill.idBill = " + idBill + " AND statusBill = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                total += float.Parse(row["price"].ToString());
            }
            return total;
        }

        public DateTime? GetTimeByidBill(int idBill)
        {
            DateTime? time = null;
            string query = "SELECT getIn FROM Bill WHERE Bill.idBill = " + idBill;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                time = (DateTime) row["getIn"];
            }
            return time;
        }
    }
}
