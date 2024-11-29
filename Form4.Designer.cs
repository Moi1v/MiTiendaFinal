namespace MiTienda
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtCode = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            BtnSave = new Button();
            Btnmostrar = new Button();
            BtnRefresh = new Button();
            BtnDelete = new Button();
            dataGridViewProductos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            label6 = new Label();
            textBoxProductID = new TextBox();
            BtnRegresar = new Button();
            pictureBoxProducto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 85);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 119);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 153);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 189);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 225);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 4;
            label5.Text = "cantidad en inventario";
            // 
            // TxtCode
            // 
            TxtCode.Location = new Point(185, 72);
            TxtCode.Margin = new Padding(3, 4, 3, 4);
            TxtCode.Name = "TxtCode";
            TxtCode.Size = new Size(114, 27);
            TxtCode.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(185, 108);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(185, 143);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(114, 27);
            txtDescription.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(185, 179);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(114, 27);
            txtPrice.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(185, 215);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(114, 27);
            txtStock.TabIndex = 9;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(561, 503);
            BtnSave.Margin = new Padding(3, 4, 3, 4);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(109, 55);
            BtnSave.TabIndex = 10;
            BtnSave.Text = "Guardar";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // Btnmostrar
            // 
            Btnmostrar.Location = new Point(677, 503);
            Btnmostrar.Margin = new Padding(3, 4, 3, 4);
            Btnmostrar.Name = "Btnmostrar";
            Btnmostrar.Size = new Size(109, 55);
            Btnmostrar.TabIndex = 11;
            Btnmostrar.Text = "Mostrar";
            Btnmostrar.UseVisualStyleBackColor = true;
            Btnmostrar.Click += Btnconsult_Click;
            // 
            // BtnRefresh
            // 
            BtnRefresh.Location = new Point(792, 503);
            BtnRefresh.Margin = new Padding(3, 4, 3, 4);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(109, 55);
            BtnRefresh.TabIndex = 12;
            BtnRefresh.Text = "Actualizar";
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(907, 503);
            BtnDelete.Margin = new Padding(3, 4, 3, 4);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(109, 55);
            BtnDelete.TabIndex = 13;
            BtnDelete.Text = "Eliminar";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Descripcion, Precio, Cantidad });
            dataGridViewProductos.Location = new Point(341, 21);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.Size = new Size(678, 367);
            dataGridViewProductos.TabIndex = 14;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 44);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 15;
            label6.Text = "ProductID";
            // 
            // textBoxProductID
            // 
            textBoxProductID.Location = new Point(185, 33);
            textBoxProductID.Margin = new Padding(3, 4, 3, 4);
            textBoxProductID.Name = "textBoxProductID";
            textBoxProductID.Size = new Size(114, 27);
            textBoxProductID.TabIndex = 16;
            // 
            // BtnRegresar
            // 
            BtnRegresar.Location = new Point(446, 503);
            BtnRegresar.Margin = new Padding(3, 4, 3, 4);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(109, 55);
            BtnRegresar.TabIndex = 17;
            BtnRegresar.Text = "Return";
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // pictureBoxProducto
            // 
            pictureBoxProducto.Location = new Point(31, 326);
            pictureBoxProducto.Name = "pictureBoxProducto";
            pictureBoxProducto.Size = new Size(283, 262);
            pictureBoxProducto.TabIndex = 18;
            pictureBoxProducto.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 600);
            Controls.Add(pictureBoxProducto);
            Controls.Add(BtnRegresar);
            Controls.Add(textBoxProductID);
            Controls.Add(label6);
            Controls.Add(dataGridViewProductos);
            Controls.Add(BtnDelete);
            Controls.Add(BtnRefresh);
            Controls.Add(Btnmostrar);
            Controls.Add(BtnSave);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(TxtCode);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtCode;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Button BtnSave;
        private Button Btnmostrar;
        private Button BtnRefresh;
        private Button BtnDelete;
        private DataGridView dataGridViewProductos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private Label label6;
        private TextBox textBoxProductID;
        private Button BtnRegresar;
        private PictureBox pictureBoxProducto;
    }
}