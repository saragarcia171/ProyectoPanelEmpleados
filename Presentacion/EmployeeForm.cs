using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPanelEmpleados.Presentacion
{
    public partial class EmployeeForm : Form
    {
        public TextBox txtNombre;

        public TextBox txtSalario;

        public ComboBox cbTipoContrato;

        public Button btnGuardar;

        public Button btnCancelar;

        public EmployeeForm()
        {
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Registrar Empleado";

            this.Size = new Size(500, 420);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.BackColor =
                ColorTranslator.FromHtml("#F3F4F6");

            this.Font =
                new Font("Segoe UI", 10);

            // LABEL NOMBRE

            Label lblNombre = new Label();

            lblNombre.Text = "Nombre";

            lblNombre.Location =
                new Point(40, 40);

            lblNombre.AutoSize = true;

            // TEXTBOX NOMBRE

            txtNombre = new TextBox();

            txtNombre.Location =
                new Point(40, 70);

            txtNombre.Size =
                new Size(380, 30);

            // LABEL SALARIO

            Label lblSalario = new Label();

            lblSalario.Text = "Salario";

            lblSalario.Location =
                new Point(40, 120);

            lblSalario.AutoSize = true;

            // TEXTBOX SALARIO

            txtSalario = new TextBox();

            txtSalario.Location =
                new Point(40, 150);

            txtSalario.Size =
                new Size(380, 30);

            // LABEL TIPO

            Label lblTipo = new Label();

            lblTipo.Text = "Tipo de contrato";

            lblTipo.Location =
                new Point(40, 200);

            lblTipo.AutoSize = true;

            // COMBOBOX

            cbTipoContrato = new ComboBox();

            cbTipoContrato.Location =
                new Point(40, 230);

            cbTipoContrato.Size =
                new Size(380, 30);

            cbTipoContrato.Items.Add(
                "Tiempo Completo");

            cbTipoContrato.Items.Add(
                "Medio Tiempo");

            cbTipoContrato.Items.Add(
                "Freelance");

            // BOTÓN GUARDAR

            btnGuardar = new Button();

            btnGuardar.Text = "Guardar";

            btnGuardar.Size =
                new Size(130, 45);

            btnGuardar.Location =
                new Point(40, 310);

            btnGuardar.BackColor =
                ColorTranslator.FromHtml("#3B82F6");

            btnGuardar.ForeColor =
                Color.White;

            btnGuardar.FlatStyle =
                FlatStyle.Flat;

            btnGuardar.FlatAppearance.BorderSize = 0;

            // BOTÓN CANCELAR

            btnCancelar = new Button();

            btnCancelar.Text = "Cancelar";

            btnCancelar.Size =
                new Size(130, 45);

            btnCancelar.Location =
                new Point(190, 310);

            btnCancelar.BackColor =
                ColorTranslator.FromHtml("#EF4444");

            btnCancelar.ForeColor =
                Color.White;

            btnCancelar.FlatStyle =
                FlatStyle.Flat;

            btnCancelar.FlatAppearance.BorderSize = 0;

            // CONTROLES

            this.Controls.Add(lblNombre);

            this.Controls.Add(txtNombre);

            this.Controls.Add(lblSalario);

            this.Controls.Add(txtSalario);

            this.Controls.Add(lblTipo);

            this.Controls.Add(cbTipoContrato);

            this.Controls.Add(btnGuardar);

            this.Controls.Add(btnCancelar);
        }
    }
}