using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_Quản_lý_Quán_Trà_Sữa.DTO
{
    public class NgayLuong
    {
        private int idNgayLuong;
        private int idNhanVien;
        private DateTime? ngay;
        private float luongNgay;
        private float luongCon;
        private float tongLuong;

        public NgayLuong(int idNgayLuong, int idNhanVien , DateTime? ngay , float luongNgay, float luongCon, float tongLuong)
        {
            this.IdNgayLuong = idNgayLuong;
            this.IdNhanVien = idNhanVien;
            this.Ngay = ngay;
            this.LuongNgay = luongNgay;
            this.LuongCon = luongCon;
            this.TongLuong = tongLuong;
        }
        public NgayLuong(DataRow row)
        {
            this.IdNgayLuong = (int) row["idNgayLuong"];
            this.IdNhanVien = (int) row["idNhanVien"];
            this.Ngay = (DateTime) row["ngay"];
            this.LuongNgay = float.Parse(row["luongNgay"].ToString());
            this.LuongCon = float.Parse(row["luongCon"].ToString());
            this.TongLuong = float.Parse(row["tongLuong"].ToString());
        }
        public int IdNgayLuong
        {
            get
            {
                return idNgayLuong;
            }

            set
            {
                idNgayLuong = value;
            }
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

        public DateTime? Ngay
        {
            get
            {
                return ngay;
            }

            set
            {
                ngay = value;
            }
        }

        public float LuongNgay
        {
            get
            {
                return luongNgay;
            }

            set
            {
                luongNgay = value;
            }
        }

        public float LuongCon
        {
            get
            {
                return luongCon;
            }

            set
            {
                luongCon = value;
            }
        }

        public float TongLuong
        {
            get
            {
                return tongLuong;
            }

            set
            {
                tongLuong = value;
            }
        }
    }
}
