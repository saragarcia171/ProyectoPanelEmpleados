using ProyectoPanelEmpleados.Controladores;
using ProyectoPanelEmpleados.Fabricas;
using ProyectoPanelEmpleados.Modelos;
using ProyectoPanelEmpleados.Repositorios;

namespace ProyectoPanelEmpleados.Presentacion
{
    public partial class MainDashboard : Form
    {
        private readonly EmpleadoController controller;

        private DataGridView dgvEmpleados;

        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLiquidacion;

        private Panel sidebar;

        private int contadorId = 1;

        public MainDashboard()
        {
            controller =
                new EmpleadoController(
                    new EmpleadoRepository());

            ConfigurarUI();
        }

        private void ConfigurarUI()
        {
            this.Text =
                "Panel de Empleados";

            this.Size =
                new Size(1100, 650);

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.BackColor =
                ColorTranslator.FromHtml("#F3F4F6");

            this.FormBorderStyle =
                FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            // =========================
            // SIDEBAR
            // =========================

            sidebar = new Panel();

            sidebar.Size =
                new Size(220, this.Height);

            sidebar.Location =
                new Point(0, 0);

            sidebar.BackColor =
                ColorTranslator.FromHtml("#1E3A8A");

            this.Controls.Add(sidebar);

            Label lblTitulo = new Label();

            lblTitulo.Text =
                "Panel Empleados";

            lblTitulo.ForeColor =
                Color.White;

            lblTitulo.Font =
                new Font(
                    "Segoe UI",
                    16,
                    FontStyle.Bold);

            lblTitulo.AutoSize = true;

            lblTitulo.Location =
                new Point(25, 40);

            sidebar.Controls.Add(lblTitulo);

            // =========================
            // TABLA
            // =========================

            dgvEmpleados =
                new DataGridView();

            dgvEmpleados.Location =
                new Point(250, 80);

            dgvEmpleados.Size =
                new Size(800, 450);

            dgvEmpleados.BackgroundColor =
                Color.White;

            dgvEmpleados.BorderStyle =
                BorderStyle.None;

            dgvEmpleados.AllowUserToAddRows =
                false;

            dgvEmpleados.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvEmpleados.MultiSelect =
                false;

            dgvEmpleados.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvEmpleados.RowHeadersVisible =
                false;

            dgvEmpleados.DefaultCellStyle.SelectionBackColor =
                ColorTranslator.FromHtml("#DBEAFE");

            dgvEmpleados.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor =
                ColorTranslator.FromHtml("#2563EB");

            dgvEmpleados.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvEmpleados.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            dgvEmpleados.EnableHeadersVisualStyles =
                false;

            dgvEmpleados.Columns.Add(
                "Id",
                "ID");

            dgvEmpleados.Columns.Add(
                "Nombre",
                "Nombre");

            dgvEmpleados.Columns.Add(
                "Contrato",
                "Contrato");

            dgvEmpleados.Columns.Add(
                "Salario",
                "Salario Calculado");

            // =========================
            // COLUMNA OCULTA
            // =========================

            dgvEmpleados.Columns.Add(
                "SalarioBase",
                "Salario Base");

            dgvEmpleados.Columns["SalarioBase"].Visible =
                false;

            this.Controls.Add(dgvEmpleados);

            // =========================
            // BOTÓN AGREGAR
            // =========================

            btnAgregar = new Button();

            btnAgregar.Text =
                "Agregar";

            btnAgregar.Size =
                new Size(120, 40);

            btnAgregar.Location =
                new Point(250, 560);

            btnAgregar.BackColor =
                ColorTranslator.FromHtml("#10B981");

            btnAgregar.ForeColor =
                Color.White;

            btnAgregar.FlatStyle =
                FlatStyle.Flat;

            btnAgregar.FlatAppearance.BorderSize =
                0;

            btnAgregar.Cursor =
                Cursors.Hand;

            btnAgregar.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            btnAgregar.Click +=
                BtnAgregar_Click;

            this.Controls.Add(btnAgregar);

            // =========================
            // BOTÓN EDITAR
            // =========================

            btnEditar = new Button();

            btnEditar.Text =
                "Editar";

            btnEditar.Size =
                new Size(120, 40);

            btnEditar.Location =
                new Point(390, 560);

            btnEditar.BackColor =
                ColorTranslator.FromHtml("#3B82F6");

            btnEditar.ForeColor =
                Color.White;

            btnEditar.FlatStyle =
                FlatStyle.Flat;

            btnEditar.FlatAppearance.BorderSize =
                0;

            btnEditar.Cursor =
                Cursors.Hand;

            btnEditar.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            btnEditar.Click +=
                BtnEditar_Click;

            this.Controls.Add(btnEditar);

            // =========================
            // BOTÓN ELIMINAR
            // =========================

            btnEliminar = new Button();

            btnEliminar.Text =
                "Eliminar";

            btnEliminar.Size =
                new Size(120, 40);

            btnEliminar.Location =
                new Point(530, 560);

            btnEliminar.BackColor =
                ColorTranslator.FromHtml("#EF4444");

            btnEliminar.ForeColor =
                Color.White;

            btnEliminar.FlatStyle =
                FlatStyle.Flat;

            btnEliminar.FlatAppearance.BorderSize =
                0;

            btnEliminar.Cursor =
                Cursors.Hand;

            btnEliminar.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            btnEliminar.Click +=
                BtnEliminar_Click;

            this.Controls.Add(btnEliminar);

            // =========================
            // BOTÓN LIQUIDACIÓN
            // =========================

            btnLiquidacion = new Button();

            btnLiquidacion.Text =
                "Liquidación";

            btnLiquidacion.Size =
                new Size(140, 40);

            btnLiquidacion.Location =
                new Point(670, 560);

            btnLiquidacion.BackColor =
                ColorTranslator.FromHtml("#8B5CF6");

            btnLiquidacion.ForeColor =
                Color.White;

            btnLiquidacion.FlatStyle =
                FlatStyle.Flat;

            btnLiquidacion.FlatAppearance.BorderSize =
                0;

            btnLiquidacion.Cursor =
                Cursors.Hand;

            btnLiquidacion.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            btnLiquidacion.Click +=
                BtnLiquidacion_Click;

            this.Controls.Add(btnLiquidacion);
        }

