# ToPage
A small paging library for .NET.

This library contains extension methods for `IEnumerable<T>` and `IOrderedQueryable<T>` types that make it easy to fetch a page of data from them.

## Installation
Package | Description
--- | ---
[ToPage](https://www.nuget.org/packages/ToPage) | The base library
[ToPage.EFCore](https://www.nuget.org/packages/ToPage.EFCore) | Provides `async` overloads using EF Core's `ToListAsync` and `CountAsync` methods
[ToPage.EF6](https://www.nuget.org/packages/ToPage.EF6) | Provides `async` overloads using EF6's `ToListAsync` and `CountAsync` methods

## Examples
#### Basic `IEnumerable` example
```csharp
var numbers = Enumerable.Range(1, 10);
var page = numbers.ToPage(pageNumber: 1, itemsPerPage: 3);

Console.WriteLine(string.Join(", ", page.Items));
// Output:
// 1, 2, 3
```

#### Basic `IEnumerable` example with counts
```csharp
var numbers = Enumerable.Range(1, 10);
var page = numbers.ToPageWithCounts(pageNumber: 1, itemsPerPage: 3);

Console.WriteLine($"Total items: {page.ItemCount}, total pages: {page.PageCount}");
Console.WriteLine(string.Join(", ", page.Items));
// Output:
// Total items: 10, total pages: 4
// 1, 2, 3
```
