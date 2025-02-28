//using System;

//namespace ConsoleAppwipro.Day2
//{
//    class array_demo
//    {
//        static void Main(string[] args)
//        {
//            // single dimensional array

//            //int[] arr1 = new int[5];
//            //arr1[0] = 1;
//            //arr1[1] = 2;
//            //arr1[2] = 3;
//            //arr1[3] = 4;
//            //arr1[4] = 5;

//            //int[] arr2 = new int[5] { 6,7,8,9,10};   

//            //int[] arr3 = {11,12,13,14,15};

//            //int[] arr4 = new int[] { 16, 17, 18, 19, 20 };

//            ////for (int i = 0; i<arr1.Length ; i++)
//            ////{
//            ////    Console.WriteLine($"{arr1[i]} {arr2[i]} {arr3[i]} {arr4[i]}");
//            ////}

//            //for (int i = 0; i < arr1.Length; i++)
//            //{
//            //    Console.WriteLine("{0} {1} {2} {3}", arr1[i], arr2[i], arr3[i], arr4[i]);
//            //}

//            // =======================================================================================================================

//            // double dimensional arrays

//            //int[,] arr = new int[2, 2] { { 2, 3 }, { 3,4} };
//            //for (int i = 0; i < arr.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < arr.GetLength(1); j++)
//            //    {
//            //        Console.Write("{0} ",arr[i, j]);
//            //    }
//            //    Console.WriteLine();
//            //}

//            // =======================================================================================================================

//            // Practice programs

//            // addition of matrix


//            //Console.WriteLine("Enter the row length of the matrix");
//            //int r = int.Parse(Console.ReadLine());
//            //Console.WriteLine("Enter the column length of the matrix");
//            //int c = int.Parse(Console.ReadLine());
//            //int[,] arr1 = new int[r, c];
//            //int[,] arr2 = new int[r, c];
//            //Console.WriteLine("Enter the elements for the first matrix");
//            //for (int i = 0; i < r; i++)
//            //{
//            //    for (int j = 0; j < c; j++)
//            //    {
//            //        arr1[i, j] = int.Parse(Console.ReadLine());
//            //    }
//            //}
//            //Console.WriteLine("Enter the elements for the second matrix");
//            //for (int i = 0; i < r; i++)
//            //{
//            //    for (int j = 0; j < c; j++)
//            //    {
//            //        arr2[i, j] = int.Parse(Console.ReadLine());
//            //    }
//            //}
//            //Console.WriteLine("Matrix 1 is:");
//            //for (int i = 0; i < r; i++)
//            //{
//            //    for (int j = 0; j < c; j++)
//            //    {
//            //        Console.Write("{0} ", arr1[i, j]);
//            //    }
//            //    Console.WriteLine();
//            //}
//            //Console.WriteLine("Matrix 2 is:");
//            //for (int i = 0; i < r; i++)
//            //{
//            //    for (int j = 0; j < c; j++)
//            //    {
//            //        Console.Write("{0} ", arr2[i, j]);
//            //    }
//            //    Console.WriteLine();
//            //}
//            //Console.WriteLine("Addition of matrix is");
//            //for (int i = 0; i < r; i++)
//            //{
//            //    for (int j = 0; j < c; j++)
//            //    {
//            //        Console.Write("{0} ",arr1[i,j]+arr2[i, j]);
//            //    }
//            //    Console.WriteLine();
//            //}
//            //Console.WriteLine("Multiplication of Matrices is");
//            //int[,] result = new int[r, c];
//            //for (int i = 0; i < r; i++)
//            //{
//            //    for (int j = 0; j < c; j++)
//            //    {
//            //        result[i, j] = 0;

//            //        for (int k = 0; k < r; k++)
//            //        {
//            //            result[i, j] += arr1[i, k] * arr2[k, j];
//            //        }

//            //        Console.Write(result[i, j] + " ");
//            //    }
//            //    Console.WriteLine();
//            //}

//            // =======================================================================================================================

//            //jagged array

//            //int[][] arr = new int[3][];
//            //arr[0] = new int[3];
//            //arr[1] = new int[2];
//            //arr[2] = new int[4];

//            //arr[0][0] = 1;
//            //arr[0][1] = 2;
//            //arr[0][2] = 3;

//            //arr[1][0] = 4;
//            //arr[1][1] = 5;

//            //arr[2][0] = 6;
//            //arr[2][1] = 7;
//            //arr[2][2] = 8;
//            //arr[2][3] = 9;

//            //Console.WriteLine("The elements of the array are");

//            //// using for loop
//            //for (int i = 0; i < arr.Length; i++)
//            //{
//            //    for (int j = 0; j < arr[i].Length; j++)
//            //    {
//            //        Console.Write(arr[i][j] + " ");
//            //    }
//            //    Console.WriteLine();
//            //}

//            ////using for each loop
//            ////foreach(var array in arr)
//            ////{
//            ////    foreach (var item in array)
//            ////    {
//            ////        Console.Write(item +" ");
//            ////    }
//            ////    Console.WriteLine();
//            ////}
//            ///

//            // sum of diagonal

//            int[,] arr = new int[3, 3] {
//                { 1,2,3},
//                { 4,5,6},
//                { 7,8,9}
//            };
//            int sum=0;
//            for(int i = 0; i < arr.GetLength(0); i++)
//            {
//                for(int j = 0; j < arr.GetLength(1); j++)
//                {
//                    if(i==j)
//                    {
//                        sum += arr[i, j];
//                    }
//                }
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}
