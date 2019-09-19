using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        [Key]
        public int IdGrupo { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }

        public String Descripcion { get; set; }
        public ICollection<Campeonato> Campeonatos { get; set; }
        public Enfrentamiento Enfrentamiento { get; set; }
        public EquipoGrupo EquipoGrupo { get; set; }

    }
}
