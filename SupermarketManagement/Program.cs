using SupermarketManagement.Repositories;
using SupermarketManagement.Models;
using SupermarketManagement.Presenters;
using SupermarketManagement.Views;

namespace SupermarketManagement
{
    internal static class Program
    {
        private static ViewCashiers view;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
         
            //Application.Run(new login());
            Application.Run(new ViewProduct());
            //Application.Run(new ViewCashiers());
        }
    }
}