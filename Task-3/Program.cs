using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Divisible by 3 and 4
            /*
             * Write a program that takes a number from the user then print yes 
             * if that number can be divided by 3 and 4 otherwise print no.
             */
            Console.WriteLine("Question 1:");
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 3 == 0 && num1 % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.WriteLine("----------------------------------");
            #endregion

            #region 2. Check if number is negative or positive
            /*
             * Write a program that allows the user to insert an integer 
             * then print negative if it is negative number otherwise print positive.
             */
            Console.WriteLine("Question 2:");
            Console.Write("Enter an integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine()) ;
            if (num2 < 0)
                Console.WriteLine("negative");
            else
                Console.WriteLine("positive");
            Console.WriteLine("----------------------------------");
            #endregion

            #region 3. Max and Min of 3 numbers
            /*
             * Write a program that takes 3 integers from the user 
             * then prints the max element and the min element.
             */
            Console.WriteLine("Question 3:");
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int max = a;
            int min = a;

            if (b > max) max = b;
            if (c > max) max = c;

            if (b < min) min = b;
            if (c < min) min = c;

            Console.WriteLine("Max element = " + max);
            Console.WriteLine("Min element = " + min);
            Console.WriteLine("----------------------------------");
            #endregion

            #region 4. Even or Odd
            /*
             * Write a program that allows the user to insert an integer number 
             * then check If a number is even or odd.
             */
            Console.WriteLine("Question 4:");
            Console.Write("Enter an integer: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            if (num4 % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            Console.WriteLine("----------------------------------");
            #endregion

            #region 5. Vowel or Consonant
            /*
             * Write a program that takes character from the user then 
             * if it is a vowel chars (a,e,i,o,u) then print (vowel) 
             * otherwise print (consonant).
             */
            Console.WriteLine("Question 5:");
            Console.Write("Enter a character: ");
            char ch = Char.ToLower(Convert.ToChar(Console.ReadLine()));
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
            Console.WriteLine("----------------------------------");
            #endregion
        }
    }
}
