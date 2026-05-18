namespace ProyectoPanelEmpleados.Modelos
{
    public class EmpleadoFreelance : Empleado
    {
        public EmpleadoFreelance(
            string nombre,
            decimal salarioBase)
            : base(nombre, salarioBase)
        {
        }

        public override decimal CalcularSalario()
        {
            return SalarioBase;
        }

        public override decimal CalcularBonificacion()
        {
            return 0;
        }
    }
}