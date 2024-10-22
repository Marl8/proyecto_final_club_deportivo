using proyecto_final_club_deportivo.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Logica
{
    internal class UsuarioController
    {
        UsuarioRepository usuarioRepository = new UsuarioRepository();
        
        public DataTable login(string username, string password)
        {
            string pass = getSHA256(password);
            return this.usuarioRepository.loginUsuario(username, pass);
        }


        // Encripta la contraseña con un algoritmo SHA256
        public static string getSHA256(string str)
        {
            SHA256 sha256 = SHA256.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
