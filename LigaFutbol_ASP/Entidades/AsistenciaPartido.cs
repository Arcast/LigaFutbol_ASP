using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AsistenciaPartido
    {
        [Key]
        public int IdAsistencia { get; set; }
        public int IdJugador { get; set; }
        public Boolean PartidoDisputado { get; set; }
        public ICollection<Enfrentamiento> Enfrentamientos { get; set; }
        
    }
}
