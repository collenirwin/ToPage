using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using ToPage;
using ToPage.EFCore;

namespace EntityFramework
{
    class Program
    {
        static async Task Main()
        {
            using var context = new AppDbContext();
            context.Database.Migrate();

            var command = "";
            do
            {
                Console.Write("Enter a page number (> 0), or type exit to quit: ");
                command = Console.ReadLine();

                if (int.TryParse(command, out var pageNumber) && pageNumber > 0)
                {
                    var page = await context.People
                        .OrderBy(person => person.Id)
                        .ToPageWithCountsAsync(pageNumber, itemsPerPage: 10);

                    RenderPage(page);
                }
            } while (command != "exit");
        }

        static void RenderPage(IPageWithCounts<Person> page)
        {
            Console.Clear();
            Console.WriteLine($"Id\tAge\tFavorite Color");

            foreach (var person in page.Items)
            {
                Console.WriteLine($"{person.Id}\t{person.Age}\t{person.FavoriteColor}");
            }

            Console.WriteLine($"Page {page.PageNumber} of {page.PageCount} ({page.ItemCount} people total)");
        }
    }
}
