using Quản_Lý_Quán_Trà_Sữa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Quán_Trà_Sữa.DAO
{
    public class BillInfoDAO
    {
        #region Singleton
        private static BillInfoDAO instance;
        private BillInfoDAO() { }
        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        #endregion

        public List<BillInfo> GetListBillInfoByIdBill(int idBill)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE idBill = " + idBill);
            foreach(DataRow row in data.Rows)
            {
                listBillInfo.Add(new BillInfo(row));
            }
            return listBillInfo;
        }


        public void DeleteBillInfoByIdBillInfo(int idBillInfo)
        {

            DataProvider.Instance.ExecuteNonQuery("USP_DeleteBillInfoById @idBillInfo", new object[] { idBillInfo });
        }
        public int GetIdBillInfoByFullName(int idDrink , int idBill)
        {
            int idBillInfo = -1;
            string query = "SELECT * FROM BillInfo WHERE idBill = " + idBill + " AND idDrink = " + idDrink;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                idBillInfo = (int)row["idBillInfo"];
                break;
            }
            return idBillInfo;
        }

        public void AddBillInfoByIdBill(int idBill, int idDrink, int countD, float price)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_AddBillInfoByIdBill @idBill , @idDrink , @countD , @price", new object[] { idBill, idDrink, countD, price });
        }

        public void UpdateBillInfoByIdBill(int countD, float price, int idBillInfo)
        {
            DataProvider.Instance.ExecuteNonQuery("UpdateBillInfoById  @countD , @price , @idBillInfo", new object[] { countD, price , idBillInfo });
        }
    }
}
