using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Models
{
    public class FixedDiscount: IDiscount
    {
        private OrderModel order;
        public double DiscountAmount { get; private set; }

        public FixedDiscount(double discountAmount)
        {
            this.DiscountAmount = discountAmount;
        }

        public void CalcDiscount()
        {
            MessageBox.Show($"Fixed discount applied: 100 LE off, ");
        }
    }
}
