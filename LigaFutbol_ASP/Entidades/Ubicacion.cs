using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ubicacion
    {
        [Key]
        public int IdUbicacion { get; set; }
        [Required(ErrorMessage = "Nombre del pais es requerido")]
        public String Pais { get; set; }
        public String Departamento { get; set; }
        public String Municipio { get; set; }
        public String Comunidad { get; set; }

        public ICollection<Liga> ligas { get; set; }
    }
}
