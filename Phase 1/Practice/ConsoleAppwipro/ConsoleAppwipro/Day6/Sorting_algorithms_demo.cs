
//// Bubble Sort

//using System;

//namespace ConsoleAppwipro.Day6
//{
//    internal class Sorting_algorithms_demo
//    {
//        static void Main()
//        {
//            int[] numbers = { 5, 2, 9, 1, 5, 6 };
//            Console.WriteLine("Original array:");
//            PrintArray(numbers);

//            BubbleSort(numbers);

//            Console.WriteLine("Sorted array:");
//            PrintArray(numbers);
//        }

//        static void BubbleSort(int[] array)
//        {
//            int n = array.Length;
//            for (int i = 0; i < n - 1; i++)
//            {
//                for (int j = 0; j < n - i - 1; j++)
//                {
//                    if (array[j] > array[j + 1])
//                    {
//                        // Swap array[j] and array[j + 1]
//                        int temp = array[j];
//                        array[j] = array[j + 1];
//                        array[j + 1] = temp;
//                    }
//                }
//            }
//        }

//        static void PrintArray(int[] array)
//        {
//            foreach (int element in array)
//            {
//                Console.Write(element + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

// ===============================================================================================================================


// selection sort
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 64, 25, 12, 22, 11 };
//        Console.WriteLine("Original array:");
//        PrintArray(numbers);

//        SelectionSort(numbers);

//        Console.WriteLine("Sorted array:");
//        PrintArray(numbers);
//    }

//    static void SelectionSort(int[] array)
//    {
//        int n = array.Length;    //5
//        for (int i = 0; i < n - 1; i++)
//        {
//            // Find the minimum element in the unsorted sublist
//            int minIndex = i;

//            for (int j = i + 1; j < n; j++)
//            {
//                if (array[j] < array[minIndex])
//                {
//                    minIndex = j;
//                }
//            }

//            // Swap the found minimum element with the first element
//            int temp = array[minIndex];
//            array[minIndex] = array[i];
//            array[i] = temp;
//        }
//    }

//    static void PrintArray(int[] array)
//    {
//        foreach (int element in array)
//        {
//            Console.Write(element + " ");
//        }
//        Console.WriteLine();
//    }
//}



// ===============================================================================================================================

//  Insertion Sort

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 12, 11, 13, 5, 6 };
//        Console.WriteLine("Original array:");
//        PrintArray(numbers);

//        InsertionSort(numbers);

//        Console.WriteLine("Sorted array:");
//        PrintArray(numbers);
//    }

//    static void InsertionSort(int[] array)
//    {
//        int n = array.Length;
//        for (int i = 1; i < n; ++i)
//        {
//            int key = array[i];
//            int j = i - 1;

//            // Move elements of array[0..i-1] that are greater than key
//            // to one position ahead of their current position
//            while (j >= 0 && array[j] > key)
//            {
//                array[j + 1] = array[j];
//                j = j - 1;
//            }
//            array[j + 1] = key;
//        }
//    }

//    static void PrintArray(int[] array)
//    {
//        foreach (int element in array)
//        {
//            Console.Write(element + " ");
//        }
//        Console.WriteLine();
//    }
//}