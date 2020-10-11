using System.Linq;

namespace ToPage
{
    /// <summary>
    /// Provides static methods relating to <see cref="IPage"/> objects.
    /// </summary>
    public static class Page
    {
        /// <summary>
        /// Creates an empty <see cref="Page{T}"/>.
        /// </summary>
        /// <typeparam name="T">Type of the items on the page.</typeparam>
        /// <returns>An empty <see cref="Page{T}"/>.</returns>
        public static Page<T> Empty<T>() => new Page<T>(items: Enumerable.Empty<T>(), pageNumber: 1);

        /// <summary>
        /// Creates an empty <see cref="PageWithCounts{T}"/>.
        /// </summary>
        /// <typeparam name="T">Type of the items on the page.</typeparam>
        /// <returns>An empty <see cref="PageWithCounts{T}"/>.</returns>
        public static PageWithCounts<T> EmptyWithCounts<T>()
            => new PageWithCounts<T>(items: Enumerable.Empty<T>(), pageNumber: 1, itemCount: 0, pageCount: 0);
    }
}
