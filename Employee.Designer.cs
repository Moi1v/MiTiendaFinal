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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtLastname = new TextBox();
            txtDPI = new TextBox();
            txtCargo = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            BtnEliminar = new Button();
            BtnMostrar = new Button();
            button4 = new Button();
            label7 = new Label();
            txtEmployeeID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 283);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 312);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 339);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 3;
            label3.Text = "DPI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 366);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Cargo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 392);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 5;
            label5.Text = "Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 422);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 6;
            label6.Text = "Contraseña";
            // 
            // txtName
            // 
            txtName.Location = new Point(98, 275);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 23);
            txtName.TabIndex = 7;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(98, 304);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(152, 23);
            txtLastname.TabIndex = 8;
            // 
            // txtDPI
            // 
            txtDPI.Location = new Point(98, 333);
            txtDPI.Name = "txtDPI";
            txtDPI.Size = new Size(152, 23);
            txtDPI.TabIndex = 9;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(98, 363);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(152, 23);
            txtCargo.TabIndex = 10;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(98, 389);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(152, 23);
            txtUser.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(98, 418);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(152, 23);
            txtPassword.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(345, 269);
            button1.Name = "button1";
            button1.Size = new Size(100, 34);
            button1.TabIndex = 13;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(345, 312);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(100, 34);
            BtnEliminar.TabIndex = 14;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnMostrar
            // 
            BtnMostrar.Location = new Point(345, 356);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(100, 34);
            BtnMostrar.TabIndex = 15;
            BtnMostrar.Text = "Mostrar";
            BtnMostrar.UseVisualStyleBackColor = true;
            BtnMostrar.Click += BtnMostrar_Click;
            // 
            // button4
            // 
            button4.Location = new Point(345, 396);
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
            label7.Location = new Point(17, 251);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 17;
            label7.Text = "ID Empleado";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(98, 246);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(152, 23);
            txtEmployeeID.TabIndex = 18;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(txtEmployeeID);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(BtnMostrar);
            Controls.Add(BtnEliminar);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(txtCargo);
            Controls.Add(txtDPI);
            Controls.Add(txtLastname);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Employee";
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtLastname;
        private TextBox txtDPI;
        private TextBox txtCargo;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button button1;
        private Button BtnEliminar;
        private Button BtnMostrar;
        private Button button4;
        private Label label7;
        private TextBox txtEmployeeID;
    }
}