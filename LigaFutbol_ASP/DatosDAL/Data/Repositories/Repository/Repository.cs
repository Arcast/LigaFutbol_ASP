using DatosDAL.Data.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DatosDAL.Data.Repositories.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        internal DbContext _context;
        internal DbSet<T> _DbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _DbSet = context.Set<T>();
        }

        public void AddOrUpdate(T Entidad)
        {
            _DbSet.AddOrUpdate(Entidad);
        }

        public void AddRange(IEnumerable<T> Entity)
        {
            _DbSet.AddRange(Entity);
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
           return _DbSet.Find(id);
        }

        public IEnumerable<T> ListAll()
        {
            return _DbSet.ToList();
        }

        public IEnumerable<T> ListAllBy(Expression<Func<T, bool>> predicate)
        {
            return _DbSet.Where(predicate).ToList();
        }

        public void Remove(int id)
        {
            var query = _DbSet.Find(id); ;
            _DbSet.Remove(query);
        }
    }
}
