namespace ProyectoPanelEmpleados.Modelos
{
    public class EmpleadoMedioTiempo : Empleado
    {
        public EmpleadoMedioTiempo(
            string nombre,
            decimal salarioBase)
            : base(nombre, salarioBase)
        {
        }

        public override decimal CalcularSalario()
        {
            return (SalarioBase * 0.5m)
                + CalcularBonificacion();
        }
    }
}