using System.Collections.Generic;

namespace ToPage
{
    public class Page<T> : IPage<T>
    {
        public IEnumerable<T> Items { get; }

        public int PageNumber { get; }

        public Page(IEnumerable<T> items, int pageNumber)
        {
            Items = items;
            PageNumber = pageNumber;
        }
    }
}
