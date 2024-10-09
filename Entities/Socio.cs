using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Entities
{
    internal class Socio : Persona
    {
        public int IdSocio {  get; }
        public bool EstadoSocio { get; set; }
        public bool AptoFisico { get; set; }

        public Socio(int idSocio, bool estadoSocio, bool aptoFisico, string nombre,
            string apellido, string dni, string email, string telefono) 
            : base(nombre, apellido, dni, email, telefono)
        {
            IdSocio = idSocio;
            EstadoSocio = estadoSocio;
            AptoFisico = aptoFisico;
        }

        public Socio(bool estadoSocio, bool aptoFisico, string nombre,
            string apellido, string dni, string email, string telefono)
            : base(nombre, apellido, dni, email, telefono)
        {
            EstadoSocio = estadoSocio;
            AptoFisico = aptoFisico;
        }
    }
}
