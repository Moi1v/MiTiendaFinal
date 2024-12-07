namespace MiTienda
{
    partial class Employee
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtLastname = new TextBox();
            txtID = new TextBox();
            txtCargo = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            BtnEliminar = new Button();
            BtnActualizar = new Button();
            button4 = new Button();
            label7 = new Label();
            txtEmployeeID = new TextBox();
            dataGridViewEmployee = new DataGridView();
            txtSearch = new TextBox();
            PHONE = new Label();
            BtnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 58);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 87);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 114);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 3;
            label3.Text = "DPI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 141);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Cargo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 167);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 5;
            label5.Text = "Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 197);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 6;
            label6.Text = "Contraseña";
            // 
            // txtName
            // 
            txtName.Location = new Point(121, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 23);
            txtName.TabIndex = 7;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(121, 79);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(152, 23);
            txtLastname.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(121, 108);
            txtID.Name = "txtID";
            txtID.Size = new Size(152, 23);
            txtID.TabIndex = 9;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(121, 138);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(152, 23);
            txtCargo.TabIndex = 10;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(121, 164);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(152, 23);
            txtUser.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(121, 193);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(152, 23);
            txtPassword.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(366, 21);
            button1.Name = "button1";
            button1.Size = new Size(100, 34);
            button1.TabIndex = 13;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(366, 64);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(100, 34);
            BtnEliminar.TabIndex = 14;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(366, 108);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(100, 34);
            BtnActualizar.TabIndex = 15;
            BtnActualizar.Text = "Actualizar Datos";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += BtnMostrar_Click;
            // 
            // button4
            // 
            button4.Location = new Point(366, 148);
            button4.Name = "button4";
            button4.Size = new Size(100, 34);
            button4.TabIndex = 16;
            button4.Text = "Regresar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 26);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 17;
            label7.Text = "ID Empleado";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(121, 21);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(152, 23);
            txtEmployeeID.TabIndex = 18;
            // 
            // dataGridViewEmployee
            // 
            dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployee.Location = new Point(41, 235);
            dataGridViewEmployee.Name = "dataGridViewEmployee";
            dataGridViewEmployee.Size = new Size(728, 239);
            dataGridViewEmployee.TabIndex = 19;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(564, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 21;
            // 
            // PHONE
            // 
            PHONE.AutoSize = true;
            PHONE.Location = new Point(495, 26);
            PHONE.Name = "PHONE";
            PHONE.Size = new Size(45, 15);
            PHONE.TabIndex = 20;
            PHONE.Text = "Buscar:";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(366, 188);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(100, 28);
            BtnBuscar.TabIndex = 22;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(BtnBuscar);
            Controls.Add(txtSearch);
            Controls.Add(PHONE);
            Controls.Add(dataGridViewEmployee);
            Controls.Add(txtEmployeeID);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnEliminar);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(txtCargo);
            Controls.Add(txtID);
            Controls.Add(txtLastname);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtLastname;
        private TextBox txtID;
        private TextBox txtCargo;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button button1;
        private Button BtnEliminar;
        private Button BtnActualizar;
        private Button button4;
        private Label label7;
        private TextBox txtEmployeeID;
        private DataGridView dataGridViewEmployee;
        private TextBox txtSearch;
        private Label PHONE;
        private Button BtnBuscar;
    }
}