using System;
using System.Collections.Generic;

namespace ToPage
{
    /// <summary>
    /// A page with generic page items, an item count, and a page count.
    /// </summary>
    /// <typeparam name="T">Type of the items on the page.</typeparam>
    public class PageWithCounts<T> : Page<T>, IPageWithCounts<T>
    {
        /// <inheritdoc/>
        public override int NextPageNumber => Math.Min(PageCount, PageNumber + 1);

        /// <inheritdoc/>
        public int ItemCount { get; }

        /// <inheritdoc/>
        public int PageCount { get; }

        /// <summary>
        /// Initializes a <see cref="PageWithCounts{T}"/> with items, a page number, an item count, and a page count.
        /// </summary>
        /// <param name="items">The items on the page.</param>
        /// <param name="pageNumber">The 1-based page number.</param>
        /// <param name="itemCount">Total number of items in the collection this page is from.</param>
        /// <param name="pageCount">Total number of pages in the collection this page is from.</param>
        public PageWithCounts(IEnumerable<T> items, int pageNumber, int itemCount, int pageCount)
            : base(items, pageNumber)
        {
            ItemCount = itemCount;
            PageCount = pageCount;
        }
    }
}
