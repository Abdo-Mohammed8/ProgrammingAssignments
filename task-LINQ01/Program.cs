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

            int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] Arr2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            #region LINQ - Element Operators

            Console.WriteLine("1. Get first Product out of Stock");
            var q1 = products.FirstOrDefault(p => p.UnitsInStock == 0);
            Console.WriteLine(q1);
            Console.WriteLine("------------------------------");

            Console.WriteLine("2. Return the first product whose Price > 1000, unless null if no match");
            var q2 = products.FirstOrDefault(p => p.UnitPrice > 1000);
            Console.WriteLine(q2);
            Console.WriteLine("------------------------------");

            Console.WriteLine("3. Retrieve the second number greater than 5");
            var q3 = Arr1.Where(n => n > 5).Skip(1).FirstOrDefault();
            Console.WriteLine(q3);
            Console.WriteLine("------------------------------");

            #endregion

            #region LINQ - Aggregate Operators

            Console.WriteLine("1. Uses Count to get the number of odd numbers in the array");
            var q4 = Arr1.Count(n => n % 2 == 1);
            Console.WriteLine(q4);
            Console.WriteLine("------------------------------");

            Console.WriteLine("2. Return a list of customers and how many orders each has");
            var q5 = customers.Select(c => new { c.CustomerName, OrdersCount = c.Orders.Count() });
            foreach (var item in q5) Console.WriteLine($"{item.CustomerName}: {item.OrdersCount}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("3. Return a list of categories and how many products each has");
            var q6 = products.GroupBy(p => p.Category)
                             .Select(g => new { Category = g.Key, Count = g.Count() });
            foreach (var item in q6) Console.WriteLine($"{item.Category}: {item.Count}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("4. Get the total of the numbers in an array");
            var q7 = Arr1.Sum();
            Console.WriteLine(q7);
            Console.WriteLine("------------------------------");

            Console.WriteLine("5. Get the total number of characters of all words in dictionary_english.txt");
            var dictWords = File.ReadAllLines("dictionary_english.txt");
            var q8 = dictWords.Sum(w => w.Length);
            Console.WriteLine(q8);
            Console.WriteLine("------------------------------");

            Console.WriteLine("6. Get the length of the shortest word in dictionary_english.txt");
            var q9 = dictWords.Min(w => w.Length);
            Console.WriteLine(q9);
            Console.WriteLine("------------------------------");

            Console.WriteLine("7. Get the length of the longest word in dictionary_english.txt");
            var q10 = dictWords.Max(w => w.Length);
            Console.WriteLine(q10);
            Console.WriteLine("------------------------------");

            Console.WriteLine("8. Get the average length of the words in dictionary_english.txt");
            var q11 = dictWords.Average(w => w.Length);
            Console.WriteLine(q11);
            Console.WriteLine("------------------------------");

            Console.WriteLine("9. Get the total units in stock for each product category");
            var q12 = products.GroupBy(p => p.Category)
                              .Select(g => new { g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) });
            foreach (var item in q12) Console.WriteLine($"{item.Key}: {item.TotalUnits}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("10. Get the cheapest price among each category's products");
            var q13 = products.GroupBy(p => p.Category)
                              .Select(g => new { g.Key, MinPrice = g.Min(p => p.UnitPrice) });
            foreach (var item in q13) Console.WriteLine($"{item.Key}: {item.MinPrice}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("11. Get the products with the cheapest price in each category (Use Let)");
            var q14 = from p in products
                      group p by p.Category into g
                      let minPrice = g.Min(p => p.UnitPrice)
                      from p2 in g
                      where p2.UnitPrice == minPrice
                      select new { g.Key, p2.ProductName, p2.UnitPrice };
            foreach (var item in q14) Console.WriteLine($"{item.Key} - {item.ProductName}: {item.UnitPrice}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("12. Get the most expensive price among each category's products");
            var q15 = products.GroupBy(p => p.Category)
                              .Select(g => new { g.Key, MaxPrice = g.Max(p => p.UnitPrice) });
            foreach (var item in q15) Console.WriteLine($"{item.Key}: {item.MaxPrice}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("13. Get the products with the most expensive price in each category");
            var q16 = from p in products
                      group p by p.Category into g
                      let maxPrice = g.Max(p => p.UnitPrice)
                      from p2 in g
                      where p2.UnitPrice == maxPrice
                      select new { g.Key, p2.ProductName, p2.UnitPrice };
            foreach (var item in q16) Console.WriteLine($"{item.Key} - {item.ProductName}: {item.UnitPrice}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("14. Get the average price of each category's products");
            var q17 = products.GroupBy(p => p.Category)
                              .Select(g => new { g.Key, AvgPrice = g.Average(p => p.UnitPrice) });
            foreach (var item in q17) Console.WriteLine($"{item.Key}: {item.AvgPrice}");
            Console.WriteLine("------------------------------");

            #endregion

            #region LINQ - Ordering Operators

            Console.WriteLine("1. Sort a list of products by name");
            var q18 = products.OrderBy(p => p.ProductName);
            foreach (var p in q18) Console.WriteLine(p.ProductName);
            Console.WriteLine("------------------------------");

            Console.WriteLine("2. Case-insensitive sort of words in an array");
            var q19 = Arr2.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            foreach (var w in q19) Console.WriteLine(w);
            Console.WriteLine("------------------------------");

            Console.WriteLine("3. Sort a list of products by units in stock from highest to lowest");
            var q20 = products.OrderByDescending(p => p.UnitsInStock);
            foreach (var p in q20) Console.WriteLine($"{p.ProductName}: {p.UnitsInStock}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("4. Sort digits first by length then alphabetically");
            var q21 = digits.OrderBy(d => d.Length).ThenBy(d => d);
            foreach (var d in q21) Console.WriteLine(d);
            Console.WriteLine("------------------------------");

            Console.WriteLine("5. Sort words first by length then case-insensitive");
            var q22 = Arr2.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            foreach (var w in q22) Console.WriteLine(w);
            Console.WriteLine("------------------------------");

            Console.WriteLine("6. Sort products by category then price desc");
            var q23 = products.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            foreach (var p in q23) Console.WriteLine($"{p.Category} - {p.ProductName}: {p.UnitPrice}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("7. Sort words first by length then case-insensitive descending");
            var q24 = Arr2.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            foreach (var w in q24) Console.WriteLine(w);
            Console.WriteLine("------------------------------");

            Console.WriteLine("8. Digits with second letter 'i' reversed");
            var q25 = digits.Where(d => d.Length > 1 && d[1] == 'i').Reverse();
            foreach (var d in q25) Console.WriteLine(d);
            Console.WriteLine("------------------------------");

            #endregion

            #region LINQ – Transformation Operators

            Console.WriteLine("1. Return a sequence of just the names of a list of products");
            var q26 = products.Select(p => p.ProductName);
            foreach (var name in q26) Console.WriteLine(name);
            Console.WriteLine("------------------------------");

            Console.WriteLine("2. Produce uppercase and lowercase versions of each word");
            var q27 = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            foreach (var item in q27) Console.WriteLine($"{item.Upper} - {item.Lower}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("3. Select properties of Products with renamed UnitPrice as Price");
            var q28 = products.Select(p => new { p.ProductName, Price = p.UnitPrice, p.Category });
            foreach (var item in q28) Console.WriteLine($"{item.ProductName} - {item.Price} - {item.Category}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("4. Determine if int matches its position in array");
            var q29 = Arr1.Select((num, index) => new { Num = num, Index = index, Match = num == index });
            foreach (var item in q29) Console.WriteLine($"{item.Num} : {item.Match}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("5.  pairs where a < b");
            var q30 = from a in numbersA
                      from b in numbersB
                      where a < b
                      select new { a, b };
            foreach (var pair in q30) Console.WriteLine($"{pair.a} is less than {pair.b}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("6. Select all orders where total < 500");
            var q31 = customers.SelectMany(c => c.Orders)
                               .Where(o => o.Total < 500);
            foreach (var o in q31) Console.WriteLine(o);
            Console.WriteLine("------------------------------");

            Console.WriteLine("7. Select all orders where order was made in 1998 or later");
            var q32 = customers.SelectMany(c => c.Orders)
                               .Where(o => o.OrderDate.Year >= 1998);
            foreach (var o in q32) Console.WriteLine(o);
            Console.WriteLine("------------------------------");

            #endregion
        }
    }
}
