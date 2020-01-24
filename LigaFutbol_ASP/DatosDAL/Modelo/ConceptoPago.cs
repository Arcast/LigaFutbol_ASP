using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDAL.Modelo
{
    public class ConceptoPago
    {
        [Key]
        public int IdConceptoPago { get; set; }
        public String Concepto { get; set; }
        public Decimal Monto { get; set; }
        public String Moneda { get; set; }
        public Boolean Estado { get; set; }

        public ICollection<Liga> Ligas { get; set; }

       
    }
}
