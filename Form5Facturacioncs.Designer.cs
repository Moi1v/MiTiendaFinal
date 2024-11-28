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
            dgvFactura = new DataGridView();
            nombreFactura = new DataGridViewTextBoxColumn();
            precioUnitarioFactura = new DataGridViewTextBoxColumn();
            cantidadFactura = new DataGridViewTextBoxColumn();
            subtotalFactura = new DataGridViewTextBoxColumn();
            lblTotalFactura = new Label();
            btnConfirmarVenta = new Button();
            btnCancelarVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            SuspendLayout();
            // 
            // dgvFactura
            // 
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Columns.AddRange(new DataGridViewColumn[] { nombreFactura, precioUnitarioFactura, cantidadFactura, subtotalFactura });
            dgvFactura.Location = new Point(31, 58);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(553, 392);
            dgvFactura.TabIndex = 0;
            // 
            // nombreFactura
            // 
            nombreFactura.HeaderText = "Producto";
            nombreFactura.MinimumWidth = 6;
            nombreFactura.Name = "nombreFactura";
            nombreFactura.Width = 125;
            // 
            // precioUnitarioFactura
            // 
            precioUnitarioFactura.HeaderText = "Precio Unitario";
            precioUnitarioFactura.MinimumWidth = 6;
            precioUnitarioFactura.Name = "precioUnitarioFactura";
            precioUnitarioFactura.Width = 125;
            // 
            // cantidadFactura
            // 
            cantidadFactura.HeaderText = "Cantidad";
            cantidadFactura.MinimumWidth = 6;
            cantidadFactura.Name = "cantidadFactura";
            cantidadFactura.Width = 125;
            // 
            // subtotalFactura
            // 
            subtotalFactura.HeaderText = "Subtotal";
            subtotalFactura.MinimumWidth = 6;
            subtotalFactura.Name = "subtotalFactura";
            subtotalFactura.Width = 125;
            // 
            // lblTotalFactura
            // 
            lblTotalFactura.AutoSize = true;
            lblTotalFactura.Location = new Point(327, 499);
            lblTotalFactura.Name = "lblTotalFactura";
            lblTotalFactura.Size = new Size(87, 20);
            lblTotalFactura.TabIndex = 1;
            lblTotalFactura.Text = "Total: Q0.00";
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Location = new Point(460, 490);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(124, 29);
            btnConfirmarVenta.TabIndex = 2;
            btnConfirmarVenta.Text = "Confirmar Venta";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Location = new Point(460, 525);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(124, 29);
            btnCancelarVenta.TabIndex = 3;
            btnCancelarVenta.Text = "Cancelar";
            btnCancelarVenta.UseVisualStyleBackColor = true;
            // 
            // Form5Facturacioncs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 584);
            Controls.Add(btnCancelarVenta);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(lblTotalFactura);
            Controls.Add(dgvFactura);
            Name = "Form5Facturacioncs";
            Text = "Form5Facturacioncs";
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFactura;
        private DataGridViewTextBoxColumn nombreFactura;
        private DataGridViewTextBoxColumn precioUnitarioFactura;
        private DataGridViewTextBoxColumn cantidadFactura;
        private DataGridViewTextBoxColumn subtotalFactura;
        private Label lblTotalFactura;
        private Button btnConfirmarVenta;
        private Button btnCancelarVenta;
    }
}