        private void BtnAgregar_Click(
            object? sender,
            EventArgs e)
        {
            EmployeeForm form =
                new EmployeeForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(
                        form.txtNombre.Text) ||

                    string.IsNullOrWhiteSpace(
                        form.txtSalario.Text) ||

                    string.IsNullOrWhiteSpace(
                        form.cbTipoContrato.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!decimal.TryParse(
                        form.txtSalario.Text,
                        out decimal salario))
                {
                    MessageBox.Show(
                        "Ingrese un salario válido.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Empleado empleado =
                    EmpleadoFactory.CrearEmpleado(
                        form.cbTipoContrato.Text,
                        form.txtNombre.Text,
                        salario);

                empleado.Id =
                    contadorId++;

                controller.RegistrarEmpleado(
                    empleado);

                dgvEmpleados.Rows.Add(
                    empleado.Id,
                    empleado.Nombre,
                    form.cbTipoContrato.Text,
                    empleado.CalcularSalario(),
                    salario);
            }
        }

        private void BtnEditar_Click(
            object? sender,
            EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un empleado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DataGridViewRow fila =
                dgvEmpleados.SelectedRows[0];

            EmployeeForm form =
                new EmployeeForm();

            form.txtNombre.Text =
                fila.Cells[1].Value?.ToString();

            form.cbTipoContrato.Text =
                fila.Cells[2].Value?.ToString();

            // =========================
            // USAR SALARIO BASE
            // =========================

            form.txtSalario.Text =
                fila.Cells[4].Value?.ToString();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!decimal.TryParse(
                        form.txtSalario.Text,
                        out decimal salario))
                {
                    MessageBox.Show(
                        "Ingrese un salario válido.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Empleado empleadoEditado =
                    EmpleadoFactory.CrearEmpleado(
                        form.cbTipoContrato.Text,
                        form.txtNombre.Text,
                        salario);

                fila.Cells[1].Value =
                    empleadoEditado.Nombre;

                fila.Cells[2].Value =
                    form.cbTipoContrato.Text;

                fila.Cells[3].Value =
                    empleadoEditado.CalcularSalario();

                // =========================
                // GUARDAR NUEVO BASE
                // =========================

                fila.Cells[4].Value =
                    salario;
            }
        }

        private void BtnEliminar_Click(
            object? sender,
            EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int fila =
                    dgvEmpleados
                        .SelectedRows[0]
                        .Index;

                dgvEmpleados.Rows
                    .RemoveAt(fila);
            }
            else
            {
                MessageBox.Show(
                    "Seleccione un empleado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void BtnLiquidacion_Click(
            object? sender,
            EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un empleado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DataGridViewRow fila =
                dgvEmpleados.SelectedRows[0];

            string nombre =
                fila.Cells[1].Value?.ToString() ?? "";

            string contrato =
                fila.Cells[2].Value?.ToString() ?? "";

            decimal salario =
                Convert.ToDecimal(
                    fila.Cells[3].Value);

            decimal bonificacion = 0;

            if (contrato != "Freelance")
            {
                bonificacion =
                    salario * 0.10m;
            }

            decimal liquidacion =
                salario + bonificacion;

            string mensajeBonificacion =
                contrato == "Freelance"
                ? "No aplica para prestación de servicios"
                : bonificacion.ToString("C");

            MessageBox.Show(
                $"Empleado: {nombre}\n\n" +
                $"Contrato: {contrato}\n\n" +
                $"Salario: {salario:C}\n" +
                $"Bonificación: {mensajeBonificacion}\n" +
                $"Liquidación: {liquidacion:C}",
                "Liquidación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}