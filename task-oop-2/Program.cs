using System;

namespace task_oop_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project: Point3D Class
            Console.WriteLine("--- Question 1: Point3D Testing ---");
            Console.WriteLine("Define 3D Point Class and basic constructors using chaining. Override ToString to print coordinates. Compare points, clone, and sort them.");
            Point3D p1 = new Point3D(10, 10, 10);
            Console.WriteLine(p1.ToString());

            Point3D p2 = ReadPoint("P1");
            Point3D p3 = ReadPoint("P2");

            Console.WriteLine("P1 == P2? " + (p2 == p3));

            Point3D[] points = new Point3D[]
            {
                new Point3D(1, 5, 0),
                new Point3D(2, 2, 0),
                new Point3D(1, 2, 0)
            };
            Array.Sort(points);
            Console.WriteLine("Sorted Points:");
            foreach (var pt in points)
            {
                Console.WriteLine(pt);
            }

            Point3D cloned = (Point3D)p1.Clone();
            Console.WriteLine("Cloned Point: " + cloned);
            Console.WriteLine();
            #endregion

            #region Second Project: Maths Static Class
            Console.WriteLine("--- Question 2: Maths Class ---");
            Console.WriteLine("Define static class with Add, Subtract, Multiply, and Divide methods. Call each method.");
            Console.WriteLine("Add: " + Maths.Add(10, 5));
            Console.WriteLine("Subtract: " + Maths.Subtract(10, 5));
            Console.WriteLine("Multiply: " + Maths.Multiply(10, 5));
            Console.WriteLine("Divide: " + Maths.Divide(10, 5));
            Console.WriteLine();
            #endregion

            #region Third Project: Duration Class
            Console.WriteLine("--- Question 3: Duration Class ---");
            Console.WriteLine("Define class Duration with hours, minutes, seconds. Implement ToString, Equals, GetHashCode, operator overloading, and DateTime conversion.");
            Duration d1 = new Duration(1, 10, 15);
            Console.WriteLine(d1);

            Duration d2 = new Duration(7800);
            Console.WriteLine(d2);

            Duration d3 = new Duration(666);
            Console.WriteLine(d3);

            d3 = d1 + d2;
            Console.WriteLine("d3 = d1 + d2 => " + d3);

            d3 = d1 + 7800;
            Console.WriteLine("d3 = d1 + 7800 => " + d3);

            d3 = 666 + d3;
            Console.WriteLine("d3 = 666 + d3 => " + d3);

            d3 = ++d1;
            Console.WriteLine("d3 = ++d1 => " + d3);

            d3 = --d2;
            Console.WriteLine("d3 = --d2 => " + d3);

            Duration dSub = d1 - d2;
            Console.WriteLine("d1 - d2 => " + dSub);

            Console.WriteLine("d1 > d2? " + (d1 > d2));
            Console.WriteLine("d1 <= d2? " + (d1 <= d2));

            DateTime dt = (DateTime)d1;
            Console.WriteLine("DateTime converted from d1: " + dt.ToLongTimeString());
            Console.WriteLine();
            #endregion
        }

        static Point3D ReadPoint(string pointName)
        {
            int x, y, z;

            Console.WriteLine($"Enter coordinates for {pointName}:");

            while (true)
            {
                Console.Write("X: ");
                if (int.TryParse(Console.ReadLine(), out x)) break;
                Console.WriteLine("Invalid input. Try again.");
            }
            while (true)
            {
                Console.Write("Y: ");
                if (int.TryParse(Console.ReadLine(), out y)) break;
                Console.WriteLine("Invalid input. Try again.");
            }
            while (true)
            {
                Console.Write("Z: ");
                if (int.TryParse(Console.ReadLine(), out z)) break;
                Console.WriteLine("Invalid input. Try again.");
            }

            return new Point3D(x, y, z);
        }
    }
}
