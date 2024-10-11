using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Datos
{
    internal class UsuarioRepository
    {   
        public DataTable loginUsuario(string username, string password)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                //MySqlCommand comando = new MySqlCommand("SELECT username, password FROM usuario u WHERE username = @username AND password = @password", sqlCon);
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("username",MySqlDbType.VarChar).Value = username;
                comando.Parameters.Add("pass", MySqlDbType.VarChar).Value = password;
                //comando.Parameters.AddWithValue("@username", username);
                //comando.Parameters.AddWithValue("@password", password);

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
