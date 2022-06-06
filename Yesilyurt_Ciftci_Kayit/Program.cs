using System;
using System.Windows.Forms;
using Yesilyurt_Ciftci_Kayit.Forms;
namespace Yesilyurt_Ciftci_Kayit
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
            Application.Run(new LoginForm());
        }
    }
}
