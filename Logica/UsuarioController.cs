using proyecto_final_club_deportivo.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Logica
{
    internal class UsuarioController
    {
        UsuarioRepository usuarioRepository = new UsuarioRepository();
        
        public DataTable login(string username, string password)
        {
            return this.usuarioRepository.loginUsuario(username, password);
        }
    }
}
