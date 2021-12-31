using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IRepository<T> where T : class, new()
    {
        IQueryable<T> All();

        T Find(T entity);

        T Find(object id);

        T Update(T entity);

        bool Delete(T entity);

        int SaveChanges();

        T Add(T entity);
    }
}
