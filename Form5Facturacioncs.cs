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
    public partial class Form5Facturacioncs : Form
    {
        public Form5Facturacioncs()
        {
            InitializeComponent();
        }

        public string Total
        {
            get { return lblTotalFactura.Text; }
            set { lblTotalFactura.Text = value; }
        }

        public void AgregarProducto(string nombre, decimal precio, int cantidad, decimal subtotal)
        {
            dgvFactura.Rows.Add(nombre, precio, cantidad, subtotal);
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venta confirmada con éxito. ¡Gracias por su compra!");
            this.Close();
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea cancelar la venta?", "Cancelar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}