using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountBLL
    {
        public List<Account> GetAccountByUserName (string username)
        {
            return AccountDAL.Instance.GetAccountByUserName(username);
        }
        public List<Account> GetListAccount()
        {
            return AccountDAL.Instance.GetListAccount();
        }
    }
}
