﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ToPage
{
    /// <summary>
    /// A page with generic page items.
    /// </summary>
    /// <typeparam name="T">Type of the items on the page.</typeparam>
    public class Page<T> : IPage<T>
    {
        /// <inheritdoc/>
        public IEnumerable<T> Items { get; }

        /// <inheritdoc/>
        public int PageNumber { get; }

        /// <inheritdoc/>
        public virtual int NextPageNumber => PageNumber + 1;

        /// <inheritdoc/>
        public int PreviousPageNumber => Math.Max(1, PageNumber - 1);

        /// <summary>
        /// Initializes a <see cref="Page{T}"/> with items and a page number.
        /// </summary>
        /// <param name="items">The items on the page.</param>
        /// <param name="pageNumber">The 1-based page number.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="items"/> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="pageNumber"/> is less than 1.
        /// </exception>
        public Page(IEnumerable<T> items, int pageNumber)
        {
            Items = items ?? throw new ArgumentNullException(nameof(items));

            if (pageNumber < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(pageNumber), "Page number must be greater than 0.");
            }

            PageNumber = pageNumber;
        }

        /// <inheritdoc/>
        public IEnumerator<T> GetEnumerator() => Items.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
