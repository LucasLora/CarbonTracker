using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarbonTracker.Models;
using CarbonTracker.Presenters;
using CarbonTracker.Views;
using CarbonTracker._Repositories;
using System.Configuration;

namespace CarbonTracker
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string stringConexao = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
            IMainView view = new MainView();
            new MainPresenter(view, stringConexao);

            Application.Run((Form)view);
        }
    }
}
