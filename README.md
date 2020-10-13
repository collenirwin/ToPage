# ToPage
A small paging library for .NET.

This library contains extension methods for `IEnumerable<T>` and `IOrderedQueryable<T>` types that make it easy to fetch a page of data from them.

## Installation
Package | Description
--- | ---
[ToPage](https://www.nuget.org/packages/ToPage) | The base library
[ToPage.EFCore](https://www.nuget.org/packages/ToPage.EFCore) | Provides `async` overloads using EF Core's `ToListAsync` and `CountAsync` methods
[ToPage.EF6](https://www.nuget.org/packages/ToPage.EF6) | Provides `async` overloads using EF6's `ToListAsync` and `CountAsync` methods
