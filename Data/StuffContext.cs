using Microsoft.EntityFrameworkCore;

namespace TestFujitsu.Models
{
    public class StuffContext : DbContext
    {
        public StuffContext(DbContextOptions<StuffContext> options) : base(options) { }

        public DbSet<Stuff> Stuffs { get; set; }

    }
}