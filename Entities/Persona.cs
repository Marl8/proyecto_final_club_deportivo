using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Entities
{
    internal abstract class Persona
    {
        public string Nombre{ get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }

        protected Persona(string nombre, string apellido, string dni, string email, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Email = email;
            Telefono = telefono;
        }

        protected Persona(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }
    }
}
