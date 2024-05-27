using SupermarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Repositories
{
    public interface ICashierRepository
    {
        bool addCashier(CashierModel cashierModel);
        void EditCashier(CashierModel cashierModel);
        IEnumerable<CashierModel> GetAllCashiers();

    }
}

