namespace ToPage
{
    /// <summary>
    /// A page with an item count and a page count.
    /// </summary>
    public interface IPageWithCounts : IPage
    {
        /// <summary>
        /// Total number of items in the collection this page is from.
        /// </summary>
        int ItemCount { get; }

        /// <summary>
        /// Total number of pages in the collection this page is from.
        /// </summary>
        int PageCount { get; }
    }

    /// <summary>
    /// A page with generic page items, an item count, and a page count.
    /// </summary>
    /// <typeparam name="T">Type of the items on the page.</typeparam>
    public interface IPageWithCounts<T> : IPage<T>, IPageWithCounts
    {
    }
}
