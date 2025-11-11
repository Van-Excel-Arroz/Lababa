using System;
using System.Windows.Forms;

namespace Lababa
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DashboardForm());
            Application.Run(new WizardForm());
        }
    }
}
