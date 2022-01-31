using RepoOrganizer.Core.Common.Contracts;
using RepoOrganizer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoOrganizer.Data.Contracts
{
    public interface IAccountRepository : IDataRepository<Account>
    {
        /// <summary>
        /// We are not limited by basic data repo , but we are adding new features
        /// (custom methods)
        /// </summary>
        /// <param name="login">Some login info</param>
        /// <returns></returns>
        Account GetByLogin(string login);
    }
}
