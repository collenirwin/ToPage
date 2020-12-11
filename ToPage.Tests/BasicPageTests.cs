﻿using System;
using System.Linq;
using Xunit;

namespace ToPage.Tests
{
    public class BasicPageTests
    {
        [Fact]
        public void Throws_For_Null_Items() => Assert.Throws<ArgumentNullException>(() => new Page<int>(null, 1));

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Throws_For_PageCount_Under_1(int pageCount)
            => Assert.Throws<ArgumentOutOfRangeException>(() => new Page<int>(Enumerable.Empty<int>(), pageCount));
    }
}
