using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Models
{
    public class addOrderModel
    {
        private int id;
        private int amount;
        private string name;
        private double price;
        public addOrderModel()
        {
            id = -1;
            name = "";

            price = 0.0;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }


        }



    }
}
