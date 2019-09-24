using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementWindowsApp.Forms;
using StockManagementWindowsApp.Gateway;

namespace StockManagementWindowsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new loginForm());
            Runprogram();
        }

        private static void Runprogram()
        {
            UserGateway userGateway = new UserGateway();
            DateTime date = userGateway.GetRegistrationDate();
          //  DateTime sdate = DateTime.ParseExact(date,"mm-dd-yyyy",null);
            var days = DateTime.Now.Subtract(date).TotalDays;
            if (days > 365 || date == new DateTime())
            {
                Application.Run(new OutDated());
            }
            else
            {
                Application.Run(new loginForm());
            }

        }
    }
}
