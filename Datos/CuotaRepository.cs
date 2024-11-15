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
    internal class CuotaRepository
    {
        public string crearCuota(Cuota cuota, int idSocio)
        {
            string mensaje;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("crearCuota", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("valorCuota", MySqlDbType.Double).Value =
                cuota.ValorCouta;
                comando.Parameters.Add("fechaPago", MySqlDbType.Date).Value =
                cuota.FechaPago.Date;
                comando.Parameters.Add("fechaVencimiento", MySqlDbType.Date).Value =
                cuota.FechaVencimiento.Date;
                comando.Parameters.Add("fechaProxVec", MySqlDbType.Date).Value =
                cuota.FechaProxVencimiento.Date;
                comando.Parameters.Add("formaPago", MySqlDbType.VarChar).Value =
                cuota.FormaPago;
                comando.Parameters.Add("cantCuotas", MySqlDbType.Int32).Value =
                cuota.CantidadCuotas;
                comando.Parameters.Add("estadoCuota", MySqlDbType.Byte).Value =
                cuota.Estado;
                comando.Parameters.Add("idSocio", MySqlDbType.Int32).Value = idSocio;
                MySqlParameter codigo = new MySqlParameter();
                codigo.ParameterName = "respuesta";
                codigo.MySqlDbType = MySqlDbType.Int32;
                codigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(codigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                mensaje = Convert.ToString(codigo.Value);
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

        public string pagarCuota(int idSocio, double valor, DateTime fechaPago, string formaPago, int cantCuotas)
        {
            string mensaje;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("pagoCuota", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idSocio", MySqlDbType.Int32).Value =
                idSocio;
                comando.Parameters.Add("valorCuota", MySqlDbType.Double).Value =
                valor;
                comando.Parameters.Add("fechaPago", MySqlDbType.Date).Value =
                fechaPago.Date;
                comando.Parameters.Add("formaPago", MySqlDbType.VarChar).Value =
                formaPago;
                comando.Parameters.Add("cantCuotas", MySqlDbType.Int32).Value =
                cantCuotas;
                MySqlParameter codigo = new MySqlParameter();
                codigo.ParameterName = "respuesta";
                codigo.MySqlDbType = MySqlDbType.Int32;
                codigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(codigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                mensaje = Convert.ToString(codigo.Value);
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

        public string buscarIdSocio(string dniCliente)
        {
            string respuesta = "0";
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("SELECT id_socio FROM socios WHERE dni = @dni", sqlCon);

                comando.Parameters.AddWithValue("@dni", dniCliente);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    respuesta = reader.GetInt32(0).ToString();
                }
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

        public string existeCuotaSocio(int id)
        {
            string respuesta;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("existeCuotaSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("id", MySqlDbType.Int32).Value = id;

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

        public string buscarCuotasImpagas(int idSocio)
        {
            string respuesta = "0";
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = "SELECT c.idCuota FROM cuotas AS c INNER JOIN socios s ON s.id_socio = c.fk_socio " +
                    "JOIN (SELECT fk_socio, MAX(fecha_prox_vencimiento) AS max_fecha FROM cuotas GROUP BY fk_socio) AS px " +
                    "ON c.fk_socio = px.fk_socio AND c.fecha_prox_vencimiento = px.max_fecha " +
                    "WHERE px.max_fecha < @fecha and id_socio = @id ORDER BY c.fecha_prox_vencimiento DESC";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);

                comando.Parameters.AddWithValue("@id", idSocio);
                comando.Parameters.AddWithValue("@fecha", DateTime.Now.Date);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    respuesta = reader.GetInt32(0).ToString();
                }
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

        public DateTime buscarFechaVencimiento(int idSocio)
        {
            DateTime respuesta = new DateTime();
            bool estado = false;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("SELECT fecha_prox_vencimiento FROM cuotas WHERE fk_socio = @id ORDER BY fecha_prox_vencimiento DESC LIMIT 1", sqlCon);

                comando.Parameters.AddWithValue("@id", idSocio);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    respuesta = reader.GetDateTime(0);
                }
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
