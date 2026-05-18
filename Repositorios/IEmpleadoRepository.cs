using System.Collections.Generic;
using ProyectoPanelEmpleados.Modelos;

namespace ProyectoPanelEmpleados.Repositorios
{
    public interface IEmpleadoRepository
    {
        void Agregar(Empleado empleado);

        List<Empleado> ObtenerTodos();

        void Eliminar(int id);
    }
}