using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SupermarketManagement.Models;
using SupermarketManagement.Views;
using SupermarketManagement.Repositories;

namespace SupermarketManagement.Presenters
{
    public class ViewAdminsPresenter
    {
        private BindingSource adminBindingSource;
        private IViewAdmins viewAdmins;
        private IAdminRepository adminRepository;
        private IEnumerable<AdminModel> admins;

        
        public ViewAdminsPresenter(IViewAdmins viewAdmins, IAdminRepository adminRepository)
        {
            this.viewAdmins = viewAdmins;
            this.adminRepository = adminRepository;
            this.adminBindingSource = new BindingSource();
            this.viewAdmins.setAdminsList(adminBindingSource);
            LoadAllList();
        }


        public void LoadAllList()
        {
            admins = adminRepository.GetAllAdmins();
            adminBindingSource.DataSource = admins;
        }
    }
}
