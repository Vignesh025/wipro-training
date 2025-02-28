// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Principaldiagonalelements
// {
//     public class Jaggedarraysumdemo
//     {
//         static void Main(string[] args)
//         {
//             int[][] jaggedarray = new int[4][];
//             jaggedarray[0] = new int[] {1,2,3,4};
//             jaggedarray[1] = new int[] {5,6,7};
//             jaggedarray[2] = new int[] {8,9};
//             jaggedarray[3] = new int[] {10,11,12,13,14};

//             for(int i=0;i<jaggedarray.GetLength(0);i++)
//             {
//                 int sum=0;
//                 for(int j=0;j<jaggedarray[i].GetLength(0);j++)
//                 {
//                     sum+=jaggedarray[i][j];
//                 }
//                 System.Console.WriteLine(sum);
//             }
//         }

//     }
// }