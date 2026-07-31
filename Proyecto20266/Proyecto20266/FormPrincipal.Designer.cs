namespace Proyecto20266
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menúToolStripMenuItem = new ToolStripMenuItem();
            menuClientes = new ToolStripMenuItem();
            menuProductos = new ToolStripMenuItem();
            menuFacturas = new ToolStripMenuItem();
            menuSalir = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menúToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(665, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            menúToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuClientes, menuProductos, menuFacturas, menuSalir });
            menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            menúToolStripMenuItem.Size = new Size(50, 20);
            menúToolStripMenuItem.Text = "Menú";
            // 
            // menuClientes
            // 
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(123, 22);
            menuClientes.Text = "Clientes";
            menuClientes.Click += menuClientes_Click;
            // 
            // menuProductos
            // 
            menuProductos.Name = "menuProductos";
            menuProductos.Size = new Size(123, 22);
            menuProductos.Text = "Producto";
            menuProductos.Click += menuProductos_Click;
            // 
            // menuFacturas
            // 
            menuFacturas.Name = "menuFacturas";
            menuFacturas.Size = new Size(123, 22);
            menuFacturas.Text = "Factura";
            menuFacturas.Click += menuFacturas_Click;
            // 
            // menuSalir
            // 
            menuSalir.Name = "menuSalir";
            menuSalir.Size = new Size(123, 22);
            menuSalir.Text = "Salir";
            menuSalir.Click += menuSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 69);
            label1.Name = "label1";
            label1.Size = new Size(548, 65);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Facturación";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 313);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menúToolStripMenuItem;
        private ToolStripMenuItem menuClientes;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem menuProductos;
        private ToolStripMenuItem menuFacturas;
        private ToolStripMenuItem menuSalir;
        private Label label1;
    }
}