using System.Collections.Generic;

namespace ToPage
{
    /// <summary>
    /// The base interface for a page. Contains a page number.
    /// </summary>
    public interface IPage
    {
        /// <summary>
        /// The 1-based page number for this page.
        /// </summary>
        int PageNumber { get; }
    }

    /// <summary>
    /// A page with generic page items.
    /// </summary>
    /// <typeparam name="T">Type of the items on the page.</typeparam>
    public interface IPage<T> : IPage
    {
        /// <summary>
        /// The items on this page.
        /// </summary>
        IEnumerable<T> Items { get; }
    }
}
