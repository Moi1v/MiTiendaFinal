using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

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
            string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=True;";

            // Datos de la venta
            int customerID, employeeID, productID, quantity;
            decimal price, total;

            // Validar entradas
            if (!int.TryParse(txtCustomerID.Text.Trim(), out customerID) ||
                !int.TryParse(txtEmployeeID.Text.Trim(), out employeeID) ||
                !int.TryParse(txtProductID.Text.Trim(), out productID) ||
                !int.TryParse(txtQuantity.Text.Trim(), out quantity) ||
                quantity <= 0)
            {
                MessageBox.Show("Por favor, ingresa valores válidos para Cliente, Empleado, Producto y Cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Obtener el precio del producto
                    string queryPrice = "SELECT Price, Stock FROM Products WHERE ProductID = @ProductID";
                    using (SqlCommand commandPrice = new SqlCommand(queryPrice, connection))
                    {
                        commandPrice.Parameters.AddWithValue("@ProductID", productID);
                        using (SqlDataReader reader = commandPrice.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                price = Convert.ToDecimal(reader["Price"]);
                                int stock = Convert.ToInt32(reader["Stock"]);

                                // Validar stock disponible
                                if (quantity > stock)
                                {
                                    MessageBox.Show("Stock insuficiente para la cantidad solicitada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // Calcular total
                    total = price * quantity;

                    // Insertar venta en la tabla Sales
                    string querySale = @"INSERT INTO Sales (SaleDate, CustomerID, EmployeeID, Total) 
                                 VALUES (@SaleDate, @CustomerID, @EmployeeID, @Total);
                                 SELECT SCOPE_IDENTITY();";

                    int saleID;
                    using (SqlCommand commandSale = new SqlCommand(querySale, connection))
                    {
                        commandSale.Parameters.AddWithValue("@SaleDate", DateTime.Now);
                        commandSale.Parameters.AddWithValue("@CustomerID", customerID);
                        commandSale.Parameters.AddWithValue("@EmployeeID", employeeID);
                        commandSale.Parameters.AddWithValue("@Total", total);

                        // Obtener el ID de la venta recién creada
                        saleID = Convert.ToInt32(commandSale.ExecuteScalar());
                    }

                    // Insertar detalle de la venta en SaleDetails
                    string querySaleDetail = @"INSERT INTO SaleDetails (SaleID, ProductID, Quantity, UnitPrice) 
                                       VALUES (@SaleID, @ProductID, @Quantity, @UnitPrice)";

                    using (SqlCommand commandSaleDetail = new SqlCommand(querySaleDetail, connection))
                    {
                        commandSaleDetail.Parameters.AddWithValue("@SaleID", saleID);
                        commandSaleDetail.Parameters.AddWithValue("@ProductID", productID);
                        commandSaleDetail.Parameters.AddWithValue("@Quantity", quantity);
                        commandSaleDetail.Parameters.AddWithValue("@UnitPrice", price);

                        commandSaleDetail.ExecuteNonQuery();
                    }

                    // Actualizar el stock del producto
                    string queryUpdateStock = @"UPDATE Products SET Stock = Stock - @Quantity WHERE ProductID = @ProductID";

                    using (SqlCommand commandUpdateStock = new SqlCommand(queryUpdateStock, connection))
                    {
                        commandUpdateStock.Parameters.AddWithValue("@Quantity", quantity);
                        commandUpdateStock.Parameters.AddWithValue("@ProductID", productID);

                        commandUpdateStock.ExecuteNonQuery();
                    }

                    MessageBox.Show("Venta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
}
