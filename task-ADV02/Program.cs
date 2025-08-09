using System;
using System.Collections;
using System.Collections.Generic;
using task_ADV02;

class Program
{
    #region Question 1: Reverse ArrayList without built-in Reverse
    static void ReverseArrayList(ArrayList list)
    {
        int left = 0;
        int right = list.Count - 1;
        while (left < right)
        {
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
    }
    #endregion

    #region Question 2: Get even numbers from a list
    static List<int> GetEvenNumbers(List<int> numbers)
    {
        List<int> evens = new List<int>();
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                evens.Add(num);
            }
        }
        return evens;
    }
    #endregion


    #region Question 4: Count numbers greater than X
    static int CountGreaterThanX(int[] arr, int x)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num > x) count++;
        }
        return count;
    }
    #endregion

    #region Question 5: Check palindrome array
    static bool IsPalindrome(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            if (arr[left] != arr[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
    #endregion

    #region Question 6: Remove duplicates from array
    static int[] RemoveDuplicates(int[] arr)
    {
        List<int> uniqueList = new List<int>();
        foreach (int num in arr)
        {
            if (!uniqueList.Contains(num))
            {
                uniqueList.Add(num);
            }
        }
        return uniqueList.ToArray();
    }
    #endregion

    #region Question 7: Remove odd numbers from ArrayList
    static void RemoveOddNumbers(ArrayList list)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            if ((int)list[i] % 2 != 0)
            {
                list.RemoveAt(i);
            }
        }
    }
    #endregion

    static void Main()
    {
        #region  Question 1
        Console.WriteLine("1.\tYou are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.");
        Console.WriteLine();
        ArrayList arrList = new ArrayList() { 1, 2, 3, 4, 5 };
        ReverseArrayList(arrList);
        Console.WriteLine("Reversed ArrayList: " + string.Join(", ", arrList.ToArray()));

        Console.WriteLine("-------------------------------------------");
        #endregion

        #region  Question 2

        Console.WriteLine("2.\tYou are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.");
        Console.WriteLine();
        List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine("Even Numbers: " + string.Join(", ", GetEvenNumbers(nums)));

        Console.WriteLine("-------------------------------------------");
        #endregion

        #region  Question 3

        Console.WriteLine("3.\timplement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.");
        Console.WriteLine();
        FixedSizeList<string> fixedList = new FixedSizeList<string>(3);
        fixedList.Add("A");
        fixedList.Add("B");
        fixedList.Add("C");
        Console.WriteLine("FixedSizeList Get: " + fixedList.Get(1));

        Console.WriteLine("-------------------------------------------");
        #endregion

        #region  Question 4

        Console.WriteLine("4.\tGiven an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.");
        Console.WriteLine();
        int[] arr = { 11, 5, 3 };
        Console.WriteLine(CountGreaterThanX(arr, 1));
        Console.WriteLine(CountGreaterThanX(arr, 5));
        Console.WriteLine(CountGreaterThanX(arr, 13));
        Console.WriteLine("-------------------------------------------");
        #endregion

        #region Question 5

        Console.WriteLine("5.\tGiven a number N and an array of N numbers. Determine if it's palindrome or not.");
        Console.WriteLine();
        int[] palArr = { 1, 3, 2, 3, 1 };
        Console.WriteLine(IsPalindrome(palArr) ? "YES" : "NO");

        Console.WriteLine("--------------------------------------------");
        #endregion

        #region  Question 6
        Console.WriteLine("6.\tGiven an array, implement a function to remove duplicate elements from an array.");
        Console.WriteLine();
        int[] dupArr = { 1, 2, 2, 3, 1, 4 };
        Console.WriteLine("Unique Array: " + string.Join(", ", RemoveDuplicates(dupArr)));

        Console.WriteLine("---------------------------------------------");
        #endregion

        #region  Question 7
        Console.WriteLine("7.\t Given an array list , implement a function to remove all odd numbers from it.");
        Console.WriteLine();
        ArrayList mixedList = new ArrayList() { 1, 2, 3, 4, 5, 6 };
        RemoveOddNumbers(mixedList);
        Console.WriteLine("ArrayList without odd numbers: " + string.Join(", ", mixedList.ToArray()));

        Console.WriteLine("---------------------------------------------");
        #endregion
    }
}
