using System;
using System.Collections.Generic;
using System.Linq;
using ToPage.Utils;

namespace ToPage
{
    /// <summary>
    /// Provides extension methods for <see cref="IEnumerable{T}"/> objects.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Creates an <see cref="IPage{T}"/> from the enumerable.
        /// </summary>
        /// <typeparam name="T">The enumerable's item type.</typeparam>
        /// <param name="values">Enumerable to build the page from.</param>
        /// <param name="pageNumber">The 1-based page number to get.</param>
        /// <param name="itemsPerPage">The number of items on the page.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="values"/> or  is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="pageNumber"/> or <paramref name="itemsPerPage"/> is less than 1.
        /// </exception>
        /// <returns>The specified page from the enumerable.</returns>
        public static IPage<T> ToPage<T>(this IEnumerable<T> values, int pageNumber, int itemsPerPage)
        {
            ThrowUtils.AssertValidToPageArgs(values, pageNumber, itemsPerPage);

            var items = values
                .Skip((pageNumber - 1) * itemsPerPage)
                .Take(itemsPerPage);

            return new Page<T>(items, pageNumber);
        }

        /// <summary>
        /// Creates an <see cref="IPageWithCounts{T}"/> from the enumerable.
        /// </summary>
        /// <typeparam name="T">The enumerable's item type.</typeparam>
        /// <param name="values">Enumerable to build the page from.</param>
        /// <param name="pageNumber">The 1-based page number to get.</param>
        /// <param name="itemsPerPage">The number of items on the page.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="values"/> or  is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="pageNumber"/> or <paramref name="itemsPerPage"/> is less than 1.
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when <paramref name="values"/> contains more than <see cref="int.MaxValue"/> items.
        /// </exception>
        /// <returns>The specified page from the enumerable.</returns>
        public static IPageWithCounts<T> ToPageWithCounts<T>(this IEnumerable<T> values,
            int pageNumber, int itemsPerPage)
        {
            var page = ToPage(values, pageNumber, itemsPerPage);

            int itemCount = values.Count();
            int pageCount = (int)Math.Ceiling((double)itemCount / itemsPerPage);

            return new PageWithCounts<T>(page.Items, page.PageNumber, itemCount, pageCount);
        }
    }
}
