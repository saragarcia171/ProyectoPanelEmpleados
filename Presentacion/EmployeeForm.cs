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

        private Button btnGuardar;
        private Button btnCancelar;

        public EmployeeForm()
        {
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text =
                "Registrar Empleado";

            this.Size =
                new Size(400, 350);

            this.StartPosition =
                FormStartPosition.CenterParent;

            this.BackColor =
                Color.White;

            this.FormBorderStyle =
                FormBorderStyle.FixedDialog;

            this.MaximizeBox = false;

            // =========================
            // LABEL NOMBRE
            // =========================

            Label lblNombre = new Label();

            lblNombre.Text =
                "Nombre";

            lblNombre.Location =
                new Point(30, 40);

            lblNombre.AutoSize = true;

            lblNombre.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            this.Controls.Add(lblNombre);

            // =========================
            // TEXTBOX NOMBRE
            // =========================

            txtNombre = new TextBox();

            txtNombre.Location =
                new Point(30, 70);

            txtNombre.Size =
                new Size(320, 30);

            this.Controls.Add(txtNombre);

            // =========================
            // LABEL SALARIO
            // =========================

            Label lblSalario = new Label();

            lblSalario.Text =
                "Salario";

            lblSalario.Location =
                new Point(30, 115);

            lblSalario.AutoSize = true;

            lblSalario.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            this.Controls.Add(lblSalario);

            // =========================
            // TEXTBOX SALARIO
            // =========================

            txtSalario = new TextBox();

            txtSalario.Location =
                new Point(30, 145);

            txtSalario.Size =
                new Size(320, 30);

            this.Controls.Add(txtSalario);

            // =========================
            // LABEL CONTRATO
            // =========================

            Label lblContrato = new Label();

            lblContrato.Text =
                "Tipo de contrato";

            lblContrato.Location =
                new Point(30, 190);

            lblContrato.AutoSize = true;

            lblContrato.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            this.Controls.Add(lblContrato);

            // =========================
            // COMBOBOX
            // =========================

            cbTipoContrato = new ComboBox();

            cbTipoContrato.Location =
                new Point(30, 220);

            cbTipoContrato.Size =
                new Size(320, 30);

            cbTipoContrato.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cbTipoContrato.Items.Add(
                "Tiempo Completo");

            cbTipoContrato.Items.Add(
                "Medio Tiempo");

            cbTipoContrato.Items.Add(
                "Freelance");

            this.Controls.Add(cbTipoContrato);

            // =========================
            // BOTÓN GUARDAR
            // =========================

            btnGuardar = new Button();

            btnGuardar.Text =
                "Guardar";

            btnGuardar.Size =
                new Size(120, 40);

            btnGuardar.Location =
                new Point(30, 270);

            btnGuardar.BackColor =
                ColorTranslator.FromHtml("#10B981");

            btnGuardar.ForeColor =
                Color.White;

            btnGuardar.FlatStyle =
                FlatStyle.Flat;

            btnGuardar.FlatAppearance.BorderSize =
                0;

            btnGuardar.Cursor =
                Cursors.Hand;

            btnGuardar.Click +=
                BtnGuardar_Click;

            this.Controls.Add(btnGuardar);

            // =========================
            // BOTÓN CANCELAR
            // =========================

            btnCancelar = new Button();

            btnCancelar.Text =
                "Cancelar";

            btnCancelar.Size =
                new Size(120, 40);

            btnCancelar.Location =
                new Point(230, 270);

            btnCancelar.BackColor =
                ColorTranslator.FromHtml("#EF4444");

            btnCancelar.ForeColor =
                Color.White;

            btnCancelar.FlatStyle =
                FlatStyle.Flat;

            btnCancelar.FlatAppearance.BorderSize =
                0;

            btnCancelar.Cursor =
                Cursors.Hand;

            btnCancelar.Click +=
                BtnCancelar_Click;

            this.Controls.Add(btnCancelar);
        }

        private void BtnGuardar_Click(
            object? sender,
            EventArgs e)
        {
            this.DialogResult =
                DialogResult.OK;

            this.Close();
        }

        private void BtnCancelar_Click(
            object? sender,
            EventArgs e)
        {
            this.DialogResult =
                DialogResult.Cancel;

            this.Close();
        }
    }
}