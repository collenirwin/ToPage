using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ToPage.EFCore
{
    /// <summary>
    /// Provides extension methods for <see cref="IOrderedQueryable{T}"/> objects relating to Entity Framework Core.
    /// </summary>
    public static class EFCoreQueryableExtensions
    {
        /// <summary>
        /// Creates an <see cref="IPage{T}"/> from the query.
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
        public static async Task<IPage<T>> ToPageAsync<T>(this IOrderedQueryable<T> query,
            int pageNumber, int itemsPerPage)
            => await QueryableExtensions
                .ToPageAsync(query, pageNumber, itemsPerPage, async items => await items.ToListAsync());

        /// <summary>
        /// Creates an <see cref="IPageWithCounts{T}"/> from the query.
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
        public static async Task<IPageWithCounts<T>> ToPageWithCountsAsync<T>(this IOrderedQueryable<T> query,
            int pageNumber, int itemsPerPage)
            => await QueryableExtensions
                .ToPageWithCountsAsync(query, pageNumber, itemsPerPage,
                    async items => await items.ToListAsync(),
                    async items => await items.CountAsync());
    }
}
