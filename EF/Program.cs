


using EF;
using Microsoft.EntityFrameworkCore.Internal;

using var db = new NorthwindContext();

foreach (var category in db.Categories.Where(x => x.Name.StartsWith("Co")))
{
    Console.WriteLine(category.Name);
}

