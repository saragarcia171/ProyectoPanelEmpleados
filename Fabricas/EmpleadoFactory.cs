using System;
using ProyectoPanelEmpleados.Modelos;

namespace ProyectoPanelEmpleados.Fabricas
{
    public static class EmpleadoFactory
    {
        public static Empleado CrearEmpleado(
            string tipo,
            string nombre,
            decimal salarioBase)
        {
            switch (tipo)
            {
                case "Tiempo Completo":
                    return new EmpleadoTiempoCompleto(
                        nombre,
                        salarioBase);

                case "Medio Tiempo":
                    return new EmpleadoMedioTiempo(
                        nombre,
                        salarioBase);

                case "Freelance":
                    return new EmpleadoFreelance(
                        nombre,
                        salarioBase);

                default:
                    throw new Exception(
                        "Tipo de empleado inválido");
            }
        }
    }
}