using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace DAL
{
    public class ProductDAL
    {
        private static ProductDAL instance;
        public static ProductDAL Instance
        {
            get { if (instance == null) instance = new ProductDAL(); return instance; }
            private set => instance = value;
        }
        private ProductDAL() { }
        public List<Product> GetProductById(int id)
        {
            List<Product> list = new List<Product>();
            DataTable dataTable = Database.Instance.ExecuteQuery($"SELECT * FROM tblProduct WHERE id = {id}");
            foreach (DataRow row in dataTable.Rows)
            {
                Product products = new Product(row);
                list.Add(products);
            }
            return list;
        }
        public List<Product> LoadProductList()
        {
            List<Product> list = new List<Product>();
            DataTable dataTable = Database.Instance.ExecuteQuery("SELECT * FROM tblProduct");
            foreach (DataRow row in dataTable.Rows)
            {
                Product products = new Product(row);
                list.Add(products);
            }
            return list;
        }
        public void Add_Product(string name, int idCategory, float price, string image)
        {
            Database.Instance.ExecuteQuery("USP_Insert_Product @name , @idCategory , @price , @image ", new object[] {name, idCategory, price, image});
        }
        public void Update_Product(int id, string name, int idCategory, float price, string image)
        {
            Database.Instance.ExecuteQuery("USP_Update_Product @id , @name , @idCategory , @price , @image ", new object[] { id, name, idCategory, price, image });
        }
        public void Delete_Product(int id)
        {
            Database.Instance.ExecuteQuery("USP_Delete_Product @id ", new object[] { id });
        }
    }

}
