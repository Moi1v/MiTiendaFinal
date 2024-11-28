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
            CodigoFactura = new DataGridViewTextBoxColumn();
            NombreFactura = new DataGridViewTextBoxColumn();
            CantidadFactura = new DataGridViewTextBoxColumn();
            PrecioUnitarioFactura = new DataGridViewTextBoxColumn();
            SubtotalFactura = new DataGridViewTextBoxColumn();
            lblTotalFactura = new Label();
            btnConfirmarVenta = new Button();
            btnCancelarVenta = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            SuspendLayout();
            // 
            // dgvFactura
            // 
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Columns.AddRange(new DataGridViewColumn[] { CodigoFactura, NombreFactura, CantidadFactura, PrecioUnitarioFactura, SubtotalFactura });
            dgvFactura.Location = new Point(12, 191);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(679, 392);
            dgvFactura.TabIndex = 0;
            // 
            // CodigoFactura
            // 
            CodigoFactura.HeaderText = "Codigo";
            CodigoFactura.MinimumWidth = 6;
            CodigoFactura.Name = "CodigoFactura";
            CodigoFactura.Width = 125;
            // 
            // NombreFactura
            // 
            NombreFactura.HeaderText = "Nombre";
            NombreFactura.MinimumWidth = 6;
            NombreFactura.Name = "NombreFactura";
            NombreFactura.Width = 125;
            // 
            // CantidadFactura
            // 
            CantidadFactura.HeaderText = "Cantidad";
            CantidadFactura.MinimumWidth = 6;
            CantidadFactura.Name = "CantidadFactura";
            CantidadFactura.Width = 125;
            // 
            // PrecioUnitarioFactura
            // 
            PrecioUnitarioFactura.HeaderText = "Precio Unitario";
            PrecioUnitarioFactura.MinimumWidth = 6;
            PrecioUnitarioFactura.Name = "PrecioUnitarioFactura";
            PrecioUnitarioFactura.Width = 125;
            // 
            // SubtotalFactura
            // 
            SubtotalFactura.HeaderText = "Subtotal";
            SubtotalFactura.MinimumWidth = 6;
            SubtotalFactura.Name = "SubtotalFactura";
            SubtotalFactura.Width = 125;
            // 
            // lblTotalFactura
            // 
            lblTotalFactura.AutoSize = true;
            lblTotalFactura.Location = new Point(434, 631);
            lblTotalFactura.Name = "lblTotalFactura";
            lblTotalFactura.Size = new Size(87, 20);
            lblTotalFactura.TabIndex = 1;
            lblTotalFactura.Text = "Total: Q0.00";
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Location = new Point(567, 622);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(124, 29);
            btnConfirmarVenta.TabIndex = 2;
            btnConfirmarVenta.Text = "Confirmar Venta";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Location = new Point(567, 657);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(124, 29);
            btnCancelarVenta.TabIndex = 3;
            btnCancelarVenta.Text = "Cancelar";
            btnCancelarVenta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 27);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 27);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 6;
            label3.Text = "DPI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 109);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 8;
            label5.Text = "Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 109);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 9;
            label6.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(274, 59);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 142);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(143, 142);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 15;
            // 
            // Form5Facturacioncs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 720);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label lblTotalFactura;
        private Button btnConfirmarVenta;
        private Button btnCancelarVenta;
        private DataGridViewTextBoxColumn CodigoFactura;
        private DataGridViewTextBoxColumn NombreFactura;
        private DataGridViewTextBoxColumn CantidadFactura;
        private DataGridViewTextBoxColumn PrecioUnitarioFactura;
        private DataGridViewTextBoxColumn SubtotalFactura;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}