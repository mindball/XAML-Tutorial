using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoOrganizer.Core.Common.Contracts
{
    public interface IDataRepository
    {
    }
    public interface IDataRepository<T> : IDataRepository where T : class, new()
    {
        T Get(int id);

        T Add(T entity);

        void Remove(T entity);

        void Remove(int id);

        T Update(T entity);

        IEnumerable<T> Get();
    }
}
