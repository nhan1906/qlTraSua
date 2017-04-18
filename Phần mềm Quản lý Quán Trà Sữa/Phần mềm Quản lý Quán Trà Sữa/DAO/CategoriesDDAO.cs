using Quản_Lý_Quán_Trà_Sữa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Quán_Trà_Sữa.DAO
{
    public class CategoriesDDAO
    {
        #region Singleton
        private static CategoriesDDAO instance;

        public static CategoriesDDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoriesDDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private CategoriesDDAO() { }
        #endregion

        public List<CategoriesD> GetListCategories()
        {
            List<CategoriesD> listCategories = new List<CategoriesD>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM CategoriesD");
            foreach(DataRow row in data.Rows)
            {
                listCategories.Add(new CategoriesD(row));
            }
            return listCategories;
        }
        public CategoriesD GetCategoryByName(string name)
        {
            CategoriesD ca = null;
            string query = "SELECT * FROM CategoriesD WHERE nameCategories = N'" + name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                ca = new CategoriesD(row);
            }
            return ca;
        }

        public int AddNewCategories(string name)
        {
            return DataProvider.Instance.ExecuteNonQuery("USP_AddNewCategories @nameCategories ", new object[] { name });
        }

        public int DeleteCategoriy(string name)
        {
            return DataProvider.Instance.ExecuteNonQuery("Delete from CategoriesD Where nameCategories = N'" + name + "'");
        }

        public int EditCategories(string name, string text)
        {
            return DataProvider.Instance.ExecuteNonQuery("USP_UpdateCategoriesName @nameold , @namenew ", new object[] { name, text });
        }
    }
}
