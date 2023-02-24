using System;
using System.Windows.Forms;

namespace Capitulo20Exercicios
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Questao01());
            //Application.Run(new Questao02e03());
            Application.Run(new Questao04e05());
        }
    }
}
