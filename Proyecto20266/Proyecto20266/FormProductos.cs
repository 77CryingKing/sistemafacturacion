using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto20266 // <--- RECUERDA CAMBIAR ESTO POR EL NOMBRE DE TU PROYECTO
{
    public partial class FormProductos : Form
    {
        // Lista en memoria para simular la base de datos de productos
        private List<Producto> listaProductos = new List<Producto>();
        private int filaSeleccionadaIndex = -1;

        public FormProductos(object btnGuardar) => this.btnGuardarProductos = (Button)btnGuardar;

        public FormProductos()
        {
            InitializeComponent();
            ConfigurarColumnasTabla();
            EstadoBotones(true); // Inicializa los controles bloqueados
        }

        // 1. Configuramos la estructura de la tabla de productos
        private void ConfigurarColumnasTabla()
        {
            dgvProductos.Columns.Add("Codigo", "Código");
            dgvProductos.Columns.Add("Descripcion", "Descripción");
            dgvProductos.Columns.Add("Precio", "Precio Unitario");
            dgvProductos.Columns.Add("Stock", "Stock");
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // 2. Control lógico de estados para evitar errores del usuario
        private void EstadoBotones(bool inicial)
        {
            txtCodigo.Enabled = !inicial;
            txtDescripcion.Enabled = !inicial;
            txtPrecio.Enabled = !inicial;
            txtStock.Enabled = !inicial;

            btnNuevo.Enabled = inicial;
            btnGuardarProducto.Enabled = !inicial;
            btnCancelar.Enabled = !inicial;

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            filaSeleccionadaIndex = -1;
        }

        // 3. Sincroniza la lista interna con la pantalla
        private void ActualizarTabla()
        {
            dgvProductos.Rows.Clear();
            foreach (var p in listaProductos)
            {
                // Formateamos el precio como moneda para que se vea profesional (.ToString("C2"))
                dgvProductos.Rows.Add(p.Codigo, p.Descripcion, p.Precio.ToString("C2"), p.Stock);
            }
        }

        // ==================== METODOS PARA ENLAZAR A LOS BOTONES ====================

        public void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            EstadoBotones(false);
            txtCodigo.Focus();
        }

        public void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            // Validaciones básicas de llenado
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Código y Descripción son campos obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validaciones numéricas para evitar caídas del sistema por escribir letras en Precio o Stock
            double precio = 0;
            int stock = 0;
            if (!double.TryParse(txtPrecio.Text, out precio) || !int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Por favor, introduce valores numéricos válidos en Precio y Stock.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Creamos el objeto Producto
            Producto nuevoProducto = new Producto
            {
                Codigo = txtCodigo.Text,
                Descripcion = txtDescripcion.Text,
                Precio = precio,
                Stock = stock
            };

            listaProductos.Add(nuevoProducto);
            ActualizarTabla();
            LimpiarCampos();
            EstadoBotones(true);
            MessageBox.Show("Producto registrado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            EstadoBotones(true);
        }

        // 4. Capturar el producto seleccionado al hacer clic en la tabla
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Validamos que el clic sea en un renglón de datos real (no en los títulos de arriba)
            if (e.RowIndex >= 0 && e.RowIndex < listaProductos.Count)
            {
                filaSeleccionadaIndex = e.RowIndex;

                // 2. Extraemos el producto directamente de la lista de memoria usando el índice de la tabla
                Producto p = listaProductos[filaSeleccionadaIndex];

                // 3. Llenamos los cuadros de texto con los datos del objeto de forma segura
                txtCodigo.Text = p.Codigo;
                txtDescripcion.Text = p.Descripcion;
                txtPrecio.Text = p.Precio.ToString();
                txtStock.Text = p.Stock.ToString();

                // 4. Bloqueamos el código para que no lo editen y activamos/desactivamos controles
                txtCodigo.Enabled = false;
                txtDescripcion.Enabled = true;
                txtPrecio.Enabled = true;
                txtStock.Enabled = true;

                btnNuevo.Enabled = false;
                btnCancelar.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                // 5. Desactivamos el botón de guardar usando una validación segura para el compilador
                if (btnGuardarProductos != null)
                {
                    btnGuardarProductos.Enabled = false;
                }
            }
        }

        public void btnModificar_Click(object sender, EventArgs e)
        {
            double precio = 0;
            int stock = 0;
            if (!double.TryParse(txtPrecio.Text, out precio) || !int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Precios y Stock deben ser numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (filaSeleccionadaIndex >= 0)
            {
                listaProductos[filaSeleccionadaIndex].Descripcion = txtDescripcion.Text;
                listaProductos[filaSeleccionadaIndex].Precio = precio;
                listaProductos[filaSeleccionadaIndex].Stock = stock;

                ActualizarTabla();
                LimpiarCampos();
                EstadoBotones(true);
                MessageBox.Show("Producto actualizado.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionadaIndex >= 0)
            {
                DialogResult resultado = MessageBox.Show("¿Eliminar este producto del catálogo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    listaProductos.RemoveAt(filaSeleccionadaIndex);
                    ActualizarTabla();
                    LimpiarCampos();
                    EstadoBotones(true);
                }
            }
        }
    }

    // Estructura de datos para el objeto Producto
    public class Producto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
    }
}