using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.DTO
{
    public class NhanVien
    {
        private int idNhanVien;
        private string maNhanVien;
        private string tenNhanVien;
        private int cateNhanVien;
        public NhanVien(int idNhanVien, string maNhanVien, string tenNhanVien, int cateNhanVien)
        {
            this.IdNhanVien = idNhanVien;
            this.MaNhanVien = maNhanVien;
            this.TenNhanVien = tenNhanVien;
            this.CateNhanVien = cateNhanVien;
        }

        public NhanVien(DataRow row)
        {
            this.IdNhanVien = (int) row["idNhanVien"];
            this.MaNhanVien = row["maNhanVien"].ToString();
            this.TenNhanVien = row["tenNhanVien"].ToString();
            this.CateNhanVien = (int) row["cateNhanVien"];
        }

        public int IdNhanVien
        {
            get
            {
                return idNhanVien;
            }

            set
            {
                idNhanVien = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }

            set
            {
                maNhanVien = value;
            }
        }

        public string TenNhanVien
        {
            get
            {
                return tenNhanVien;
            }

            set
            {
                tenNhanVien = value;
            }
        }

        public int CateNhanVien
        {
            get
            {
                return cateNhanVien;
            }

            set
            {
                cateNhanVien = value;
            }
        }
    }
}
