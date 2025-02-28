
// Linear Search

//using System;


//namespace ConsoleAppwipro.Day6
//{
//    internal class Searching_algorithms_demo
//    {
//        static void Main()
//        {
//            int[] numbers = { 3, 8, 2, 1, 5, 7, 4, 6 };
//            int target = 5;

//            int index = LinearSearch(numbers, target);

//            if (index != -1)
//            {
//                Console.WriteLine($"Element found at index {index}.");
//            }
//            else
//            {
//                Console.WriteLine("Element not found.");
//            }
//        }

//        static int LinearSearch(int[] array, int target)
//        {
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] == target)
//                {
//                    return i;
//                }
//            }
//            return -1; // Element not found
//        }
//    }
//}

// ===============================================================================================================================


//  Binary Search

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        int target = 7;

//        int index = BinarySearch(numbers, target);

//        if (index != -1)
//        {
//            Console.WriteLine($"Element found at index {index}.");
//        }
//        else
//        {
//            Console.WriteLine("Element not found.");
//        }
//    }

//    static int BinarySearch(int[] array, int target)
//    {
//        int left = 0;
//        int right = array.Length - 1;

//        while (left <= right)
//        {
//            int mid = left + (right - left) / 2;

//            if (array[mid] == target)
//            {
//                return mid;
//            }
//            if (array[mid] < target)
//            {
//                left = mid + 1;
//            }
//            else
//            {
//                right = mid - 1;
//            }
//        }

//        return -1; // Element not found
//    }
//}