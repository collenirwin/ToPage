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

        [Fact]
        public void Gets_Leftover_Items_On_Last_Page()
        {
            // arrange
            var query = GetBasicOrderedQuery();
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
            var query = GetBasicOrderedQuery();
            int pageNumber = 1000;
            int itemsPerPage = 10;

            // act
            var page = query.ToPage(pageNumber, itemsPerPage);

            // assert
            Assert.Empty(page.Items);
        }

        [Fact]
        public void All_Pages_Have_Correct_Items()
        {
            // arrange
            var query = GetBasicOrderedQuery();
            int itemsPerPage = 1;

            // act, assert
            for (int x = 1; x <= 100; x++)
            {
                var page = query.ToPage(pageNumber: x, itemsPerPage);
                Assert.Single(page.Items, x);
            }

            var emptyPage = query.ToPage(pageNumber: 101, itemsPerPage);
            Assert.Empty(emptyPage.Items);
        }

        private IOrderedQueryable<int> GetBasicOrderedQuery()
            => Enumerable.Range(1, 100)
                .AsQueryable()
                .OrderBy(x => x);
    }
}
