using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoPanelEmpleados.Controladores;
using ProyectoPanelEmpleados.Fabricas;
using ProyectoPanelEmpleados.Modelos;
using ProyectoPanelEmpleados.Repositorios;

namespace ProyectoPanelEmpleados.Presentacion
{
    public partial class MainDashboard : Form
    {
        private Panel sidebar;

        private DataGridView dgvEmpleados;

        private Button btnAgregar;

        private Button btnEditar;

        private Button btnEliminar;

        private Label lblTitulo;

        private readonly EmpleadoController controller;

        private int contadorId = 1;

        public MainDashboard()
        {
            controller = new EmpleadoController(
                new EmpleadoRepository());

            ConfigurarUI();
        }

        private void ConfigurarUI()
        {
            this.Text = "EmployeeHub";

            this.Size = new Size(1200, 700);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.BackColor =
                ColorTranslator.FromHtml("#F3F4F6");

            this.Font =
                new Font("Segoe UI", 10);

            // SIDEBAR

            sidebar = new Panel();

            sidebar.Size = new Size(220, 700);

            sidebar.BackColor =
                ColorTranslator.FromHtml("#1E3A5F");

            sidebar.Dock = DockStyle.Left;

            this.Controls.Add(sidebar);

            // TÍTULO

            lblTitulo = new Label();

            lblTitulo.Text =
                "Panel de Empleados";

            lblTitulo.Font =
                new Font(
                    "Segoe UI",
                    22,
                    FontStyle.Bold);

            lblTitulo.Location =
                new Point(260, 40);

            lblTitulo.AutoSize = true;

            this.Controls.Add(lblTitulo);

            // TABLA

            dgvEmpleados = new DataGridView();

            dgvEmpleados.Size =
                new Size(850, 350);

            dgvEmpleados.Location =
                new Point(260, 140);

            dgvEmpleados.BackgroundColor =
                Color.White;

            dgvEmpleados.BorderStyle =
                BorderStyle.None;

            dgvEmpleados.EnableHeadersVisualStyles = false;

            dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor =
                ColorTranslator.FromHtml("#1E3A5F");

            dgvEmpleados.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvEmpleados.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvEmpleados.RowHeadersVisible = false;

            dgvEmpleados.DefaultCellStyle.SelectionBackColor =
                ColorTranslator.FromHtml("#DBEAFE");

            dgvEmpleados.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvEmpleados.Columns.Add(
                "Id",
                "ID");

            dgvEmpleados.Columns.Add(
                "Nombre",
                "Nombre");

            dgvEmpleados.Columns.Add(
                "Tipo",
                "Tipo");

            dgvEmpleados.Columns.Add(
                "Salario",
                "Salario");

            this.Controls.Add(dgvEmpleados);

            // BOTÓN AGREGAR

            btnAgregar = new Button();

            btnAgregar.Text = "Agregar";

            btnAgregar.Size =
                new Size(130, 45);

            btnAgregar.Location =
                new Point(280, 540);

            btnAgregar.BackColor =
                ColorTranslator.FromHtml("#3B82F6");

            btnAgregar.ForeColor =
                Color.White;

            btnAgregar.FlatStyle =
                FlatStyle.Flat;

            btnAgregar.FlatAppearance.BorderSize = 0;

            btnAgregar.Cursor = Cursors.Hand;

            btnAgregar.Click += BtnAgregar_Click;

            this.Controls.Add(btnAgregar);

            // BOTÓN EDITAR

            btnEditar = new Button();

            btnEditar.Text = "Editar";

            btnEditar.Size =
                new Size(130, 45);

            btnEditar.Location =
                new Point(430, 540);

            btnEditar.BackColor =
                ColorTranslator.FromHtml("#10B981");

            btnEditar.ForeColor =
                Color.White;

            btnEditar.FlatStyle =
                FlatStyle.Flat;

            btnEditar.FlatAppearance.BorderSize = 0;

            btnEditar.Cursor = Cursors.Hand;

            this.Controls.Add(btnEditar);

            // BOTÓN ELIMINAR

            btnEliminar = new Button();

            btnEliminar.Text = "Eliminar";

            btnEliminar.Size =
                new Size(130, 45);

            btnEliminar.Location =
                new Point(580, 540);

            btnEliminar.BackColor =
                ColorTranslator.FromHtml("#EF4444");

            btnEliminar.ForeColor =
                Color.White;

            btnEliminar.FlatStyle =
                FlatStyle.Flat;

            btnEliminar.FlatAppearance.BorderSize = 0;

            btnEliminar.Cursor = Cursors.Hand;

            this.Controls.Add(btnEliminar);

            btnEliminar.Click += BtnEliminar_Click;
        }
        private void BtnEliminar_Click(
    object sender,
    EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int fila =
                    dgvEmpleados.SelectedRows[0].Index;

                dgvEmpleados.Rows.RemoveAt(fila);
            }
        }

        private void BtnAgregar_Click(
            object sender,
            EventArgs e)
        {
            EmployeeForm form =
                new EmployeeForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                Empleado empleado =
                    EmpleadoFactory.CrearEmpleado(
                        form.cbTipoContrato.Text,
                        form.txtNombre.Text,
                        decimal.Parse(form.txtSalario.Text));

                empleado.Id = contadorId++;

                controller.RegistrarEmpleado(
                    empleado);

                dgvEmpleados.Rows.Add(
                    empleado.Id,
                    empleado.Nombre,
                    form.cbTipoContrato.Text,
                    empleado.CalcularSalario());
            }
        }
    }
}