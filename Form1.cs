using ConexionSQLAzure;
using Microsoft.Data.SqlClient;
using System.Data;

namespace MiTienda
{
    public partial class log_in : Form
    {
        private AzureSqlConnection _connection;

        public log_in()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string contrasena = textBox2.Text.Trim();

            string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=True;";

            string query = "SELECT COUNT(1) FROM Employees WHERE Username = @Username AND PasswordHash = @PasswordHash";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", usuario);
                        command.Parameters.AddWithValue("@PasswordHash", contrasena);

                        int count = (int)command.ExecuteScalar();

                        if (count == 1)
                        {
                            Menu designedForm = new Menu();
                            designedForm.Show();
                            textBox1.Clear();
                            textBox2.Clear();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Clear();
                            textBox2.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error");
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_in_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
        }
    }
}
