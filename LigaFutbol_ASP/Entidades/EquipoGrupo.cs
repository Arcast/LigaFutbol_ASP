using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoGrupo
    {
        [Key]
        public int IdEquipoGrupo { get; set; }
        public int IdEquipo { get; set; }
        public int IdGrupo { get; set; }
        public Boolean Estado { get; set; }

        public ICollection<Grupo> grupos { get; set; }
        public ICollection<Equipo> Equipos { get; set; }

        
    }
}
