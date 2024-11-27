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


         
            string usuario = textBox1.Text.Trim();
            string contrasena = textBox2.Text.Trim();

          
            string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=True;";

           
            string query = "SELECT COUNT(1) FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @Contrasena";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                 
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
            
                        command.Parameters.AddWithValue("@Usuario", usuario);
                        command.Parameters.AddWithValue("@Contrasena", contrasena);

                        int result = Convert.ToInt32(command.ExecuteScalar());

                        if (result == 1)
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
            }
            catch (Exception ex)
            {
         
                MessageBox.Show($"Error al validar las credenciales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
