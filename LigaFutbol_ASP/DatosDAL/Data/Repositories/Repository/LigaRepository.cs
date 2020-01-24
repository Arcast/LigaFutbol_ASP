using DatosDAL.Data.Repositories.IRepository;
using DatosDAL.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDAL.Data.Repositories.Repository
{
    public class LigaRepository: Repository<Liga>, ILigaRepository
    {
        public LigaRepository(DbContext context) : base(context)
        {

        }

        public DbContext LigaDbContext
        {
            get { return _context as DbContext; }
        }
    }
}
