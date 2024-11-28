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
    public partial class Employee : Form
    {
        private string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=True;";

        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text.Trim();
            string LastName = txtLastname.Text.Trim();
            string DPI = txtDPI.Text.Trim();
            string Cargo = txtCargo.Text.Trim();
            string User = txtUser.Text.Trim();
            string PasswordUser = txtPassword.Text.Trim();

            string query = "INSERT INTO Employees (FirstName, LastName, IdentificationNumber, Position, Username, PasswordHash) " +
                           "VALUES (@FirstName, @LastName, @IdentificationNumber, @Position, @Username, @PasswordHash)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@FirstName", Name);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@IdentificationNumber", DPI);
                    command.Parameters.AddWithValue("@Position", Cargo);
                    command.Parameters.AddWithValue("@Username", User);
                    command.Parameters.AddWithValue("@PasswordHash", PasswordUser);


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Empleado agregado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el Empleado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEmployeeID.Text.Trim(), out int EmployeeIDR))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este empleado?",
                                                        "Confirmar eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
                    if (confirmResult != DialogResult.Yes)
                    {
                        return;
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = EmployeeIDR;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Empleado eliminado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo encontrar el Empleado para eliminar.");
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Error de base de datos: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inesperado: {ex.Message}");
                }
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEmployeeID.Text.Trim(), out int EmployeeIDR))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este empleado?",
                                                        "Confirmar eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
                    if (confirmResult != DialogResult.Yes)
                    {
                        return;
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = EmployeeIDR;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Empleado eliminado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo encontrar el Empleado para eliminar.");
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Error de base de datos: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inesperado: {ex.Message}");
                }
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Employees";

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
                            MessageBox.Show($"Id Empleado: {reader["EmployeeID"]}, " +
                                            $"Nombre: {reader[1]}, " +
                                            $"Apellido: {reader[2]}, " +
                                            $"DPI: {reader[3]}, " +
                                            $"Cargo: {reader[4]}, " +
                                            $"UserName: {reader[5]}, " +
                                            $"Password: {reader [6]}");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error {ex.Message}");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu Return = new Menu();
            Return.Show();
            this.Hide();
        }
    }
}
