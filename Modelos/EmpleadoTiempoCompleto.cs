namespace ProyectoPanelEmpleados.Modelos
{
    public class EmpleadoTiempoCompleto : Empleado
    {
        public EmpleadoTiempoCompleto(
            string nombre,
            decimal salarioBase)
            : base(nombre, salarioBase)
        {
        }

        public override decimal CalcularSalario()
        {
            return SalarioBase + CalcularBonificacion();
        }
    }
}