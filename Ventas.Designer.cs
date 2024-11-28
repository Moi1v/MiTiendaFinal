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
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            DescipcionProducto = new DataGridViewTextBoxColumn();
            PrecioProducto = new DataGridViewTextBoxColumn();
            CantidadProducto = new DataGridViewTextBoxColumn();
            dgvCarrito = new DataGridView();
            CodigoCarrito = new DataGridViewTextBoxColumn();
            NombreCarrito = new DataGridViewTextBoxColumn();
            CantidadCarrito = new DataGridViewTextBoxColumn();
            PrecioCarrito = new DataGridViewTextBoxColumn();
            SubtotalCarrito = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            btnBuscarProducto = new Button();
            btnAgregarCarrito = new Button();
            btnQuitarCarrito = new Button();
            btnFinalizarVenta = new Button();
            lblTotal = new Label();
            label1 = new Label();
            numericCantidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { CodigoProducto, NombreProducto, DescipcionProducto, PrecioProducto, CantidadProducto });
            dgvProductos.Location = new Point(27, 111);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(679, 436);
            dgvProductos.TabIndex = 0;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo";
            CodigoProducto.MinimumWidth = 6;
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.Width = 125;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre";
            NombreProducto.MinimumWidth = 6;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Width = 125;
            // 
            // DescipcionProducto
            // 
            DescipcionProducto.HeaderText = "Descripcion";
            DescipcionProducto.MinimumWidth = 6;
            DescipcionProducto.Name = "DescipcionProducto";
            DescipcionProducto.Width = 125;
            // 
            // PrecioProducto
            // 
            PrecioProducto.HeaderText = "Precio";
            PrecioProducto.MinimumWidth = 6;
            PrecioProducto.Name = "PrecioProducto";
            PrecioProducto.Width = 125;
            // 
            // CantidadProducto
            // 
            CantidadProducto.HeaderText = "Cantidad";
            CantidadProducto.MinimumWidth = 6;
            CantidadProducto.Name = "CantidadProducto";
            CantidadProducto.Width = 125;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { CodigoCarrito, NombreCarrito, CantidadCarrito, PrecioCarrito, SubtotalCarrito });
            dgvCarrito.Location = new Point(745, 111);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new Size(670, 436);
            dgvCarrito.TabIndex = 1;
            // 
            // CodigoCarrito
            // 
            CodigoCarrito.HeaderText = "Codigo";
            CodigoCarrito.MinimumWidth = 6;
            CodigoCarrito.Name = "CodigoCarrito";
            CodigoCarrito.Width = 125;
            // 
            // NombreCarrito
            // 
            NombreCarrito.HeaderText = "Nombre";
            NombreCarrito.MinimumWidth = 6;
            NombreCarrito.Name = "NombreCarrito";
            NombreCarrito.Width = 125;
            // 
            // CantidadCarrito
            // 
            CantidadCarrito.HeaderText = "Cantidad";
            CantidadCarrito.MinimumWidth = 6;
            CantidadCarrito.Name = "CantidadCarrito";
            CantidadCarrito.Width = 125;
            // 
            // PrecioCarrito
            // 
            PrecioCarrito.HeaderText = "Precio";
            PrecioCarrito.MinimumWidth = 6;
            PrecioCarrito.Name = "PrecioCarrito";
            PrecioCarrito.Width = 125;
            // 
            // SubtotalCarrito
            // 
            SubtotalCarrito.HeaderText = "Subtotal";
            SubtotalCarrito.MinimumWidth = 6;
            SubtotalCarrito.Name = "SubtotalCarrito";
            SubtotalCarrito.Width = 125;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(27, 65);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 2;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(1279, 675);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(136, 29);
            btnBuscarProducto.TabIndex = 3;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.Location = new Point(1279, 570);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(136, 29);
            btnAgregarCarrito.TabIndex = 4;
            btnAgregarCarrito.Text = "Agregar al Carrito";
            btnAgregarCarrito.UseVisualStyleBackColor = true;
            // 
            // btnQuitarCarrito
            // 
            btnQuitarCarrito.Location = new Point(1279, 605);
            btnQuitarCarrito.Name = "btnQuitarCarrito";
            btnQuitarCarrito.Size = new Size(136, 29);
            btnQuitarCarrito.TabIndex = 5;
            btnQuitarCarrito.Text = "Quitar del Carrito";
            btnQuitarCarrito.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Location = new Point(1279, 640);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(136, 29);
            btnFinalizarVenta.TabIndex = 6;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1146, 574);
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
            // numericCantidad
            // 
            numericCantidad.Location = new Point(176, 66);
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(150, 27);
            numericCantidad.TabIndex = 9;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 726);
            Controls.Add(numericCantidad);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(btnQuitarCarrito);
            Controls.Add(btnAgregarCarrito);
            Controls.Add(btnBuscarProducto);
            Controls.Add(txtBuscar);
            Controls.Add(dgvCarrito);
            Controls.Add(dgvProductos);
            Name = "Ventas";
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private DataGridView dgvCarrito;
        private TextBox txtBuscar;
        private Button btnBuscarProducto;
        private Button btnAgregarCarrito;
        private Button btnQuitarCarrito;
        private Button btnFinalizarVenta;
        private Label lblTotal;
        private Label label1;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn DescipcionProducto;
        private DataGridViewTextBoxColumn PrecioProducto;
        private DataGridViewTextBoxColumn CantidadProducto;
        private DataGridViewTextBoxColumn CodigoCarrito;
        private DataGridViewTextBoxColumn NombreCarrito;
        private DataGridViewTextBoxColumn CantidadCarrito;
        private DataGridViewTextBoxColumn PrecioCarrito;
        private DataGridViewTextBoxColumn SubtotalCarrito;
        private NumericUpDown numericCantidad;
    }
}