using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        private static LoginDAL instance;
        public static LoginDAL Instance 
        {
            get { if (instance == null) instance = new LoginDAL(); return instance; } 
            private set => instance = value; 
        }
        private LoginDAL() { }
        public bool Login(string userName, string password)
        {
            string query = "USP_Login @userName , @password";
            DataTable result = Database.Instance.ExecuteQuery(query, new object[]{ userName, password});
            return result.Rows.Count > 0;
        }
    }
}
