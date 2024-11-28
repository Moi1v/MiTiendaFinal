using ConexionSQLAzure;
using Microsoft.Data.SqlClient;
using System.Data.Common;
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
            var usuarios = new (string Username, string Password)[]
            {
            ("carlosm", "password1"),
            ("anal", "password2"),
            ("juanp", "password3"),
            ("mariag", "password4"),
            ("luish", "password5"),
            ("sof�ar", "password6")
            };

            string usuario = textBox1.Text.Trim();
            string contrasena = textBox2.Text.Trim();

         
            bool loginValido = false;
            foreach (var u in usuarios)
            {
                if (u.Username == usuario && u.Password == contrasena)
                {
                    loginValido = true;
                    break;
                }
            }

            if (loginValido)
            {
               
                Menu designedForm = new Menu();
                designedForm.Show();
                textBox1.Clear();
                textBox2.Clear();
                this.Hide();

                string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=True;";

                string query = "SELECT * FROM Employees";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        MessageBox.Show("�Conectado!");

                        SqlCommand command = new SqlCommand(query, connection);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show($"{reader["EmployeeID"]}, {reader[1]}, {reader[2]}, {reader[3]}, {reader [4]}, {reader[5]}, {reader [6]}");
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error {ex.Message}");
                    }
                }

            }
            else
            {
          
                MessageBox.Show("Usuario o contrase�a incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
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
