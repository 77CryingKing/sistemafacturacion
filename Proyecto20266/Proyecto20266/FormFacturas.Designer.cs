namespace Proyecto20266
{
    partial class FormFacturas
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            cmbCliente = new ComboBox();
            label2 = new Label();
            txtNumFactura = new TextBox();
            label1 = new Label();
            dtpFecha = new DateTimePicker();
            groupBox2 = new GroupBox();
            nmCantidad = new NumericUpDown();
            btnAgregar = new Button();
            label5 = new Label();
            txtPrecioUnitario = new TextBox();
            label4 = new Label();
            cmbProducto = new ComboBox();
            label3 = new Label();
            btnQuitar = new Button();
            dgvDetalle = new DataGridView();
            lblSubtotal = new Label();
            lblIva = new Label();
            lblTotal = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnGenerarFactura = new Button();
            btnCancelarFactura = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNumFactura);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Location = new Point(46, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 149);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la factura";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 25);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 4;
            label6.Text = "Fecha";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(177, 93);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 23);
            cmbCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 93);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // txtNumFactura
            // 
            txtNumFactura.Location = new Point(180, 56);
            txtNumFactura.Name = "txtNumFactura";
            txtNumFactura.ReadOnly = true;
            txtNumFactura.Size = new Size(100, 23);
            txtNumFactura.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 59);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 1;
            label1.Text = "Numero de factura";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(98, 19);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nmCantidad);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtPrecioUnitario);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cmbProducto);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(431, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(309, 191);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar productos al Detalle";
            // 
            // nmCantidad
            // 
            nmCantidad.Location = new Point(132, 104);
            nmCantidad.Name = "nmCantidad";
            nmCantidad.Size = new Size(120, 23);
            nmCantidad.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(57, 155);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 106);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 6;
            label5.Text = "Cantidad";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(132, 70);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(100, 23);
            txtPrecioUnitario.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 73);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 4;
            label4.Text = "Precio unitario";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(132, 29);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(121, 23);
            cmbProducto.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 32);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Producto";
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(623, 191);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(75, 23);
            btnQuitar.TabIndex = 3;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(12, 211);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(413, 150);
            dgvDetalle.TabIndex = 4;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(436, 282);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(34, 15);
            lblSubtotal.TabIndex = 5;
            lblSubtotal.Text = "$0.00";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Location = new Point(547, 282);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(34, 15);
            lblIva.TabIndex = 6;
            lblIva.Text = "$0.00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(655, 283);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(34, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "$0.00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(431, 267);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 8;
            label10.Text = "Subtotal";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(547, 267);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 9;
            label11.Text = "I.V.A";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(655, 267);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 10;
            label12.Text = "Total";
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.Location = new Point(447, 330);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(75, 23);
            btnGenerarFactura.TabIndex = 11;
            btnGenerarFactura.Text = "Generar";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // btnCancelarFactura
            // 
            btnCancelarFactura.Location = new Point(608, 330);
            btnCancelarFactura.Name = "btnCancelarFactura";
            btnCancelarFactura.Size = new Size(75, 23);
            btnCancelarFactura.TabIndex = 12;
            btnCancelarFactura.Text = "Cancelar";
            btnCancelarFactura.UseVisualStyleBackColor = true;
            btnCancelarFactura.Click += btnCancelarFactura_Click;
            // 
            // FormFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 373);
            Controls.Add(btnCancelarFactura);
            Controls.Add(btnGenerarFactura);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(lblTotal);
            Controls.Add(lblIva);
            Controls.Add(lblSubtotal);
            Controls.Add(dgvDetalle);
            Controls.Add(btnQuitar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormFacturas";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpFecha;
        private ComboBox cmbCliente;
        private Label label2;
        private TextBox txtNumFactura;
        private Label label1;
        private GroupBox groupBox2;
        private NumericUpDown nmCantidad;
        private Button btnAgregar;
        private NumericUpDown numericUpDown1;
        private Button btnGenerarFactura;
        private Label label5;
        private TextBox txtPrecioUnitario;
        private TextBox textBox1;
        private Label label4;
        private ComboBox cmbProducto;
        private ComboBox comboBox1;
        private Label label3;
        private Button btnQuitar;
        private Label label6;
        private DataGridView dgvDetalle;
        private Label lblSubtotal;
        private Label lblIva;
        private Label lblTotal;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnCancelarFactura;

        public Control Fecha { get; private set; }
    }
}