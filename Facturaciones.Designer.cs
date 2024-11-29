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
            label1 = new Label();
            label2 = new Label();
            txtNIT = new TextBox();
            txtIDVenta = new TextBox();
            BtnFinalizar = new Button();
            label3 = new Label();
            label4 = new Label();
            txtIDProducto = new TextBox();
            txtStock = new TextBox();
            dataGridViewFacturacion = new DataGridView();
            label5 = new Label();
            txtPriceF = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFacturacion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 69);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "NIT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 110);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "ID Venta";
            // 
            // txtNIT
            // 
            txtNIT.Location = new Point(161, 61);
            txtNIT.Name = "txtNIT";
            txtNIT.Size = new Size(138, 23);
            txtNIT.TabIndex = 2;
            // 
            // txtIDVenta
            // 
            txtIDVenta.Location = new Point(161, 102);
            txtIDVenta.Name = "txtIDVenta";
            txtIDVenta.Size = new Size(138, 23);
            txtIDVenta.TabIndex = 3;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.Location = new Point(161, 298);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(107, 47);
            BtnFinalizar.TabIndex = 4;
            BtnFinalizar.Text = "Guardar Venta";
            BtnFinalizar.UseVisualStyleBackColor = true;
            BtnFinalizar.Click += BtnFinalizar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 148);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "ID Del Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 184);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 6;
            label4.Text = "Cantidad Vendida";
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(161, 140);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(138, 23);
            txtIDProducto.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(161, 175);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(138, 23);
            txtStock.TabIndex = 8;
            // 
            // dataGridViewFacturacion
            // 
            dataGridViewFacturacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFacturacion.Location = new Point(390, 61);
            dataGridViewFacturacion.Name = "dataGridViewFacturacion";
            dataGridViewFacturacion.Size = new Size(412, 237);
            dataGridViewFacturacion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 219);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 10;
            label5.Text = "Precio Final";
            // 
            // txtPriceF
            // 
            txtPriceF.Location = new Point(161, 211);
            txtPriceF.Name = "txtPriceF";
            txtPriceF.Size = new Size(138, 23);
            txtPriceF.TabIndex = 11;
            // 
            // Facturaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 450);
            Controls.Add(txtPriceF);
            Controls.Add(label5);
            Controls.Add(dataGridViewFacturacion);
            Controls.Add(txtStock);
            Controls.Add(txtIDProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BtnFinalizar);
            Controls.Add(txtIDVenta);
            Controls.Add(txtNIT);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Facturaciones";
            Text = "Facturaciones";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFacturacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNIT;
        private TextBox txtIDVenta;
        private Button BtnFinalizar;
        private Label label3;
        private Label label4;
        private TextBox txtIDProducto;
        private TextBox txtStock;
        private DataGridView dataGridViewFacturacion;
        private Label label5;
        private TextBox txtPriceF;
    }
}