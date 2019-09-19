using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enfrentamiento
    {
        [Key]
        public int IdEnfrentamiento { get; set; }
        public int NumeroJornada { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int NumJuego { get; set; }
        public int EquipoLocal { get; set; }
        public int EquipoVisitante { get; set; }
        public int NumeroVuelta { get; set; }
        public int Arbitro { get; set; }
        public String Estado { get; set; }

        public ICollection<Grupo> Grupos { get; set; }
        public DetalleTarjeta DetalleTarjeta { get; set; }
        public AsistenciaPartido AsistenciaPartido { get; set; }
        public DetalleGoles DetalleGoles { get; set; }
        public ObservacionEnfrentamiento Observacion { get; set; }
    }
}
