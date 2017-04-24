using Quản_Lý_Quán_Trà_Sữa.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.DAO
{
    public class NgayLuongDAO
    {
        #region Singleton
        private static NgayLuongDAO instance;
        private NgayLuongDAO() { }

        public static NgayLuongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NgayLuongDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        #endregion

        public int IsExistNgayLuongByNameAndDay(int idNhanVien ,DateTime day)
        {
            string days = day.ToString("yyyy-MM-dd");
            string query = "Select * from NgayLuong where idNhanVien = " + idNhanVien + " AND ngay = '" + days + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                return (int)row["cateL"];
            }
            return -1;
        }

        public int GetIdNgayLuongByNhanVien(int idNhanVien , DateTime day)
        {
            string days = day.ToString("yyyy-MM-dd");
            string query = "Select * from NgayLuong where idNhanVien = " + idNhanVien + " AND ngay = '" + days + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                return (int)row["idNgayLuong"];
            }
            return 0;
        }
        public  int UpdateLuongNgay(int idNhanVien, int cateL, float luongNgay)
        {
            int idNgayLuong = NgayLuongDAO.Instance.GetIdNgayLuongByNhanVien(idNhanVien, DateTime.Now);
            return DataProvider.Instance.ExecuteNonQuery("USP_UpdateLuongNgay @idNgayLuong , @idNhanVien , @cateL , @luongNgay" , new object[] {idNgayLuong , idNhanVien , cateL , luongNgay});
        }

        public int InsertLuongNgay(int idNhanVien, int cateL, float luongNgay)
        {
            return DataProvider.Instance.ExecuteNonQuery("USP_InsertNgayLuong @idNhanVien , @cateL , @luongNgay", new object[] { idNhanVien, cateL, luongNgay });
        }
        public int UpdateLuongNV(int idNhanVien , float cateNew , float cateOld)
        {
            return DataProvider.Instance.ExecuteNonQuery("UpdateLuongNV @idNhanVien , @cateNew , @cateOld", new object[] { idNhanVien , cateNew , cateOld});
        }

        public int InsertLuongNV(int idNhanVien, float cateNew)
        {
            return DataProvider.Instance.ExecuteNonQuery("AddLuongNV @idNhanVien , @cateNew", new object[] { idNhanVien, cateNew });
        }
        public float LuongByNhanVien(int idNhanVien)
        {
            float luongThang = 0;
            string query = "SELECT * FROM NgayLuong WHERE idNhanVien = " + idNhanVien + " AND MONTH(ngay) = " + DateTime.Now.Month;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                luongThang += float.Parse(row["luongNgay"].ToString());
            }
            return luongThang;
        }

        public string GetNgayLuongByNhanVien(int idNhanVien)
        {
            DateTime day = DateTime.Now;
            string days = day.ToString("yyyy-MM-dd");
            string query = "Select * from NgayLuong where idNhanVien = " + idNhanVien + " AND ngay = '" + days + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                return row["luongNgay"].ToString();
            }
            return "0";
        }
    }
}
