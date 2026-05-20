using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPanelEmpleados.Presentacion
{
    public class LiquidacionForm : Form
    {
        public LiquidacionForm(
            string nombre,
            decimal salario,
            decimal bonificacion,
            decimal liquidacion)
        {
            this.Text = "Liquidación";

            this.Size = new Size(450, 350);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.BackColor =
                ColorTranslator.FromHtml("#F3F4F6");

            Label lblInfo = new Label();

            lblInfo.Text =
                $"Empleado: {nombre}\n\n" +
                $"Salario: ${salario}\n\n" +
                $"Bonificación: ${bonificacion}\n\n" +
                $"Liquidación: ${liquidacion}";

            lblInfo.Font =
                new Font("Segoe UI", 12);

            lblInfo.Location =
                new Point(40, 40);

            lblInfo.AutoSize = true;

            this.Controls.Add(lblInfo);
        }
    }
}