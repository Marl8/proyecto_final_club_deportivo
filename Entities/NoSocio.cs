using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Entities
{
    internal class NoSocio: Persona
    {
        public int IdNoSocio { get; }
        public DateTime DiaHabilitado { get; set; }
        public bool AptoFisico {  get; set; }
        public List<Actividad>? listaActividades { get; set; }

        public NoSocio(int idNoSocio, DateTime dia, bool aptoFisico, string nombre, string apellido, string dni,
            string email, string telefono) 
            : base(nombre, apellido, dni, email, telefono)
        {
            this.IdNoSocio = idNoSocio;
            this.DiaHabilitado = dia;
            this.AptoFisico = aptoFisico;
        }

        public NoSocio(DateTime dia, bool aptoFisico, string nombre, string apellido, string dni,
            string email, string telefono)
            : base(nombre, apellido, dni, email, telefono)
        {
            this.DiaHabilitado = dia;
            this.AptoFisico = aptoFisico;
        }
    }
}
