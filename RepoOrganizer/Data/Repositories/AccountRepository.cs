using RepoOrganizer.Data.Contracts;
using RepoOrganizer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoOrganizer.Data.Repositories
{
    /// <summary>
    /// I have an interface that I can use for dependency injection here.
    /// this class are ready to use with DI container <IAccountRepository, AccountRepository>
    /// </summary>
    public class AccountRepository : DataRepositoryBase<Account>, IAccountRepository
    {
        /// <summary>
        /// simply instantiating the Entity Framework context on its own
        /// </summary>
        /// <param name="login">Account login info</param>
        /// <returns></returns>
        public Account GetByLogin(string login)
        {
            using (DataContexClassIsHere entityDbContext = new DataContexClassIsHere)
            {
                return entityDbContext.AccountSet
                    .Where(a => a.LoginEmail == login)
                    .FirstOrDefault();
            }
        }

        protected override Account AddEntity(DataContexClassIsHere entityContext, Account entity)
            => entityContext.AccountSet.Add(entity);   
        

        protected override IEnumerable<Account> GetEntities(DataContexClassIsHere entityContext)
            => entityContext.AccountSet.ToList();

        protected override Account GetEntity(DataContexClassIsHere entityContext, int id)
            => entityContext.AccountSet
                .Where(a => a.AccountId == id)
                .FirstOrDefault();

        protected override Account UpdateEntity(DataContexClassIsHere entityContext, Account entity)
            => entityContext.AccountSet
                .Where(x => x.AccountId == entity.AccountId)
                .FirstOrDefault();
    }
}
