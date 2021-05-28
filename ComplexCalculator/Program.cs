using ComplexCalculator.Presenters;
using ComplexCalculator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCalculator
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

            // MVP
            MainView view = new MainView();
            MainPresenter presenter = new MainPresenter(view);
            presenter.Initialize();

            Application.Run();
        }
    }
}
