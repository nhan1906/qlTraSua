using System;
using System.Collections.Generic;
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
    }
}
