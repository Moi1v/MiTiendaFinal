namespace MiTienda
{
    partial class Ventas
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
            dgvProductos = new DataGridView();
            productoVentas = new DataGridViewTextBoxColumn();
            precioVentas = new DataGridViewTextBoxColumn();
            stockVentas = new DataGridViewTextBoxColumn();
            dgvCarrito = new DataGridView();
            nombreCarrito = new DataGridViewTextBoxColumn();
            precioUnitarioCarrito = new DataGridViewTextBoxColumn();
            cantidadCarrito = new DataGridViewTextBoxColumn();
            subtotalCarrito = new DataGridViewTextBoxColumn();
            txtBuscarProducto = new TextBox();
            btnBuscarProducto = new Button();
            btnAgregarCarrito = new Button();
            btnQuitarCarrito = new Button();
            btnFinalizarVenta = new Button();
            lblTotal = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { productoVentas, precioVentas, stockVentas });
            dgvProductos.Location = new Point(27, 111);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(428, 436);
            dgvProductos.TabIndex = 0;
            // 
            // productoVentas
            // 
            productoVentas.HeaderText = "Productos";
            productoVentas.MinimumWidth = 6;
            productoVentas.Name = "productoVentas";
            productoVentas.Width = 125;
            // 
            // precioVentas
            // 
            precioVentas.HeaderText = "Precio";
            precioVentas.MinimumWidth = 6;
            precioVentas.Name = "precioVentas";
            precioVentas.Width = 125;
            // 
            // stockVentas
            // 
            stockVentas.HeaderText = "Stock";
            stockVentas.MinimumWidth = 6;
            stockVentas.Name = "stockVentas";
            stockVentas.Width = 125;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { nombreCarrito, precioUnitarioCarrito, cantidadCarrito, subtotalCarrito });
            dgvCarrito.Location = new Point(485, 111);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new Size(553, 436);
            dgvCarrito.TabIndex = 1;
            // 
            // nombreCarrito
            // 
            nombreCarrito.HeaderText = "Producto";
            nombreCarrito.MinimumWidth = 6;
            nombreCarrito.Name = "nombreCarrito";
            nombreCarrito.Width = 125;
            // 
            // precioUnitarioCarrito
            // 
            precioUnitarioCarrito.HeaderText = "Precio Unitario";
            precioUnitarioCarrito.MinimumWidth = 6;
            precioUnitarioCarrito.Name = "precioUnitarioCarrito";
            precioUnitarioCarrito.Width = 125;
            // 
            // cantidadCarrito
            // 
            cantidadCarrito.HeaderText = "Cantidad";
            cantidadCarrito.MinimumWidth = 6;
            cantidadCarrito.Name = "cantidadCarrito";
            cantidadCarrito.Width = 125;
            // 
            // subtotalCarrito
            // 
            subtotalCarrito.HeaderText = "Subtotal";
            subtotalCarrito.MinimumWidth = 6;
            subtotalCarrito.Name = "subtotalCarrito";
            subtotalCarrito.Width = 125;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(27, 65);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(125, 27);
            txtBuscarProducto.TabIndex = 2;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(902, 675);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(136, 29);
            btnBuscarProducto.TabIndex = 3;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.Location = new Point(902, 570);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(136, 29);
            btnAgregarCarrito.TabIndex = 4;
            btnAgregarCarrito.Text = "Agregar al Carrito";
            btnAgregarCarrito.UseVisualStyleBackColor = true;
            // 
            // btnQuitarCarrito
            // 
            btnQuitarCarrito.Location = new Point(902, 605);
            btnQuitarCarrito.Name = "btnQuitarCarrito";
            btnQuitarCarrito.Size = new Size(136, 29);
            btnQuitarCarrito.TabIndex = 5;
            btnQuitarCarrito.Text = "Quitar del Carrito";
            btnQuitarCarrito.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Location = new Point(902, 640);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(136, 29);
            btnFinalizarVenta.TabIndex = 6;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(769, 574);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(87, 20);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total: Q0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 33);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 8;
            label1.Text = "Buscar";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 726);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(btnQuitarCarrito);
            Controls.Add(btnAgregarCarrito);
            Controls.Add(btnBuscarProducto);
            Controls.Add(txtBuscarProducto);
            Controls.Add(dgvCarrito);
            Controls.Add(dgvProductos);
            Name = "Ventas";
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn productoVentas;
        private DataGridViewTextBoxColumn precioVentas;
        private DataGridViewTextBoxColumn stockVentas;
        private DataGridView dgvCarrito;
        private DataGridViewTextBoxColumn nombreCarrito;
        private DataGridViewTextBoxColumn precioUnitarioCarrito;
        private DataGridViewTextBoxColumn cantidadCarrito;
        private DataGridViewTextBoxColumn subtotalCarrito;
        private TextBox txtBuscarProducto;
        private Button btnBuscarProducto;
        private Button btnAgregarCarrito;
        private Button btnQuitarCarrito;
        private Button btnFinalizarVenta;
        private Label lblTotal;
        private Label label1;
    }
}