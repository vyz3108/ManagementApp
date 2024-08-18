using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;
        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set => instance = value;
        }
        public AccountDAL() { }
        public List<Account> GetListAccount()
        {
            List<Account> list = new List<Account>();
            DataTable dataTable = Database.Instance.ExecuteQuery("USP_GetListAccount", new object[] {});

            foreach (DataRow item in dataTable.Rows)
            {
                Account acc = new Account(item);
                list.Add(acc);
            }
            return list;
        }

        public List<Account> GetAccountByUserName(string userName)
        {
            List<Account> list = new List<Account>();
            DataTable dataTable = Database.Instance.ExecuteQuery("USP_GetAccountByUserName @userName", new object[] { userName });

            foreach (DataRow item in dataTable.Rows)
            {
                Account acc = new Account(item);
                list.Add(acc);
            }
            return list;
        }
        
    }
}
