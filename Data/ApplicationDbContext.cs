using ShirtsModels;
using System.Data.Entity;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Shirt> Shirts { get; set; }
    }
}
