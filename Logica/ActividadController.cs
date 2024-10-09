using proyecto_final_club_deportivo.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Logica
{
    internal class ActividadController
    {
        ActividadRepository actividadRepository = new ActividadRepository();

        public string inscribirActividad(int idNoSocio, int idActividad)
        {
            return actividadRepository.inscribirActividad(idNoSocio, idActividad);
        }

        public string buscarActividad(string nombreAct) 
        {
            return actividadRepository.buscarActividad(nombreAct);
        }

        public string buscarNoSocio(string dniCliente)
        {
            return actividadRepository.buscarNoSocio(dniCliente);
        }
    }
}
