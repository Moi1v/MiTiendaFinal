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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace MiTienda
{
    public partial class Clientes : Form
    {
        private SqlConnection connection = DBConexion.GetInstance().GetConnection();


        public Clientes()
        {
            InitializeComponent();
            CargarCliente();
            dataGridViewCliente.SelectionChanged += ClienteTable_SelectionChanged;
        }


        private void CargarCliente()
        {
            string query = "SELECT CustomerID as ID, NIT, FirstName as Nombre, LastName as Apellido, Address as Dirección, Phone as Teléfono FROM Customers";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridViewCliente.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void ClienteTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCliente.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCliente.SelectedRows[0];
                txtNIT.Text = selectedRow.Cells["NIT"].Value.ToString();
                txtName.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtLastName.Text = selectedRow.Cells["Apellido"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Dirección"].Value.ToString();
                txtSearch.Text = selectedRow.Cells["Teléfono"].Value.ToString();


                btnAgregar.Enabled = false;
                btnactualizar.Enabled = true;
            }
            else
            {

                btnAgregar.Enabled = true;
                btnactualizar.Enabled = false;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            int customerId = Convert.ToInt32(dataGridViewCliente.SelectedRows[0].Cells["ID"].Value);

            string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente eliminado.");
                        CargarCliente();

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el cliente.");
                    }
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string customerNIT = txtNIT.Text.Trim();
            string customerFirstName = txtName.Text.Trim();
            string customerLastName = txtLastName.Text.Trim();
            string customerAddress = txtAddress.Text.Trim();
            string customerPhone = txtSearch.Text.Trim();

            string query = "INSERT INTO Customers (NIT, FirstName, LastName, Address, Phone) " +
                           "VALUES (@NIT, @FirstName, @LastName, @Address, @Phone)";


            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

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
                        CargarCliente();
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
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            string query;

            if (string.IsNullOrEmpty(searchText))
            {
                query = "SELECT CustomerID as ID, NIT, FirstName as Nombre, LastName as Apellido, Address as Dirección, Phone as Teléfono FROM Customers";
            }
            else
            {
                query = "SELECT CustomerID as ID, NIT, FirstName as Nombre, LastName as Apellido, Address as Dirección, Phone as Teléfono " +
                        "FROM Customers WHERE FirstName LIKE @search OR LastName LIKE @search";
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

                    dataGridViewCliente.DataSource = dt;
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
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Menu Return = new Menu();
            Return.Show();
            this.Hide();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Customers SET  FirstName = @FirstName, LastName = @LastName, Address = @Address, Phone = @Phone WHERE NIT = @NIT";

            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", txtName.Text);
                        command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                        command.Parameters.AddWithValue("@NIT", txtNIT.Text);
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);
                        command.Parameters.AddWithValue("@Phone", txtSearch.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente actualizado.");
                            CargarCliente();
                        }
                        else
                        {
                            MessageBox.Show("Cliente no encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el cliente: {ex.Message}");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu Return = new Menu();
            Return.Show();
            this.Hide();
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

