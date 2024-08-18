using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBLL
    {
        public List<Product> LoadProductList()
        {
            return ProductDAL.Instance.LoadProductList();
        }
        public List<Product> GetProductById(int id) 
        {
            return ProductDAL.Instance.GetProductById(id);
        }
    }
}
