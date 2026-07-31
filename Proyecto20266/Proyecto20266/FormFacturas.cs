using System;
using System.Windows.Forms;

namespace Proyecto20266
{
    // Se cambió el nombre de la clase a FormFacturas (en plural)
    public partial class FormFacturas : Form
    {
        private double subtotalGeneral = 0;
        private double impuestoIVA = 0;
        private double totalGeneral = 0;
        private const double PORCENTAJE_IVA = 0.16;
        private int contadorFactura = 1001;

        // El constructor también debe llamarse igual que la clase: FormFacturas
        public FormFacturas()
        {
            InitializeComponent();
            ConfigurarColumnasFactura();
            CargarDatosSimulados();
            txtNumFactura.Text = contadorFactura.ToString();
        }

        private void ConfigurarColumnasFactura()
        {
            dgvDetalle.Columns.Add("Codigo", "Código");
            dgvDetalle.Columns.Add("Descripcion", "Descripción");
            dgvDetalle.Columns.Add("Cantidad", "Cantidad");
            dgvDetalle.Columns.Add("Precio", "Precio Unitario");
            dgvDetalle.Columns.Add("Subtotal", "Subtotal");
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarDatosSimulados()
        {
            cmbCliente.Items.Add("Juan Pérez - DNI: 123456");
            cmbCliente.Items.Add("María López - DNI: 789101");
            cmbCliente.Items.Add("Consumidor Final");
            cmbCliente.SelectedIndex = 0;

            cmbProducto.Items.Add("Laptop HP (Cod: P001)");
            cmbProducto.Items.Add("Mouse Óptico (Cod: P002)");
            cmbProducto.Items.Add("Teclado Mecánico (Cod: P003)");
            cmbProducto.SelectedIndex = 0;
            ActualizarPrecioUnitario();
        }

        private void ActualizarPrecioUnitario()
        {
            if (cmbProducto.SelectedIndex == 0) txtPrecioUnitario.Text = "750.00";
            if (cmbProducto.SelectedIndex == 1) txtPrecioUnitario.Text = "25.00";
            if (cmbProducto.SelectedIndex == 2) txtPrecioUnitario.Text = "60.00";
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarPrecioUnitario();
        }

        private void CalcularTotales()
        {
            subtotalGeneral = 0;
            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.Cells["Subtotal"].Value != null)
                {
                    subtotalGeneral += Convert.ToDouble(fila.Cells["Subtotal"].Value);
                }
            }

            impuestoIVA = subtotalGeneral * PORCENTAJE_IVA;
            totalGeneral = subtotalGeneral + impuestoIVA;

            lblSubtotal.Text = subtotalGeneral.ToString("C2");
            lblIva.Text = impuestoIVA.ToString("C2");
            lblTotal.Text = totalGeneral.ToString("C2");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = cmbProducto.SelectedItem.ToString();
            int cantidad = Convert.ToInt32(nmCantidad.Value);
            double precio = Convert.ToDouble(txtPrecioUnitario.Text);
            double subtotalFila = cantidad * precio;

            string codigo = productoSeleccionado.Contains("Cod:") ?
                            productoSeleccionado.Substring(productoSeleccionado.IndexOf("Cod:") + 4).Replace(")", "") : "000";

            dgvDetalle.Rows.Add(codigo, productoSeleccionado, cantidad, precio.ToString("C2"), subtotalFila);
            CalcularTotales();
            nmCantidad.Value = 1;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null && dgvDetalle.CurrentRow.Index >= 0)
            {
                dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index);
                CalcularTotales();
            }
            else
            {
                MessageBox.Show("Selecciona un producto de la tabla para quitarlo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("No puedes generar una factura vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensajeExito = $"--- FACTURA GENERADA CON ÉXITO ---\n\n" +
                                 $"Factura N°: {txtNumFactura.Text}\n" +
                                 $"Fecha: {dtpFecha.Value.ToShortDateString()}\n" +
                                 $"Cliente: {cmbCliente.SelectedItem}\n" +
                                 $"Total Cobrado: {totalGeneral.ToString("C2")}\n\n" +
                                 $"¡Operación procesada correctamente!";

            MessageBox.Show(mensajeExito, "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvDetalle.Rows.Clear();
            CalcularTotales();
            contadorFactura++;
            txtNumFactura.Text = contadorFactura.ToString();
        }

        private void btnCancelarFactura_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas cancelar la factura actual?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                dgvDetalle.Rows.Clear();
                CalcularTotales();
            }
        }
    }
}