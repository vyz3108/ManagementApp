using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        private int iD;
        private string name;
        private string address;
        private string sdt;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public Customer(int iD, string name, string address, string sdt)
        {
            this.ID = iD;
            this.Name = name;
            this.Address = address;
            this.Sdt = sdt;
        }
        public Customer(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.Name = row["name"].ToString();
            this.Address = row["address"].ToString();
            this.Sdt = row["sdt"].ToString();
        }
    }
}
