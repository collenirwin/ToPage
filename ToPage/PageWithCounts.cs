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
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="items"/> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="pageNumber"/> is less than 1,
        /// when <paramref name="itemCount"/> is less than 0,
        /// or when <paramref name="pageCount"/> is less than 0.
        /// </exception>
        public PageWithCounts(IEnumerable<T> items, int pageNumber, int itemCount, int pageCount)
            : base(items, pageNumber)
        {
            if (itemCount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(itemCount), "Item count must be at least 0.");
            }

            if (pageCount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pageCount), "Page count must be at least 0.");
            }

            ItemCount = itemCount;
            PageCount = pageCount;
        }
    }
}
