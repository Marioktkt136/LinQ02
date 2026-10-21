using LINQ.DataSources;
using LINQ.Models;

namespace LinQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //var result = Source.ProductList
            //.OrderByDescending(p => p.UnitPrice)
            //.Take(3);

            //foreach (var p in result)
            //    Console.WriteLine($"{p.ProductName} - ${p.UnitPrice}");
            #endregion

            #region Q2
            //int pageNumber = 2;
            //int pageSize = 5;

            //var result = Source.ProductList
            //    .Skip((pageNumber - 1) * pageSize)
            //    .Take(pageSize);

            //foreach (var p in result)
            //    Console.WriteLine(p.ProductName);
            #endregion

            #region Q3
            //var result = Source.ProductList
            //            .TakeWhile(p => p.UnitPrice < 25);

            //foreach (var p in result)
            //    Console.WriteLine($"{p.ProductName} - ${p.UnitPrice}");
            #endregion

            #region Q4
            //bool result = Source.ProductList
            //                .Where(p => p.Category == "Seafood")
            //                .All(p => p.UnitsInStock > 0);

            //Console.WriteLine(result);
            #endregion

            #region Q5
            //int[] ids = { 3, 9, 13, 18 };

            //bool result = ids.Contains(9);

            //Console.WriteLine(result); // True
            #endregion

            #region Q6
            //var result = Source.ProductList
            //            .GroupBy(p => p.Category);

            //foreach (var group in result)
            //{
            //    Console.WriteLine(
            //        $"{group.Key}: {group.Count()} products");
            //}
            #endregion

            #region Q7
            //var result = Source.ProductList
            //            .GroupBy(p => p.Category)
            //            .Select(g => new
            //            {
            //                Category = g.Key,
            //                ProductNames = g.Select(p => p.ProductName)
            //            });

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Category);

            //    foreach (var name in group.ProductNames)
            //        Console.WriteLine($"  {name}");
            //}
            #endregion

            #region Q8
            //var result = Source.ProductList
            //            .GroupBy(p => p.Category)
            //            .Where(g => g.Count() > 3)
            //            .Select(g => new
            //            {
            //                Category = g.Key,
            //                ProductCount = g.Count()
            //            });

            //foreach (var item in result)
            //    Console.WriteLine($"{item.Category}: {item.ProductCount}");
            #endregion

            #region Q9 - Missing anaswer
            //var result =
            //from c in Source.CustomerList
            //group c by c.Country into countryGroup
            //select new
            //{
            //    Country = countryGroup.Key,
            //    Count = countryGroup.Count(),

            //    TotalOrderValue = countryGroup
            //        .SelectMany(c => c.Orders)
            //        .SelectMany(o => o.Total)
            //        .Sum(od =>
            //            od. * od.Quantity *
            //            (1m - (decimal)od.Discount))
            //};

            //foreach (var item in result)
            //{
            //    Console.WriteLine(
            //        $"{item.Country} | Customers: {item.Count} | " +
            //        $"Total: {item.TotalOrderValue:C}");
            //}
            #endregion

            #region Q10
            //int totalUnits = Source.ProductList.Sum(p => p.UnitsInStock);

            //Console.WriteLine(totalUnits);
            #endregion

            #region Q11
            //decimal cheapestPrice = Source.ProductList.Min(p => p.UnitPrice);
            //decimal mostExpensivePrice = Source.ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine($"Cheapest: ${cheapestPrice}");
            //Console.WriteLine($"Most expensive: ${mostExpensivePrice}");
            #endregion

            #region Q12
            //var result = Source.ProductList
            //            .Select(p => p.Category)
            //            .Distinct();

            //foreach (var category in result)
            //    Console.WriteLine(category);
            #endregion

            #region Q13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            //foreach (int id in result)
            //    Console.WriteLine(id);
            #endregion

            #region Q14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(
            //    list2,
            //    StringComparer.OrdinalIgnoreCase);

            //foreach (string country in result)
            //    Console.WriteLine(country);
            #endregion

            #region Q15
            //Dictionary<int, Product> productDictionary =
            //            Source.ProductList.ToDictionary(p => p.ProductID);

            //if (productDictionary.TryGetValue(18, out Product product))
            //{
            //    Console.WriteLine(
            //        $"{product.ProductID} - {product.ProductName} - " +
            //        $"${product.UnitPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("Product not found.");
            //}
            #endregion

            #region Q16
            //var result = Source.ProductList
            //            .First(p => p.UnitPrice > 50);

            //Console.WriteLine(result.ProductName);
            #endregion

            #region Q17
            //var result = Source.ProductList
            //            .FirstOrDefault(p => p.UnitPrice > 500);

            //if (result != null)
            //    Console.WriteLine(result.ProductName);
            //else
            //    Console.WriteLine("No product found.");
            #endregion

            #region Q18
            //var result = Enumerable.Range(1, 10)
            //                .Select(i => $"7 x {i} = {7 * i}");

            //foreach (var line in result)
            //    Console.WriteLine(line);
            #endregion

            #region Q19
            //var result = Enumerable.Range(1, 30)
            //            .Where(n => n % 2 == 0);

            //foreach (int number in result)
            //    Console.WriteLine(number);
            #endregion

            #region Q20
            //var result = Source.ProductList
            //            .Take(3)
            //            .Select(p => p.ProductName)
            //            .Concat(
            //Source.CustomerList
            //.Take(3)
            //.Select(c => c.CustomerName));

            //foreach (string name in result)
            //    Console.WriteLine(name);
            #endregion

            #region Q21
             //   var result = Source.ProductList
             //.Zip(
             //    Source.CustomerList,
             //    (p, c) => $"{p.ProductName} sold to {c.CustomerName}");

             //   foreach (string item in result)
             //       Console.WriteLine(item);
            #endregion
        }
    }
}
