


using EF;
using Microsoft.EntityFrameworkCore.Internal;

using var db = new NorthwindContext();

//foreach (var category in db.Categories.Where(x => x.Name.Contains("Co")))
//{
//    Console.WriteLine(category.Name);
//}

foreach (var product in db.Products.Take(5))
{
    Console.WriteLine(product.Name);
}

