using Microsoft.EntityFrameworkCore;

namespace ToPage.Tests.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
