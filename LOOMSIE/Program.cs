using System;
using System.Windows.Forms;
using AppCore.Forms;

namespace L000MES
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var formMain = new FormMain();
            formMain.Setup();
            Application.Run(formMain);
        }
    }
}
