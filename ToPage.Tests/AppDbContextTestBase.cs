using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using ToPage.Tests.Data;

namespace ToPage.Tests
{
    public class AppDbContextTestBase : IDisposable
    {
        private readonly SqliteConnection _connection;
        protected readonly AppDbContext _context;

        public AppDbContextTestBase()
        {
            _connection = new SqliteConnection("Data source=:memory:");
            _connection.Open();

            _context = new AppDbContext(new DbContextOptionsBuilder<AppDbContext>()
               .UseSqlite(_connection)
               .Options);

            Seed();
        }

        private void Seed()
        {
            _context.Database.EnsureCreated();
            _context.People.AddRange(Enumerable.Range(1, 100).Select(x => new Person { Name = x.ToString() }));
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            _connection.Dispose();
        }
    }
}
