using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MiTienda
{
    public partial class Form4 : Form
    {
        private string connectionString = "Server=uspg.database.windows.net;Database=AZURE JOSIMAR;User Id=jhernandez;Password=g&ouJ1szsLZ6rJLt;";

        public Form4()
        {
            InitializeComponent();
            dataGridViewProductos.ColumnCount = 5;
            dataGridViewProductos.Columns[0].Name = "Código";
            dataGridViewProductos.Columns[1].Name = "Nombre";
            dataGridViewProductos.Columns[2].Name = "Descripción";
            dataGridViewProductos.Columns[3].Name = "Precio";
            dataGridViewProductos.Columns[4].Name = "Cantidad";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
      
            string query = "INSERT INTO Products (Codigo, Nombre, Descripcion, Precio, Cantidad) VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @Cantidad)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Codigo", TxtCode.Text);
                        command.Parameters.AddWithValue("@Nombre", txtName.Text);
                        command.Parameters.AddWithValue("@Descripcion", txtDescription.Text);
                        command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrice.Text));
                        command.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(txtStock.Text));

                        command.ExecuteNonQuery();
                        MessageBox.Show("Producto guardado correctamente en la base de datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el producto: {ex.Message}");
                }
            }

            LimpiarCampos();
            ActualizarDataGridView();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
         
            string query = "UPDATE Products SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, Cantidad = @Cantidad WHERE Codigo = @Codigo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Codigo", TxtCode.Text);
                        command.Parameters.AddWithValue("@Nombre", txtName.Text);
                        command.Parameters.AddWithValue("@Descripcion", txtDescription.Text);
                        command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrice.Text));
                        command.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(txtStock.Text));

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto actualizado correctamente en la base de datos.");
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el producto: {ex.Message}");
                }
            }

            LimpiarCampos();
            ActualizarDataGridView();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
         
            string query = "DELETE FROM Products WHERE Codigo = @Codigo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Codigo", TxtCode.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente de la base de datos.");
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
                }
            }

            LimpiarCampos();
            ActualizarDataGridView();
        }

        private void Btnconsult_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridViewProductos.Rows.Clear();

                            while (reader.Read())
                            {
                                dataGridViewProductos.Rows.Add(
                                    reader["Codigo"],
                                    reader["Nombre"],
                                    reader["Descripcion"],
                                    reader["Precio"],
                                    reader["Cantidad"]
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al consultar los productos: {ex.Message}");
                }
            }
        }

        private void LimpiarCampos()
        {
            TxtCode.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtStock.Clear();
        }

        private void ActualizarDataGridView()
        {
            Btnconsult_Click(null, null); 
        }
    }
}
