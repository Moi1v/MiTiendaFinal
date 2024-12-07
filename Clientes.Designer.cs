namespace MiTienda
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            NIT = new Label();
            NAME = new Label();
            Apellido = new Label();
            Direccion = new Label();
            PHONE = new Label();
            txtNIT = new TextBox();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtSearch = new TextBox();
            BtnBuscar = new Button();
            BtnEliminar = new Button();
            CustomerID = new Label();
            txtCustomerID = new TextBox();
            btnAgregar = new Button();
            btnactualizar = new Button();
            pictureBox1 = new PictureBox();
            dataGridViewCliente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).BeginInit();
            SuspendLayout();
            // 
            // NIT
            // 
            NIT.AutoSize = true;
            NIT.Location = new Point(54, 142);
            NIT.Margin = new Padding(4, 0, 4, 0);
            NIT.Name = "NIT";
            NIT.Size = new Size(35, 25);
            NIT.TabIndex = 0;
            NIT.Text = "Nit";
            // 
            // NAME
            // 
            NAME.AutoSize = true;
            NAME.Location = new Point(54, 195);
            NAME.Margin = new Padding(4, 0, 4, 0);
            NAME.Name = "NAME";
            NAME.Size = new Size(78, 25);
            NAME.TabIndex = 1;
            NAME.Text = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Location = new Point(54, 243);
            Apellido.Margin = new Padding(4, 0, 4, 0);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(78, 25);
            Apellido.TabIndex = 2;
            Apellido.Text = "Apellido";
            // 
            // Direccion
            // 
            Direccion.AutoSize = true;
            Direccion.Location = new Point(54, 292);
            Direccion.Margin = new Padding(4, 0, 4, 0);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(85, 25);
            Direccion.TabIndex = 3;
            Direccion.Text = "Direccion";
            // 
            // PHONE
            // 
            PHONE.AutoSize = true;
            PHONE.Location = new Point(54, 340);
            PHONE.Margin = new Padding(4, 0, 4, 0);
            PHONE.Name = "PHONE";
            PHONE.Size = new Size(67, 25);
            PHONE.TabIndex = 4;
            PHONE.Text = "Buscar:";
            // 
            // txtNIT
            // 
            txtNIT.Location = new Point(153, 128);
            txtNIT.Margin = new Padding(4, 5, 4, 5);
            txtNIT.Name = "txtNIT";
            txtNIT.Size = new Size(141, 31);
            txtNIT.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(153, 182);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(141, 31);
            txtName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(153, 230);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(141, 31);
            txtLastName.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(153, 278);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(141, 31);
            txtAddress.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(153, 327);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(141, 31);
            txtSearch.TabIndex = 9;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(403, 528);
            BtnBuscar.Margin = new Padding(4, 5, 4, 5);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(153, 72);
            BtnBuscar.TabIndex = 11;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(564, 528);
            BtnEliminar.Margin = new Padding(4, 5, 4, 5);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(153, 72);
            BtnEliminar.TabIndex = 12;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // CustomerID
            // 
            CustomerID.AutoSize = true;
            CustomerID.Location = new Point(54, 93);
            CustomerID.Margin = new Padding(4, 0, 4, 0);
            CustomerID.Name = "CustomerID";
            CustomerID.Size = new Size(83, 25);
            CustomerID.TabIndex = 14;
            CustomerID.Text = "ClienteID";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(153, 80);
            txtCustomerID.Margin = new Padding(4, 5, 4, 5);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(141, 31);
            txtCustomerID.TabIndex = 15;
            txtCustomerID.TextChanged += txtCustomerID_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(726, 528);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(153, 68);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(887, 528);
            btnactualizar.Margin = new Padding(4, 5, 4, 5);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(153, 68);
            btnactualizar.TabIndex = 17;
            btnactualizar.Text = "Actualizar Datos";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1083, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridViewCliente
            // 
            dataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCliente.Location = new Point(386, 82);
            dataGridViewCliente.Margin = new Padding(4, 5, 4, 5);
            dataGridViewCliente.Name = "dataGridViewCliente";
            dataGridViewCliente.RowHeadersWidth = 62;
            dataGridViewCliente.Size = new Size(724, 410);
            dataGridViewCliente.TabIndex = 19;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(dataGridViewCliente);
            Controls.Add(pictureBox1);
            Controls.Add(btnactualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCustomerID);
            Controls.Add(CustomerID);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnBuscar);
            Controls.Add(txtSearch);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txtNIT);
            Controls.Add(PHONE);
            Controls.Add(Direccion);
            Controls.Add(Apellido);
            Controls.Add(NAME);
            Controls.Add(NIT);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NIT;
        private Label NAME;
        private Label Apellido;
        private Label Direccion;
        private Label PHONE;
        private TextBox txtNIT;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtSearch;
        private Button BtnBuscar;
        private Button BtnEliminar;
        private Label CustomerID;
        private TextBox txtCustomerID;
        private Button btnAgregar;
        private Button btnactualizar;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewCliente;
    }
}