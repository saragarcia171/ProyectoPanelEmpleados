using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoPanelEmpleados.Controladores;
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

        private readonly EmpleadoController controller;

        public MainDashboard()
        {
            controller = new EmpleadoController(
                new EmpleadoRepository());

            InitializeComponent();

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

            sidebar = new Panel();

            sidebar.Size = new Size(220, 700);

            sidebar.BackColor =
                ColorTranslator.FromHtml("#1E3A5F");

            sidebar.Dock = DockStyle.Left;

            Button btnInicio = new Button();

            btnInicio.Text = "Inicio";

            btnInicio.Size = new Size(180, 40);

            btnInicio.Location = new Point(20, 50);

            Button btnEmpleados = new Button();

            btnEmpleados.Text = "Empleados";

            btnEmpleados.Size = new Size(180, 40);

            btnEmpleados.Location =
                new Point(20, 110);

            Button btnLiquidaciones = new Button();

            btnLiquidaciones.Text = "Liquidaciones";

            btnLiquidaciones.Size =
                new Size(180, 40);

            btnLiquidaciones.Location =
                new Point(20, 170);

            sidebar.Controls.Add(btnInicio);

            sidebar.Controls.Add(btnEmpleados);

            sidebar.Controls.Add(btnLiquidaciones);

            dgvEmpleados = new DataGridView();

            dgvEmpleados.Size =
                new Size(850, 350);

            dgvEmpleados.Location =
                new Point(260, 150);

            dgvEmpleados.BackgroundColor =
                Color.White;

            dgvEmpleados.Columns.Add(
                "Nombre",
                "Nombre");

            dgvEmpleados.Columns.Add(
                "Tipo",
                "Tipo");

            dgvEmpleados.Columns.Add(
                "Salario",
                "Salario");

            btnAgregar = new Button();

            btnAgregar.Text = "Agregar";

            btnAgregar.BackColor =
                ColorTranslator.FromHtml("#3B82F6");

            btnAgregar.ForeColor = Color.White;

            btnAgregar.Size =
                new Size(120, 40);

            btnAgregar.Location =
                new Point(260, 540);

            btnEditar = new Button();

            btnEditar.Text = "Editar";

            btnEditar.BackColor =
                ColorTranslator.FromHtml("#10B981");

            btnEditar.ForeColor = Color.White;

            btnEditar.Size =
                new Size(120, 40);

            btnEditar.Location =
                new Point(400, 540);

            btnEliminar = new Button();

            btnEliminar.Text = "Eliminar";

            btnEliminar.BackColor =
                ColorTranslator.FromHtml("#EF4444");

            btnEliminar.ForeColor = Color.White;

            btnEliminar.Size =
                new Size(120, 40);

            btnEliminar.Location =
                new Point(540, 540);

            this.Controls.Add(sidebar);

            this.Controls.Add(dgvEmpleados);

            this.Controls.Add(btnAgregar);

            this.Controls.Add(btnEditar);

            this.Controls.Add(btnEliminar);
        }
    }
}