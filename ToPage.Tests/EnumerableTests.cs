using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ToPage.Tests
{
    public class EnumerableTests
    {
        [Fact]
        public void Has_Correct_PageNumber()
        {
            // arrange
            var values = GetBasicEnumerable();
            int pageNumber = 1;
            int itemsPerPage = 10;

            // act
            var page = values.ToPage(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(pageNumber, page.PageNumber);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(10, 11)]
        public void Has_Correct_NextPageNumber(int pageNumber, int expected)
        {
            // arrange
            var values = GetBasicEnumerable();
            int itemsPerPage = 10;

            // act
            var page = values.ToPage(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(expected, page.NextPageNumber);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(11, 10)]
        public void Has_Correct_PreviousPageNumber(int pageNumber, int expected)
        {
            // arrange
            var values = GetBasicEnumerable();
            int itemsPerPage = 10;

            // act
            var page = values.ToPage(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(expected, page.PreviousPageNumber);
        }

        [Fact]
        public void Has_Correct_Has_Correct_Number_Of_Items()
        {
            // arrange
            var values = GetBasicEnumerable();
            int pageNumber = 1;
            int itemsPerPage = 10;

            // act
            var page = values.ToPage(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(itemsPerPage, page.Items.Count());
        }

        [Fact]
        public void Throws_On_Null_values()
        {
            // arrange
            IEnumerable<int> values = null;
            int pageNumber = 1;
            int itemsPerPage = 10;

            // act, assert
            Assert.Throws<ArgumentNullException>(() => _ = values.ToPage(pageNumber, itemsPerPage));
        }

        [Fact]
        public void Throws_On_PageNumber_Under_1()
        {
            // arrange
            var values = GetBasicEnumerable();
            int pageNumber = 0;
            int itemsPerPage = 10;

            // act, assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _ = values.ToPage(pageNumber, itemsPerPage));
        }

        [Fact]
        public void Throws_On_ItemsPerPage_Under_1()
        {
            // arrange
            var values = GetBasicEnumerable();
            int pageNumber = 1;
            int itemsPerPage = 0;

            // act, assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _ = values.ToPage(pageNumber, itemsPerPage));
        }

        [Fact]
        public void Gets_Leftover_Items_On_Last_Page()
        {
            // arrange
            var values = GetBasicEnumerable();
            int pageNumber = 7;
            int itemsPerPage = 15;

            // act
            var page = values.ToPage(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(10, page.Items.Count());
        }

        [Fact]
        public void Gets_0_Items_When_PageNumber_Is_Too_High()
        {
            // arrange
            var values = GetBasicEnumerable();
            int pageNumber = 1000;
            int itemsPerPage = 10;

            // act
            var page = values.ToPage(pageNumber, itemsPerPage);

            // assert
            Assert.Empty(page.Items);
        }

        [Fact]
        public void All_Pages_Have_Correct_Items()
        {
            // arrange
            var values = GetBasicEnumerable();
            int itemsPerPage = 1;

            // act, assert
            for (int x = 1; x <= 100; x++)
            {
                var page = values.ToPage(pageNumber: x, itemsPerPage);
                Assert.Single(page.Items, x);
            }

            var emptyPage = values.ToPage(pageNumber: 101, itemsPerPage);
            Assert.Empty(emptyPage.Items);
        }

        [Fact]
        public void All_Pages_Have_Correct_Items_Implicit()
        {
            // arrange
            var values = GetBasicEnumerable();
            int itemsPerPage = 1;

            // act, assert
            for (int x = 1; x <= 100; x++)
            {
                var page = values.ToPage(pageNumber: x, itemsPerPage);
                Assert.Single(page, x);
            }

            var emptyPage = values.ToPage(pageNumber: 101, itemsPerPage);
            Assert.Empty(emptyPage);
        }

        [Fact]
        public void Page_Enumerable_Is_Just_Page_Items()
        {
            // arrange
            var values = GetBasicEnumerable();
            int pageNumber = 1;
            int itemsPerPage = 10;

            // act
            var page = values.ToPage(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(page.Items, page);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(101)]
        [InlineData(0)]
        [InlineData(10_000)]
        public void Has_Correct_ItemCount(int itemCount)
        {
            // arrange
            var values = GetBasicEnumerable(itemCount);
            int pageNumber = 1;
            int itemsPerPage = 10;

            // act
            var page = values.ToPageWithCounts(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(itemCount, page.ItemCount);
        }

        [Theory]
        [InlineData(100, 10, 10)]
        [InlineData(101, 10, 11)]
        [InlineData(0, 10, 0)]
        [InlineData(10_000, 7, 1429)]
        public void Has_Correct_PageCount(int itemCount, int itemsPerPage, int pageCount)
        {
            // arrange
            var values = GetBasicEnumerable(itemCount);
            int pageNumber = 1;

            // act
            var page = values.ToPageWithCounts(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(pageCount, page.PageCount);
        }

        [Fact]
        public void Has_Correct_NextPageNumber_With_Counts()
        {
            // arrange
            var values = GetBasicEnumerable();
            int pageNumber = 10;
            int itemsPerPage = 10;

            // act
            var page = values.ToPageWithCounts(pageNumber, itemsPerPage);

            // assert
            Assert.Equal(page.PageNumber, page.NextPageNumber);
        }

        private IEnumerable<int> GetBasicEnumerable(int length = 100) => Enumerable.Range(1, length);
    }
}
