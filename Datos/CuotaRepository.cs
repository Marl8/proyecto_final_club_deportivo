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
        public string crearCuota(Cuota cuota)
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
                comando.Parameters.Add("formaPago", MySqlDbType.VarChar).Value =
                cuota.FormaPago;
                comando.Parameters.Add("cantCuotas", MySqlDbType.Int32).Value =
                cuota.CantidadCuotas;
                comando.Parameters.Add("estadoCuota", MySqlDbType.Byte).Value =
                cuota.Estado;
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

        public string buscarSocio(string dniCliente)
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
    }
}
