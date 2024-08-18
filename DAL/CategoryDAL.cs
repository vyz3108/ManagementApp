using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDAL
    {
        private static CategoryDAL instance;
        public static CategoryDAL Instance
        {
            get { if (instance == null) instance = new CategoryDAL(); return instance; }
            private set => instance = value;
        }
        public CategoryDAL() { }

        public List<Category> GetCategories()
        {
            List<Category> list = new List<Category>();
            DataTable dataTable = Database.Instance.ExecuteQuery("SELECT * FROM dbo.tblCategory");
            foreach (DataRow row in dataTable.Rows)
            {
                Category cate = new Category(row);
                list.Add(cate);
            }
            return list;
        }
    }
}
