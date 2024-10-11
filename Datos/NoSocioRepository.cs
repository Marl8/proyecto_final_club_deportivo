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
    internal class NoSocioRepository
{
        public string inscribirNoSocio(NoSocio noSocio)
        {
            string mensaje;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("registrarNoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("nombreNoSocio", MySqlDbType.VarChar).Value =
                noSocio.Nombre;
                comando.Parameters.Add("apellidoNoSocio", MySqlDbType.VarChar).Value =
                noSocio.Apellido;
                comando.Parameters.Add("dniNoSocio", MySqlDbType.VarChar).Value =
                noSocio.Dni;
                comando.Parameters.Add("emailNoSocio", MySqlDbType.VarChar).Value =
                noSocio.Email;
                comando.Parameters.Add("telefonoNoSocio", MySqlDbType.VarChar).Value =
                noSocio.Telefono;
                comando.Parameters.Add("aptoFisico", MySqlDbType.Byte).Value =
                noSocio.AptoFisico;
           
                //comando.Parameters.AddWithValue("diaHabilitado", noSocio.DiaHabilitado.Date);
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

        public DataTable listarNoSociosHabilitados(DateTime dia)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("listarNoSocios", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("diaHabilitado", MySqlDbType.Date).Value = dia.Date;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
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
        }
    }
}
