using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        public int IdEquipo { get; set; }
        public String CodigoEquipo { get; set; }
        public String NombreEquipo{ get; set; }
        public String Procedencia { get; set; }
        public DateTime FechaInscripcion { get; set; }

        public EquipoGrupo EquipoGrupo { get; set; }
        public RepresentanteEquipo RepresentanteEquipo { get; set; }
        public EquipoJugador EquipoJugador { get; set; }
        public Pago Pago { get; set; }

    }
}
