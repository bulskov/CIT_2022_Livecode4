


using EF;
using Microsoft.EntityFrameworkCore.Internal;

using var db = new NorthwindContext();

foreach (var category in db.Categories)
{
    Console.WriteLine(category.Name);
}

