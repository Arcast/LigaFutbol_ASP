using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmergenciaJugador
    {
        [Key]
        public int IdEmergenciaJugador { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public int Telefono1{ get; set; }
        public int Telefono2{ get; set; }
        public String Parentezco { get; set; }

        public ICollection<Jugador> Jugador { get; set; }
    }
}
