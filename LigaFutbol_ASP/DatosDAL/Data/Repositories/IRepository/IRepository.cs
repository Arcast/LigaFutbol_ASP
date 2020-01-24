using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DatosDAL.Data.Repositories.IRepository
{
    public interface IRepository<T> where T: class
    {
        T GetById(int id);
        IEnumerable<T> ListAll();
        IEnumerable<T> ListAllBy(Expression<Func<T,bool>> predicate);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        void AddOrUpdate(T Entidad);
        void AddRange(IEnumerable<T> Entity);
        void Remove(int id);

    }
}
