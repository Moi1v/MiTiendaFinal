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
using System.Xml.Linq;
using MiTienda.conexion;

namespace MiTienda
{
    public partial class Facturaciones : Form
    {

        private SqlConnection connection = DBConexion.GetInstance().GetConnection();
        private List<Producto> productosDisponibles = new List<Producto>();
        private List<Producto> productosSeleccionados = new List<Producto>();
        private decimal totalFactura = 0;


        public Facturaciones()
        {
            InitializeComponent();
            CargarProductosDesdeBD();
            MostrarProductos();
            CargarClientesYEmpleados();
        }

        private void CargarProductosDesdeBD()
        {
            productosDisponibles.Clear();
            string query = "SELECT ProductID, Code, Name, Description, Price, Stock, ImagePath FROM Products";
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int productid = Convert.ToInt32(reader["ProductID"]);
                    string code = reader["Code"].ToString();
                    string name = reader["Name"].ToString();
                    string description = reader["Description"].ToString();
                    decimal price = Convert.ToDecimal(reader["Price"]);
                    int stock = Convert.ToInt32(reader["Stock"]);
                    string imagePath = reader["ImagePath"].ToString();


                    Producto producto = new Producto(productid, code, name, description, price, stock, imagePath);
                    productosDisponibles.Add(producto);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        private void MostrarProductos()
        {
            flpProductos.Controls.Clear();

            foreach (var producto in productosDisponibles)
            {
                Panel tarjetaProducto = new Panel();
                tarjetaProducto.Width = 200;
                tarjetaProducto.Height = 350;
                tarjetaProducto.BorderStyle = BorderStyle.FixedSingle;
                tarjetaProducto.Margin = new Padding(10);

                PictureBox picImagen = new PictureBox
                {
                    Image = producto.Imagen,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 150,
                    Height = 150,
                    Location = new Point(25, 10)
                };

                Label lblNombre = new Label
                {
                    Text = producto.Name,
                    Width = 150,
                    Location = new Point(25, 170)
                };

                Label lblPrecio = new Label
                {
                    Text = $"Precio: Q{producto.Price}",
                    Width = 150,
                    Location = new Point(25, 190)
                };

                Label lblStock = new Label
                {
                    Text = $"Stock: {producto.Stock}",
                    Width = 150,
                    Location = new Point(25, 210)
                };


                NumericUpDown numCantidad = new NumericUpDown
                {
                    Minimum = 1,
                    Maximum = producto.Stock,
                    Value = 1,
                    Width = 150,
                    Location = new Point(25, 230)
                };

                Button btnAgregar = new Button
                {
                    Text = "Agregar",
                    Width = 150,
                    Location = new Point(25, 260)
                };


                btnAgregar.Click += (sender, e) => AgregarProducto(producto, (int)numCantidad.Value);

                tarjetaProducto.Controls.Add(picImagen);
                tarjetaProducto.Controls.Add(lblNombre);
                tarjetaProducto.Controls.Add(lblPrecio);
                tarjetaProducto.Controls.Add(lblStock);
                tarjetaProducto.Controls.Add(numCantidad);
                tarjetaProducto.Controls.Add(btnAgregar);

                flpProductos.Controls.Add(tarjetaProducto);
            }
        }



        private void AgregarProducto(Producto producto, int cantidadSeleccionada)
        {

            var productoExistente = productosSeleccionados.FirstOrDefault(p => p.Code == producto.Code);
            if (productoExistente != null)
            {
                productoExistente.Cantidad += cantidadSeleccionada;
            }
            else
            {
                producto.Cantidad = cantidadSeleccionada;
                productosSeleccionados.Add(producto);
            }

            string itemFactura = $"{producto.Name} - Cantidad: {cantidadSeleccionada} - Precio: Q{producto.Price * cantidadSeleccionada}";
            listBoxFactura.Items.Add(itemFactura);

            totalFactura += producto.Price * cantidadSeleccionada;
            lblTotal.Text = $"Total: Q{totalFactura}";
        }

        private void CargarClientesYEmpleados()
        {


            string queryClientes = "SELECT CustomerID, FirstName + ' ' + LastName AS FullName FROM Customers";
            SqlDataAdapter adapterClientes = new SqlDataAdapter(queryClientes, connection);
            DataTable dtClientes = new DataTable();
            adapterClientes.Fill(dtClientes);

            cmbClientes.DisplayMember = "FullName";
            cmbClientes.ValueMember = "CustomerID";
            cmbClientes.DataSource = dtClientes;


            string queryEmpleados = "SELECT EmployeeID, FirstName + ' ' + LastName AS FullName FROM Employees";
            SqlDataAdapter adapterEmpleados = new SqlDataAdapter(queryEmpleados, connection);
            DataTable dtEmpleados = new DataTable();
            adapterEmpleados.Fill(dtEmpleados);

            cmbEmpleados.DisplayMember = "FullName";
            cmbEmpleados.ValueMember = "EmployeeID";
            cmbEmpleados.DataSource = dtEmpleados;

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu Return = new Menu();
            Return.Show();
            this.Hide();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbClientes.SelectedItem == null || cmbEmpleados.SelectedItem == null || listBoxFactura.Items.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un cliente, un empleado y productos antes de realizar la venta.");
                    return;
                }


                int customerId = (int)cmbClientes.SelectedValue;
                int employeeId = (int)cmbEmpleados.SelectedValue;
                decimal totalVenta = totalFactura;


                string querySales = "INSERT INTO Sales (SaleDate, CustomerID, EmployeeID, Total) OUTPUT INSERTED.SaleID VALUES (@SaleDate, @CustomerID, @EmployeeID, @Total)";
                int salesId;

                using (SqlCommand command = new SqlCommand(querySales, connection))
                {
                    command.Parameters.AddWithValue("@SaleDate", DateTime.Now);
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.Parameters.AddWithValue("@EmployeeID", employeeId);
                    command.Parameters.AddWithValue("@Total", totalVenta);

                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }


                    salesId = (int)command.ExecuteScalar();
                }


                foreach (var item in productosSeleccionados)
                {
                    string querySalesDetails = "INSERT INTO SaleDetails (SaleID, ProductID, Quantity, UnitPrice) VALUES (@SaleID, @ProductID, @Quantity, @UnitPrice)";

                    using (SqlCommand command = new SqlCommand(querySalesDetails, connection))
                    {
                        command.Parameters.AddWithValue("@SaleID", salesId);
                        command.Parameters.AddWithValue("@ProductID", item.ProductID);
                        command.Parameters.AddWithValue("@Quantity", item.Cantidad);
                        command.Parameters.AddWithValue("@UnitPrice", item.Price);

                        command.ExecuteNonQuery();
                    }

                    // Actualizar el stock del producto
                    string queryUpdateStock = "UPDATE Products SET Stock = Stock - @Quantity WHERE ProductID = @ProductID";

                    using (SqlCommand command = new SqlCommand(queryUpdateStock, connection))
                    {
                        command.Parameters.AddWithValue("@Quantity", item.Cantidad);
                        command.Parameters.AddWithValue("@ProductID", item.ProductID);

                        command.ExecuteNonQuery();
                    }
                }


                MessageBox.Show("Venta registrada con éxito.");


                productosSeleccionados.Clear();
                listBoxFactura.Items.Clear();
                lblTotal.Text = "Total: Q0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la venta: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}