using System.Collections.Generic;

namespace ToPage
{
    public interface IPage
    {
        int PageNumber { get; }
    }

    public interface IPage<T> : IPage
    {
        IEnumerable<T> Items { get; }
    }
}
