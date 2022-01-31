using RepoOrganizer.Core.Common.Contracts;

namespace RepoOrganizer.Data
{
    public class DataRepositoryFactory : IDataRepositoryFactory
    {
        /// <summary>
        /// Return actual repo, from DI container
        /// </summary>
        /// <typeparam name="T">Entity repository</typeparam>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public T GetDataRepository<T>() where T : IDataRepository
        {
            throw new System.NotImplementedException();
        }
    }
}
