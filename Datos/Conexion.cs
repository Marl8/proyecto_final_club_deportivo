using MySql.Data.MySqlClient;
using System;
using System.Xml;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            this.clave = "";
        }*/

        /*private Conexion()
        {
            this.baseDatos = "bm0cbfipzlmy25cartq2";
            this.servidor = "bm0cbfipzlmy25cartq2-mysql.services.clever-cloud.com";
            this.puerto = "3306";
            this.usuario = "ugjrogu4xztm9uix";
            this.clave = "HJFkxQONPWlyE13xxf7u";
        }*/

        private Conexion() // asignamos valores a las variables de la conexion
        {
            // Leer configuración del archivo XML si existe
            if (System.IO.File.Exists("configuracion.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("configuracion.xml");
                this.baseDatos = doc.SelectSingleNode("/configuracion/baseDatos").InnerText;
                this.servidor = doc.SelectSingleNode("/configuracion/servidor").InnerText;
                this.puerto = doc.SelectSingleNode("/configuracion/puerto").InnerText;
                this.usuario = doc.SelectSingleNode("/configuracion/usuario").InnerText;
                this.clave = doc.SelectSingleNode("/configuracion/clave").InnerText;
            }
            else
            {
                // variables usadas para la repetición de líneas de código
                bool correcto = false;
                int mensaje;
                // creamos las variables para recibir los datos desde el teclado
                string T_servidor = "Servidor";
                string T_puerto = "Puerto";
                string T_usuario = "Usuario";
                string T_clave = "Clave";
                while (correcto != true)
                {
                    // Armamos los cuadros de dialogo para el ingreso de datos
                    T_servidor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
                    T_puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
                    T_usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
                    T_clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese clave", "DATOS DE INSTALACIÓN MySQL");
                    mensaje = (int)MessageBox.Show("Su ingreso: SERVIDOR = " +
                    T_servidor + " PUERTO = " + T_puerto + " USUARIO = " +
                    T_usuario + " CLAVE = " + T_clave,
                    "AVISO DEL SISTEMA", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (mensaje != 6) // el valor 6 corresponde al SI
                    {
                        MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                        correcto = false;
                    }
                    else
                    {
                        correcto = true;
                    }
                }
                // Asignar las variables
                this.baseDatos = "proyecto_club_deportivo";
                this.servidor = T_servidor;
                this.puerto = T_puerto;
                this.usuario = T_usuario;
                this.clave = T_clave;

                if (verificarConexion())
                {
                    CrearConexion();
                    // Crear y guardar el archivo XML con las credenciales
                    XmlTextWriter xmlWriter = new XmlTextWriter("configuracion.xml", System.Text.Encoding.UTF8);
                    xmlWriter.WriteStartDocument();
                    xmlWriter.Formatting = Formatting.Indented;
                    // Escribir el elemento raíz
                    xmlWriter.WriteStartElement("configuracion");
                    // Escribir elementos
                    xmlWriter.WriteElementString("baseDatos", this.baseDatos);
                    xmlWriter.WriteElementString("servidor", this.servidor);
                    xmlWriter.WriteElementString("puerto", this.puerto);
                    xmlWriter.WriteElementString("usuario", this.usuario);
                    xmlWriter.WriteElementString("clave", this.clave);
                    // Cerrar el elemento raíz
                    xmlWriter.WriteEndElement();
                    // Cerrar el documento
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Close();
                }
                else
                {
                    MessageBox.Show("Datos de conexión invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }


        /*private Conexion() // asignamos valores a las variables de la conexion
        {
            // variables usadas para larepetición de líneas de código
            bool correcto = false;
            int mensaje;
            // creamos las variables para recibir los datos desde el teclado

            string T_servidor = "Servidor" ;
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave";

            while (correcto != true)
            {
                // Armamos los cuadros de dialogo para el ingreso de datos
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese clave", "DATOS DE INSTALACIÓN MySQL");

                mensaje = (int)MessageBox.Show("su ingreso: SERVIDOR = " +
                T_servidor + " PUERTO= " + T_puerto + " USUARIO: " +
                T_usuario + " CLAVE: " + T_clave,
                "AVISO DEL SISTEMA", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                
                if (mensaje != 6) // el valor 6 corresponde al SI
                {
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }
            }

            // reemplazamos los datos concretos que teniamos por las variables
            this.baseDatos = "proyecto_club_deportivo";
            this.servidor = T_servidor; // "localhost";
            this.puerto = T_puerto; //"3306";
            this.usuario = T_usuario; // "root";
            this.clave = T_clave; // "";
        }*/


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

        public bool verificarConexion()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(
                    $"datasource={this.servidor};port={this.puerto};username={this.usuario};password={this.clave};Database={this.baseDatos}"))
                {
                    conexion.Open();
                    conexion.Close();
                    return true; // La conexión fue exitosa
                }
            }
            catch (Exception)
            {
                return false; // La conexión falló
            }
        }
    }
}