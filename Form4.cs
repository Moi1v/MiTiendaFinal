using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MiTienda.conexion;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace MiTienda
{
    public partial class Form4 : Form
    {
        private SqlConnection connection = DBConexion.GetInstance().GetConnection();


        public Form4()
        {
            InitializeComponent();
            CargarProducto();
            dataGridViewProductos.SelectionChanged += ProductsTable_SelectionChanged;
        }

        private void CargarProducto()
        {
            string query = "SELECT ProductID as ID, Code as Código, Name as Nombre, Description as Descripción, Price as Precio, Stock, ImagePath FROM Products";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridViewProductos.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtCode.Text) || string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtPrice.Text) ||
                string.IsNullOrEmpty(txtStock.Text) || pictureBoxProducto.Image == null)
            {
                MessageBox.Show("Por favor completa todos los campos y selecciona una imagen.");
                return;
            }   


            string imagePath = SaveImageToFolder(pictureBoxProducto.Image);


            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("No se pudo guardar la imagen.");
                return;
            }


            string query = "INSERT INTO Products (Code, Name, Description, Price, Stock, ImagePath) VALUES (@Code, @Name, @Description, @Price, @Stock, @ImagePath)";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Code", TxtCode.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);

                try
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto guardado correctamente.");
                    CargarProducto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private void LoadProductImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                pictureBoxProducto.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBoxProducto.Image = null;
                MessageBox.Show("Imagen no encontrada.");
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCode.Text) || string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtPrice.Text) ||
                string.IsNullOrEmpty(txtStock.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            string query = "UPDATE Products SET Name = @Name, Description = @Description, Price = @Price, Stock = @Stock, imagePath = @ImagePath WHERE Code = @Code";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Code", TxtCode.Text);
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Description", txtDescription.Text);
                    command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                    command.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));

                    string imagePath = null;
                    if (pictureBoxProducto.Image != null)
                    {
                        imagePath = SaveImageToFolder(pictureBoxProducto.Image);
                    }

                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        command.Parameters.AddWithValue("@ImagePath", imagePath);
                    }


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto actualizado.");
                        CargarProducto();
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
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {


            int productID = Convert.ToInt32(dataGridViewProductos.SelectedRows[0].Cells["ID"].Value);

            string query = "DELETE FROM Products WHERE ProductID = @ProductID";


            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    SqlCommand command = new SqlCommand(query, connection);


                    command.Parameters.AddWithValue("@ProductID", productID);


                    int rowsAffected = command.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto eliminado.");
                        CargarProducto();
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
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }



        }

        private void Btnconsult_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Products";


            string rutaCarpeta = Path.Combine(Application.StartupPath, "Images");


            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show($"{reader["ProductID"]}, {reader[1]}, {reader[2]}, {reader[3]}, {reader[4]}, {reader[5]}");

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

        private void BtnSeleccionarImagen_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar Imagen del Producto";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pictureBoxProducto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
        private string SaveImageToFolder(Image image)
        {
            // Verificamos si la imagen es válida
            if (image != null)
            {
                // Definir la carpeta para guardar las imágenes
                string folderPath = @"C:\imagenes";  // La ruta que mencionas en el disco C
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);  // Crear la carpeta si no existe
                }

                // Definir el nombre de archivo para la imagen (puedes agregar lógica para generar nombres únicos)
                string imageName = Guid.NewGuid().ToString() + ".jpg";  // Usamos un GUID para asegurar que el nombre sea único
                string imagePath = Path.Combine(folderPath, imageName);

                // Guardar la imagen en la ruta especificada
                image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                return imagePath;  // Devolver la ruta donde se guardó la imagen
            }
            return string.Empty;  // Si la imagen no es válida, devolver una cadena vacía
        }

        private void ProductsTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProductos.SelectedRows[0];

                TxtCode.Text = selectedRow.Cells["Código"].Value.ToString();
                txtName.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["Descripción"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Precio"].Value.ToString();
                txtStock.Text = selectedRow.Cells["Stock"].Value.ToString();

                string imagePath = selectedRow.Cells["ImagePath"].Value.ToString();


                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {

                    pictureBoxProducto.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBoxProducto.Image = null;
                }


                BtnSave.Enabled = false;

            }
            else
            {

                BtnSave.Enabled = true;

            }
        }

        private void textBoxProductID_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

