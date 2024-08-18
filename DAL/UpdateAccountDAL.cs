using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UpdateAccountDAL
    {
        private static UpdateAccountDAL instance;
        public static UpdateAccountDAL Instance
        {
            get { if (instance == null) instance = new UpdateAccountDAL(); return instance; }
            private set => instance = value;
        }
        public UpdateAccountDAL() { }
        #region Method
        public void Reset_Password(string UserName)
        {
            Database.Instance.ExecuteQuery("USP_Reset_Password @UserName", new object[] { UserName });
        }
        public void Update_Account(string UserName, string DisplayName, string Password, string NewPass, string RePass)
        {
            Database.Instance.ExecuteQuery("USP_Update_Account @UserName , @DisplayName , @Password , @NewPass , @RePass ", new object[] { UserName, DisplayName, Password, NewPass, RePass });
        }
        public void Change_DisplayName(string UserName, string DisplayName, string Password)
        {
            Database.Instance.ExecuteQuery("USP_Change_DisplayName @UserName , @DisplayName , @Password ", new object[] { UserName, DisplayName, Password });
        }
        public void Change_Password(string UserName, string Password, string NewPass, string RePass)
        {
            Database.Instance.ExecuteQuery("USP_Change_Password @UserName , @Password , @NewPass , @RePass ", new object[] { UserName, Password, NewPass, RePass });
        }
        public void AD_Add_Account(string UserName, string DisplayName, int Type)
        {
            Database.Instance.ExecuteQuery("ADSP_Insert_Account @UserName , @DisplayName , @Type ", new object[] { UserName, DisplayName, Type });
        }
        public void AD_Edit_Account(string UserName, string DisplayName, int Type)
        {
            Database.Instance.ExecuteQuery("ADSP_Update_Account @UserName , @DisplayName , @Type ", new object[] { UserName, DisplayName, Type });
        }
        public void AD_Delete_Account(string UserName)
        {
            Database.Instance.ExecuteQuery("ADSP_Delete_Account @UserName ", new object[] { UserName });
        }
        #endregion
    }
}
