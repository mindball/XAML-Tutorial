using RepoOrganizer.Data.Entities;
using System.Data.Entity;

namespace RepoOrganizer.Data
{
    public class DataContexClassIsHere : DbContext
    {

        public DbSet<Account> AccountSet { get; set; }    
    }
}
