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
    }
}
