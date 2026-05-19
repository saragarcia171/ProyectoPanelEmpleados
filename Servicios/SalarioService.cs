using ProyectoPanelEmpleados.Modelos;

namespace ProyectoPanelEmpleados.Servicios
{
    public class SalarioService
    {
        public decimal ObtenerSalario(
            Empleado empleado)
        {
            return empleado.CalcularSalario();
        }
    }
}