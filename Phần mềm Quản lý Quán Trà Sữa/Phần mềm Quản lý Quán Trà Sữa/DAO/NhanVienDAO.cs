using Quản_Lý_Quán_Trà_Sữa.DAO;
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
    }
}
