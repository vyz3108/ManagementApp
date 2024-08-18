using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        private int iD;
        private int idCustomer;
        private DateTime? buyTime;

        public int ID { get => iD; set => iD = value; }
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
        public DateTime? BuyTime { get => buyTime; set => buyTime = value; }

        public Bill(int id, int idCustomer, DateTime? buyTime) 
        {
            this.ID = id;
            this.IdCustomer = idCustomer;
            this.BuyTime = buyTime;
        }

        public Bill(DataRow row) 
        {
            this.ID = (int)row["id"];
            this.IdCustomer = (int)row["idCustomer"];
            this.BuyTime = (DateTime?)row["buyTime"];
        }
    }
}
