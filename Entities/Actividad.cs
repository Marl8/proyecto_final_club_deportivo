using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Entities
{
    internal class Actividad
    {
        public int idActividad { get; }
        public string nombreActividad { get; set; }
        public double valorActividad { get; set; }

        public Actividad(int idActividad, string nombreActividad, double valorActividad)
        {
            this.idActividad = idActividad;
            this.nombreActividad = nombreActividad;
            this.valorActividad = valorActividad;
        }

        public Actividad(string nombreActividad, double valorActividad)
        {
            this.nombreActividad = nombreActividad;
            this.valorActividad = valorActividad;
        }
    }
}
