using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Models
{
    public class FixedDiscount: IDiscount
    {
        public double DiscountAmount { get; private set; }

        public FixedDiscount(double discountAmount)
        {
            DiscountAmount = discountAmount;
        }

        public void CalcDiscount()
        {
            Console.WriteLine($"Fixed discount applied: {DiscountAmount}");
        }
    }
}
