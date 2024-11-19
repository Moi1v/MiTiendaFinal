using Microsoft.Data.SqlClient;

namespace MiTienda
{



    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

            string usuario = textBox1.Text;
            string contrasena = textBox2.Text;


            string usuarioValido = "usuarioEjemplo";
            string contrasenaValida = "contrasenaEjemplo";


            if (usuario == usuarioValido && contrasena == contrasenaValida)
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=True;";

            string query = "SELECT * FROM Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    MessageBox.Show("Conectado a la Base de datos");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo conectar a la Base de datos");
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.ShowDialog(); 
        }

    }
}
