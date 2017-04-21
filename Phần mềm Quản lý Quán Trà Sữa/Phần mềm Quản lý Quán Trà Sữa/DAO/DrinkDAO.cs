using Quản_Lý_Quán_Trà_Sữa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Quán_Trà_Sữa.DAO
{
    public class DrinkDAO
    {
        #region Singleton
        private static DrinkDAO instance;

        public static DrinkDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DrinkDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private DrinkDAO() { }
        #endregion
        
        public DataTable GetListDrinkByIdCategory(int idCategoriesD)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListDrinkByIdCategory @idCategoriesD ", new object[] {idCategoriesD });
            
        }
        public int[] GetSizeDrinkByName(string name)
        {
            int[] sizeDrink = new int[3];
            string query = "SELECT idSizeDrink FROM Drink WHERE nameDrink = N'" + name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                int size = (int)row["idSizeDrink"];
                switch (size)
                {
                    case 1:
                        sizeDrink[0] = 1;
                        break;
                    case 2:
                        sizeDrink[1] = 1;
                        break;
                    case 3:
                        sizeDrink[2] = 1;
                        break;
                    default:
                        break;
                }
            }
            return sizeDrink;
        }

        public DataTable GetListDrinkByIdCategoryToDtgv(int idCategoriesD)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListDrinkByIdCategoryToDtgv @idCategoriesD ", new object[] { idCategoriesD });
            
        }

        public Drink GetDrinkByName(string name, int idSizeDrink)
        {
            Drink drink = null;
            string query = "SELECT * FROM Drink WHERE nameDrink = N'" + name + "' AND idSizeDrink = " + idSizeDrink;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                drink = new DTO.Drink(row);
                break;
            }
            return drink;
        }
        public Drink GetDrinkByName(string name)
        {
            Drink drink = null;
            string query = "SELECT * FROM Drink WHERE nameDrink = N'" + name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                drink = new DTO.Drink(row);
                break;
            }
            return drink;
        }

        public int DeleteDrink(string nameDrink, int idSizeDrink)
        {
            int result = 1;
            string query = "Delete Drink Where nameDrink = N'" + nameDrink + "' AND idSizeDrink = " + idSizeDrink;
            result = DataProvider.Instance.ExecuteNonQuery(query);

            return result;
        }
        public int AddDrinkNoImage(string nameDrink, float price , int idCategoriesD , int idSizeDrink)
        {
            return DataProvider.Instance.ExecuteNonQuery("USP_AddDrinkNoImagge @nameDrink , @price , @idCategoriesD , @idSizeDrink", new object[] { nameDrink, price, idCategoriesD, idSizeDrink });
        }
        public int AddDrinkWithImage(string nameDrink, float price, int idCategoriesD, int idSizeDrink , byte[] pt)
        {
            return DataProvider.Instance.ExecuteNonQuery("USP_AddDrinkWithImage @nameDrink , @price , @idCategoriesD , @idSizeDrink , @picture", new object[] { nameDrink, price, idCategoriesD, idSizeDrink , pt });
        }

        public int EditDrinkNoImage(string nameDrink, float price, int idCategoriesD, int idSizeDrink , int idDrink)
        {
            return DataProvider.Instance.ExecuteNonQuery("USP_EditDrinkNoImage @nameDrink , @price , @idCategoriesD , @idSizeDrink , @idDrink", new object[] { nameDrink, price, idCategoriesD, idSizeDrink , idDrink});
        }

        public int EditDrinkWithImage(string nameDrink, float price, int idCategoriesD, int idSizeDrink, byte[] pt, int idDrink)
        {
            return DataProvider.Instance.ExecuteNonQuery("USP_EditDrinkWithImage @nameDrink , @price , @idCategoriesD , @idSizeDrink , @picture , @idDrink", new object[] { nameDrink, price, idCategoriesD, idSizeDrink, pt , idDrink});
        }
        public string GetFullNameByIdDrink(int idDrink)
        {
            string name = "";
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Drink WHERE idDrink = " + idDrink);
            foreach(DataRow row in data.Rows)
            {
                int idSizeDrink = (int)row["idSizeDrink"];
                string nameDrink = row["nameDrink"].ToString();
                if(idSizeDrink == 1)
                {
                    return nameDrink + " - L";
                }
                else if(idSizeDrink == 2)
                {
                    return nameDrink + " - TB";
                }
                else if (idSizeDrink == 3)
                {
                    return nameDrink + " - N";
                }
            }
            return name;
        }
    }
}
