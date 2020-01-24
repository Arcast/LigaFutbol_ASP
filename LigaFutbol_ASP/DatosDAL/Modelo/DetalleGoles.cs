using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDAL.Modelo
{
    public class DetalleGoles
    {
        [Key]
        public int IdDetalleGoles { get; set; }
        public int IdJugador { get; set; }
        public int IdEquipo { get; set; }
        public TimeSpan MyProperty { get; set; }
        public Boolean GolEnContra { get; set; }

        public ICollection<Enfrentamiento> Enfrentamientos { get; set; }

    }
}
