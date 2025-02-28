// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Principaldiagonalelements
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             int[,] arr= new int[3,3]{{1,2,3},{3,4,5},{5,6,7}};
//             int sum =0;

//             for(int i=0;i<arr.GetLength(0);i++)
//             {
//                 for(int j=0;j<arr.GetLength(1);j++)
//                 {
//                     if(i==j)
//                     {
//                         sum+=arr[i,j];
//                     }
//                 }
//             }
//             System.Console.WriteLine(sum);
//         }
//     }
// }