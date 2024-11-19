using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiTienda
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = txtUsuario.Text;
            string nuevaContrasena = txtContrasena.Text;
            string correo = txtCorreo.Text; 

            
            if (!string.IsNullOrEmpty(nuevoUsuario) && !string.IsNullOrEmpty(nuevaContrasena))
            {
                MessageBox.Show("Usuario registrado exitosamente.");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
