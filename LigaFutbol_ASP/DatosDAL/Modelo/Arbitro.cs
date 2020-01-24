using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDAL.Modelo
{
    [Validator(typeof(ArbitroValidator))]
    public class Arbitro
    {
        [Key]
        public int IdArbitro { get; set; }
        [Required(ErrorMessage = "nombre del arbitro es requerido")]
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }

        public ICollection<Liga> Ligas { get; set; }

       
    }
}
