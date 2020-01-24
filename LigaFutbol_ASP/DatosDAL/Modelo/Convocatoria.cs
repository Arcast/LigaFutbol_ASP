using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDAL.Modelo
{
    public class Convocatoria
    {
        [Key]
        public int IdConvocatoria { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Boolean Estado { get; set; }
        public Campeonato Campeonato { get; set; }
    }
}
