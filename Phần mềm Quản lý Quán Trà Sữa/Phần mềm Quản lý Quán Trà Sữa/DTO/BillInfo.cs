using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Quán_Trà_Sữa.DTO
{
    public class BillInfo
    {
        private int idBillInfo;
        private int idBill;
        private int idDrink;
        private int countD;
        private float price;
        public BillInfo(int idBillInfo, int idBill, int idDrink, int countD, float price)
        {
            this.IdBillInfo = idBillInfo;
            this.IdBill = idBill;
            this.IdDrink = idDrink;
            this.CountD = countD;
            this.Price = price;
        }
        public BillInfo(DataRow row)
        {
            this.IdBillInfo = (int) row["idBillInfo"];
            this.IdBill = (int) row["idBill"];
            this.IdDrink = (int) row["idDrink"];
            this.CountD = (int) row["countD"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
        public int IdBillInfo
        {
            get
            {
                return idBillInfo;
            }

            set
            {
                idBillInfo = value;
            }
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

        public int IdDrink
        {
            get
            {
                return idDrink;
            }

            set
            {
                idDrink = value;
            }
        }

        public int CountD
        {
            get
            {
                return countD;
            }

            set
            {
                countD = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
