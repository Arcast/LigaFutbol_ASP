using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDAL.Modelo
{
   public class RepresentanteEquipo
    {
        [Key]
        public int IdRepresentanteEquipo { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Cedula { get; set; }
        public int Telefono { get; set; }

        public Equipo Equipo { get; set; }

    }
}
