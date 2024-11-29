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
            BtnFinalizar = new Button();
            label4 = new Label();
            txtIDCustomer = new TextBox();
            dataGridViewFacturacion = new DataGridView();
            label1 = new Label();
            txtEmpleado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFacturacion).BeginInit();
            SuspendLayout();
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 70);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 6;
            label4.Text = "ID De Cliente";
            // 
            // txtIDCustomer
            // 
            txtIDCustomer.Location = new Point(161, 61);
            txtIDCustomer.Name = "txtIDCustomer";
            txtIDCustomer.Size = new Size(138, 23);
            txtIDCustomer.TabIndex = 8;
            // 
            // dataGridViewFacturacion
            // 
            dataGridViewFacturacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFacturacion.Location = new Point(390, 61);
            dataGridViewFacturacion.Name = "dataGridViewFacturacion";
            dataGridViewFacturacion.Size = new Size(412, 237);
            dataGridViewFacturacion.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 101);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 12;
            label1.Text = "ID Empleado";
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(161, 93);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(138, 23);
            txtEmpleado.TabIndex = 14;
            // 
            // Facturaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 450);
            Controls.Add(txtEmpleado);
            Controls.Add(label1);
            Controls.Add(dataGridViewFacturacion);
            Controls.Add(txtIDCustomer);
            Controls.Add(label4);
            Controls.Add(BtnFinalizar);
            Name = "Facturaciones";
            Text = "Facturaciones";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFacturacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNIT;
        private Button BtnFinalizar;
        private Label label4;
        private TextBox txtIDProducto;
        private TextBox txtIDCustomer;
        private DataGridView dataGridViewFacturacion;
        private Label label1;
        private TextBox txtEmpleado;
    }
}