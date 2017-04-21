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
        public void UpdateBillInfoByIdBill(int idBill, int idDrink, int count, float bonusprice, string nameFull , float totalPrice)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfoByIdBill @idBill , @idDrink , @countD , @bonusPrice , @nameFull , @totalPrice" ,new object[] {idBill, idDrink , count , bonusprice , nameFull , totalPrice});
        }

        public void EditBillInfoByIdBillInfo(int idBillInfo, int idDrink, int countD, float bonusprice, string nameFull, float totalPrice)
        {
                DataProvider.Instance.ExecuteNonQuery("UpdateBillInfoById @idBillInfo , @idDrink , @countD , @bonusPrice , @nameFull , @totalPrice", new object[] { idBillInfo, idDrink , countD, bonusprice, nameFull, totalPrice });
            
        }
        public void DeleteBillInfoByIdBillInfo(int idBillInfo)
        {

            DataProvider.Instance.ExecuteNonQuery("DeleteBillInfoById @idBillInfo", new object[] { idBillInfo });
        }
        public int GetIdBillInfoByFullName(string fullName)
        {
            int idBillInfo = 0;
            string query = "SELECT * FROM BillInfo WHERE nameFull = N'" + fullName + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                idBillInfo = (int)row["idBillInfo"];
                break;
            }
            return idBillInfo;
        }
    }
}
