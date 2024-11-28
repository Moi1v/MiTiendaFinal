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
                if (!row.IsNewRow)
                {
                    total += Convert.ToDecimal(row.Cells["subtotalCarrito"].Value);
                }
            }
            lblTotal.Text = "Total: Q" + total.ToString("F2");
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarProducto.Text.Trim().ToLower();
            bool encontrado = false;

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Cells["productoVentas"].Value != null)
                {
                    string nombreProducto = row.Cells["productoVentas"].Value.ToString().ToLower();

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

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                var fila = dgvProductos.SelectedRows[0];
                string nombre = fila.Cells["productoVentas"].Value.ToString();
                decimal precio = Convert.ToDecimal(fila.Cells["precioVentas"].Value);
                int stock = Convert.ToInt32(fila.Cells["stockVentas"].Value);

                if (stock > 0)
                {
                    int cantidad = 1;
                    decimal subtotal = precio * cantidad;

                    dgvCarrito.Rows.Add(nombre, precio, cantidad, subtotal);

                    fila.Cells["stockVentas"].Value = stock - 1;

                    ActualizarTotal();
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock disponible para este producto.");
                }
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
                var fila = dgvCarrito.SelectedRows[0];
                string nombre = fila.Cells["nombreCarrito"].Value.ToString();

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if (row.Cells["productoVentas"].Value.ToString() == nombre)
                    {
                        row.Cells["stockVentas"].Value = Convert.ToInt32(row.Cells["stockVentas"].Value) + 1;
                        break;
                    }
                }

                dgvCarrito.Rows.Remove(fila);
                ActualizarTotal();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para quitar del carrito.");
            }
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.Rows.Count > 0)
            {
                Form5Facturacioncs facturacion = new Form5Facturacioncs();

                foreach (DataGridViewRow row in dgvCarrito.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string nombre = row.Cells["nombreCarrito"].Value.ToString();
                        decimal precio = Convert.ToDecimal(row.Cells["precioUnitarioCarrito"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["cantidadCarrito"].Value);
                        decimal subtotal = Convert.ToDecimal(row.Cells["subtotalCarrito"].Value);

                        facturacion.AgregarProducto(nombre, precio, cantidad, subtotal);
                    }
                }

                facturacion.Total = lblTotal.Text;
                facturacion.ShowDialog();
            }
            else
            {
                MessageBox.Show("El carrito está vacío. No se puede finalizar la venta.");
            }
        }
    }
}