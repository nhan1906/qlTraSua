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
        private DateTime? getIn;
        private DateTime? getOut;
        private float sale;
        private float totalPrice;
        private int statusBill;
        #region Properties
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

        public DateTime? GetIn
        {
            get
            {
                return getIn;
            }

            set
            {
                getIn = value;
            }
        }

        public DateTime? GetOut
        {
            get
            {
                return getOut;
            }

            set
            {
                getOut = value;
            }
        }

        public float Sale
        {
            get
            {
                return sale;
            }

            set
            {
                sale = value;
            }
        }

        public float TotalPrice
        {
            get
            {
                return totalPrice;
            }

            set
            {
                totalPrice = value;
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
        #endregion
        public Bill(int idBill, int idTableD, float sale , float totalPrice, int statusBill , DateTime? getIn, DateTime? getOut = null)
        {
            this.IdBill = idBill;
            this.IdTableD = idTableD;
            this.GetIn = getIn;
            this.GetOut = getOut;
            this.Sale = sale;
            this.TotalPrice = totalPrice;
            this.StatusBill = statusBill;
        }
        public Bill(DataRow row)
        {
            this.IdBill = (int) row["idBill"];
            this.IdTableD = (int) row["idTableD"];
            this.GetIn = (DateTime) row["getIn"];
            var temp = row["getOut"];
            if(temp.ToString() != "")
                this.getOut = (DateTime)row["getOut"];
            this.Sale = float.Parse(row["sale"].ToString());
            this.TotalPrice = float.Parse(row["totalPrice"].ToString());
            this.StatusBill = (int) row["statusBill"];
        }
        
    }
}
