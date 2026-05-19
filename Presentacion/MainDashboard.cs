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

        private Label lblTitulo;

        private readonly EmpleadoController controller;

        public MainDashboard()
        {
            controller = new EmpleadoController(
                new EmpleadoRepository());


            ConfigurarUI();
        }

        private void ConfigurarUI()
        {
            // CONFIGURACIÓN GENERAL

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

            // BOTÓN INICIO

            Button btnInicio = new Button();

            btnInicio.Text = "Inicio";

            btnInicio.Size = new Size(180, 45);

            btnInicio.Location =
                new Point(20, 50);

            btnInicio.BackColor =
                ColorTranslator.FromHtml("#3B82F6");

            btnInicio.ForeColor = Color.White;

            btnInicio.FlatStyle =
                FlatStyle.Flat;

            btnInicio.FlatAppearance.BorderSize = 0;

            // BOTÓN EMPLEADOS

            Button btnEmpleados = new Button();

            btnEmpleados.Text = "Empleados";

            btnEmpleados.Size = new Size(180, 45);

            btnEmpleados.Location =
                new Point(20, 115);

            btnEmpleados.BackColor =
                ColorTranslator.FromHtml("#3B82F6");

            btnEmpleados.ForeColor = Color.White;

            btnEmpleados.FlatStyle =
                FlatStyle.Flat;

            btnEmpleados.FlatAppearance.BorderSize = 0;

            // BOTÓN LIQUIDACIONES

            Button btnLiquidaciones = new Button();

            btnLiquidaciones.Text = "Liquidaciones";

            btnLiquidaciones.Size =
                new Size(180, 45);

            btnLiquidaciones.Location =
                new Point(20, 180);

            btnLiquidaciones.BackColor =
                ColorTranslator.FromHtml("#3B82F6");

            btnLiquidaciones.ForeColor =
                Color.White;

            btnLiquidaciones.FlatStyle =
                FlatStyle.Flat;

            btnLiquidaciones.FlatAppearance.BorderSize = 0;

            // AGREGAR BOTONES AL SIDEBAR

            sidebar.Controls.Add(btnInicio);

            sidebar.Controls.Add(btnEmpleados);

            sidebar.Controls.Add(btnLiquidaciones);

            // TÍTULO PRINCIPAL

            lblTitulo = new Label();

            lblTitulo.Text =
                "Panel de Empleados";

            lblTitulo.Font =
                new Font(
                    "Segoe UI",
                    22,
                    FontStyle.Bold);

            lblTitulo.ForeColor =
                ColorTranslator.FromHtml("#1E3A5F");

            lblTitulo.Location =
                new Point(260, 40);

            lblTitulo.AutoSize = true;

            // TABLA EMPLEADOS

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

            dgvEmpleados.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            dgvEmpleados.ColumnHeadersHeight = 40;

            dgvEmpleados.RowTemplate.Height = 35;

            dgvEmpleados.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvEmpleados.MultiSelect = false;

            dgvEmpleados.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // COLUMNAS

            dgvEmpleados.Columns.Add(
                "Nombre",
                "Nombre");

            dgvEmpleados.Columns.Add(
                "Tipo",
                "Tipo Contrato");

            dgvEmpleados.Columns.Add(
                "Salario",
                "Salario");

            // BOTÓN AGREGAR

            btnAgregar = new Button();

            btnAgregar.Text = "Agregar";

            btnAgregar.BackColor =
                ColorTranslator.FromHtml("#3B82F6");

            btnAgregar.ForeColor = Color.White;

            btnAgregar.FlatStyle =
                FlatStyle.Flat;

            btnAgregar.FlatAppearance.BorderSize = 0;

            btnAgregar.Size =
                new Size(130, 45);

            btnAgregar.Location =
                new Point(280, 540);

            // BOTÓN EDITAR

            btnEditar = new Button();

            btnEditar.Text = "Editar";

            btnEditar.BackColor =
                ColorTranslator.FromHtml("#10B981");

            btnEditar.ForeColor = Color.White;

            btnEditar.FlatStyle =
                FlatStyle.Flat;

            btnEditar.FlatAppearance.BorderSize = 0;

            btnEditar.Size =
                new Size(130, 45);

            btnEditar.Location =
                new Point(430, 540);

            // BOTÓN ELIMINAR

            btnEliminar = new Button();

            btnEliminar.Text = "Eliminar";

            btnEliminar.BackColor =
                ColorTranslator.FromHtml("#EF4444");

            btnEliminar.ForeColor = Color.White;

            btnEliminar.FlatStyle =
                FlatStyle.Flat;

            btnEliminar.FlatAppearance.BorderSize = 0;

            btnEliminar.Size =
                new Size(130, 45);

            btnEliminar.Location =
                new Point(580, 540);

            // AGREGAR CONTROLES

            this.Controls.Add(sidebar);

            this.Controls.Add(lblTitulo);

            this.Controls.Add(dgvEmpleados);

            this.Controls.Add(btnAgregar);

            this.Controls.Add(btnEditar);

            this.Controls.Add(btnEliminar);
        }
    }
}