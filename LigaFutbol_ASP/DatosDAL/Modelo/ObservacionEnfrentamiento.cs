using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDAL.Modelo
{
    public class ObservacionEnfrentamiento
    {
        [Key]
        public int IdObservacion { get; set; }
        public String Observaciones { get; set; }
        public String RealizadaPor { get; set; }
        public ICollection<Enfrentamiento> Enfrentamientos { get; set; }

    }
}
