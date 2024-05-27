using SupermarketManagement.Models;
using SupermarketManagement.Repositories;
using SupermarketManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Presenters
{
    public class ViewCashierPresenter
    {

        private BindingSource cashierBindingSource;
        private IViewCashiers viewCashiers;
        private ICashierRepository cashierRepository;
        private IEnumerable<CashierModel> cashiers;


        public ViewCashierPresenter(IViewCashiers viewCashiers, ICashierRepository cashierRepository)
        {
            this.viewCashiers = viewCashiers;
            this.cashierRepository = cashierRepository;
            this.cashierBindingSource = new BindingSource();
            this.viewCashiers.setCashiersList(cashierBindingSource);
            LoadAllList();
        }


        public void LoadAllList()
        {
            cashiers = cashierRepository.GetAllCashiers();
            cashierBindingSource.DataSource = cashiers;
        }
    }
}

