using System.Linq;

namespace ToPage
{
    /// <summary>
    /// Provides static methods relating to <see cref="IPage"/> objects.
    /// </summary>
    public static class Page
    {
        /// <summary>
        /// Creates an empty <see cref="IPage{T}"/>.
        /// </summary>
        /// <typeparam name="T">Type of the items on the page.</typeparam>
        /// <returns>An empty <see cref="IPage{T}"/>.</returns>
        public static IPage<T> Empty<T>() => new Page<T>(items: Enumerable.Empty<T>(), pageNumber: 1);

        /// <summary>
        /// Creates an empty <see cref="IPageWithCounts{T}"/>.
        /// </summary>
        /// <typeparam name="T">Type of the items on the page.</typeparam>
        /// <returns>An empty <see cref="IPageWithCounts{T}"/>.</returns>
        public static IPageWithCounts<T> EmptyWithCounts<T>()
            => new PageWithCounts<T>(items: Enumerable.Empty<T>(), pageNumber: 1, itemCount: 0, pageCount: 0);
    }
}
