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
            txtCode = new TextBox();
            btnBuscarProducto = new Button();
            btnAgregarCarrito = new Button();
            btnQuitarCarrito = new Button();
            btnFinalizarVenta = new Button();
            lblTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            txtStock = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(141, 89);
            txtCode.Margin = new Padding(3, 2, 3, 2);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(110, 23);
            txtCode.TabIndex = 2;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(664, 505);
            btnBuscarProducto.Margin = new Padding(3, 2, 3, 2);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(119, 22);
            btnBuscarProducto.TabIndex = 3;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.Location = new Point(664, 427);
            btnAgregarCarrito.Margin = new Padding(3, 2, 3, 2);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(119, 22);
            btnAgregarCarrito.TabIndex = 4;
            btnAgregarCarrito.Text = "Agregar al Carrito";
            btnAgregarCarrito.UseVisualStyleBackColor = true;
            // 
            // btnQuitarCarrito
            // 
            btnQuitarCarrito.Location = new Point(664, 453);
            btnQuitarCarrito.Margin = new Padding(3, 2, 3, 2);
            btnQuitarCarrito.Name = "btnQuitarCarrito";
            btnQuitarCarrito.Size = new Size(119, 22);
            btnQuitarCarrito.TabIndex = 5;
            btnQuitarCarrito.Text = "Quitar del Carrito";
            btnQuitarCarrito.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Location = new Point(664, 479);
            btnFinalizarVenta.Margin = new Padding(3, 2, 3, 2);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(119, 22);
            btnFinalizarVenta.TabIndex = 6;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.Menu;
            lblTotal.ForeColor = SystemColors.ActiveCaptionText;
            lblTotal.Location = new Point(458, 167);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(68, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total: Q0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 11;
            label1.Text = "ID De Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 12;
            label2.Text = "Cantidad";
            // 
            // txtName
            // 
            txtName.Location = new Point(141, 130);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 14;
            label3.Text = "ID De Cliente";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(141, 167);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(110, 23);
            txtDescription.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 206);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 16;
            label4.Text = "ID De Empleado";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(141, 203);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(110, 23);
            txtStock.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 111);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 19;
            label6.Text = "Precio Del Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 78);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 18;
            label5.Text = "Nombre De Producto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(458, 138);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 20;
            label7.Text = "En Stock:";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 544);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(lblTotal);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(btnQuitarCarrito);
            Controls.Add(btnAgregarCarrito);
            Controls.Add(btnBuscarProducto);
            Controls.Add(txtCode);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ventas";
            Text = "Ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCode;
        private Button btnBuscarProducto;
        private Button btnAgregarCarrito;
        private Button btnQuitarCarrito;
        private Button btnFinalizarVenta;
        private Label lblTotal;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtDescription;
        private Label label4;
        private TextBox txtStock;
        private Label label6;
        private Label label5;
        private Label label7;
    }
}