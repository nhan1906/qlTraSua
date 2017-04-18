using Quản_Lý_Quán_Trà_Sữa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Quán_Trà_Sữa.DAO
{
    public class SizeDrinkDAO
    {
        #region Singleton
        private static SizeDrinkDAO instance;
        private SizeDrinkDAO() { }
        public static SizeDrinkDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SizeDrinkDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public List<SizeDrink> GetListSizeDrink()
        {
            List<SizeDrink> list = new List<SizeDrink>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM SizeDrink");
            foreach (DataRow row in data.Rows)
            {
                list.Add(new SizeDrink(row));
            }
            return list;
        }

        public SizeDrink GetSizeDrinkByName(string name)
        {
            SizeDrink drinkt = null;
            string query = "SELECT * FROM SizeDrink WHERE nameSizeDrink = N'" + name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                drinkt = new SizeDrink(row);
            }
            return drinkt;
        }
        #endregion
    }
}
