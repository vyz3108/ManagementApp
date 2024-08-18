using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class BillBLL
    {
        public int GetBillIDByCustomerID(int id)
        {
            return BillDAL.Instance.GetBillIDByCustomerID(id);
        }
        public List<Bill> GetBillList()
        {
            return BillDAL.Instance.GetBillList();
        }
    }
}
