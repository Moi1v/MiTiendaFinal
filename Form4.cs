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
        private string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=True;";

        public Form4()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {


            string productCode = TxtCode.Text.Trim();
            string productName = txtName.Text.Trim();
            string productDescription = txtDescription.Text.Trim();
            decimal productPrice = decimal.Parse(txtPrice.Text.Trim());
            int productStock = int.Parse(txtStock.Text.Trim());


            string query = "INSERT INTO Products (Code, Name, Description, Price, Stock ) " +
                           "VALUES (@Code, @Name, @Description, @Price, @Stock )";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);


                    command.Parameters.AddWithValue("@Code", productCode);
                    command.Parameters.AddWithValue("@Name", productName);
                    command.Parameters.AddWithValue("@Description", productDescription);
                    command.Parameters.AddWithValue("@Price", productPrice);
                    command.Parameters.AddWithValue("@Stock", productStock);



                    int rowsAffected = command.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto agregado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el producto.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

            string query = "UPDATE Products SET Name = @Name, Description = @Description, Price = @Price, Stock = @Stock WHERE Code = @Code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Code", TxtCode.Text);
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Description", txtDescription.Text);
                        command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                        command.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));

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


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {


            int productID = int.Parse(textBoxProductID.Text.Trim());

            string query = "DELETE FROM Products WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);


                    command.Parameters.AddWithValue("@ProductID", productID);


                    int rowsAffected = command.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto eliminado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar el producto para eliminar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }



        }

        private void Btnconsult_Click(object sender, EventArgs e)
        {


            string query = "SELECT * FROM Products";

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
                            MessageBox.Show($"{reader["ProductID"]}, {reader[1]}, {reader[2]}, {reader[3]}, {reader[4]}, {reader[5]}, {reader[6]}");
                            
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error {ex.Message}");
                }
            }

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu designedForm = new Menu();
            designedForm.Show();
            this.Hide();
        }
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProductos.SelectedRows.Count > 0)
                {
                    string codigoProducto = dataGridViewProductos.SelectedRows[0].Cells["Codigo"].Value.ToString();

                    string rutaCarpeta = Path.Combine(Application.StartupPath, "Images");

                    string rutaImagen = Path.Combine(rutaCarpeta, $"{codigoProducto}.jpg");

                    if (File.Exists(rutaImagen))
                    {
                        pictureBoxProducto.Image = Image.FromFile(rutaImagen);
                    }
                    else
                    {
                        pictureBoxProducto.Image = null;
                        MessageBox.Show($"No se encontró una imagen para el producto: {codigoProducto}", "Imagen no disponible");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar la imagen: {ex.Message}", "Error");
            }
        }


    }
}

