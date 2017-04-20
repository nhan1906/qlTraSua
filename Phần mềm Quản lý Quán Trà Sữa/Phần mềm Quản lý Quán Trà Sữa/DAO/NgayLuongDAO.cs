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

        public bool IsExistNgayLuongByNameAndDay(int idNhanVien ,DateTime day)
        {
            string days = day.ToString("yyyy-MM-dd");
            string query = "Select * from NgayLuong where idNhanVien = " + idNhanVien + " AND ngay = '" + days + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                return true;
            }
            return false;
        }
    }
}
