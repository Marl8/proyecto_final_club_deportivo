using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Datos
{
    public class Conexion // la clase debe ser PUBLICA
    {
        // declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion() 
        {
            this.baseDatos = "proyecto_club_deportivo";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "4842";
        }

        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? con = new MySqlConnection();

            try
            {
                con.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
            }        
            catch (Exception)
            {
                throw;
            }
            return con;
         }

        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) 
            {
                con = new Conexion(); 
            }
            return con;
        }
    }
}