using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data;

namespace API.Controllers
{
    public class Movimento
    {
        private string connectionString = "server=localhost;user=root;database=PontoDb;password=#Marelso1890;port=3306";
        private MySqlConnection connection;

        public Movimento()
        {
            connection = new MySqlConnection(connectionString);
        }

        public bool ExecutarQuery(string query)
        {
            MySqlCommand command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = query;
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                string message = string.Empty;

                switch (ex.Number)
                {
                    case 2627:
                        message = "Registro já incluido na base de dados.";
                        break;
                    default:
                        break;
                }
                throw new Exception(message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public DataTable ConsultaQuery(string query)
        {
            MySqlDataReader dados = null;
            DataTable table = new DataTable();

            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = query;
                dados = command.ExecuteReader();

                if (dados.HasRows)
                {
                    table.Load(dados);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return table;
        }
    }
}
