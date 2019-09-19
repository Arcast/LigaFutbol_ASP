using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class DetalleTarjeta
    {
        [Key]
        public int IdDetalleTarjeta { get; set; }
        [Required]
        public int IdJugador { get; set; }
        [Required(ErrorMessage = "Seleccione el tipo de tarjeta")]
        public String TipoTarjeta { get; set; }
        public DateTime Hora { get; set; }

        public ICollection<Enfrentamiento> Enfrentamientos { get; set; }

    }
}
