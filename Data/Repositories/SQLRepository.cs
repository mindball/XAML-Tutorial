using System;
using System.Data.Entity;
using System.Linq;


namespace Data.Repositories
{
    public class SQLRepository<T> : IRepository<T> where T : class, new()
    {
        private readonly ApplicationDbContext context;
        private DbSet<T> dbSetEntity;

        public SQLRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.dbSetEntity = context.Set<T>();
        }

        public T Add(T entity)
        {
            var newEntity = dbSetEntity.Add(entity);
            this.SaveChanges();
            return newEntity;
        }

        public IQueryable<T> All()
            //=> this.dbSetEntity.AsQueryable<T>();
            => this.dbSetEntity.AsQueryable();

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Find(T entity)
            => dbSetEntity.Find(entity);

        public T Find(object id)
            => dbSetEntity.Find(id);

        public int SaveChanges()
            => this.context.SaveChanges();

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
