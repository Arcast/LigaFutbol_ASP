using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDAL.Modelo
{
    public class RepresentanteLiga
    {
        [Key]
        public int IdRepresentante { get; set; }
        [Required(ErrorMessage = "Nombre del representante es requerido")]
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Cedula { get; set; }
        public String Direccion { get; set; }
        public int Telefono { get; set; }
        public String Puesto { get; set; }

        public ICollection<Liga> Ligas { get; set; }

      
    }
}
