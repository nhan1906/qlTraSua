using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Quán_Trà_Sữa.DTO
{
    public class Drink
    {
        /*
         * idDrink INT IDENTITY PRIMARY KEY,
	nameDrink NVARCHAR(100) NOT NULL,
	price float NOT NULL DEFAULT 0,
	idTypeDrink INT NOT NULL, -- 1 Lon, 2 Trung Binh, 3 Nho
	picture IMAGE,
	idCategoriesD INT NOT NULL,
         */
        private int idDrink;
        private string nameDrink;
        private float price;
        private int idSizeDrink;
        private byte[] picture;
        private int idCategoriesD;
        public Drink() { }

        public Drink(int idDrink, string nameDrink, float price, int idCategoriesD, int idSizeDrink, byte[] picture = null)
        {
            this.IdDrink = idDrink;
            this.Price = price;
            this.NameDrink = nameDrink;
            this.IdCategoriesD = idCategoriesD;
            this.IdSizeDrink = idSizeDrink;
            this.Picture = picture;
        }
        public Drink(DataRow row)
        {
            this.IdDrink = (int) row["idDrink"];
            this.Price = (float) Convert.ToDouble(row["price"].ToString());
            this.NameDrink = row["nameDrink"].ToString();
            this.IdCategoriesD = (int)row["idCategoriesD"];
            this.IdSizeDrink = (int)row["idSizeDrink"];
            var temp = row["picture"];
            if(temp.ToString() != "")
                this.Picture = (byte[]) row["picture"];
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

        public string NameDrink
        {
            get
            {
                return nameDrink;
            }

            set
            {
                nameDrink = value;
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

        public byte[] Picture
        {
            get
            {
                return picture;
            }

            set
            {
                picture = value;
            }
        }
    }
}
