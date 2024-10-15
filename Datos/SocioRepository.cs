using MySql.Data.MySqlClient;
using proyecto_final_club_deportivo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace proyecto_final_club_deportivo.Datos
{
    internal class SocioRepository
    {
        public string inscribirSocio(Socio socio)
        {
            string mensaje;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("registrarSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("nombreSocio", MySqlDbType.VarChar).Value =
                socio.Nombre;
                comando.Parameters.Add("apellidoSocio", MySqlDbType.VarChar).Value =
                socio.Apellido;
                comando.Parameters.Add("dniSocio", MySqlDbType.VarChar).Value =
                socio.Dni;
                comando.Parameters.Add("emailSocio", MySqlDbType.VarChar).Value =
                socio.Email;
                comando.Parameters.Add("telefonoSocio", MySqlDbType.VarChar).Value =
                socio.Telefono;
                comando.Parameters.Add("aptoFisico", MySqlDbType.Byte).Value =
                socio.AptoFisico;
                comando.Parameters.Add("estadoSocio", MySqlDbType.Byte).Value =
                socio.EstadoSocio;
                MySqlParameter idSocio = new MySqlParameter();
                idSocio.ParameterName = "respuesta";
                idSocio.MySqlDbType = MySqlDbType.Int32;
                idSocio.Direction = ParameterDirection.Output;
                comando.Parameters.Add(idSocio);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                mensaje = Convert.ToString(idSocio.Value);
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return mensaje;
        }

        public Socio buscarSocio(string dniSocio)
        {
            MySqlDataReader reader;
            Socio socio = null;
            int id;
            string nombre;
            string apellido;
            string dni;
            string email;
            string telefono;
            bool aptoFisico;
            bool estado;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM socios WHERE dni = @dni", sqlCon);
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@dni", dniSocio);

                sqlCon.Open();
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    id = reader.GetInt32(0);
                    nombre = reader.GetString(1);
                    apellido = reader.GetString(2);
                    dni = reader.GetString(3);
                    email = reader.GetString(4);
                    telefono = reader.GetString(5);
                    aptoFisico = reader.GetBoolean(6);
                    estado = reader.GetBoolean(7);
                    socio = new Socio(id, estado, aptoFisico, nombre, apellido, dni, email, telefono);
                }  
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return socio;
        }

        /**
         * Listará todos los socios con cuota impaga con vencimiento en el dia.  
         **/

        public DataTable listarSociosVencimientoDiario(DateTime dia)
        {
            MySqlDataReader reader;
            DataTable tabla = new DataTable();

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = "SELECT s.id_socio, s.nombre, s.apellido, s.dni, c.fecha_prox_vencimiento, c.estado " +
                    "FROM socios AS s INNER JOIN cuotas AS c ON s.id_socio = c.fk_socio " +
                    "WHERE fecha_prox_vencimiento = @fechaVenc";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@fechaVenc", dia);
                //comando.Parameters.AddWithValue("@estado", estado);
                sqlCon.Open();
                reader = comando.ExecuteReader();
                tabla.Load(reader);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return tabla;
        }

        public DataTable listarSociosEnMora(DateTime dia)
        {
            MySqlDataReader reader;
            DataTable tabla = new DataTable();
            bool estado = false; 
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = "SELECT s.id_socio, s.nombre, s.apellido, s.dni, c.fecha_prox_vencimiento, c.estado, s.estado " +
                    "FROM socios AS s " +
                    "INNER JOIN cuotas c ON s.id_socio = c.fk_socio " +
                    "INNER JOIN (SELECT fk_socio, MAX(fecha_prox_vencimiento) AS max_fecha FROM cuotas GROUP BY fk_socio) AS px " +
                    "ON c.fk_socio = px.fk_socio AND c.fecha_prox_vencimiento = px.max_fecha " +
                    "WHERE px.max_fecha < @fechaVenc AND c.estado = @estado " +
                    "ORDER BY c.fecha_prox_vencimiento DESC;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@fechaVenc", dia);
                comando.Parameters.AddWithValue("@estado", estado);
                sqlCon.Open();
                reader = comando.ExecuteReader();
                tabla.Load(reader);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return tabla;
        }

        // Si el socio esta en mora será inhabilitado para las todas las actividades
        public string modificarEstadoSocio(string dni, bool estado)
        {
            string respuesta;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("modificarEstadoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("dniSocio", MySqlDbType.VarChar).Value = dni;
                comando.Parameters.Add("estadoSocio", MySqlDbType.Byte).Value = estado;

                MySqlParameter existe = new MySqlParameter();
                existe.ParameterName = "respuesta";
                existe.MySqlDbType = MySqlDbType.Int32;
                existe.Direction = ParameterDirection.Output;
                comando.Parameters.Add(existe);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(existe.Value);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return respuesta;
        }
    }
}
