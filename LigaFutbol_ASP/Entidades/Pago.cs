using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pago
    {
        [Key]
        public int IdPago { get; set; }
        public int Concepto { get; set; }
        public decimal MontoConcepto { get; set; }
        public decimal MontoRecibido { get; set; }
        public DateTime Fecha { get; set; }
        public  int IdRecibidoPor { get; set; }
        public Boolean Abono { get; set; }

        public ICollection<Equipo> Equipos { get; set; }
    }
}
