using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_club_deportivo.Entities
{
    internal class Cuota
    {
        public int id {  get; }
        public double? ValorCouta { get; set; }
        public DateTime? FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string FormaPago { get; set; }
        public int CantidadCuotas { get; set; }
        public bool Estado {  get; set; }


        public Cuota(int id, double valorCouta, DateTime fechaPago, DateTime fechaVencimiento,
            string formaPago, int cantidadCuotas, bool estado)
        {
            this.id = id;
            this.ValorCouta = valorCouta;
            this.FechaPago = fechaPago;
            this.FechaVencimiento = fechaVencimiento;
            this.FormaPago = formaPago;
            this.CantidadCuotas = cantidadCuotas;
            this.Estado = estado;
        }

        public Cuota(double? valorCouta, DateTime? fechaPago, DateTime fechaVencimiento,
            string formaPago, int cantidadCuotas, bool estado)
        {
            this.ValorCouta = valorCouta;
            this.FechaPago = fechaPago;
            this.FechaVencimiento = fechaVencimiento;
            this.FormaPago = formaPago;
            this.CantidadCuotas = cantidadCuotas;
            this.Estado = estado;
        }
    }
}
