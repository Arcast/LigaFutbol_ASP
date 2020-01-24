using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDAL.Modelo
{
    public class ConfiguracionCampeonato
    {
        [Key]
        public int IdConfiguracion { get; set; }
        public int CantidadVueltas { get; set; }
        public int JuegosXJornadas { get; set; }
        public int MaxJugadoresEq { get; set; }
        public int MinJugadoresEq { get; set; }

        public Boolean TraspasoJugador { get; set; }

        public Campeonato Campeonato { get; set; }
    }
}
