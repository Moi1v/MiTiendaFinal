using Microsoft.Data.SqlClient;
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
        string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=True;";

        private DataTable carrito = new DataTable();

        public Ventas()
        {
            InitializeComponent();
            InitializeCarrito();
        }

        private void InitializeCarrito()
        {

            carrito.Columns.Add("ProductID", typeof(int));
            carrito.Columns.Add("Name", typeof(string));
            carrito.Columns.Add("Price", typeof(decimal));
            carrito.Columns.Add("Quantity", typeof(int));
            carrito.Columns.Add("Total", typeof(decimal));
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            string query = "SELECT ProductID, Code, Name, Price FROM Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable productsTable = new DataTable();
                    adapter.Fill(productsTable);
                    dataGridViewProducts.DataSource = productsTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los productos: {ex.Message}");
                }
            }
        }

        private void textBoxSearch_TextChanged_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                string query = "SELECT ProductID, Code, Name, Price FROM Products WHERE Name LIKE @Search OR Code LIKE @Search";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + searchText + "%");
                        DataTable productsTable = new DataTable();
                        adapter.Fill(productsTable);
                        dataGridViewProducts.DataSource = productsTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al buscar productos: {ex.Message}");
                    }
                }
            }
            else
            {
                LoadProducts();
            }
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells["ProductID"].Value);
                string productName = dataGridViewProducts.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                decimal productPrice = Convert.ToDecimal(dataGridViewProducts.Rows[e.RowIndex].Cells["Price"].Value);

                bool productExists = false;
                foreach (DataRow row in carrito.Rows)
                {
                    if (Convert.ToInt32(row["ProductID"]) == productId)
                    {
                        row["Quantity"] = Convert.ToInt32(row["Quantity"]) + 1;
                        row["Total"] = Convert.ToDecimal(row["Quantity"]) * productPrice;
                        productExists = true;
                        break;
                    }
                }

                // Si el producto no existe en el carrito, agregarlo
                if (!productExists)
                {
                    carrito.Rows.Add(productId, productName, productPrice, 1, productPrice);
                }

                UpdateTotal();  // Actualizar el total del carrito
            }
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in carrito.Rows)
            {
                total += Convert.ToDecimal(row["Total"]);
            }
            Total.Text = $"Total: {total:C2}";
        }

        private void buttonConfirmSale_Click(object sender, EventArgs e)
        {
            // Pasar el carrito al formulario Facturaciones
            if (carrito.Rows.Count > 0)
            {
                decimal total = 0;
                foreach (DataRow row in carrito.Rows)
                {
                    total += Convert.ToDecimal(row["Total"]);
                }

                MessageBox.Show($"Venta confirmada. Total: {total:C2}");

                // Crea una nueva instancia de Facturaciones y pasa el carrito
                Facturaciones facturacionForm = new Facturaciones(carrito);
                facturacionForm.Show();

                // Oculta el formulario actual
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún producto.");
            }


        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            Menu Return = new Menu();
            Return.Show();
            this.Hide();
        }
    }
}
