﻿using Quản_Lý_Quán_Trà_Sữa.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.DAO
{
    public class NhanVienDAO
    {
        #region Singleton
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private NhanVienDAO() { }
#endregion
        public DataTable GetListNhanVien()
        {
            return DataProvider.Instance.ExecuteQuery("Select tenNhanVien , cateNhanVien from NhanVien  , cateNhanVien WHERE NhanVien.idCateNV = cateNhanVien.idCateNV");
        }

        public int InsertNhanVien(string tenNhanVien, int idCateNV)
        {
            return DataProvider.Instance.ExecuteNonQuery("USP_InsertNhanvien @tenNhanVien , @idCateNV", new object[] { tenNhanVien, idCateNV });
        }

        public int GetIdByName(string tenNhanVien)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select idNhanVien from NhanVien Where tenNhanVien = N'" + tenNhanVien + "'");
            foreach(DataRow row in data.Rows)
            {
                return (int)row["idNhanvien"];
            }
            return -1;
        }

        public float GetLuongUncheck(int idNhanvien)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM NhanVien WHERE idNhanVien = " + idNhanvien);
            foreach(DataRow row in data.Rows)
            {
                return float.Parse(row["luongUncheck"].ToString());
            }
            return 0;
        }
    }
}
