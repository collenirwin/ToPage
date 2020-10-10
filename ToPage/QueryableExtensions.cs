using System;
using System.Collections.Generic;
using System.Linq;

namespace ToPage
{
    public static class QueryableExtensions
    {
        public static Page<T> ToPage<T>(this IOrderedQueryable<T> query, int pageNumber, int itemsPerPage)
            => ToPage(query, pageNumber, itemsPerPage, Enumerable.ToList);

        public static Page<T> ToPage<T>(this IOrderedQueryable<T> query, int pageNumber, int itemsPerPage,
            Func<IQueryable<T>, IEnumerable<T>> itemsEnumerator)
        {
            AssertValidToPageArgs(query, pageNumber, itemsPerPage);

            var items = itemsEnumerator(query
                .Skip((pageNumber - 1) * itemsPerPage)
                .Take(itemsPerPage));

            return new Page<T>(items, pageNumber);
        }

        private static void AssertValidToPageArgs<T>(IOrderedQueryable<T> query, int pageNumber, int itemsPerPage)
        {
            _ = query ?? throw new ArgumentNullException(nameof(query));

            if (pageNumber < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(pageNumber));
            }

            if (itemsPerPage < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(itemsPerPage));
            }
        }
    }
}
