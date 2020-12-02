using System;
using ToPage;

namespace Basic
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string FavoriteColor { get; set; }
        }

        static void Main()
        {
            var people = new[]
            {
                new Person { Name = "Collen",  Age = 25, FavoriteColor = "Green" },
                new Person { Name = "Larry",   Age = 50, FavoriteColor = "Red" },
                new Person { Name = "David",   Age = 20, FavoriteColor = "Blue" },
                new Person { Name = "Amy",     Age = 48, FavoriteColor = "Yellow" },
                new Person { Name = "Charlie", Age = 30, FavoriteColor = "Pink" },
                new Person { Name = "Megan",   Age = 34, FavoriteColor = "Orange" },
                new Person { Name = "Booker",  Age = 29, FavoriteColor = "Green" },
                new Person { Name = "Tiffany", Age = 78, FavoriteColor = "Blue" },
                new Person { Name = "Steven",  Age = 22, FavoriteColor = "Brown" },
                new Person { Name = "Steph",   Age = 64, FavoriteColor = "Purple" }
            };

            Console.Write("Page number: ");
            int pageNumber = int.Parse(Console.ReadLine());

            Console.Write("Items per page: ");
            int itemsPerPage = int.Parse(Console.ReadLine());

            var page = people.ToPage(pageNumber, itemsPerPage);

            Console.WriteLine($"Name\tAge\tFavorite Color (Page {page.PageNumber})");
            foreach (var person in page)
            {
                Console.WriteLine($"{person.Name}\t{person.Age}\t{person.FavoriteColor}");
            }

            Main();
        }
    }
}
