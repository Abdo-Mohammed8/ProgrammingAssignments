using System;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Value Type by Value vs by Reference
            Console.WriteLine("Question 1: Difference between passing Value type by value vs by reference");

            void IncrementByValue(int x)
            {
                x++;
            }

            void IncrementByRef(ref int x)
            {
                x++;
            }

            int a = 5;
            IncrementByValue(a);
            Console.WriteLine("After IncrementByValue: " + a);  

            IncrementByRef(ref a);
            Console.WriteLine("After IncrementByRef: " + a);    
            Console.WriteLine("Explanation: Passing by value doesn't change the original variable, passing by reference does.");
            Console.WriteLine("--------------------------------------------------------------");
            #endregion

            #region 2. Reference Type by Value vs by Reference
            Console.WriteLine("Question 2: Difference between passing Reference type by value vs by reference");

            void ModifyArrayByValue(string[] arr)
            {
                arr[0] = "Changed";
                arr = new string[] { "New", "Array" };
            }

            void ModifyArrayByRef(ref string[] arr)
            {
                arr[0] = "Changed Again";
                arr = new string[] { "Completely", "New" };
            }

            string[] words = { "Original", "Word" };
            ModifyArrayByValue(words);
            Console.WriteLine("After ModifyArrayByValue: " + string.Join(", ", words)); // First element changed
            ModifyArrayByRef(ref words);
            Console.WriteLine("After ModifyArrayByRef: " + string.Join(", ", words));   // Whole array changed
            Console.WriteLine("Explanation: By value affects contents, by ref affects entire reference.");
            Console.WriteLine("--------------------------------------------------------------------");
            #endregion

            #region 3. Sum and Subtract Function
            Console.WriteLine("Question 3: Function returns sum and subtract of 2 numbers");

            (int sum, int diff) SumAndSubtract(int x, int y)
            {
                return (x + y, x - y);
            }

            Console.Write("Enter first number: ");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int y3 = int.Parse(Console.ReadLine());
            var result3 = SumAndSubtract(x3, y3);
            Console.WriteLine($"Sum: {result3.sum}, Subtract: {result3.diff}");
            Console.WriteLine("---------------------------------------");
            #endregion

            #region 4. Sum of Digits
            Console.WriteLine("Question 4: Function to sum digits of a number");

            int SumDigits(int number)
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                return sum;
            }

            Console.Write("Enter a number: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of the digits of {num4} is: {SumDigits(num4)}");
            Console.WriteLine("--------------------------------------------");
            #endregion

            #region 5. Is Prime Function
            Console.WriteLine("Question 5: Function to check if number is prime");

            bool IsPrime(int number)
            {
                if (number < 2) return false;
                for (int i = 2; i * i <= number; i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }

            Console.Write("Enter a number to check for prime: ");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num5) ? "It is prime." : "It is not prime.");
            Console.WriteLine("-----------------------------------------------------------");
            #endregion

            #region 6. MinMaxArray with ref parameters
            Console.WriteLine("Question 6: Function to return Min and Max from array using ref");

            void MinMaxArray(int[] arr, ref int min, ref int max)
            {
                min = arr[0];
                max = arr[0];
                foreach (int val in arr)
                {
                    if (val < min) min = val;
                    if (val > max) max = val;
                }
            }

            int[] arr6 = { 3, 7, 1, 9, 4 };
            int min6 = 0, max6 = 0;
            MinMaxArray(arr6, ref min6, ref max6);
            Console.WriteLine($"Min: {min6}, Max: {max6}");
            Console.WriteLine("--------------------------");
            #endregion

            #region 7. Iterative Factorial
            Console.WriteLine("Question 7: Iterative factorial function");

            int Factorial(int n7)
            {
                int result = 1;
                for (int i = 2; i <= n7; i++)
                    result *= i;
                return result;
            }

            Console.Write("Enter number for factorial: ");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of {num7} is: {Factorial(num7)}");
            Console.WriteLine("---------------------------------------------");
            #endregion

            #region 8. ChangeChar in string
            Console.WriteLine("Question 8: Change character in string by index");

            string ChangeChar(string input, int position, char newChar)
            {
                if (position < 0 || position >= input.Length) return input;
                char[] chars = input.ToCharArray();
                chars[position] = newChar;
                return new string(chars);
            }

            Console.Write("Enter a string: ");
            string str8 = Console.ReadLine();
            Console.Write("Enter position (0-based): ");
            int pos8 = int.Parse(Console.ReadLine());
            Console.Write("Enter new character: ");
            char ch8 = Console.ReadLine()[0];
            Console.WriteLine("Updated string: " + ChangeChar(str8, pos8, ch8));
            Console.WriteLine("-----------------------");
            #endregion
        }
    }
}
