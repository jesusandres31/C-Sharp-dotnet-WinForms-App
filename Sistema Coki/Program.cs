using System;
using System.Windows.Forms;

namespace Sistema_Coki
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FVendedor(5, "Jesus Andres"));
            Application.Run(new FLogin());
        }
    }
}
