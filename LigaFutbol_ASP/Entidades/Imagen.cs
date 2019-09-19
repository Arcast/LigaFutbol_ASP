using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Imagen
    {
        [Key]
        public int IdImagen { get; set; }
        public String Procedencia { get; set; }
        public int Identificador { get; set; }
        public Byte Foto { get; set; }
    }
}
