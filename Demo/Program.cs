using System.Globalization;
using System.Xml.Schema;
using static Demo.ListGenerator;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1 ,2
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var OddNum = Enumerable.Where(Numbers, X => X % 2 == 1);
            //var EvenNum = Numbers.Where(X => X % 2 == 0);

            //var DividedBy4 = from N in Numbers
            //                 where N % 4 == 0
            //                 select N;
            //foreach (var item in DividedBy4)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #region Part 3
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var OddNum = Numbers.Where(Num => Num % 2 == 1);
            //Numbers.AddRange(new int[] { 13, 14, 15, 16, 17 });
            //foreach (var item in OddNum)
            //{
            //    Console.Write($"{item} ");
            //}
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var OddNum = Numbers.Where(Num => Num % 2 == 1).ToList();
            //Numbers.AddRange(new int[] { 13, 14, 15, 16, 17 });
            //foreach (var item in OddNum)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #region part 4
            #region out of stock
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0);

            //Result = from P in ProductsList 
            //         where P.UnitsInStock == 0
            //         select P;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Instock
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

            //Result = from P in ProductsList
            //         where P.UnitsInStock == 0 && P.Category == "Meat/Poultry"
            //         select P;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region first 10 element
            //var Result = ProductsList.Where((P , I) => P.UnitsInStock == 0 && I >10);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #endregion

            #region Part 6

            #region select product name 
            //var Result = ProductsList.Select(P => P.ProductName);

            //Result = from P in ProductsList
            //         select P.ProductName;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region select customer Name
            //var Result = CustomersList.Select(C => C.CustomerName);

            //Result = from C in CustomersList
            //         select C.CustomerName;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}  
            #endregion

            #region select order
            //var Result = CustomersList.SelectMany(P => P.Orders);

            //Result = from C in CustomersList 
            //         from O in C.Orders
            //         select O;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region select product name and product id 

            //var Result = ProductsList.Select(P => new { P.ProductID, P.ProductName });

            //Result = from P in ProductsList
            //         select new
            //         {
            //             P.ProductID,
            //             P.ProductName,
            //         };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region  Apply Discount
            // var Result = ProductsList.Where(P => P.UnitsInStock > 0)
            //                          .Select(P => new
            //                          {
            //                              P.ProductID,
            //                              P.ProductName,
            //                              OldPrice = P.UnitPrice,
            //                              NewPrice = P.UnitPrice - (P.UnitPrice * 0.1M),
            //                          });

            // Result = from P in ProductsList
            //          where P.UnitsInStock > 0
            //          select new
            //          {
            //              P.ProductID,
            //              P.ProductName,
            //              OldPrice = P.UnitPrice,
            //              NewPrice = P.UnitPrice - (P.UnitPrice * 0.1M),
            //          };

            //var Result02 = ProductsList.Select((P, I) => new { Name = P.ProductName, Index = I });
            // foreach (var item in Result02)
            // {
            //     Console.WriteLine(item);
            // } 
            #endregion

            #endregion

            #region part 7

            #region order by price asc
            //var Result = ProductsList.OrderBy(P => P.UnitPrice);

            //Result = from P in ProductsList
            //         orderby P.UnitPrice
            //         select P;

            #endregion
            #region order by price dsc
            //var Result = ProductsList.OrderByDescending(P => P.UnitPrice);

            //Result = from P in ProductsList
            //         orderby P.UnitPrice descending
            //         select P; 
            #endregion
            #region reverse

            //var Result = ProductsList.OrderBy(P => P.UnitPrice).ThenBy(P => P.UnitsInStock).Reverse();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #endregion

            #region part 8
            //List<Product> products = new List<Product>();
            //var Result = ProductsList.First();
            //Result = ProductsList.First(P => P.UnitsInStock == 0);
            //Result = ProductsList.Last();
            //Result = ProductsList.Last(P => P.UnitsInStock == 0);
            //Result = products.FirstOrDefault();

            //Console.WriteLine(Result?.ProductName ?? "not found");

            //Result = ProductsList.FirstOrDefault();
            //Result = ProductsList.FirstOrDefault(P => P.UnitsInStock == 0);
            //Result = ProductsList.LastOrDefault();
            //Result = ProductsList.LastOrDefault(P => P.UnitsInStock == 0);

            //Result = ProductsList.Single();
            //Result = products.Single();
            //Result = ProductsList.SingleOrDefault();
            //Result = products.SingleOrDefault();

            //Result = ProductsList.ElementAt(1);
            //Result = ProductsList.ElementAt(77);
            //Result = ProductsList.ElementAtOrDefault(1);
            //Result = ProductsList.ElementAtOrDefault(77);


            //var Result = (from P in ProductsList
            //             where P.UnitsInStock == 0
            //             select P).First();
            //Console.WriteLine(Result); 
            #endregion

            #region part 9

            // var Result = ProductsList.Count;
            // Result = ProductsList.Count(P => P.UnitsInStock == 0);

            //var Result = ProductsList.Max();
            //Result = ProductsList.Min();
            //var Result02 = ProductsList.Max(P => P.ProductName.Length);
            //Result02 = ProductsList.Min(P => P.ProductName.Length);

            //var Result = ProductsList.Sum(P => P.UnitPrice);
            //Result = ProductsList.Average(P => P.UnitPrice);

            //string[] Names = {"Fatma" , "Kamal" , "Ibrahim" , "Nassar" };
            //var Result = Names.Aggregate((Str01, Str02) => $"{Str01} {Str02}");
            //Console.WriteLine(Result); 
            #endregion
        }
    }
}
