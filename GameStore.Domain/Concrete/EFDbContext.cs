using GameStore.Domain.Entities;
using System.Data.Entity;

namespace GameStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        public EFDbContext(string connectionString) : base(nameOrConnectionString: connectionString)
        { }
    }
}