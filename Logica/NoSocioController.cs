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
    internal class NoSocioController
    {
        internal NoSocioRepository noSocioRepository = new NoSocioRepository();

        public string inscribirNoSocio(NoSocio noSocio)
        {
            return noSocioRepository.inscribirNoSocio(noSocio);
        }

        public DataTable listarNoSocios(DateTime dia) { 
            return noSocioRepository.listarNoSociosHabilitados(dia);
        }
    }
}
