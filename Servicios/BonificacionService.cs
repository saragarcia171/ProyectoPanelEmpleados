using ProyectoPanelEmpleados.Modelos;

namespace ProyectoPanelEmpleados.Servicios
{
    public class BonificacionService
    {
        public decimal ObtenerBonificacion(
            Empleado empleado)
        {
            return empleado.CalcularBonificacion();
        }
    }
}