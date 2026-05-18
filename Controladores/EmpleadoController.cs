using System.Collections.Generic;
using ProyectoPanelEmpleados.Modelos;
using ProyectoPanelEmpleados.Repositorios;

namespace ProyectoPanelEmpleados.Controladores
{
    public class EmpleadoController
    {
        private readonly IEmpleadoRepository repository;

        public EmpleadoController(
            IEmpleadoRepository repository)
        {
            this.repository = repository;
        }

        public void RegistrarEmpleado(
            Empleado empleado)
        {
            repository.Agregar(empleado);
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return repository.ObtenerTodos();
        }

        public void EliminarEmpleado(int id)
        {
            repository.Eliminar(id);
        }
    }
}