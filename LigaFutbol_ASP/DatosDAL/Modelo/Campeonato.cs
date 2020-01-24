using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDAL.Modelo
{
    public class Campeonato
    {
        [Key]
        public int IdCampeonato { get; set; }
        public String CodigoCampeonato { get; set; }
        public String NombreCampeonato { get; set; }
        public String Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Boolean Estado { get; set; }

        public Liga Liga { get; set; }
        public Convocatoria Convocatoria { get; set; }
        public Categoria Categoria { get; set; }
        public ConfiguracionCampeonato ConfiguracionCampeonato { get; set; }

      
    }
}
