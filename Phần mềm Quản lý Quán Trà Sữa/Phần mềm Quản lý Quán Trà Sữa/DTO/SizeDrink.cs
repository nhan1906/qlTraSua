using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Quán_Trà_Sữa.DTO
{
    public class SizeDrink
    {
        private int idSizeDrink;
        private string nameSizeDrink;

        public int IdSizeDrink
        {
            get
            {
                return idSizeDrink;
            }

            set
            {
                idSizeDrink = value;
            }
        }

        public string NameSizeDrink
        {
            get
            {
                return nameSizeDrink;
            }

            set
            {
                nameSizeDrink = value;
            }
        }

        public SizeDrink(int idTypeDrink, string nameTypeDrink)
        {
            this.IdSizeDrink = idTypeDrink;
            this.NameSizeDrink = nameTypeDrink;
        }
        public SizeDrink(DataRow row)
        {
            this.IdSizeDrink = (int)row["idSizeDrink"];
            this.NameSizeDrink = row["nameSizeDrink"].ToString();
        }
    }
}
