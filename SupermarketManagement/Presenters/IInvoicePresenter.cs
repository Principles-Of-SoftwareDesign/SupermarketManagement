using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Presenters
{
    public interface IInvoicePresenter
    {
        void ApplyDiscount(string code);
    }
}
