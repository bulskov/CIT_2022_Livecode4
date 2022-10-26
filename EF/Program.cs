


using EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

using var db = new NorthwindContext();

//foreach (var category in db.Categories.Where(x => x.Name.Contains("Co")))
//{
//    Console.WriteLine(category.Name);
//}

foreach (var product in db
             .Products
             .Include(x => x.Category)
             .Where(x => x.Category.Name.Contains("a"))
             .Take(5).OrderBy(x => x.Name))
{
    Console.WriteLine($"Productname: {product.Name}, Category: {product.Category.Name}");
}

