using MySql.Data.MySqlClient;
using proyecto_final_club_deportivo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
