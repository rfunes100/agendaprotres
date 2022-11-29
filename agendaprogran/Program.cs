
using agendaprogran.Formularios;
using agendaprogran.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agendaprogran
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
           Application.Run(new SplaschScreen());
            Application.Run(new Menufrn());
       //  Application.Run(new Cargofrm());
        }
    }
}
