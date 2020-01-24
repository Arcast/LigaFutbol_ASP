using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDAL.Modelo
{
    public class Compras
    {
        [Key]
        public int MyProperty { get; set; }
        public String Concepto { get; set; }
        public decimal Monto { get; set; }
        public String Moneda { get; set; }
        public DateTime Fecha { get; set; }

        public ICollection<Liga> Ligas { get; set; }

       

    }
}
