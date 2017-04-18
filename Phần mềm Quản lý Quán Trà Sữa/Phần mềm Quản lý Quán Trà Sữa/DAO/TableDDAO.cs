using Quản_Lý_Quán_Trà_Sữa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Quán_Trà_Sữa.DAO
{
    public class TableDDAO
    {
        private static TableDDAO instance;

        public static TableDDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TableDDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private TableDDAO() { }
        public List<TableD> GetListTableD()
        {
            List<TableD> lTableD = new List<TableD>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TableD");
            foreach (DataRow row in data.Rows)
            {
                lTableD.Add(new TableD(row));
            }
            return lTableD;
        }
        public void SetStatusTableById(int idTableD)
        {
            DataProvider.Instance.ExecuteQuery("USP_UpdateStatusTable @idTableD", new object[] { idTableD });
        }
        public int GetTotalTable()
        {
            int total = 0;
            List<TableD> lTableD = new List<TableD>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TableD");
            total = data.Rows.Count;
            return total;
        }

        public int GetNooneTable()
        {
            int total = 0;
            List<TableD> lTableD = new List<TableD>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TableD WHERE status = 0");
            total = data.Rows.Count;
            return total;
        }


        public void AddTable()
        {
            int idNextTable = GetTotalTable();
            DataProvider.Instance.ExecuteNonQuery("USP_AddTable @nameTable ", new object[] { idNextTable.ToString() });
        }
    }
}
