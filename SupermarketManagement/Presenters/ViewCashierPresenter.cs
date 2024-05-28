using SupermarketManagement.Models;
using SupermarketManagement.Repositories;
using SupermarketManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagement.Presenters
{
    public class ViewCashierPresenter
    {
        private BindingSource cashierBindingSource;
        private IViewCashiers viewCashiers;
        private ICashierRepository cashierRepository;
        private Hashing hashing;
        private IEnumerable<CashierModel> cashiers;


        public ViewCashierPresenter(IViewCashiers viewCashiers, ICashierRepository cashierRepository)
        {
            this.viewCashiers = viewCashiers;
            this.hashing = new Hashing();
            this.cashierRepository = cashierRepository;
            this.cashierBindingSource = new BindingSource();
            this.viewCashiers.setCashiersList(cashierBindingSource);
            
        }

        public void LoadAllList()
        {
            var cashiers = cashierRepository.GetAllCashiers();
            //cashierBindingSource.DataSource = cashiers;
            viewCashiers.DisplayCashiers(cashiers);
        }
        public void addCashier()
        {
            if (string.IsNullOrWhiteSpace(viewCashiers.Name) ||
                string.IsNullOrWhiteSpace(viewCashiers.Email) ||
                string.IsNullOrWhiteSpace(viewCashiers.PhoneNumber) ||
                string.IsNullOrWhiteSpace(viewCashiers.Password))
            {
                viewCashiers.ShowMessage("Warning: All fields are required.", "Add Cashier");
                return;
            }

            var cashier = new CashierModel
            {
                Name = viewCashiers.Name,
                Email = viewCashiers.Email,
                PhoneNumber = viewCashiers.PhoneNumber,
                Password = hashing.hashPassword(viewCashiers.Password)
            };

            if (cashierRepository.addCashier(cashier))
            {
                viewCashiers.CloseForm();
                LoadAllList();
            }
            else
            {
                viewCashiers.ShowMessage("Error: No rows were affected.", "Add cashier");
            }
        }

    
    public void UpdateCashier()
        {
            var cashier = new CashierModel
            {
        
                Name = viewCashiers.Name,
                Email = viewCashiers.Email,
                Password = viewCashiers.Password,
                PhoneNumber = viewCashiers.PhoneNumber

            };

            if (cashierRepository.UpdateCashier(cashier))
            {
                viewCashiers.ShowMessage("Record updated successfully!", "Edit Cashier");
                LoadAllList();
            }
            else
            {
                viewCashiers.ShowMessage("Record update failed!", "Edit Cashier");
            }
        }
        public void DeleteCashier()
        {
            String cashierName = viewCashiers.Name;

            if (cashierRepository.DeleteCashier(cashierName))
            {
                viewCashiers.ShowMessage("Record deleted successfully!", "Delete Cashier");
                LoadAllList();
            }
            else
            {
                viewCashiers.ShowMessage("Record delete failed!", "Delete Cashier");
            }
        }

        public void SelectCashier(int rowIndex, DataGridView dataGridView)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
            {   
                viewCashiers.Name = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                viewCashiers.Email = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                viewCashiers.PhoneNumber = dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
                viewCashiers.Password = dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            }
        }
    }
}


