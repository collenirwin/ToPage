using System;
using System.Collections.Generic;
using System.Linq;
using ToPage.Utils;

namespace ToPage
{
    /// <summary>
    /// Provides extension methods for <see cref="IOrderedQueryable{T}"/> objects.
    /// </summary>
    public static class QueryableExtensions
    {
        /// <summary>
        /// Creates a <see cref="Page{T}"/> from the query.
        /// </summary>
        /// <typeparam name="T">The query's item type.</typeparam>
        /// <param name="query">Query to build the page from.</param>
        /// <param name="pageNumber">The 1-based page number to get.</param>
        /// <param name="itemsPerPage">The number of items on the page.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="query"/> or  is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="pageNumber"/> or <paramref name="itemsPerPage"/> is less than 1.
        /// </exception>
        /// <returns>The specified page from the query.</returns>
        public static Page<T> ToPage<T>(this IOrderedQueryable<T> query, int pageNumber, int itemsPerPage)
            => ToPage(query, pageNumber, itemsPerPage, Enumerable.ToList);

        /// <summary>
        /// Creates a <see cref="Page{T}"/> from the query.
        /// </summary>
        /// <typeparam name="T">The query's item type.</typeparam>
        /// <param name="query">Query to build the page from.</param>
        /// <param name="pageNumber">The 1-based page number to get.</param>
        /// <param name="itemsPerPage">The number of items on the page.</param>
        /// <param name="itemsEnumerator">The function to use for enumerating the page items from the query.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="query"/> or <paramref name="itemsEnumerator"/> is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="pageNumber"/> or <paramref name="itemsPerPage"/> is less than 1.
        /// </exception>
        /// <returns>The specified page from the query.</returns>
        public static Page<T> ToPage<T>(this IOrderedQueryable<T> query, int pageNumber, int itemsPerPage,
            Func<IQueryable<T>, IEnumerable<T>> itemsEnumerator)
        {
            ThrowUtils.AssertValidToPageArgs(query, pageNumber, itemsPerPage, itemsEnumerator);

            var items = itemsEnumerator(query
                .Skip((pageNumber - 1) * itemsPerPage)
                .Take(itemsPerPage));

            return new Page<T>(items, pageNumber);
        }
    }
}
