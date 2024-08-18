using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BillInfoBLL
    {
        public List<BillInfo> GetListBillInfo(int id)
        {
            return BillInfoDAL.Instance.GetListBillInfo(id);
        }
    }
}
