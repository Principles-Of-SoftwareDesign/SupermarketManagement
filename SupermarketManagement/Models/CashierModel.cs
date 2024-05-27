using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Models
{
    public class CashierModel : UserModel
    {
        public CashierModel()
        {
            Role = 0; // Set the role to "cashier"
        }

    }
}
