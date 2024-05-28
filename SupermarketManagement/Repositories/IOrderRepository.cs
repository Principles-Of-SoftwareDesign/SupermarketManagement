using SupermarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Repositories
{
    public interface IOrderRepository
    {
        bool addOrder(OrderModel orderModel);
        decimal GetProductPrice(string productName);
    }
}

