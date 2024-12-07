namespace MiTienda
{
    partial class Facturaciones
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
            label4 = new Label();
            label1 = new Label();
            BtnRegresar = new Button();
            flpProductos = new FlowLayoutPanel();
            listBoxFactura = new ListBox();
            lblTotal = new Label();
            cmbClientes = new ComboBox();
            cmbEmpleados = new ComboBox();
            btnVenta = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 47);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 6;
            label4.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(409, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 12;
            label1.Text = "Empleado:";
            // 
            // BtnRegresar
            // 
            BtnRegresar.Location = new Point(1009, 652);
            BtnRegresar.Margin = new Padding(4, 5, 4, 5);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(136, 78);
            BtnRegresar.TabIndex = 18;
            BtnRegresar.Text = "Return";
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // flpProductos
            // 
            flpProductos.AutoScroll = true;
            flpProductos.Location = new Point(30, 140);
            flpProductos.Margin = new Padding(4, 5, 4, 5);
            flpProductos.Name = "flpProductos";
            flpProductos.Size = new Size(740, 568);
            flpProductos.TabIndex = 19;
            // 
            // listBoxFactura
            // 
            listBoxFactura.FormattingEnabled = true;
            listBoxFactura.ItemHeight = 25;
            listBoxFactura.Location = new Point(804, 102);
            listBoxFactura.Margin = new Padding(4, 5, 4, 5);
            listBoxFactura.Name = "listBoxFactura";
            listBoxFactura.Size = new Size(338, 454);
            listBoxFactura.TabIndex = 20;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1009, 582);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 25);
            lblTotal.TabIndex = 21;
            lblTotal.Text = "label2";
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(163, 47);
            cmbClientes.Margin = new Padding(4, 5, 4, 5);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(171, 33);
            cmbClientes.TabIndex = 22;
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(520, 47);
            cmbEmpleados.Margin = new Padding(4, 5, 4, 5);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(171, 33);
            cmbEmpleados.TabIndex = 23;
            cmbEmpleados.SelectedIndexChanged += cmbEmpleados_SelectedIndexChanged;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(840, 650);
            btnVenta.Margin = new Padding(4, 5, 4, 5);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(147, 82);
            btnVenta.TabIndex = 24;
            btnVenta.Text = "Venta";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // Facturaciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 750);
            Controls.Add(btnVenta);
            Controls.Add(cmbEmpleados);
            Controls.Add(cmbClientes);
            Controls.Add(lblTotal);
            Controls.Add(listBoxFactura);
            Controls.Add(flpProductos);
            Controls.Add(BtnRegresar);
            Controls.Add(label1);
            Controls.Add(label4);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Facturaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNIT;
        private Label label4;
        private TextBox txtIDProducto;
        private Label label1;
        private Button BtnRegresar;
        private FlowLayoutPanel flpProductos;
        private ListBox listBoxFactura;
        private Label lblTotal;
        private ComboBox cmbClientes;
        private ComboBox cmbEmpleados;
        private Button btnVenta;
    }
}