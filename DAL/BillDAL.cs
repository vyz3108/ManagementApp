using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillDAL
    {
        private static BillDAL instance;
        public static BillDAL Instance 
        {
            get { if (instance == null) instance = new BillDAL(); return instance; }
            private set => instance = value; 
        }
        public BillDAL() { }

        public int GetBillIDByCustomerID(int id)
        {
            DataTable data = Database.Instance.ExecuteQuery("USP_GetBillByCustomerID @id", new object[] { id });
            //DataTable data = Database.Instance.ExecuteQuery($"SELECT * FROM dbo.tblBill WHERE idTable = {id}");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public List<Bill> GetBillList()
        {
            List<Bill> list = new List<Bill>();
            DataTable dataTable = Database.Instance.ExecuteQuery("SELECT * FROM tblBill");
            foreach (DataRow row in dataTable.Rows)
            {
                Bill b = new Bill(row);
                list.Add(b);
            }
            return list;
        }
    }
}
