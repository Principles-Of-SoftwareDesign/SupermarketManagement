using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Models
{
    public interface IDiscount
    {
        void CalcDiscount();
        double DiscountAmount { get; }

    }
}
