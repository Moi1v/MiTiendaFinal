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
            NIT = new Label();
            NAME = new Label();
            Apellido = new Label();
            Direccion = new Label();
            PHONE = new Label();
            txtNIT = new TextBox();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            BtnBuscar = new Button();
            BtnEliminar = new Button();
            BtnUpdate = new Button();
            CustomerID = new Label();
            txtCustomerID = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // NIT
            // 
            NIT.AutoSize = true;
            NIT.Location = new Point(38, 85);
            NIT.Name = "NIT";
            NIT.Size = new Size(23, 15);
            NIT.TabIndex = 0;
            NIT.Text = "Nit";
            // 
            // NAME
            // 
            NAME.AutoSize = true;
            NAME.Location = new Point(38, 117);
            NAME.Name = "NAME";
            NAME.Size = new Size(51, 15);
            NAME.TabIndex = 1;
            NAME.Text = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Location = new Point(38, 146);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(51, 15);
            Apellido.TabIndex = 2;
            Apellido.Text = "Apellido";
            // 
            // Direccion
            // 
            Direccion.AutoSize = true;
            Direccion.Location = new Point(38, 175);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(57, 15);
            Direccion.TabIndex = 3;
            Direccion.Text = "Direccion";
            // 
            // PHONE
            // 
            PHONE.AutoSize = true;
            PHONE.Location = new Point(38, 204);
            PHONE.Name = "PHONE";
            PHONE.Size = new Size(52, 15);
            PHONE.TabIndex = 4;
            PHONE.Text = "Telefono";
            // 
            // txtNIT
            // 
            txtNIT.Location = new Point(107, 77);
            txtNIT.Name = "txtNIT";
            txtNIT.Size = new Size(100, 23);
            txtNIT.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(107, 109);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(107, 138);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(107, 167);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(107, 196);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlDark;
            flowLayoutPanel1.ForeColor = SystemColors.ButtonShadow;
            flowLayoutPanel1.Location = new Point(282, 42);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(446, 222);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(282, 317);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(107, 43);
            BtnBuscar.TabIndex = 11;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(395, 317);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(107, 43);
            BtnEliminar.TabIndex = 12;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(621, 315);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(107, 43);
            BtnUpdate.TabIndex = 13;
            BtnUpdate.Text = "Regresar";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // CustomerID
            // 
            CustomerID.AutoSize = true;
            CustomerID.Location = new Point(38, 56);
            CustomerID.Name = "CustomerID";
            CustomerID.Size = new Size(55, 15);
            CustomerID.TabIndex = 14;
            CustomerID.Text = "ClienteID";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(107, 48);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(100, 23);
            txtCustomerID.TabIndex = 15;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(508, 317);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 41);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(txtCustomerID);
            Controls.Add(CustomerID);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnBuscar);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txtNIT);
            Controls.Add(PHONE);
            Controls.Add(Direccion);
            Controls.Add(Apellido);
            Controls.Add(NAME);
            Controls.Add(NIT);
            Name = "Clientes";
            Text = "Clientes";
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
        private TextBox txtPhone;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BtnBuscar;
        private Button BtnEliminar;
        private Button BtnUpdate;
        private Label CustomerID;
        private TextBox txtCustomerID;
        private Button btnAgregar;
    }
}