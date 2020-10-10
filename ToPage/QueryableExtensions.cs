using System;
using System.Linq;

namespace ToPage
{
    public static class QueryableExtensions
    {
        public static Page<T> ToPage<T>(this IOrderedQueryable<T> query, int pageNumber, int itemsPerPage)
        {
            AssertValidToPageArgs(query, pageNumber, itemsPerPage);

            var items = query
                .Skip((pageNumber - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToList();

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
