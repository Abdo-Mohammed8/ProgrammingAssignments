using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Enter and Print a Number
            /*
             * Write a program that allows the user to enter a number then print it.
             */
            Console.WriteLine("Question 1:");
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + num1);
            Console.WriteLine("----------------------------------");
            #endregion

            #region 2. Convert Non-Numeric String to Integer
            /*
             * Write C# program that converts a string to an integer, 
             * but the string contains non-numeric characters. 
             * And mention what will happen.
             */
            Console.WriteLine("Question 2:");
            string str = "123abc";
            try
            {
                int num2 = Convert.ToInt32(str);
                Console.WriteLine(num2);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("----------------------------------");
            #endregion

            #region 3. Floating Point Arithmetic
            /*
             * Write C# program that Perform a simple arithmetic operation with floating-point numbers
             * And mention what will happen.
             */
            Console.WriteLine("Question 3:");
            float a = 5.5f;
            float b = 2.2f;
            float result = a + b;
            Console.WriteLine("Result: " + result); 
            Console.WriteLine("----------------------------------");
            #endregion

            #region 4. Extract Substring
            /*
             * Write C# program that Extract a substring from a given string.
             */
            Console.WriteLine("Question 4:");
            string text = "Hello World";
            string sub = text.Substring(0, 5);
            Console.WriteLine("Substring: " + sub); 
            Console.WriteLine("----------------------------------");
            #endregion

            #region 5. Value Type Assignment and Modification
            /*
             * Write C# program that Assigning one value type variable to another 
             * and modifying the value of one variable and mention what will happen.
             */
            Console.WriteLine("Question 5:");
            int x = 5;
            int y = x;
            y = 10;
            Console.WriteLine("x = " + x); 
            Console.WriteLine("y = " + y); 

            Console.WriteLine("----------------------------------");
            #endregion

            #region 6. Reference Type Assignment and Modification
            /*
             * Write C# program that Assigning one reference type variable to another 
             * and modifying the object through one variable and mention what will happen.
             */
            Console.WriteLine("Question 6:");
            MyClass obj1 = new MyClass();
            obj1.Value = 10;
            MyClass obj2 = obj1;
            obj2.Value = 20;
            Console.WriteLine("obj1.Value = " + obj1.Value); 
            Console.WriteLine("obj2.Value = " + obj2.Value); 
 
            Console.WriteLine("----------------------------------");
            #endregion

            #region 7. Concatenate Two Strings
            /*
             * Write C# program that take two string variables and print them as one variable.
             */
            Console.WriteLine("Question 7:");
            string first = "Hello";
            string second = "World";
            string combined = first + " " + second;
            Console.WriteLine("Combined: " + combined); 
            Console.WriteLine("----------------------------------");
            #endregion

            #region 8. Convert.ToInt32(!(30 < 20))
            /*
             * int d;
             * d = Convert.ToInt32(!(30 < 20));
             * Answer: A value 1 will be assigned to d.
             */

            Console.WriteLine("Question 8:");
            Console.WriteLine("Answer: A value 1 will be assigned to d.");
            Console.WriteLine("----------------------------------");
            #endregion

            #region 9. Console.WriteLine(13 / 2 + " " + 13 % 2)
            /*
             * Console.WriteLine(13 / 2 + " " + 13 % 2);
             * Answer: 6 1
             */
            Console.WriteLine("Question 9:");
            Console.WriteLine("Answer: 6 1");
            Console.WriteLine("----------------------------------");

            #endregion

            #region 10. Conditional Arithmetic Output
            /*
             * int num = 1, z = 5;
             * if (!(num <= 0))
             *     Console.WriteLine(++num + z++ + " " + ++z);
             * else
             *     Console.WriteLine(--num + z-- + " " + --z);
             * Answer: 7 7
             */
            Console.WriteLine("Question 10:");
            Console.WriteLine("Answer: 7 7");

            Console.WriteLine("----------------------------------");
            #endregion

        }
    }

    class MyClass
    {
        public int Value;
    }
}
