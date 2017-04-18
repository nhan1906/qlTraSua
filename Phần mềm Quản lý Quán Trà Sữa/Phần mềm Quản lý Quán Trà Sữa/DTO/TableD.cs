using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Quán_Trà_Sữa.DTO
{
    public class TableD
    {
        private int idTableD;
        private string nameTable;
        private int status;
        private int numberPeople;
        
        public TableD(int idTableD, string nameTable, int status)
        {
            this.IdTableD = idTableD;
            this.NameTable = nameTable;
            this.Status = status;
            this.NumberPeople = numberPeople;
        }
        public TableD(DataRow row)
        {
            this.IdTableD = (int) row["idTableD"];
            this.NameTable = row["nameTable"].ToString();
            this.Status = (int)row["status"];
            this.NumberPeople = (int)row["numberPeople"];
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

        public string NameTable
        {
            get
            {
                return nameTable;
            }

            set
            {
                nameTable = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int NumberPeople
        {
            get
            {
                return numberPeople;
            }

            set
            {
                numberPeople = value;
            }
        }
    }
}
