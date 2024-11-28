using System;
using System.Windows.Forms;

namespace MiTienda
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Lógica para buscar productos en dgvProductos según Código o Nombre
            string busqueda = txtBuscar.Text.ToLower();

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                bool coincide = row.Cells["CodigoProducto"].Value.ToString().ToLower().Contains(busqueda) ||
                                row.Cells["NombreProducto"].Value.ToString().ToLower().Contains(busqueda);

                row.Visible = coincide;
            }
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            // Obtener el producto seleccionado
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProductos.SelectedRows[0];

                string codigo = row.Cells["CodigoProducto"].Value.ToString();
                string nombre = row.Cells["NombreProducto"].Value.ToString();
                decimal precio = Convert.ToDecimal(row.Cells["PrecioProducto"].Value);
                int cantidadDisponible = Convert.ToInt32(row.Cells["CantidadProducto"].Value);

                // Pedir cantidad a agregar
                int cantidad = Convert.ToInt32(numericCantidad.Value);

                if (cantidad > 0 && cantidad <= cantidadDisponible)
                {
                    // Calcular subtotal
                    decimal subtotal = cantidad * precio;

                    // Agregar al carrito
                    dgvCarrito.Rows.Add(codigo, nombre, cantidad, precio, subtotal);

                    // Actualizar inventario
                    row.Cells["CantidadProducto"].Value = cantidadDisponible - cantidad;

                    ActualizarTotal();
                }
                else
                {
                    MessageBox.Show("Cantidad inválida o insuficiente en inventario.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para agregar al carrito.");
            }
        }

        private void btnQuitarCarrito_Click(object sender, EventArgs e)
        {
            // Quitar producto seleccionado del carrito
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCarrito.SelectedRows[0];

                string codigo = row.Cells["CodigoCarrito"].Value.ToString();
                int cantidad = Convert.ToInt32(row.Cells["CantidadCarrito"].Value);

                // Devolver cantidad al inventario
                foreach (DataGridViewRow prodRow in dgvProductos.Rows)
                {
                    if (prodRow.Cells["CodigoProducto"].Value.ToString() == codigo)
                    {
                        prodRow.Cells["CantidadProducto"].Value =
                            Convert.ToInt32(prodRow.Cells["CantidadProducto"].Value) + cantidad;
                        break;
                    }
                }

                dgvCarrito.Rows.Remove(row);
                ActualizarTotal();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para quitar del carrito.");
            }
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            // Transferir datos del carrito al formulario de facturación
            Form5Facturacioncs formFacturacion = new Form5Facturacioncs();

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (!row.IsNewRow)
                {
                    formFacturacion.AgregarProducto(
                        row.Cells["CodigoCarrito"].Value.ToString(),
                        row.Cells["NombreCarrito"].Value.ToString(),
                        Convert.ToInt32(row.Cells["CantidadCarrito"].Value),
                        Convert.ToDecimal(row.Cells["PrecioUnitarioCarrito"].Value),
                        Convert.ToDecimal(row.Cells["SubtotalCarrito"].Value)
                    );
                }
            }

            formFacturacion.Total = lblTotal.Text;
            formFacturacion.Show();
        }

        private void ActualizarTotal()
        {
            // Calcular el total del carrito
            decimal total = 0;

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (!row.IsNewRow)
                {
                    total += Convert.ToDecimal(row.Cells["SubtotalCarrito"].Value);
                }
            }

            lblTotal.Text = total.ToString("C2");
        }
    }
}
