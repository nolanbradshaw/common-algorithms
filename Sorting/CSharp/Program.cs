using System;
using CommonAlgorithms;

namespace CSharp
{
    class Program
    {
        public static int minNumber = 0;
        public static int maxNumber = 100;
        public static int arrLength = 10;
        public static int[] arr = new int[arrLength];

        // Note: Don't use PrintArray() if arrLength is large.
        static void Main(string[] args)
        {
            InitalizeArray();

            var bubbleResult = SortingAlgorithms.BubbleSort((int[])arr.Clone());
            PrintArray("Bubble Sort", bubbleResult);

            var selectionResult = SortingAlgorithms.SelectionSort((int[])arr.Clone());
            PrintArray("Selection Sort", selectionResult);

            var merged = SortingAlgorithms.MergeSort(arr);
            PrintArray("Merge Sort", merged);
        }

        public static void InitalizeArray() 
        {
            Random rnd = new Random();
            for(int i = 0; i < arrLength; i++)
            {
                arr[i] = rnd.Next(minNumber, maxNumber);
            }
        }

        public static void PrintArray(string sortType, int[] arr)
        {
            Console.Write($"{sortType}: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}");
                // Don't add a comma on last item in array.
                if(i < arr.Length - 1) 
                {
                    Console.Write(",");
                }
            }
            // Print next result on a new line.
            Console.WriteLine();
        }
    }
}
