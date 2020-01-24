using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDAL.Modelo
{
    public class Jugador
    {
        [Key]
        public int IdJugador { get; set; }
        public String PNombre { get; set; }
        public String SNombre { get; set; }
        public String PApellido { get; set; }
        public String SApellido { get; set; }
        public String Direccion{ get; set; }
        public int Telefono { get; set; }
        public  DateTime FechaNacimiento { get; set; }

        public EquipoJugador EquipoJugador { get; set; }
        public EmergenciaJugador EmergenciaJugador { get; set; }

    }
}
