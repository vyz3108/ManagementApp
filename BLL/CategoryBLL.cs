using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryBLL
    {
        public List<Category> LoadCategoryList() 
        {
            return CategoryDAL.Instance.GetCategories();
        }
    }
}
