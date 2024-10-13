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

       public string crearCuota(Cuota cuota, int idSocio)
        {
            return cuotaRepository.crearCuota(cuota, idSocio);
        }

        public string pagarCuota(int idSocio, double valor, DateTime fechaPago, string formaPago, int cantCuotas)
        {
            return cuotaRepository.pagarCuota(idSocio, valor, fechaPago, formaPago, cantCuotas);
        }

        public string buscarSocio(string dni)
        {
            return cuotaRepository.buscarSocio(dni);
        }

        public string existeCuotaSocio(int id)
        {
            return cuotaRepository.existeCuotaSocio(id);
        }

        public string buscarCuotasImpagas(int idSocio)
        {
            return cuotaRepository.buscarCuotasImpagas(idSocio);
        }

    }
}
