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
            BtnRefresh = new Button();
            BtnDelete = new Button();
            dataGridViewProductos = new DataGridView();
            label6 = new Label();
            textBoxProductID = new TextBox();
            BtnRegresar = new Button();
            pictureBoxProducto = new PictureBox();
            BtnSeleccionarImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 107);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 148);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 192);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 2;
            label3.Text = "Descripccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 237);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 282);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(187, 25);
            label5.TabIndex = 4;
            label5.Text = "cantidad en inventario";
            // 
            // TxtCode
            // 
            TxtCode.Location = new Point(231, 90);
            TxtCode.Margin = new Padding(4, 5, 4, 5);
            TxtCode.Name = "TxtCode";
            TxtCode.Size = new Size(141, 31);
            TxtCode.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(231, 135);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(141, 31);
            txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(231, 178);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(141, 31);
            txtDescription.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(231, 223);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(141, 31);
            txtPrice.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(231, 268);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(141, 31);
            txtStock.TabIndex = 9;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(701, 628);
            BtnSave.Margin = new Padding(4, 5, 4, 5);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(136, 68);
            BtnSave.TabIndex = 10;
            BtnSave.Text = "Guardar";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnRefresh
            // 
            BtnRefresh.Location = new Point(846, 628);
            BtnRefresh.Margin = new Padding(4, 5, 4, 5);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(136, 68);
            BtnRefresh.TabIndex = 12;
            BtnRefresh.Text = "Actualizar";
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(990, 628);
            BtnDelete.Margin = new Padding(4, 5, 4, 5);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(136, 68);
            BtnDelete.TabIndex = 13;
            BtnDelete.Text = "Eliminar";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(426, 27);
            dataGridViewProductos.Margin = new Padding(4, 3, 4, 3);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.Size = new Size(847, 573);
            dataGridViewProductos.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 55);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 15;
            label6.Text = "ProductID";
            // 
            // textBoxProductID
            // 
            textBoxProductID.Location = new Point(231, 42);
            textBoxProductID.Margin = new Padding(4, 5, 4, 5);
            textBoxProductID.Name = "textBoxProductID";
            textBoxProductID.Size = new Size(141, 31);
            textBoxProductID.TabIndex = 16;
            textBoxProductID.TextChanged += textBoxProductID_TextChanged;
            // 
            // BtnRegresar
            // 
            BtnRegresar.Location = new Point(557, 628);
            BtnRegresar.Margin = new Padding(4, 5, 4, 5);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(136, 68);
            BtnRegresar.TabIndex = 17;
            BtnRegresar.Text = "Return";
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // pictureBoxProducto
            // 
            pictureBoxProducto.Location = new Point(39, 315);
            pictureBoxProducto.Margin = new Padding(4, 3, 4, 3);
            pictureBoxProducto.Name = "pictureBoxProducto";
            pictureBoxProducto.Size = new Size(336, 338);
            pictureBoxProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProducto.TabIndex = 18;
            pictureBoxProducto.TabStop = false;
            // 
            // BtnSeleccionarImagen
            // 
            BtnSeleccionarImagen.Location = new Point(39, 662);
            BtnSeleccionarImagen.Margin = new Padding(4, 5, 4, 5);
            BtnSeleccionarImagen.Name = "BtnSeleccionarImagen";
            BtnSeleccionarImagen.Size = new Size(336, 68);
            BtnSeleccionarImagen.TabIndex = 19;
            BtnSeleccionarImagen.Text = "Seleccionar Imagen";
            BtnSeleccionarImagen.UseVisualStyleBackColor = true;
            BtnSeleccionarImagen.Click += BtnSeleccionarImagen_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 750);
            Controls.Add(BtnSeleccionarImagen);
            Controls.Add(pictureBoxProducto);
            Controls.Add(BtnRegresar);
            Controls.Add(textBoxProductID);
            Controls.Add(label6);
            Controls.Add(dataGridViewProductos);
            Controls.Add(BtnDelete);
            Controls.Add(BtnRefresh);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button BtnRefresh;
        private Button BtnDelete;
        private DataGridView dataGridViewProductos;
        private Label label6;
        private TextBox textBoxProductID;
        private Button BtnRegresar;
        private PictureBox pictureBoxProducto;
        private Button BtnSeleccionarImagen;
    }
}