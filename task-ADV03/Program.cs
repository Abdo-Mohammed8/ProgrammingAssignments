using System;
using System.Collections.Generic;

class Program
{
    #region Q1: Reverse Queue using Stack
    static void ReverseQueue<T>(Queue<T> queue)
    {
        Stack<T> stack = new Stack<T>();

        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }
        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }
    }
    #endregion

    #region Q2: Check Balanced Parentheses using Stack
    static bool IsBalanced(string str)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in str)
        {
            if (ch == '(' || ch == '[' || ch == '{')
            {
                stack.Push(ch);
            }
            else if (ch == ')' || ch == ']' || ch == '}')
            {
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop();
                if ((ch == ')' && top != '(') ||
                    (ch == ']' && top != '[') ||
                    (ch == '}' && top != '{'))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
    #endregion

    static void Main()
    {
        #region Test Q1
        Console.WriteLine("implement a function to reverse the elements of a queue using a stack.Given a Queue,");
        Console.WriteLine("");
        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
        Console.WriteLine("Original Queue: " + string.Join(", ", queue));

        ReverseQueue(queue);

        Console.WriteLine("Reversed Queue: " + string.Join(", ", queue));
        Console.WriteLine("------------------------------------------------------");
        #endregion

        #region Test Q2
        Console.WriteLine("Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.");
        Console.WriteLine("");
        string input1 = "[()]{ }".Replace(" ", "");
        string input2 = "[(])";

        Console.WriteLine($"Input: {input1} -> {(IsBalanced(input1) ? "Balanced" : "Not Balanced")}");
        Console.WriteLine($"Input: {input2} -> {(IsBalanced(input2) ? "Balanced" : "Not Balanced")}");
        Console.WriteLine("------------------------------------------------------");
        #endregion
    }
}
