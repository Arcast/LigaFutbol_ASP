using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arbitro
    {
        [Key]
        public int IdArbitro { get; set; }
        [Required(ErrorMessage = "nombre del arbitro es requerido")]
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Cedula { get; set; }
        public int Telefono { get; set; }
        public String Direccion { get; set; }

        public ICollection<Liga> Ligas { get; set; }

        public class map
        {
            public map(ref DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Arbitro>().Property(x => x.Nombres).HasMaxLength(250);
                modelBuilder.Entity<Arbitro>().Property(x => x.Apellidos).HasMaxLength(250);
                modelBuilder.Entity<Arbitro>().Property(x => x.Direccion).HasMaxLength(250);
            }
        }
    }
}
