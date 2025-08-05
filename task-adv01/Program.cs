namespace task_adv01
{
    class Program
    {
        static void Main()
        {
            #region Test Optimized Bubble Sort
            Console.WriteLine("Optimized Bubble Sort");
            int[] arr = { 5, 1, 4, 2, 8 };
            Console.WriteLine("Original array: " + string.Join(", ", arr));

            BubbleSort.OptimizedBubbleSort(arr);

            Console.WriteLine("Sorted array:   " + string.Join(", ", arr));
            Console.WriteLine();
            #endregion



            #region Test Range<T>
            Console.WriteLine(" Generic Range<T>");
            var intRange = new Range<int>(10, 20);
            Console.WriteLine("15 in range 10-20? " + intRange.IsInRange(15));
            Console.WriteLine("25 in range 10-20? " + intRange.IsInRange(25));
            Console.WriteLine("Length of int range: " + intRange.Length());


            var doubleRange = new Range<double>(1.5, 5.7);
            Console.WriteLine("Is 3.0 in range 1.5-5.7? " + doubleRange.IsInRange(3.0));


            Console.WriteLine("Length of double range: " + doubleRange.Length());

            #endregion
        }
    }
}
