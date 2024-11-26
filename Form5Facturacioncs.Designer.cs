namespace MiTienda
{
    partial class Form5Facturacioncs
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
            txtTotalFactura = new TextBox();
            lblTotalFactura = new Label();
            dgvFactura = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btnCancelar = new Button();
            btnConfirmarVenta = new Button();
            txtNombreCliente = new TextBox();
            lblNombreCliente = new Label();
            txtNIT = new TextBox();
            lblNIT = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            SuspendLayout();
            // 
            // txtTotalFactura
            // 
            txtTotalFactura.Location = new Point(377, 55);
            txtTotalFactura.Margin = new Padding(3, 2, 3, 2);
            txtTotalFactura.Name = "txtTotalFactura";
            txtTotalFactura.Size = new Size(110, 23);
            txtTotalFactura.TabIndex = 26;
            // 
            // lblTotalFactura
            // 
            lblTotalFactura.AutoSize = true;
            lblTotalFactura.Location = new Point(377, 38);
            lblTotalFactura.Name = "lblTotalFactura";
            lblTotalFactura.Size = new Size(106, 15);
            lblTotalFactura.TabIndex = 25;
            lblTotalFactura.Text = "Total de la Compra";
            // 
            // dgvFactura
            // 
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Columns.AddRange(new DataGridViewColumn[] { nombre, precio, cantidad, Subtotal });
            dgvFactura.Location = new Point(34, 98);
            dgvFactura.Margin = new Padding(3, 2, 3, 2);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(506, 202);
            dgvFactura.TabIndex = 24;
            // 
            // nombre
            // 
            nombre.HeaderText = "Producto";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // precio
            // 
            precio.HeaderText = "Cantidad";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.Width = 125;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Precio Unitario";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 125;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(559, 278);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 22);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Location = new Point(559, 251);
            btnConfirmarVenta.Margin = new Padding(3, 2, 3, 2);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(108, 22);
            btnConfirmarVenta.TabIndex = 22;
            btnConfirmarVenta.Text = "Confirmar Venta";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(185, 55);
            txtNombreCliente.Margin = new Padding(3, 2, 3, 2);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(110, 23);
            txtNombreCliente.TabIndex = 21;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(185, 38);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(110, 15);
            lblNombreCliente.TabIndex = 20;
            lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // txtNIT
            // 
            txtNIT.Location = new Point(34, 55);
            txtNIT.Margin = new Padding(3, 2, 3, 2);
            txtNIT.Name = "txtNIT";
            txtNIT.Size = new Size(110, 23);
            txtNIT.TabIndex = 19;
            // 
            // lblNIT
            // 
            lblNIT.AutoSize = true;
            lblNIT.Location = new Point(34, 38);
            lblNIT.Name = "lblNIT";
            lblNIT.Size = new Size(84, 15);
            lblNIT.TabIndex = 18;
            lblNIT.Text = "NIT del Cliente";
            // 
            // Form5Facturacioncs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 446);
            Controls.Add(txtTotalFactura);
            Controls.Add(lblTotalFactura);
            Controls.Add(dgvFactura);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblNombreCliente);
            Controls.Add(txtNIT);
            Controls.Add(lblNIT);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form5Facturacioncs";
            Text = "  Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotalFactura;
        private Label lblTotalFactura;
        private DataGridView dgvFactura;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private Button btnCancelar;
        private Button btnConfirmarVenta;
        private TextBox txtNombreCliente;
        private Label lblNombreCliente;
        private TextBox txtNIT;
        private Label lblNIT;
    }
}