using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Models
{
    public class OrderModel
    {
        private string amount;
        private string name;
        private string price;
        public OrderModel()
        {
            amount = "0";
            name = "";

            price = "0";
        }
        public string Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }


        }



    }
}
