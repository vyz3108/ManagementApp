using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillInfoDAL
    {
        private static BillInfoDAL instance;
        public static BillInfoDAL Instance 
        {
            get { if (instance == null) instance = new BillInfoDAL(); return instance; }
            private set => instance = value; 
        }
        public BillInfoDAL() { }

        public List<BillInfo> GetListBillInfo(int id) 
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable dataTable = Database.Instance.ExecuteQuery("USP_GetBillInfoByID @id", new object[] { id });
            //DataTable dataTable = Database.Instance.ExecuteQuery($"SELECT * FROM tblBillInfo WHERE idBill = {id}");

            foreach (DataRow item in dataTable.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }


    }
}
