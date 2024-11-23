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

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venta confirmada con éxito.");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AgregarProducto(string Producto, decimal Precio_Unitario, int Cantidad, decimal Subtotal)
        {
            dgvFactura.Rows.Add(Producto, Precio_Unitario, Cantidad, Subtotal);
        }

        public void TransferirDatosCarrito(DataGridView dgvCarrito)
        {
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (!row.IsNewRow)
                {
                    int rowIndex = dgvFactura.Rows.Add();
                    dgvFactura.Rows[rowIndex].Cells["nombre"].Value = row.Cells["ProductoCarrito"].Value;
                    dgvFactura.Rows[rowIndex].Cells["precio"].Value = row.Cells["CantidadCarrito"].Value;
                    dgvFactura.Rows[rowIndex].Cells["cantidad"].Value = row.Cells["Precio_UnitarioCarrito"].Value;
                    dgvFactura.Rows[rowIndex].Cells["Subtotal"].Value = row.Cells["SubtotalCarrito"].Value;
                }
            }
        }
    }
}
