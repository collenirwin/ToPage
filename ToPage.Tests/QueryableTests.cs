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

        private IOrderedQueryable<int> GetBasicOrderedQuery()
            => Enumerable.Range(1, 100)
                .AsQueryable()
                .OrderBy(x => x);
    }
}
