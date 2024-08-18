using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        private int iD;
        private string name;
        private int idCategory;
        private float price;
        private string image;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public float Price { get => price; set => price = value; }
        public string Image { get => image; set => image = value; }
        public Product(int iD, string name, int idCategory, float price, string image) 
        { 
            this.ID = iD;
            this.Name = name;
            this.IdCategory = idCategory;
            this.Price = price;
            this.Image = image;
        }
        public Product(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.Name = row["name"].ToString();
            this.IdCategory = (int)row["idCategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Image = row["image"].ToString();
        }
    }
}
