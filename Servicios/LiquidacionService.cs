using ProyectoPanelEmpleados.Modelos;

namespace ProyectoPanelEmpleados.Servicios
{
    public class LiquidacionService
    {
        public decimal CalcularLiquidacion(
            Empleado empleado)
        {
            return empleado.CalcularSalario() * 0.15m;
        }
    }
}