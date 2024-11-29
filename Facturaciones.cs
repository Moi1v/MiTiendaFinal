﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace MiTienda
{
    public partial class Facturaciones : Form
    {
        // Propiedad para almacenar el carrito
        public DataTable Carrito { get; set; }
        private string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=True;";

        // Agregar el carrito al formulario de facturación
        public Facturaciones(DataTable carrito)
        {
            InitializeComponent();
            Carrito = carrito;

            // Aquí se asigna el carrito al DataGridView
            dataGridViewFacturacion.DataSource = Carrito;
        }


        // Método para registrar la venta
        private void RegisterSale(int customerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Modificar la consulta para no incluir TotalAmount si no existe en la tabla
                string salesQuery = "INSERT INTO Sales (CustomerID, SaleDate) VALUES (@CustomerID, @SaleDate); SELECT SCOPE_IDENTITY();";
                SqlCommand salesCmd = new SqlCommand(salesQuery, conn);
                salesCmd.Parameters.AddWithValue("@CustomerID", customerId);
                salesCmd.Parameters.AddWithValue("@SaleDate", DateTime.Now);

                // Obtener el SaleID generado
                int saleId = Convert.ToInt32(salesCmd.ExecuteScalar());

                // Insertar detalles de la venta en SaleDetails
                foreach (DataRow row in Carrito.Rows)
                {
                    int productId = Convert.ToInt32(row["ProductID"]);
                    int quantity = Convert.ToInt32(row["Quantity"]);
                    decimal unitPrice = Convert.ToDecimal(row["Price"]);

                    string saleDetailsQuery = "INSERT INTO SaleDetails (SaleID, ProductID, Quantity, UnitPrice) VALUES (@SaleID, @ProductID, @Quantity, @UnitPrice)";
                    SqlCommand saleDetailsCmd = new SqlCommand(saleDetailsQuery, conn);
                    saleDetailsCmd.Parameters.AddWithValue("@SaleID", saleId); // Usar el SaleID capturado
                    saleDetailsCmd.Parameters.AddWithValue("@ProductID", productId);
                    saleDetailsCmd.Parameters.AddWithValue("@Quantity", quantity);
                    saleDetailsCmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    saleDetailsCmd.ExecuteNonQuery();

                    // Actualizar el inventario
                    string updateProductQuery = "UPDATE Products SET Stock = Stock - @Quantity WHERE ProductID = @ProductID";
                    SqlCommand updateProductCmd = new SqlCommand(updateProductQuery, conn);
                    updateProductCmd.Parameters.AddWithValue("@Quantity", quantity);
                    updateProductCmd.Parameters.AddWithValue("@ProductID", productId);
                    updateProductCmd.ExecuteNonQuery();
                }

                // Mostrar resumen de la venta
                MessageBox.Show($"Venta registrada con éxito. Total: {GetTotalAmount():C2}");
            }

        }

        // Método para calcular el total de la venta
        private decimal GetTotalAmount()
        {
            decimal total = 0;
            foreach (DataRow row in Carrito.Rows)
            {
                total += Convert.ToDecimal(row["Total"]);
            }
            return total;
        }

        // Método para registrar el cliente
        private int GetCustomerId(string nit, string firstName, string lastName)
        {
            // Si el cliente no existe, se crea uno nuevo.
            if (nit != "CF")
            {
                string query = "SELECT CustomerID FROM Customers WHERE NIT = @NIT";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NIT", nit);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        // Crear cliente nuevo
                        string insertQuery = "INSERT INTO Customers (NIT, FirstName, LastName) VALUES (@NIT, @FirstName, @LastName)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@NIT", nit);
                        insertCmd.Parameters.AddWithValue("@FirstName", firstName);
                        insertCmd.Parameters.AddWithValue("@LastName", lastName);
                        insertCmd.ExecuteNonQuery();

                        // Devolver el ID del cliente recién creado
                        return 0;
                    }
                }
            }
            else
            {
                // Consumidor Final (CF)
                return 0;
            }
        }

        private bool VerificarSaleID(string saleID)
        {
            string query = "SELECT COUNT(*) FROM Sales WHERE SaleID = @SaleID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SaleID", saleID);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private int RegistrarVenta(string customerID, decimal totalAmount)
        {
            string query = "INSERT INTO Sales (CustomerID, SaleDate, TotalAmount) OUTPUT INSERTED.SaleID " +
                           "VALUES (@CustomerID, @SaleDate, @TotalAmount)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@SaleDate", DateTime.Now);
                command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }


        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            // Validar que el DataGridView tenga datos
            if (dataGridViewFacturacion.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en el grid para guardar.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    foreach (DataGridViewRow row in dataGridViewFacturacion.Rows)
                    {
                        // Validar que la fila no esté vacía
                        if (row.Cells["SaleID"].Value == null ||
                            row.Cells["SaleDate"].Value == null ||
                            row.Cells["CustomerID"].Value == null ||
                            row.Cells["EmployeeID"].Value == null ||
                            row.Cells["Total"].Value == null)
                        {
                            continue;
                        }

                        // Leer datos de la fila
                        int saleId = Convert.ToInt32(row.Cells["SaleID"].Value);
                        DateTime saleDate = Convert.ToDateTime(row.Cells["SaleDate"].Value);
                        int customerId = Convert.ToInt32(row.Cells["CustomerID"].Value);
                        int employeeId = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                        decimal total = Convert.ToDecimal(row.Cells["Total"].Value);

                        // Query para insertar en la tabla Sales
                        string query = "INSERT INTO Sales (SaleID, SaleDate, CustomerID, EmployeeID, Total) " +
                                       "VALUES (@SaleID, @SaleDate, @CustomerID, @EmployeeID, @Total)";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SaleID", saleId);
                        command.Parameters.AddWithValue("@SaleDate", saleDate);
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        command.Parameters.AddWithValue("@EmployeeID", employeeId);
                        command.Parameters.AddWithValue("@Total", total);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Datos guardados exitosamente en la tabla 'Sales'.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar datos: {ex.Message}");
                }
            }
        }
    }
}