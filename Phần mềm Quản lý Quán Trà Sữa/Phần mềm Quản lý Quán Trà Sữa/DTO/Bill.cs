using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Quán_Trà_Sữa.DTO
{
    public class Bill
    {
        private int idBill;
        private int idTableD;
        private DateTime? checkIn;
        private DateTime? checkOut;
        private int statusBill;
        public Bill(int idBill, int idTableD, DateTime? checkIn, DateTime? checkOut = null)
        {
            this.IdBill = idBill;
            this.IdTableD = idTableD;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
        }
        public Bill(DataRow row)
        {
            this.IdBill = (int) row["idBill"];
            this.IdTableD = (int) row["idTableD"];
            this.CheckIn = (DateTime) row["checkIn"];
            var temp = row["checkOut"];
            if(temp.ToString() != "")
                this.CheckOut = (DateTime)row["checkOut"];
        }
        public int IdBill
        {
            get
            {
                return idBill;
            }

            set
            {
                idBill = value;
            }
        }

        public int IdTableD
        {
            get
            {
                return idTableD;
            }

            set
            {
                idTableD = value;
            }
        }

        public DateTime? CheckIn
        {
            get
            {
                return checkIn;
            }

            set
            {
                checkIn = value;
            }
        }

        public DateTime? CheckOut
        {
            get
            {
                return checkOut;
            }

            set
            {
                checkOut = value;
            }
        }

        public int StatusBill
        {
            get
            {
                return statusBill;
            }

            set
            {
                statusBill = value;
            }
        }
    }
}
