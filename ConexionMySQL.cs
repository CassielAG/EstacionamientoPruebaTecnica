using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento
{
    internal class ConexionMySQL: Conexion
    {
        private MySqlConnection connection;
        private string connectionString;
        public ConexionMySQL()
        {
            connectionString = $"Server={server};Database={database};User ID={user};Password={password};";
            connection = new MySqlConnection(connectionString);
        }
        public MySqlConnection GetConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.ToString());
            }
            return connection;
        }
    }
}
