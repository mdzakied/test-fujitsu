using Microsoft.EntityFrameworkCore;

namespace TestFujitsu.Models
{
    public class StorageContext : DbContext
    {
        public StorageContext(DbContextOptions<StorageContext> options) : base(options) { }

        public DbSet<Storage> Storages { get; set; }

    }
}
