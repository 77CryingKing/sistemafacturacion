using Proyecto20266;
using System;
using System.Windows.Forms;

namespace Proyecto20266
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            // Esto hace que el formulario aparezca centrado en la pantalla al iniciar
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Evento para abrir la pantalla de Clientes
        private void menuClientes_Click(object sender, EventArgs e)
        {
            FormClientes ventanaClientes = new FormClientes();
            // .ShowDialog() hace que el usuario deba cerrar Clientes antes de volver al menú,
            // evitando que abra 20 veces la misma ventana por accidente.
            ventanaClientes.ShowDialog();
        }

        // Evento para abrir la pantalla de Productos
        private void menuProductos_Click(object sender, EventArgs e)
        {
            FormProductos ventanaProductos = new FormProductos();
            ventanaProductos.ShowDialog();
        }

        // Evento para abrir la pantalla de Facturas (con la 's' corregida)
        private void menuFacturas_Click(object sender, EventArgs e)
        {
            FormFacturas ventanaFacturas = new FormFacturas();
            ventanaFacturas.ShowDialog();
        }

        // Evento para salir del sistema de forma segura
        private void menuSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Seguro que deseas salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}