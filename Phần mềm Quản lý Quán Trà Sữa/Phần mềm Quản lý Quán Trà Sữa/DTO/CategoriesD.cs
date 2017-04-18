using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Quán_Trà_Sữa.DTO
{
    public class CategoriesD
    {
        private int idCategoriesD;
        private string nameCategories;

        public CategoriesD(int idCategoriesD, string nameCategories)
        {
            this.IdCategoriesD = idCategoriesD;
            this.NameCategories = nameCategories;
        }
        public CategoriesD(DataRow row)
        {
            this.IdCategoriesD = (int) row["idCategoriesD"];
            this.NameCategories = row["nameCategories"].ToString();
        }
        public int IdCategoriesD
        {
            get
            {
                return idCategoriesD;
            }

            set
            {
                idCategoriesD = value;
            }
        }

        public string NameCategories
        {
            get
            {
                return nameCategories;
            }

            set
            {
                nameCategories = value;
            }
        }
    }
}
