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
        public void Has_Correct_PageNumber()
        {
            // arrange
            var query = GetAllPeopleOrderedByNameQuery();
            int pageNumber = 1;
            int itemsPerPage = 10;

            // act
            var page = query.ToPage(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(pageNumber, page.PageNumber);
        }

        [Fact]
        public void Has_Correct_Has_Correct_Number_Of_Items()
        {
            // arrange
            var query = GetAllPeopleOrderedByNameQuery();
            int pageNumber = 1;
            int itemsPerPage = 10;

            // act
            var page = query.ToPage(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(itemsPerPage, page.Items.Count());
        }

        [Fact]
        public void Throws_On_Null_Query()
        {
            // arrange
            IOrderedQueryable<int> query = null;
            int pageNumber = 1;
            int itemsPerPage = 10;

            // act, assert
            Assert.Throws<ArgumentNullException>(() => _ = query.ToPage(pageNumber, itemsPerPage));
        }

        [Fact]
        public void Throws_On_PageNumber_Under_1()
        {
            // arrange
            var query = GetAllPeopleOrderedByNameQuery();
            int pageNumber = 0;
            int itemsPerPage = 10;

            // act, assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _ = query.ToPage(pageNumber, itemsPerPage));
        }

        [Fact]
        public void Throws_On_ItemsPerPage_Under_1()
        {
            // arrange
            var query = GetAllPeopleOrderedByNameQuery();
            int pageNumber = 1;
            int itemsPerPage = 0;

            // act, assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _ = query.ToPage(pageNumber, itemsPerPage));
        }

        [Fact]
        public void Gets_Leftover_Items_On_Last_Page()
        {
            // arrange
            var query = GetAllPeopleOrderedByNameQuery();
            int pageNumber = 7;
            int itemsPerPage = 15;

            // act
            var page = query.ToPage(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(10, page.Items.Count());
        }

        [Fact]
        public void Gets_0_Items_When_PageNumber_Is_Too_High()
        {
            // arrange
            var query = GetAllPeopleOrderedByNameQuery();
            int pageNumber = 1000;
            int itemsPerPage = 10;

            // act
            var page = query.ToPage(pageNumber, itemsPerPage);

            // assert
            Assert.Empty(page.Items);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(99)]
        [InlineData(0)]
        [InlineData(1)]
        public void Has_Correct_ItemCount(int itemCount)
        {
            // arrange
            var query = GetAllPeopleOrderedByNameQuery(itemCount);
            int pageNumber = 1;
            int itemsPerPage = 10;

            // act
            var page = query.ToPageWithCounts(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(itemCount, page.ItemCount);
        }

        [Theory]
        [InlineData(100, 10, 10)]
        [InlineData(92, 10, 10)]
        [InlineData(0, 10, 0)]
        [InlineData(1, 10, 1)]
        public void Has_Correct_PageCount(int itemCount, int itemsPerPage, int pageCount)
        {
            // arrange
            var query = GetAllPeopleOrderedByNameQuery(itemCount);
            int pageNumber = 1;

            // act
            var page = query.ToPageWithCounts(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(pageCount, page.PageCount);
        }

        private IOrderedQueryable<Person> GetAllPeopleOrderedByNameQuery(int length = 100)
            => _context.People
                .Take(length)
                .OrderBy(person => person.Name);
    }
}
