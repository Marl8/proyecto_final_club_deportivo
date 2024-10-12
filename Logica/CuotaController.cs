using proyecto_final_club_deportivo.Datos;
using proyecto_final_club_deportivo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Logica
{
    internal class CuotaController
    {
       internal CuotaRepository cuotaRepository = new CuotaRepository();

       public string crearCuota(Cuota cuota)
        {
            return cuotaRepository.crearCuota(cuota);
        }

        public string buscarSocio(string dni)
        {
            return cuotaRepository.buscarSocio(dni);
        }
    }
}
