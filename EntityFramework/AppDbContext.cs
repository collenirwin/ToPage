using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EntityFramework
{
    public class AppDbContext : DbContext
    {
        private static readonly Random _random = new Random();

        public DbSet<Person> People { get; set; }

        public AppDbContext()
            : base(new DbContextOptionsBuilder()
                .UseSqlite("Data Source=example.db")
                .Options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var colors = new[] { "Red", "Green", "Blue", "Yellow", "Purple", "Pink", "Brown", "Orange" };

            // seed the database with 500 users with random ages and favorite colors
            modelBuilder.Entity<Person>()
                .HasData(data: Enumerable.Range(1, 500)
                    .Select(index => new Person
                    {
                        Id = index,
                        Age = _random.Next(1, 121),
                        FavoriteColor = colors[_random.Next(colors.Length)]
                    }));
        }
    }
}
