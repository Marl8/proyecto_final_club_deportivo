using proyecto_final_club_deportivo.Datos;
using proyecto_final_club_deportivo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable listarSociosVencimientoDiario(DateTime fecha)
        {
            return socioRepository.listarSociosVencimientoDiario(fecha);
        }

        public DataTable listarSociosEnMora(DateTime fecha)
        {
            return socioRepository.listarSociosEnMora(fecha);
        }

        public string modificarEstadoSocio(string dni, bool estado)
        {
            return socioRepository.modificarEstadoSocio(dni, estado);
        }
    }
}
