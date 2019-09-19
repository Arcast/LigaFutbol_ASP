using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Liga
    {
        [Key]
        public int IdLiga { get; set; }
        public String CodigoLiga { get; set; }

        [Required(ErrorMessage = "El nombre de la liga es requerido")]
        public String NombreLiga { get; set; }
        public String Descripcion { get; set; }
        [DisplayName("Fecha de creación")]
        public DateTime FechaCreacion { get; set; }
        public Boolean Estado { get; set; }

        public RepresentanteLiga RepresentanteLiga { get; set; }
        public Arbitro Arbitro { get; set; }
        public Ubicacion Ubicacion { get; set; }
        public ConceptoPago ConceptoPago { get; set; }
        public ICollection<Campeonato> Campeonato { get; set; }

    
    }
}
