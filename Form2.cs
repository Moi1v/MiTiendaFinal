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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Employee_management designedForm = new Employee_management();
            designedForm.Show();

            this.Hide();

            string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=True;";

            string query = "SELECT * FROM dbo.Employees";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("¡Conectado A Base de Empleados!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error {ex.Message}");
                }
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            log_in designedForm = new log_in();
            designedForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 designedForm = new Form4();
            designedForm.Show();
            this.Hide();

            string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=True;";

            string query = "SELECT * FROM dbo.Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("¡Conectado A base de Productos!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error {ex.Message}");
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ventas designedForm = new Ventas();
            designedForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Clientes formsfacturas = new Clientes();
            formsfacturas.Show();
            this.Hide();
        }
    }
}
