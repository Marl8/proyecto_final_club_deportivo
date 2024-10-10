using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Entities
{
    internal class Actividad
    {
        public int IdActividad { get; }
        public string NombreActividad { get; set; }
        public double ValorActividad { get; set; }

        public Actividad(int idActividad, string nombreActividad, double valorActividad)
        {
            this.IdActividad = idActividad;
            this.NombreActividad = nombreActividad;
            this.ValorActividad = valorActividad;
        }

        public Actividad(string nombreActividad, double valorActividad)
        {
            this.NombreActividad = nombreActividad;
            this.ValorActividad = valorActividad;
        }
    }
}
