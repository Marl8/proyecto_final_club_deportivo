using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using proyecto_final_club_deportivo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public DataTable listarUsuarios()
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = "SELECT u.id, u.nombre, u.apellido, u.dni, u.username, r.Nombre FROM usuarios AS u " +
                    "INNER JOIN roles AS r ON u.fk_rol = r.id_rol";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;

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

        public DataTable buscarUsuarioPorId(int id)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = "SELECT u.id, u.nombre, u.apellido, u.username, u.dni, u.email, u.telefono, u.fk_rol FROM usuarios AS u WHERE u.id = @id";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@id", id);

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

        public DataTable buscarUsuarioPorUsername(string username)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = "SELECT u.id, u.nombre, u.apellido, u.username, u.dni, u.email, u.telefono, u.fk_rol FROM usuarios AS u WHERE u.username = @username";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@username", username);

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

        public string editarUsuario(Usuario user, int idRol)
        {
            string respuesta;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("modificarUsuario", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("nombreUs", MySqlDbType.VarChar).Value = user.Nombre;
                comando.Parameters.Add("apellidoUs", MySqlDbType.VarChar).Value = user.Apellido;
                comando.Parameters.Add("usernameUs", MySqlDbType.VarChar).Value = user.Username;
                comando.Parameters.Add("passwordUs", MySqlDbType.VarChar).Value = user.Password;
                comando.Parameters.Add("dniUs", MySqlDbType.VarChar).Value = user.Dni;
                comando.Parameters.Add("emailUs", MySqlDbType.VarChar).Value = user.Email;
                comando.Parameters.Add("telefonoUs", MySqlDbType.VarChar).Value = user.Telefono;
                comando.Parameters.Add("rolUs", MySqlDbType.Int32).Value = idRol;

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

        public string eliminarUsuario(int id)
        {
            string respuesta;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("eliminarUsuario", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idUsuario", MySqlDbType.Int32).Value = id;

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

        public DataTable buscarRol(string nombre)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = "SELECT id_rol FROM roles AS r WHERE r.Nombre = @nombre";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@nombre", nombre);

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

