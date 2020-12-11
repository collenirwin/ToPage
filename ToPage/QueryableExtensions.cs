﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToPage.Utils;

namespace ToPage
{
    /// <summary>
    /// Provides extension methods for <see cref="IOrderedQueryable{T}"/> objects.
    /// </summary>
    public static class QueryableExtensions
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
        public static IPage<T> ToPage<T>(this IOrderedQueryable<T> query, int pageNumber, int itemsPerPage)
            => ToPage(query, pageNumber, itemsPerPage, Enumerable.ToList);

        /// <summary>
        /// Creates an <see cref="IPage{T}"/> from the query.
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
        public static IPage<T> ToPage<T>(this IOrderedQueryable<T> query, int pageNumber, int itemsPerPage,
            Func<IQueryable<T>, IEnumerable<T>> itemsEnumerator)
        {
            ThrowUtils.AssertValidToPageArgs(query, pageNumber, itemsPerPage, itemsEnumerator);

            var items = itemsEnumerator(query
                .Skip((pageNumber - 1) * itemsPerPage)
                .Take(itemsPerPage));

            return new Page<T>(items, pageNumber);
        }

        /// <summary>
        /// Creates an <see cref="IPage{T}"/> from the query.
        /// </summary>
        /// <typeparam name="T">The query's item type.</typeparam>
        /// <param name="query">Query to build the page from.</param>
        /// <param name="pageNumber">The 1-based page number to get.</param>
        /// <param name="itemsPerPage">The number of items on the page.</param>
        /// <param name="itemsEnumerator">
        /// The asynchronous function to use for enumerating the page items from the query.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="query"/> or <paramref name="itemsEnumerator"/> is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="pageNumber"/> or <paramref name="itemsPerPage"/> is less than 1.
        /// </exception>
        /// <returns>The specified page from the query.</returns>
        public static async Task<IPage<T>> ToPageAsync<T>(this IOrderedQueryable<T> query,
            int pageNumber, int itemsPerPage,
            Func<IQueryable<T>, Task<IEnumerable<T>>> itemsEnumerator)
        {
            ThrowUtils.AssertValidToPageArgs(query, pageNumber, itemsPerPage);
            itemsEnumerator = itemsEnumerator ?? throw new ArgumentNullException(nameof(itemsEnumerator));

            var items = await itemsEnumerator(query
                .Skip((pageNumber - 1) * itemsPerPage)
                .Take(itemsPerPage));

            return new Page<T>(items, pageNumber);
        }

        /// <summary>
        /// Creates an <see cref="IPageWithCounts{T}"/> from the query.
        /// </summary>
        /// <typeparam name="T">The query's item type.</typeparam>
        /// <param name="query">Query to build the page from.</param>
        /// <param name="pageNumber">The 1-based page number to get.</param>
        /// <param name="itemsPerPage">The number of items on the page.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="query"/> is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="pageNumber"/> or <paramref name="itemsPerPage"/> is less than 1.
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when the <paramref name="query"/> returns more than <see cref="int.MaxValue"/> items.
        /// </exception>
        /// <returns>The specified page from the query.</returns>
        public static IPageWithCounts<T> ToPageWithCounts<T>(this IOrderedQueryable<T> query,
            int pageNumber, int itemsPerPage)
            => ToPageWithCounts(query, pageNumber, itemsPerPage, Enumerable.ToList, Queryable.Count);

        /// <summary>
        /// Creates an <see cref="IPageWithCounts{T}"/> from the query.
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
        /// <exception cref="OverflowException">
        /// Thrown when the <paramref name="query"/> returns more than <see cref="int.MaxValue"/> items.
        /// </exception>
        /// <returns>The specified page from the query.</returns>
        public static IPageWithCounts<T> ToPageWithCounts<T>(this IOrderedQueryable<T> query,
            int pageNumber, int itemsPerPage,
            Func<IQueryable<T>, IEnumerable<T>> itemsEnumerator)
            => ToPageWithCounts(query, pageNumber, itemsPerPage, itemsEnumerator, Queryable.Count);

        /// <summary>
        /// Creates an <see cref="IPageWithCounts{T}"/> from the query.
        /// </summary>
        /// <typeparam name="T">The query's item type.</typeparam>
        /// <param name="query">Query to build the page from.</param>
        /// <param name="pageNumber">The 1-based page number to get.</param>
        /// <param name="itemsPerPage">The number of items on the page.</param>
        /// <param name="itemsEnumerator">The function to use for enumerating the page items from the query.</param>
        /// <param name="itemsCounter">The function to use for counting the results of the query.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="query"/>, <paramref name="itemsEnumerator"/>,
        /// or <paramref name="itemsCounter"/> is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="pageNumber"/> or <paramref name="itemsPerPage"/> is less than 1.
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when the <paramref name="query"/> returns more than <see cref="int.MaxValue"/> items.
        /// </exception>
        /// <returns>The specified page from the query.</returns>
        public static IPageWithCounts<T> ToPageWithCounts<T>(this IOrderedQueryable<T> query,
            int pageNumber, int itemsPerPage,
            Func<IQueryable<T>, IEnumerable<T>> itemsEnumerator,
            Func<IQueryable<T>, int> itemsCounter)
        {
            itemsCounter = itemsCounter ?? throw new ArgumentNullException(nameof(itemsCounter));

            var page = ToPage(query, pageNumber, itemsPerPage, itemsEnumerator);

            int itemCount = itemsCounter(query);
            int pageCount = (int)Math.Ceiling((double)itemCount / itemsPerPage);

            return new PageWithCounts<T>(page.Items, page.PageNumber, itemCount, pageCount);
        }

        /// <summary>
        /// Creates an <see cref="IPageWithCounts{T}"/> from the query.
        /// </summary>
        /// <typeparam name="T">The query's item type.</typeparam>
        /// <param name="query">Query to build the page from.</param>
        /// <param name="pageNumber">The 1-based page number to get.</param>
        /// <param name="itemsPerPage">The number of items on the page.</param>
        /// <param name="itemsEnumerator">
        /// The asynchronous function to use for enumerating the page items from the query.
        /// </param>
        /// <param name="itemsCounter">
        /// The asynchronous function to use for counting the results of the query.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="query"/>, <paramref name="itemsEnumerator"/>,
        /// or <paramref name="itemsCounter"/> is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="pageNumber"/> or <paramref name="itemsPerPage"/> is less than 1.
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when the <paramref name="query"/> returns more than <see cref="int.MaxValue"/> items.
        /// </exception>
        /// <returns>The specified page from the query.</returns>
        public static async Task<IPageWithCounts<T>> ToPageWithCountsAsync<T>(this IOrderedQueryable<T> query,
            int pageNumber, int itemsPerPage,
            Func<IQueryable<T>, Task<IEnumerable<T>>> itemsEnumerator,
            Func<IQueryable<T>, Task<int>> itemsCounter)
        {
            itemsCounter = itemsCounter ?? throw new ArgumentNullException(nameof(itemsCounter));

            var page = await ToPageAsync(query, pageNumber, itemsPerPage, itemsEnumerator);

            int itemCount = await itemsCounter(query);
            int pageCount = (int)Math.Ceiling((double)itemCount / itemsPerPage);

            return new PageWithCounts<T>(page.Items, page.PageNumber, itemCount, pageCount);
        }
    }
}
