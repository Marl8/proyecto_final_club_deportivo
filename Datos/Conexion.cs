using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
         * Encriptamos la contraseña con una algoritmo SHA256 ya es considerado muy mala práctica guardar
         * contraseñas planas en la base de datos.
         * Sin embargo, a los fines de facilitar el acceso a la aplicación con el objeto de probar su 
         * funcionamiento se adjuntan los datos de logeo.
         * 
         * USUARIO ROL ADMINISTRADOR:
         * 
         * Username: prueba
         * Password: 123
         * 
         * USUARIO ROL EMPLEADO:
         * Username: fabi
         * Password: 12345
         * **/

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

        /*private Conexion() 
        {
            this.baseDatos = "proyecto_club_deportivo";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "4842";
        }*/

        private Conexion()
        {
            this.baseDatos = "bm0cbfipzlmy25cartq2";
            this.servidor = "bm0cbfipzlmy25cartq2-mysql.services.clever-cloud.com";
            this.puerto = "3306";
            this.usuario = "ugjrogu4xztm9uix";
            this.clave = "HJFkxQONPWlyE13xxf7u";
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