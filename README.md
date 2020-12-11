# ToPage
![.NET Core](https://github.com/collenirwin/ToPage/workflows/.NET%20Core/badge.svg)

A tiny paging library for .NET.

This library contains extension methods for `IEnumerable<T>` and `IOrderedQueryable<T>` types that make it easy to fetch a page of data from them.

## Installation
Package | Target | Description
--- | --- | ---
[ToPage](https://www.nuget.org/packages/ToPage) | .NET Standard 2.0 | The base library
[ToPage.EFCore](https://www.nuget.org/packages/ToPage.EFCore) | .NET Core 3.1 | Provides `async` overloads using EF Core's `ToListAsync` and `CountAsync` methods
[ToPage.EF6](https://www.nuget.org/packages/ToPage.EF6) | .NET Framework 4.7.2 | Provides `async` overloads using EF6's `ToListAsync` and `CountAsync` methods

## Examples
#### Example projects
 - [Basic](./Basic)
 - [Entity Framework](./EntityFramework)

#### Basic `IEnumerable` example
```csharp
var numbers = Enumerable.Range(1, 10);
var page = numbers.ToPage(pageNumber: 1, itemsPerPage: 3);

Console.WriteLine(string.Join(", ", page));
// Output:
// 1, 2, 3
```
In this example, an `IPage<int>` object is returned from `ToPage`.
Its only properties are the requested `PageNumber` (1), and the `Items` on the page.

#### Basic `IEnumerable` example with counts
```csharp
var numbers = Enumerable.Range(1, 10);
var page = numbers.ToPageWithCounts(pageNumber: 1, itemsPerPage: 3);

Console.WriteLine($"Total items: {page.ItemCount}, total pages: {page.PageCount}");
Console.WriteLine(string.Join(", ", page));
// Output:
// Total items: 10, total pages: 4
// 1, 2, 3
```
In this example, an `IPageWithCounts<int>` object is returned from `ToPage`.
It has the same properties as an `IPage<int>`,
as well as an `ItemCount` and a `PageCount` which are calculated based on the size of the collection and the number of items per page requested.

#### Entity Framework async example
```csharp
// Get the 5th page of 20 users ordered alphabetically by Name
var page = await context.Users
    .OrderBy(user => user.Name)
    .ToPageAsync(pageNumber: 5, itemsPerPage: 20);
```
*Note:* This example uses either the `ToPage.EFCore` or `ToPage.EF6` library (both APIs are the same, choose the one for the EF version you're using).
