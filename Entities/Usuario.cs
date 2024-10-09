using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Entities
{
    internal class Usuario: Persona
    {
        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public string? Password { get; set; }
        public string Rol { get; set; }


        public Usuario(int id, string nombre, string apellido, string dni,
            string username, string rol)
            : base(nombre, apellido, dni)
        {
            IdUsuario = id;
            Username = username;
            Rol = rol;
        }

        public Usuario(string nombre, string apellido, string dni,
            string username, string rol)
            : base(nombre, apellido, dni)
        {
            Username = username;
            Rol = rol;
        }
    }
}
