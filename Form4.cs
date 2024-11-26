using MiTienda.Clase__Temporal_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private List<Producto> productos = new List<Producto>();
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
            Producto nuevoProducto = new Producto
            {
                Codigo = TxtCode.Text,
                Nombre = txtName.Text,
                Descripcion = txtDescription.Text,
                Precio = Convert.ToDecimal(txtPrice.Text),
                Cantidad = Convert.ToInt32(txtStock.Text),
            };

            productos.Add(nuevoProducto);
            MessageBox.Show("Producto guardado temporalmente.");


            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            TxtCode.Clear();

            RefreshDataGridView();
        }



        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            string codigo = TxtCode.Text;
            Producto producto = productos.Find(p => p.Codigo == codigo);

            if (producto != null)
            {
                producto.Nombre = txtName.Text;
                producto.Descripcion = txtDescription.Text;
                producto.Precio = Convert.ToDecimal(txtPrice.Text);
                producto.Cantidad = Convert.ToInt32(txtStock.Text);
                MessageBox.Show("Producto actualizado temporalmente.");

                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string codigo = TxtCode.Text;
            Producto producto = productos.Find(p => p.Codigo == codigo);

            if (producto != null)
            {
                productos.Remove(producto);
                MessageBox.Show("Producto eliminado temporalmente.");

                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }


        private void Btnconsult_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=uspg.database.windows.net;Database=AZURE JOSIMAR;User Id=jhernandez;Password=g&ouJ1szsLZ6rJLt;";
            
            string query = "SELECT * FROM Products";

            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                try 
                {
                    conn.Open();
                   
                    SqlCommand command = new SqlCommand(query, conn);

                    using (SqlDataReader reader = command.ExecuteReader()) 
                    {
                        while (reader.Read()) 
                        {
                            MessageBox.Show($"{reader[ProductName]}, {reader[1]}, {reader[2]}, {reader[3]}");
                            
                        }
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Error{ex.Message}");
                }
            }

        }

        public class Producto
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
        }

        private void RefreshDataGridView()
        {
            dataGridViewProductos.Rows.Clear(); 
            foreach (Producto producto in productos)
            {
                dataGridViewProductos.Rows.Add(producto.Codigo, producto.Nombre, producto.Descripcion, producto.Precio, producto.Cantidad);
            }
        }

    }
}

