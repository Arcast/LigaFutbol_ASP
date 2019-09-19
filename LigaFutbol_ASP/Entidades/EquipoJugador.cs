using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoJugador
    {
        [Key]
        public int IdEquipoJugador { get; set; }
        public int IdEquipo { get; set; }
        public int IdJugador { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public Boolean Estado{ get; set; }

        public ICollection<Equipo> Equipos { get; set; }
        public ICollection<Jugador> jugador { get; set; }
    }
}
