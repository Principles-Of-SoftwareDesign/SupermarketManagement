using SupermarketManagement.Repositories;
using SupermarketManagement.Models;
using SupermarketManagement.Presenters;
using SupermarketManagement.Views;

namespace SupermarketManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IAdminRepository repo = new AdminRepository();
            IViewAdmins view = new ViewAdmins();
            new ViewAdminsPresenter(view, repo);
            //Application.Run((ViewAdmins)view);
            //Application.Run(new CashierView());
            /*Application.Run(new AddAdminView());
            Application.Run(new AddAdminView());*/
            Application.Run(new AddProduct());


        }
    }
}