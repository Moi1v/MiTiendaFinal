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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void ActualizarTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                total += Convert.ToDecimal(row.Cells["subtotalCarrito"].Value);
            }
            lblTotal.Text = "Q" + total.ToString("F2");
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                string nombre = dgvProductos.SelectedRows[0].Cells["nombreProducto"].Value.ToString();
                decimal precio = Convert.ToDecimal(dgvProductos.SelectedRows[0].Cells["precioUnitario"].Value);
                int cantidad = 1;
                decimal subtotal = precio * cantidad;

                dgvCarrito.Rows.Add(nombre, cantidad, precio, subtotal);

                ActualizarTotal();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para agregar al carrito.");
            }
        }

        private void btnQuitarCarrito_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                var selectedRow = dgvCarrito.SelectedRows[0];
                bool filaVacia = selectedRow.Cells["nombreProductoCarrito"].Value == null ||
                                 selectedRow.Cells["cantidadCarrito"].Value == null ||
                                 selectedRow.Cells["precioUnitarioCarrito"].Value == null ||
                                 selectedRow.Cells["subtotalCarrito"].Value == null;

                if (filaVacia)
                {
                    MessageBox.Show("La fila seleccionada está vacía. No se puede eliminar.");
                }
                else
                {
                    dgvCarrito.Rows.RemoveAt(selectedRow.Index);
                    ActualizarTotal();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila válida para quitar del carrito.");
            }
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            bool datosCompletos = true;

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells["nombreProductoCarrito"].Value == null ||
                        row.Cells["cantidadCarrito"].Value == null ||
                        row.Cells["precioUnitarioCarrito"].Value == null ||
                        row.Cells["subtotalCarrito"].Value == null)
                    {
                        datosCompletos = false;
                        break;
                    }
                }
            }

            if (!datosCompletos)
            {
                MessageBox.Show("Uno o más productos en el carrito tienen datos incompletos.");
            }
            else
            {
                Form5Facturacioncs facturacionForm = new Form5Facturacioncs();

                facturacionForm.TransferirDatosCarrito(dgvCarrito);

                facturacionForm.Show();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarProducto.Text.Trim().ToLower();
            bool encontrado = false;

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Cells["nombreProducto"].Value != null)
                {
                    string nombreProducto = row.Cells["nombreProducto"].Value.ToString().ToLower();

                    if (nombreProducto.Contains(filtro))
                    {
                        row.Selected = true;
                        dgvProductos.FirstDisplayedScrollingRowIndex = row.Index;
                        encontrado = true;
                        break;
                    }
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Producto no encontrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
