using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Models
{
    public class DiscountFactory : IDiscountHandlerFactory
    {
        private string code;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public IDiscount GetDiscount(string code)
        {
            if (code == "FIXED10")
            {
                return new FixedDiscount(100);
            }
            else if (code == "PERCENT10")
            {
                return new PercentedDiscount(10);
            }
            else return null;
            
        }
    }
}
