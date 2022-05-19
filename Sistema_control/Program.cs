using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ly_negocio;
using ly_modelo;

namespace Sistema_control
{
    static class Program
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
            Sistema.cargarConfiguraciones(neg_Configuracion.obtenerTodos(idEmpresa:1));
            Application.Run(new frmPrincipal());
        }
    }
}
