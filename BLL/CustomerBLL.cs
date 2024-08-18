using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBLL
    {
        public List<Customer> LoadCustomerList()
        {
            return CustomerDAL.Instance.LoadCustomerList();
        }
        public List<Customer> GetCustomerById(int id)
        {
            return CustomerDAL.Instance.GetCustomerById(id);
        }
    }
}
