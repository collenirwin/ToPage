using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
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
        }

        public void Dispose()
        {
            _context.Dispose();
            _connection.Dispose();
        }
    }
}
