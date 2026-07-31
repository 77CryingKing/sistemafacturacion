using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto20266 // Asegúrate de que coincida con el nombre de tu proyecto
{
    public partial class FormClientes : Form
    {
        // Simulamos una base de datos temporal usando una clase interna "Cliente"
        private List<Cliente> listaClientes = new List<Cliente>();
        private int filaSeleccionadaIndex = -1; // Nos ayuda a saber qué cliente queremos modificar o eliminar

        public FormClientes()
        {
            InitializeComponent();
            ConfigurarColumnasTabla();
            EstadoBotones(true); // Activa el estado inicial de la pantalla
        }

        // 1. Creamos las columnas de nuestra tabla manualmente al arrancar
        private void ConfigurarColumnasTabla()
        {
            dgvClientes.Columns.Add("Dni", "NIT/DNI");
            dgvClientes.Columns.Add("Nombre", "Nombre");
            dgvClientes.Columns.Add("Apellido", "Apellido");
            dgvClientes.Columns.Add("Direccion", "Dirección");
            dgvClientes.Columns.Add("Telefono", "Teléfono");
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta el ancho automáticamente
        }

        // 2. Método para controlar qué botones se pueden presionar según lo que haga el usuario
        private void EstadoBotones(bool inicial)
        {
            txtDni.Enabled = !inicial;
            txtNombre.Enabled = !inicial;
            txtApellido.Enabled = !inicial;
            txtDireccion.Enabled = !inicial;
            txtTelefono.Enabled = !inicial;

            btnNuevo.Enabled = inicial;
            btnGuardar.Enabled = !inicial;
            btnCancelar.Enabled = !inicial;

            // Modificar y Eliminar solo se activan si el usuario selecciona una fila de la tabla
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        // 3. Limpiar los cuadros de texto
        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            filaSeleccionadaIndex = -1;
        }

        // 4. Actualizar las filas de la grilla con lo que hay en la lista interna
        private void ActualizarTabla()
        {
            dgvClientes.Rows.Clear(); // Limpiamos la tabla visual
            foreach (var c in listaClientes)
            {
                dgvClientes.Rows.Add(c.Dni, c.Nombre, c.Apellido, c.Direccion, c.Telefono);
            }
        }

        // ==================== EVENTOS DE LOS BOTONES ====================

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            EstadoBotones(false);
            txtDni.Focus(); // Pone el cursor en el primer campo
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación simple: que no dejen campos vacíos
            if (string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, llena los campos obligatorios (DNI y Nombre).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardamos el cliente en nuestra lista en memoria
            Cliente nuevoCliente = new Cliente
            {
                Dni = txtDni.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text
            };

            listaClientes.Add(nuevoCliente);
            ActualizarTabla();
            LimpiarCampos();
            EstadoBotones(true);
            MessageBox.Show("Cliente guardado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            EstadoBotones(true);
        }

        // 5. Detectar cuando el usuario hace clic sobre un cliente de la tabla
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validamos que se haga clic en una fila válida y no en el encabezado
            if (e.RowIndex >= 0 && dgvClientes.Rows[e.RowIndex].Cells[0].Value != null)
            {
                filaSeleccionadaIndex = e.RowIndex;

                // Pasamos los datos de la tabla de vuelta a los TextBox para editar
                txtDni.Text = dgvClientes.Rows[filaSeleccionadaIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvClientes.Rows[filaSeleccionadaIndex].Cells[1].Value.ToString();
                txtApellido.Text = dgvClientes.Rows[filaSeleccionadaIndex].Cells[2].Value.ToString();
                txtDireccion.Text = dgvClientes.Rows[filaSeleccionadaIndex].Cells[3].Value.ToString();
                txtTelefono.Text = dgvClientes.Rows[filaSeleccionadaIndex].Cells[4].Value.ToString();

                // Habilitamos controles para Modificar o Eliminar
                txtDni.Enabled = false; // El DNI no se debería poder editar por seguridad
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;

                btnNuevo.Enabled = false;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionadaIndex >= 0)
            {
                // Modificamos el registro directamente en la lista temporal
                listaClientes[filaSeleccionadaIndex].Nombre = txtNombre.Text;
                listaClientes[filaSeleccionadaIndex].Apellido = txtApellido.Text;
                listaClientes[filaSeleccionadaIndex].Direccion = txtDireccion.Text;
                listaClientes[filaSeleccionadaIndex].Telefono = txtTelefono.Text;

                ActualizarTabla();
                LimpiarCampos();
                EstadoBotones(true);
                MessageBox.Show("Cliente modificado correctamente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionadaIndex >= 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de eliminar a este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    listaClientes.RemoveAt(filaSeleccionadaIndex);
                    ActualizarTabla();
                    LimpiarCampos();
                    EstadoBotones(true);
                }
            }
        }
    }

    // Estructura de datos temporal para modelar al objeto Cliente
    public class Cliente
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
