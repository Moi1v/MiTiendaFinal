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
            btnBuscar = new Button();
            label1 = new Label();
            btnFinalizarVenta = new Button();
            btnQuitarCarrito = new Button();
            btnAgregarCarrito = new Button();
            lblTotal = new Label();
            dgvCarrito = new DataGridView();
            ProductoCarrito = new DataGridViewTextBoxColumn();
            CantidadCarrito = new DataGridViewTextBoxColumn();
            Precio_UnitarioCarrito = new DataGridViewTextBoxColumn();
            SubtotalCarrito = new DataGridViewTextBoxColumn();
            dgvProductos = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio_Unitario = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            lblBuscarProducto = new Label();
            txtBuscarProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(149, 39);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(579, 434);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 28;
            label1.Text = "Monto Total:";
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Location = new Point(836, 457);
            btnFinalizarVenta.Margin = new Padding(3, 2, 3, 2);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(120, 22);
            btnFinalizarVenta.TabIndex = 27;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.UseVisualStyleBackColor = true;
            // 
            // btnQuitarCarrito
            // 
            btnQuitarCarrito.Location = new Point(836, 430);
            btnQuitarCarrito.Margin = new Padding(3, 2, 3, 2);
            btnQuitarCarrito.Name = "btnQuitarCarrito";
            btnQuitarCarrito.Size = new Size(120, 22);
            btnQuitarCarrito.TabIndex = 26;
            btnQuitarCarrito.Text = "Quitar del Carrito";
            btnQuitarCarrito.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.Location = new Point(836, 404);
            btnAgregarCarrito.Margin = new Padding(3, 2, 3, 2);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(120, 22);
            btnAgregarCarrito.TabIndex = 25;
            btnAgregarCarrito.Text = "Agregar al Carrito";
            btnAgregarCarrito.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(579, 457);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 24;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { ProductoCarrito, CantidadCarrito, Precio_UnitarioCarrito, SubtotalCarrito });
            dgvCarrito.Location = new Point(513, 64);
            dgvCarrito.Margin = new Padding(3, 2, 3, 2);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.Size = new Size(444, 335);
            dgvCarrito.TabIndex = 23;
            // 
            // ProductoCarrito
            // 
            ProductoCarrito.HeaderText = "Producto ";
            ProductoCarrito.MinimumWidth = 6;
            ProductoCarrito.Name = "ProductoCarrito";
            ProductoCarrito.ReadOnly = true;
            // 
            // CantidadCarrito
            // 
            CantidadCarrito.HeaderText = "Cantidad ";
            CantidadCarrito.MinimumWidth = 6;
            CantidadCarrito.Name = "CantidadCarrito";
            CantidadCarrito.ReadOnly = true;
            // 
            // Precio_UnitarioCarrito
            // 
            Precio_UnitarioCarrito.HeaderText = "Precio Unitario";
            Precio_UnitarioCarrito.MinimumWidth = 6;
            Precio_UnitarioCarrito.Name = "Precio_UnitarioCarrito";
            Precio_UnitarioCarrito.ReadOnly = true;
            // 
            // SubtotalCarrito
            // 
            SubtotalCarrito.HeaderText = "Subtotal";
            SubtotalCarrito.MinimumWidth = 6;
            SubtotalCarrito.Name = "SubtotalCarrito";
            SubtotalCarrito.ReadOnly = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad, Precio_Unitario, Subtotal });
            dgvProductos.Location = new Point(10, 64);
            dgvProductos.Margin = new Padding(3, 2, 3, 2);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(484, 416);
            dgvProductos.TabIndex = 22;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Precio_Unitario
            // 
            Precio_Unitario.HeaderText = "Precio Unitario";
            Precio_Unitario.MinimumWidth = 6;
            Precio_Unitario.Name = "Precio_Unitario";
            Precio_Unitario.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 125;
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Location = new Point(10, 14);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(94, 15);
            lblBuscarProducto.TabIndex = 21;
            lblBuscarProducto.Text = "Buscar Producto";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(10, 40);
            txtBuscarProducto.Margin = new Padding(3, 2, 3, 2);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(110, 23);
            txtBuscarProducto.TabIndex = 20;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 505);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(btnQuitarCarrito);
            Controls.Add(btnAgregarCarrito);
            Controls.Add(lblTotal);
            Controls.Add(dgvCarrito);
            Controls.Add(dgvProductos);
            Controls.Add(lblBuscarProducto);
            Controls.Add(txtBuscarProducto);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ventas";
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Label label1;
        private Button btnFinalizarVenta;
        private Button btnQuitarCarrito;
        private Button btnAgregarCarrito;
        private Label lblTotal;
        private DataGridView dgvCarrito;
        private DataGridViewTextBoxColumn ProductoCarrito;
        private DataGridViewTextBoxColumn CantidadCarrito;
        private DataGridViewTextBoxColumn Precio_UnitarioCarrito;
        private DataGridViewTextBoxColumn SubtotalCarrito;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio_Unitario;
        private DataGridViewTextBoxColumn Subtotal;
        private Label lblBuscarProducto;
        private TextBox txtBuscarProducto;
    }
}