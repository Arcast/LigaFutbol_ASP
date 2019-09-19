using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        public String NombreCategoria { get; set; }
        public String DescripcionCategoria { get; set; }

        public Campeonato Campeonato { get; set; }
    }
}
