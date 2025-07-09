using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 19. Identity Matrix
            Console.WriteLine("Question 19: Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.");
            Console.Write("Enter the size of the identity matrix: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(i == j ? "1 " : "0 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");
            #endregion

            #region 20. Sum of array
            Console.WriteLine("Question 20: Write a program in C# Sharp to find the sum of all elements of the array.");
            Console.Write("Enter size of array: ");
            int size20 = Convert.ToInt32(Console.ReadLine());
            int[] arr20 = new int[size20];
            int sum20 = 0;
            for (int i = 0; i < size20; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr20[i] = Convert.ToInt32(Console.ReadLine());
                sum20 += arr20[i];
            }
            Console.WriteLine("Sum of elements: " + sum20);
            Console.WriteLine("----------------------------------");
            #endregion

            #region 21. Merge and sort two arrays
            Console.WriteLine("Question 21: Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.");
            Console.Write("Enter size of arrays: ");
            int size21 = Convert.ToInt32(Console.ReadLine());
            int[] a21 = new int[size21];
            int[] b21 = new int[size21];
            int[] merged = new int[size21 * 2];

            Console.WriteLine("Enter elements of first array:");
            for (int i = 0; i < size21; i++)
                a21[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements of second array:");
            for (int i = 0; i < size21; i++)
                b21[i] = Convert.ToInt32(Console.ReadLine());

            Array.Copy(a21, merged, size21);
            Array.Copy(b21, 0, merged, size21, size21);
            Array.Sort(merged);
            Console.WriteLine("Merged & sorted array: " + string.Join(" ", merged));
            Console.WriteLine("----------------------------------");
            #endregion

            #region 22. Frequency count
            Console.WriteLine("Question 22: Write a program in C# Sharp to count the frequency of each element of an array.");
            Console.Write("Enter size of array: ");
            int size22 = Convert.ToInt32(Console.ReadLine());
            int[] arr22 = new int[size22];
            for (int i = 0; i < size22; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr22[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool[] counted = new bool[size22];
            for (int i = 0; i < size22; i++)
            {
                if (counted[i]) continue;
                int count = 1;
                for (int j = i + 1; j < size22; j++)
                {
                    if (arr22[i] == arr22[j])
                    {
                        count++;
                        counted[j] = true;
                    }
                }
                Console.WriteLine($"Element {arr22[i]} occurs {count} time(s)");
            }
            Console.WriteLine("----------------------------------");
            #endregion

            #region 23. Max and Min in array
            Console.WriteLine("Question 23: Write a program in C# Sharp to find maximum and minimum element in an array.");
            Console.Write("Enter size of array: ");
            int size23 = Convert.ToInt32(Console.ReadLine());
            int[] arr23 = new int[size23];
            for (int i = 0; i < size23; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr23[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max23 = arr23[0], min23 = arr23[0];
            foreach (int x in arr23)
            {
                if (x > max23) max23 = x;
                if (x < min23) min23 = x;
            }
            Console.WriteLine($"Max = {max23}, Min = {min23}");
            Console.WriteLine("----------------------------------");
            #endregion

            #region 24. Second largest
            Console.WriteLine("Question 24: Write a program in C# Sharp to find the second largest element in an array.");
            Console.Write("Enter size of array: ");
            int size24 = Convert.ToInt32(Console.ReadLine());
            int[] arr24 = new int[size24];
            for (int i = 0; i < size24; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr24[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr24);
            int max24 = arr24[^1];
            int secondMax = -1;
            for (int i = size24 - 2; i >= 0; i--)
            {
                if (arr24[i] != max24)
                {
                    secondMax = arr24[i];
                    break;
                }
            }
            Console.WriteLine("Second largest: " + (secondMax == -1 ? "Not found" : secondMax));
            Console.WriteLine("----------------------------------");
            #endregion

            #region 25. Longest distance between equal values
            Console.WriteLine("Question 25: Find the longest distance between two equal values in an array. Distance is measured by the number of cells between them.");
            Console.Write("Enter size of array: ");
            int size25 = Convert.ToInt32(Console.ReadLine());
            int[] arr25 = new int[size25];
            for (int i = 0; i < size25; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr25[i] = Convert.ToInt32(Console.ReadLine());
            }
            int longest = 0;
            for (int i = 0; i < size25; i++)
            {
                for (int j = size25 - 1; j > i; j--)
                {
                    if (arr25[i] == arr25[j])
                    {
                        int distance = j - i - 1;
                        if (distance > longest)
                            longest = distance;
                        break;
                    }
                }
            }
            Console.WriteLine("Longest distance between equal cells: " + longest);
            Console.WriteLine("----------------------------------");
            #endregion

            #region 26. Reverse word order
            Console.WriteLine("Question 26: Given a list of space separated words, reverse the order of the words.");
            Console.Write("Enter a sentence: ");
            string input26 = Console.ReadLine();
            string[] words = input26.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            Console.WriteLine(string.Join(" ", words));
            Console.WriteLine("----------------------------------");
            #endregion

            #region 27. Copy 2D array
            Console.WriteLine("Question 27: Create two multidimensional arrays of same size. Copy values from the first to the second and print the second.");
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] first = new int[rows, cols];
            int[,] second = new int[rows, cols];

            Console.WriteLine("Enter elements for first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    first[i, j] = Convert.ToInt32(Console.ReadLine());
                    second[i, j] = first[i, j];
                }
            }

            Console.WriteLine("Copied second array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(second[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");
            #endregion

            #region 28. Reverse one-dimensional array
            Console.WriteLine("Question 28: Write a Program to Print One Dimensional Array in Reverse Order.");
            Console.Write("Enter size of array: ");
            int size28 = Convert.ToInt32(Console.ReadLine());
            int[] arr28 = new int[size28];
            for (int i = 0; i < size28; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr28[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Reverse(arr28);
            Console.WriteLine("Reversed array: " + string.Join(" ", arr28));
            Console.WriteLine("----------------------------------");
            #endregion
        }
    }
}
