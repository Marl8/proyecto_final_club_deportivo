using MySql.Data.MySqlClient;
using proyecto_final_club_deportivo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace proyecto_final_club_deportivo.Datos
{
    internal class ActividadRepository
    {
        public string inscribirActividad(int idNoSocio, int idActividad, DateTime diaHabilitado) {
            string respuesta;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("inscribirActividad", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idNoSocio", MySqlDbType.Int32).Value = idNoSocio;
                comando.Parameters.Add("idActividad", MySqlDbType.Int32).Value = idActividad;
                comando.Parameters.Add("diaHabilitado", MySqlDbType.Date).Value = diaHabilitado.Date;
                MySqlParameter opRealizada = new MySqlParameter();
                opRealizada.ParameterName = "respuesta";
                opRealizada.MySqlDbType = MySqlDbType.Int32;
                opRealizada.Direction = ParameterDirection.Output;
                comando.Parameters.Add(opRealizada);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(opRealizada.Value);
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

        public string buscarIdActividad(string nombreAct)
        {
            string respuesta;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("buscarIdActividad", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("nombreActividad", MySqlDbType.VarChar).Value = nombreAct;

                MySqlParameter idActividad = new MySqlParameter();
                idActividad.ParameterName = "respuesta";
                idActividad.MySqlDbType = MySqlDbType.Int32;
                idActividad.Direction = ParameterDirection.Output;
                comando.Parameters.Add(idActividad);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(idActividad.Value);
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

        public string buscarNoSocio(string dniCliente)
        {
            string respuesta;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("buscarNoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("dniNoSocio", MySqlDbType.VarChar).Value = dniCliente;

                MySqlParameter idNoSocio = new MySqlParameter();
                idNoSocio.ParameterName = "respuesta";
                idNoSocio.MySqlDbType = MySqlDbType.Int32;
                idNoSocio.Direction = ParameterDirection.Output;
                comando.Parameters.Add(idNoSocio);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(idNoSocio.Value);
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

        public DataTable buscarActividad(string nombreAct)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("buscarActividad", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("nombreActividad", MySqlDbType.VarChar).Value = nombreAct;
                
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

        public string pagarActividad(int idNoSocio, int idAct, DateTime dia, double monto)
        {
            string respuesta;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("pagoDiario", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idNoSocio", MySqlDbType.Int32).Value = idNoSocio;
                comando.Parameters.Add("idActividad", MySqlDbType.Int32).Value = idAct;
                comando.Parameters.Add("diaHabilitado", MySqlDbType.Date).Value = dia.Date;
                comando.Parameters.Add("monto", MySqlDbType.Double).Value = monto;

                MySqlParameter codigo = new MySqlParameter();
                codigo.ParameterName = "respuesta";
                codigo.MySqlDbType = MySqlDbType.Int32;
                codigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(codigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(codigo.Value);
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
