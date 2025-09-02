using Assignment_LINQ;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Assignment01_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = ListGenerator.ProductList;
            var customers = ListGenerator.CustomerList;

            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] dictionary = File.ReadAllLines("dictionary_english.txt");

            Console.WriteLine("=========== LINQ - Element Operators ===========");

            #region Q1
            Console.WriteLine("Q1. Get first Product out of Stock");
            var q1 = products.FirstOrDefault(p => p.UnitsInStock == 0);
            Console.WriteLine(q1);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q2
            Console.WriteLine("Q2. First product whose Price > 1000 or null");
            var q2 = products.FirstOrDefault(p => p.UnitPrice > 1000);
            Console.WriteLine(q2);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q3
            Console.WriteLine("Q3. Retrieve the second number greater than 5");
            var q3 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            Console.WriteLine(q3);
            Console.WriteLine("-----------------------------");
            #endregion

            Console.WriteLine("=========== LINQ - Aggregate Operators ===========");

            #region Q4
            Console.WriteLine("Q4. Count odd numbers");
            var q4 = Arr.Count(n => n % 2 == 1);
            Console.WriteLine(q4);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q5
            Console.WriteLine("Q5. Customers and how many orders each has");
            var q5 = customers.Select(c => new { c.CustomerName, Count = c.Orders.Count() });
            foreach (var item in q5) Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q6
            Console.WriteLine("Q6. Categories and how many products each has");
            var q6 = products.GroupBy(p => p.Category)
                             .Select(g => new { Category = g.Key, Count = g.Count() });
            foreach (var item in q6) Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q7
            Console.WriteLine("Q7. Total of numbers in array");
            var q7 = Arr.Sum();
            Console.WriteLine(q7);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q8
            Console.WriteLine("Q8. Total number of characters in dictionary");
            var q8 = dictionary.Sum(w => w.Length);
            Console.WriteLine(q8);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q9
            Console.WriteLine("Q9. Shortest word length in dictionary");
            var q9 = dictionary.Min(w => w.Length);
            Console.WriteLine(q9);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q10
            Console.WriteLine("Q10. Longest word length in dictionary");
            var q10 = dictionary.Max(w => w.Length);
            Console.WriteLine(q10);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q11
            Console.WriteLine("Q11. Average word length in dictionary");
            var q11 = dictionary.Average(w => w.Length);
            Console.WriteLine(q11);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q12
            Console.WriteLine("Q12. Total units in stock per category");
            var q12 = products.GroupBy(p => p.Category)
                              .Select(g => new { g.Key, Units = g.Sum(p => p.UnitsInStock) });
            foreach (var item in q12) Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q13
            Console.WriteLine("Q13. Cheapest price per category");
            var q13 = products.GroupBy(p => p.Category)
                              .Select(g => new { g.Key, Cheapest = g.Min(p => p.UnitPrice) });
            foreach (var item in q13) Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q14
            Console.WriteLine("Q14. Products with cheapest price per category");
            var q14 = from p in products
                      group p by p.Category into g
                      let minPrice = g.Min(p => p.UnitPrice)
                      from p in g
                      where p.UnitPrice == minPrice
                      select new { g.Key, p.ProductName, p.UnitPrice };
            foreach (var item in q14) Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q15
            Console.WriteLine("Q15. Most expensive price per category");
            var q15 = products.GroupBy(p => p.Category)
                              .Select(g => new { g.Key, Expensive = g.Max(p => p.UnitPrice) });
            foreach (var item in q15) Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q16
            Console.WriteLine("Q16. Products with most expensive price per category");
            var q16 = from p in products
                      group p by p.Category into g
                      let maxPrice = g.Max(p => p.UnitPrice)
                      from p in g
                      where p.UnitPrice == maxPrice
                      select new { g.Key, p.ProductName, p.UnitPrice };
            foreach (var item in q16) Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q17
            Console.WriteLine("Q17. Average price per category");
            var q17 = products.GroupBy(p => p.Category)
                              .Select(g => new { g.Key, Avg = g.Average(p => p.UnitPrice) });
            foreach (var item in q17) Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            #endregion

            Console.WriteLine("=========== LINQ - Set Operators ===========");

            #region Q18
            Console.WriteLine("Q18. Unique category names");
            var q18 = products.Select(p => p.Category).Distinct();
            foreach (var item in q18) Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q19
            Console.WriteLine("Q19. Unique first letters from products and customers");
            var q19 = products.Select(p => p.ProductName[0])
                              .Union(customers.Select(c => c.CustomerName[0]));
            foreach (var item in q19) Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q20
            Console.WriteLine("Q20. Common first letters");
            var q20 = products.Select(p => p.ProductName[0])
                              .Intersect(customers.Select(c => c.CustomerName[0]));
            foreach (var item in q20) Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q21
            Console.WriteLine("Q21. First letters of products not in customers");
            var q21 = products.Select(p => p.ProductName[0])
                              .Except(customers.Select(c => c.CustomerName[0]));
            foreach (var item in q21) Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q22
            Console.WriteLine("Q22. Last 3 characters of all customers & products");
            var q22 = products.Select(p => p.ProductName.Substring(Math.Max(0, p.ProductName.Length - 3)))
                               .Concat(customers.Select(c => c.CustomerName.Substring(Math.Max(0, c.CustomerName.Length - 3))));
            foreach (var item in q22) Console.WriteLine(item);
            Console.WriteLine("-----------------------------");
            #endregion

            Console.WriteLine("=========== LINQ - Quantifiers ===========");

            #region Q23
            Console.WriteLine("Q23. Any word contains 'ei'");
            var q23 = dictionary.Any(w => w.Contains("ei"));
            Console.WriteLine(q23);
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q24
            Console.WriteLine("Q24. Categories with at least one out of stock product");
            var q24 = from p in products
                      group p by p.Category into g
                      where g.Any(p => p.UnitsInStock == 0)
                      select g;
            foreach (var g in q24)
            {
                Console.WriteLine($"Category: {g.Key}");
                foreach (var p in g) Console.WriteLine($" - {p.ProductName}");
            }
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q25
            Console.WriteLine("Q25. Categories with all products in stock");
            var q25 = from p in products
                      group p by p.Category into g
                      where g.All(p => p.UnitsInStock > 0)
                      select g;
            foreach (var g in q25)
            {
                Console.WriteLine($"Category: {g.Key}");
                foreach (var p in g) Console.WriteLine($" - {p.ProductName}");
            }
            Console.WriteLine("-----------------------------");
            #endregion

            Console.WriteLine("=========== LINQ - Grouping Operators ===========");

            #region Q26
            Console.WriteLine("Q26. Partition numbers by remainder mod 5");
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var q26 = numbers.GroupBy(n => n % 5);
            foreach (var g in q26)
            {
                Console.WriteLine($"Numbers with a remainder of {g.Key} when divided by 5 : {string.Join(",", g)}");
            }
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q27
            Console.WriteLine("Q27. Partition words by first letter (dictionary)");
            var q27 = dictionary.GroupBy(w => w[0]);
            foreach (var g in q27)
            {
                Console.WriteLine($"Letter {g.Key}: {string.Join(",", g.Take(5))} ...");
            }
            Console.WriteLine("-----------------------------");
            #endregion

            #region Q28
            Console.WriteLine("Q28. Group words that consist of same characters");
            string[] arr2 = { "from", "salt", "earn", "last", "near", "form" };
            var q28 = arr2.GroupBy(w => String.Concat(w.OrderBy(c => c)));
            foreach (var g in q28)
            {
                Console.WriteLine($"{g.Key}: {string.Join(",", g)}");
            }
            Console.WriteLine("-----------------------------");
            #endregion
        }
    }
}
