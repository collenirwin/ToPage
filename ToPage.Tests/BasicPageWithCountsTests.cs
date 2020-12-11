using System;
using System.Linq;
using Xunit;

namespace ToPage.Tests
{
    public class BasicPageWithCountsTests
    {
        [Fact]
        public void Throws_For_Null_Items()
            => Assert.Throws<ArgumentNullException>(() => new PageWithCounts<int>(null, 1, 0, 0));

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Throws_For_PageNumber_Under_1(int pageNumber)
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => new PageWithCounts<int>(Enumerable.Empty<int>(), pageNumber, 0, 0));

        [Fact]
        public void Throws_For_ItemCount_Under_0()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => new PageWithCounts<int>(Enumerable.Empty<int>(), 1, -1, 0));

        [Fact]
        public void Throws_For_PageCount_Under_0()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => new PageWithCounts<int>(Enumerable.Empty<int>(), 1, 0, -1));
    }
}
