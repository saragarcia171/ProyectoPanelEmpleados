using System.Collections.Generic;
using ProyectoPanelEmpleados.Modelos;

namespace ProyectoPanelEmpleados.Repositorios
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private List<Empleado> empleados =
            new List<Empleado>();

        public void Agregar(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public List<Empleado> ObtenerTodos()
        {
            return empleados;
        }

        public void Eliminar(int id)
        {
            empleados.RemoveAll(e => e.Id == id);
        }
    }
}