using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


//string connectionString = "Server=uspg.database.windows.net;Database=AZURE JOSIMAR;User Id=jhernandez;Password=g&ouJ1szsLZ6rJLt;";



namespace ConexionSQLAzure
{
    public class AzureSqlConnection
    {
        private readonly string _connectionString;
        private SqlConnection _connection;

        // Constructor que recibe la cadena de conexión
        public AzureSqlConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Método para abrir la conexión
        public void OpenConnection()
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                Console.WriteLine("Conexión abierta exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                throw;
            }
        }

        // Método para cerrar la conexión
        public void CloseConnection()
        {
            try
            {
                if (_connection != null && _connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                    Console.WriteLine("Conexión cerrada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cerrar la conexión: {ex.Message}");
                throw;
            }
        }

        // Método para ejecutar una consulta y retornar un DataTable
        public DataTable ExecuteQuery(string query)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable resultTable = new DataTable();
                        adapter.Fill(resultTable);
                        return resultTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
                throw;
            }
        }

        // Método para ejecutar un comando (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string commandText)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(commandText, _connection))
                {
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar el comando: {ex.Message}");
                throw;
            }
        }
    }
}
