using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana09
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                RepositorioProductos repo = new RepositorioProductos();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.ApplicationExit += Application_ApplicationExit;
                Application.Run(new FormListaProductos());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al cargar los productos");
            }
            
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            
        }
    }
}
