using Microsoft.Data.SqlClient;
using MiTienda.conexion;
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
        private SqlConnection connection = DBConexion.GetInstance().GetConnection();

        public Employee()
        {
            InitializeComponent();
            CargarEmployee();
            dataGridViewEmployee.SelectionChanged += EmployeeTable_SelectionChanged;
        }


        private void CargarEmployee()
        {
            string query = "SELECT EmployeeID as ID, FirstName as Nombre, LastName as Apellido, IdentificationNumber as Identificación, Position as Cargo, Username as Usuario FROM Employees";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridViewEmployee.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }


        private void EmployeeTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEmployee.SelectedRows[0];
                txtName.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtLastname.Text = selectedRow.Cells["Apellido"].Value.ToString();
                txtID.Text = selectedRow.Cells["ID"].Value.ToString();
                txtCargo.Text = selectedRow.Cells["Cargo"].Value.ToString();
                txtUser.Text = selectedRow.Cells["Usuario"].Value.ToString();


                button1.Enabled = false;
                //btnactualizar.Enabled = true;
            }
            else
            {

                button1.Enabled = true;
                //btnactualizar.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Employees (FirstName, LastName, IdentificationNumber, Position, Username, PasswordHash) " +
                           "VALUES (@FirstName, @LastName, @IdentificationNumber, @Position, @Username, @PasswordHash)";


            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@FirstName", txtName.Text);
                    command.Parameters.AddWithValue("@LastName", txtLastname.Text);
                    command.Parameters.AddWithValue("@IdentificationNumber", txtID.Text);
                    command.Parameters.AddWithValue("@Position", txtCargo.Text);
                    command.Parameters.AddWithValue("@Username", txtUser.Text);
                    command.Parameters.AddWithValue("@PasswordHash", txtPassword.Text);


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Empleado agregado exitosamente.");
                        CargarEmployee();
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
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
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
            int employeeId = Convert.ToInt32(dataGridViewEmployee.SelectedRows[0].Cells["ID"].Value);

            string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";

            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

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
                        command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = employeeId;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Empleado eliminado exitosamente.");
                            CargarEmployee();
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
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(dataGridViewEmployee.SelectedRows[0].Cells["ID"].Value);
            string query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, IdentificationNumber = @IdentificationNumber, Position = @Position, Username = @Username, PasswordHash = @Password where EmployeeID = @EmployeeID";

            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeId);
                        command.Parameters.AddWithValue("@FirstName", txtName.Text);
                        command.Parameters.AddWithValue("@LastName", txtLastname.Text);
                        command.Parameters.AddWithValue("@IdentificationNumber", txtID.Text);
                        command.Parameters.AddWithValue("@Position", txtCargo.Text);
                        command.Parameters.AddWithValue("@Username", txtUser.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Empleado actualizado.");
                            CargarEmployee();
                        }
                        else
                        {
                            MessageBox.Show("Empleado no encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el empleado: {ex.Message}");
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu Return = new Menu();
            Return.Show();
            this.Hide();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            string query;

            if (string.IsNullOrEmpty(searchText))
            {
                query = "SELECT EmployeeID as ID, IdentificationNumber as Cargo ,Position as Cargo, FirstName as Nombre, LastName as Apellido, Username as Usuario FROM Employees";
            }
            else
            {
                query = "SELECT EmployeeID as ID, IdentificationNumber as Cargo ,Position as Cargo, FirstName as Nombre, LastName as Apellido, Username as Usuario " +
                        "FROM Employees WHERE IdentificationNumber LIKE @search OR FirstName LIKE @search OR Username LIKE @search";
            }

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {

                if (!string.IsNullOrEmpty(searchText))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    da.Fill(dt);

                    dataGridViewEmployee.DataSource = dt;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
                }
                finally
                {

                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}