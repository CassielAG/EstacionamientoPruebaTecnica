using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    internal class VehiculoConsultas
    {
        private ConexionMySQL conexion;
        private List<Vehiculo> vehiculos;
        public VehiculoConsultas()
        {
            conexion = new ConexionMySQL();
            vehiculos = new List<Vehiculo>();
        }
        internal List<Vehiculo> ConsultarVehiculos(string filtro)
        {

            string query = "SELECT * FROM registro";
            if (!string.IsNullOrEmpty(filtro))
            {
                query += " WHERE entrada LIKE '%" + filtro + "%'";
            }
            MySqlCommand command = new MySqlCommand(query, conexion.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.num_placa = reader.GetString(2);
                vehiculo.tipo = reader.GetString(3);
                vehiculo.entrada = reader.GetDateTime(4);
                vehiculo.salida = reader.GetDateTime(5);
                vehiculo.tiempo = reader.GetTimeSpan(7);
                vehiculos.Add(vehiculo);
            }
            reader.Close();
            return vehiculos;
        }
        internal bool AgregarVehiculo(Vehiculo vehiculo)
        {
            string query = "INSERT INTO registro (num_placa, tipo, entrada, salida, tiempo, create_date) VALUES (@num_placa, @tipo, @entrada, @salida, @tiempo,@create_date)";
            MySqlCommand command = new MySqlCommand(query, conexion.GetConnection());
            command.Parameters.AddWithValue("@num_placa", vehiculo.num_placa);
            command.Parameters.AddWithValue("@tipo", vehiculo.tipo);
            command.Parameters.AddWithValue("@entrada", vehiculo.entrada);
            command.Parameters.AddWithValue("@salida", vehiculo.salida);
            command.Parameters.AddWithValue("@tiempo", vehiculo.tiempo);
            command.Parameters.AddWithValue("@create_date", vehiculo.create_date);
            return command.ExecuteNonQuery() > 0;
        }
        internal bool modificarVehiculo(Vehiculo vehiculo)
        {
            string query = "UPDATE registro SET num_placa = @num_placa, tipo = @tipo, entrada = @entrada, salida = @salida, tiempo = @tiempo, create_date = @create_date, moified_date = @moified_date WHERE idregistro = @idregistro";
            MySqlCommand command = new MySqlCommand(query, conexion.GetConnection());
            command.Parameters.AddWithValue("@idregistro", vehiculo.idregistro);
            command.Parameters.AddWithValue("@num_placa", vehiculo.num_placa);
            command.Parameters.AddWithValue("@tipo", vehiculo.tipo);
            command.Parameters.AddWithValue("@entrada", vehiculo.entrada);
            command.Parameters.AddWithValue("@salida", vehiculo.salida);
            command.Parameters.AddWithValue("@tiempo", vehiculo.tiempo);
            command.Parameters.AddWithValue("@create_date", vehiculo.create_date);
            command.Parameters.AddWithValue("@moified_date", vehiculo.moified_date);
            return command.ExecuteNonQuery() > 0;
        }
    }
}
