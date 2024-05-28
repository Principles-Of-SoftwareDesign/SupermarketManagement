using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Models
{
    public interface IDiscountHandlerFactory
    {
        IDiscount GetDiscount(string code);

    }
}
