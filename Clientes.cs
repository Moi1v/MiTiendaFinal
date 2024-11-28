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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace MiTienda
{
    public partial class Clientes : Form
    {
        private string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=True;";

        public Clientes()
        {
            InitializeComponent();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int CustomerID = int.Parse(txtCustomerID.Text.Trim());

            string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@CustomerID", CustomerID);

                    int rowsAffected = command.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente eliminado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar el Cliente para eliminar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string customerNIT = txtNIT.Text.Trim();
            string customerFirstName = txtName.Text.Trim();
            string customerLastName = txtLastName.Text.Trim();
            string customerAddress = txtAddress.Text.Trim();
            string customerPhone = txtPhone.Text.Trim();

            string query = "INSERT INTO Customers (NIT, FirstName, LastName, Address, Phone) " +
                           "VALUES (@NIT, @FirstName, @LastName, @Address, @Phone)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@NIT", customerNIT);
                    command.Parameters.AddWithValue("@FirstName", customerFirstName);
                    command.Parameters.AddWithValue("@LastName", customerLastName);
                    command.Parameters.AddWithValue("@Address", customerAddress);
                    command.Parameters.AddWithValue("@Phone", customerPhone);


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente agregado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el cliente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Customers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show($"{reader["CustomerID"]}, {reader[1]}, {reader[2]}, {reader[3]}, {reader[4]}, {reader[5]}");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error {ex.Message}");
                }
            }



        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           Menu Return = new Menu();
            Return.Show();
            this.Hide();
        }
     }
 }

