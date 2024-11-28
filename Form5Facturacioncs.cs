using System;
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

        public void AgregarProducto(string codigo, string nombre, int cantidad, decimal precioUnitario, decimal subtotal)
        {
            dgvFactura.Rows.Add(codigo, nombre, cantidad, precioUnitario, subtotal);
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venta confirmada con éxito.");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venta cancelada.");
            this.Close();
        }
    }
}
