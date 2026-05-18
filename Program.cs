using System;
using System.Windows.Forms;
using ProyectoPanelEmpleados.Presentacion;

namespace ProyectoPanelEmpleados
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainDashboard());
        }
    }
}