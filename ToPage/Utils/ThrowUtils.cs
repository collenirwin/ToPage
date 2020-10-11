using System;
using System.Collections.Generic;
using System.Linq;

namespace ToPage.Utils
{
    internal static class ThrowUtils
    {
        public static void AssertValidToPageArgs<T>(IOrderedQueryable<T> query, int pageNumber, int itemsPerPage,
            Func<IQueryable<T>, IEnumerable<T>> itemsEnumerator)
        {
            _ = query ?? throw new ArgumentNullException(nameof(query));
            _ = itemsEnumerator ?? throw new ArgumentNullException(nameof(itemsEnumerator));

            AssertValidPageNumber(pageNumber);
            AssertValidItemsPerPage(itemsPerPage);
        }

        public static void AssertValidToPageArgs<T>(IEnumerable<T> values, int pageNumber, int itemsPerPage)
        {
            _ = values ?? throw new ArgumentNullException(nameof(values));

            AssertValidPageNumber(pageNumber);
            AssertValidItemsPerPage(itemsPerPage);
        }

        public static void AssertValidPageNumber(int pageNumber)
        {
            if (pageNumber < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(pageNumber));
            }
        }

        public static void AssertValidItemsPerPage(int itemsPerPage)
        {
            if (itemsPerPage < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(itemsPerPage));
            }
        }
    }
}
