using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTienda.conexion
{
    internal class DBConexion
    {
        private static DBConexion instance = null;

        private string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=true;";

        private SqlConnection connection;

        private DBConexion()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al abrir la conexión. {ex.Message}");
            }
        }

        public static DBConexion GetInstance()
        {
            if (instance == null)
            {
                instance = new DBConexion();
            }
            return instance;
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
