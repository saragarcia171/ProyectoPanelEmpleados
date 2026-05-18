namespace ProyectoPanelEmpleados.Modelos
{
    public abstract class Empleado : ICalculablePago
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public decimal SalarioBase { get; set; }

        protected Empleado(string nombre, decimal salarioBase)
        {
            Nombre = nombre;
            SalarioBase = salarioBase;
        }

        public abstract decimal CalcularSalario();

        public virtual decimal CalcularBonificacion()
        {
            return SalarioBase * 0.10m;
        }
    }
}
