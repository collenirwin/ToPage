using System;
using System.Linq;
using Xunit;

namespace ToPage.Tests
{
    public class QueryableTests
    {
        [Fact]
        public void Has_Correct_PageNumber()
        {
            // arrange
            var query = GetBasicOrderedQuery();
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
            var query = GetBasicOrderedQuery();
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
            IOrderedQueryable<int> query = GetBasicOrderedQuery();
            int pageNumber = 0;
            int itemsPerPage = 10;

            // act, assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _ = query.ToPage(pageNumber, itemsPerPage));
        }

        [Fact]
        public void Throws_On_ItemsPerPage_Under_1()
        {
            // arrange
            IOrderedQueryable<int> query = GetBasicOrderedQuery();
            int pageNumber = 1;
            int itemsPerPage = 0;

            // act, assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _ = query.ToPage(pageNumber, itemsPerPage));
        }

        private IOrderedQueryable<int> GetBasicOrderedQuery()
            => Enumerable.Range(1, 100)
                .AsQueryable()
                .OrderBy(x => x);
    }
}
