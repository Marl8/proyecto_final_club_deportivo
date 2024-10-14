using proyecto_final_club_deportivo.Datos;
using proyecto_final_club_deportivo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Logica
{
    internal class SocioController
    {
        internal SocioRepository socioRepository = new SocioRepository();

        public string inscribirSocio(Socio socio)
        {
            return socioRepository.inscribirSocio(socio);
        }

        public Socio buscarSocio(string dni) 
        {
            return socioRepository.buscarSocio(dni);
        }
    }
}
