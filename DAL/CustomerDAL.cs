using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        private static CustomerDAL instance;
        public static CustomerDAL Instance
        {
            get { if (instance == null) instance = new CustomerDAL(); return instance; }
            private set => instance = value;
        }
        public CustomerDAL() { }

        public List<Customer> LoadCustomerList()
        {
            List<Customer> list = new List<Customer>();
            DataTable dataTable = Database.Instance.ExecuteQuery("USP_GetCustomerList");
            foreach (DataRow row in dataTable.Rows)
            {
                Customer customer = new Customer(row);
                list.Add(customer);
            }
            return list;
        }
        public List<Customer> GetCustomerById(int id)
        {
            List<Customer> list = new List<Customer>();
            DataTable dataTable = Database.Instance.ExecuteQuery("USP_GetCustomerById @id ", new object[] {id});
            foreach (DataRow row in dataTable.Rows)
            {
                Customer customer = new Customer(row);
                list.Add(customer);
            }
            return list;
        }
        public void Add_Customer(string name, string address, string sdt)
        {
            Database.Instance.ExecuteQuery("USP_Insert_Customer @name , @address , @sdt ", new object[] { name, address, sdt });
        }
        public void Update_Customer(int id, string name, string address, string sdt)
        {
            Database.Instance.ExecuteQuery("USP_Update_Customer @id , @name , @address , @sdt ", new object[] { id, name, address, sdt });
        }
        public void Delete_Customer(int id)
        {
            Database.Instance.ExecuteQuery("USP_Delete_Customer @id ", new object[] { id });
        }
    }
}
