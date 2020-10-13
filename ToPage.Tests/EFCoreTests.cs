using System;
using System.Linq;
using System.Threading.Tasks;
using ToPage.EFCore;
using ToPage.Tests.Data;
using Xunit;

namespace ToPage.Tests
{
    public class EFCoreTests : AppDbContextTestBase
    {
        [Fact]
        public async Task Has_Correct_PageNumber()
        {
            // arrange
            var query = GetAllPeopleOrderedByNameQuery();
            int pageNumber = 1;
            int itemsPerPage = 10;

            // act
            var page = await query.ToPageAsync(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(pageNumber, page.PageNumber);
        }

        [Fact]
        public async Task Has_Correct_Has_Correct_Number_Of_Items()
        {
            // arrange
            var query = GetAllPeopleOrderedByNameQuery();
            int pageNumber = 1;
            int itemsPerPage = 10;

            // act
            var page = await query.ToPageAsync(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(itemsPerPage, page.Items.Count());
        }

        [Fact]
        public async Task Throws_On_Null_Query()
        {
            // arrange
            IOrderedQueryable<int> query = null;
            int pageNumber = 1;
            int itemsPerPage = 10;

            // act, assert
            await Assert.ThrowsAsync<ArgumentNullException>(async () => _ = await query
                .ToPageAsync(pageNumber, itemsPerPage));
        }

        [Fact]
        public async Task Throws_On_PageNumber_Under_1()
        {
            // arrange
            var query = GetAllPeopleOrderedByNameQuery();
            int pageNumber = 0;
            int itemsPerPage = 10;

            // act, assert
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () => _ = await query
                .ToPageAsync(pageNumber, itemsPerPage));
        }

        [Fact]
        public async Task Throws_On_ItemsPerPage_Under_1()
        {
            // arrange
            var query = GetAllPeopleOrderedByNameQuery();
            int pageNumber = 1;
            int itemsPerPage = 0;

            // act, assert
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () => _ = await query
                .ToPageAsync(pageNumber, itemsPerPage));
        }

        [Fact]
        public async Task Gets_Leftover_Items_On_Last_Page()
        {
            // arrange
            var query = GetAllPeopleOrderedByNameQuery();
            int pageNumber = 7;
            int itemsPerPage = 15;

            // act
            var page = await query.ToPageAsync(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(10, page.Items.Count());
        }

        [Fact]
        public async Task Gets_0_Items_When_PageNumber_Is_Too_High()
        {
            // arrange
            var query = GetAllPeopleOrderedByNameQuery();
            int pageNumber = 1000;
            int itemsPerPage = 10;

            // act
            var page = await query.ToPageAsync(pageNumber, itemsPerPage);

            // assert
            Assert.Empty(page.Items);
        }

        private IOrderedQueryable<Person> GetAllPeopleOrderedByNameQuery()
            => _context.People
                .OrderBy(person => person.Name);
    }
}
