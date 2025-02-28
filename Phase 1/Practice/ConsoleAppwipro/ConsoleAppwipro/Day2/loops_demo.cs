//using System;

//namespace ConsoleAppwipro.Day2
//{
//    class loops_demo
//    {
//        static void Main(string[] args)
//        {
//            // for loop

//            //for(int i = 1;i<=10;i++)
//            //{
//            //    Console.WriteLine(i);
//            //}

//            // while loop

//            //int a = 10;
//            //while (a >= 0)
//            //{
//            //    Console.WriteLine(a);
//            //    a--;
//            //}

//            // do while loop

//            //int a = 5;
//            //do
//            //{
//            //    Console.WriteLine(a);
//            //} while (a != 5);

//            // ======================================================================================================================================

//            // practice programs

//            //display all even numbers from 1 to 100

//            // for loop

//            //for (int i = 1; i <= 100; i++)
//            //    {
//            //        if (i % 2 == 0)
//            //        {
//            //            Console.WriteLine(i);
//            //        }
//            //    }

//            //while loop

//            //int i = 1;
//            //while (i <= 100)
//            //{
//            //    if (i % 2 == 0)
//            //        Console.WriteLine(i);
//            //    i++;
//            //}

//            //do while loop

//            //int i = 1;
//            //do
//            //{
//            //    if (i % 2 == 0)
//            //    {
//            //        Console.WriteLine(i);
//            //    }
//            //    i++;
//            //} while (i <= 100);

//            // ======================================================================================================================================

//            //display all odd numbers from 1 to 100

//            //for loop

//            //for (int i = 1; i <= 100; i++)
//            //{
//            //    if (i % 2 != 0)
//            //    {
//            //        Console.WriteLine(i);
//            //    }
//            //}

//            //while loop

//            //int i = 1;
//            //while (i <= 100)
//            //{
//            //    if (i % 2 != 0)
//            //        Console.WriteLine(i);
//            //    i++;
//            //}

//            //do while loop

//            //int i = 1;
//            //do
//            //{
//            //    if (i % 2 != 0)
//            //    {
//            //        Console.WriteLine(i);
//            //    }
//            //    i++;
//            //} while (i <= 100);

//            // display all numbers that are divisible by 5 from 1 to 100

//            // for loop

//            //for (int i = 1; i <= 100; i++)
//            //{
//            //    if (i % 5 == 0)
//            //    {
//            //        Console.WriteLine(i);
//            //    }
//            //}

//            //while loop

//            //int i = 1;
//            //while (i <= 100)
//            //{
//            //    if (i % 5 == 0)
//            //        Console.WriteLine(i);
//            //    i++;
//            //}

//            //do while loop

//            //int i = 1;
//            //do
//            //{
//            //    if (i % 5 == 0)
//            //    {
//            //        Console.WriteLine(i);
//            //    }
//            //    i++;
//            //} while (i <= 100);

//            // ======================================================================================================================================

//            // accept min and max from the user and display all the numbers between them and make sure that max is greater than min

//            //for loop

//            //int min, max;
//            //Console.WriteLine("Enter the min number");
//            //min = int.Parse(Console.ReadLine());
//            //Console.WriteLine("Enter the max number");
//            //max = int.Parse(Console.ReadLine());
//            //for (int i = min; i <= max; i++)
//            //{
//            //    Console.WriteLine(i);
//            //}

//            // while loop

//            //int min, max;
//            //Console.WriteLine("Enter the min number");
//            //min = int.Parse(Console.ReadLine());
//            //Console.WriteLine("Enter the max number");
//            //max = int.Parse(Console.ReadLine());
//            //while (min <= max)
//            //{
//            //    Console.WriteLine(min);
//            //    min++;
//            //}

//            // do while loop

//            //int min, max;
//            //Console.WriteLine("Enter the min number");
//            //min = int.Parse(Console.ReadLine());
//            //Console.WriteLine("Enter the max number");
//            //max = int.Parse(Console.ReadLine());
//            //do
//            //{
//            //    Console.WriteLine(min);
//            //    min++;
//            //}while (min<=max);

//            // ======================================================================================================================================

//            // display fibonacci series from 1 to 50;

//            // for loop

//            //int first = 0;
//            //int second = 1;
//            //int next= first + second;
//            //Console.WriteLine(next);
//            //for(int i=1;next<50;i++)
//            //{
//            //    Console.WriteLine(next);
//            //    first = second;
//            //    second = next;
//            //    next = first + second;
//            //}

//            //while loop

//            //int first = 0;
//            //int second = 1;
//            //int next = first + second;
//            //Console.WriteLine(next);
//            //while(next<50)
//            //{
//            //    Console.WriteLine(next);
//            //    first=second;
//            //    second=next;
//            //    next = first +second;
//            //}

//            // do while loop

//            //int first = 0;
//            //int second = 1;
//            //int next = first + second;
//            //Console.WriteLine(next);
//            //do
//            //{
//            //    Console.WriteLine(next);
//            //    first = second;
//            //    second = next;
//            //    next = first + second;
//            //} while (next < 50);

//            // ======================================================================================================================================

//            //display numbers from 50 to 1

//            // forloop

//            //for(int i=50;i>=1;i--)
//            //{
//            //    Console.WriteLine(i);
//            //}

//            // while loop

//            //int i = 50;
//            //while(i>0)
//            //{
//            //    Console.WriteLine(i);
//            //    i--;
//            //}

//            // do while loop

//            //int i = 50;
//            //do
//            //{
//            //    Console.WriteLine(i);
//            //    i--;
//            //} while (i > 0);

//            // ======================================================================================================================================

//            // multiplication table of 2

//            // for loop

//            //int a = 2;
//            //for (int i = 1; i <= 10; i++)
//            //{
//            //    Console.WriteLine("{0} x {1} = {2}",a,i,a*i);
//            //}

//            // while loop

//            //int a = 2;
//            //int i = 1;
//            //while(i<=10)
//            //{
//            //    Console.WriteLine("{0} x {1} = {2}", a, i, a * i);
//            //    i++;
//            //}

//            // do while loop

//            //int a = 2;
//            //int i = 1;
//            //do
//            //{
//            //    Console.WriteLine("{0} x {1} = {2}", a, i, a * i);
//            //    i++;
//            //} while (i <= 10);

//            // ==============================================================================================================================

//            // for each loop

//            //int[] arr = { 1, 2, 3, 4, 5 };
//            //foreach (int i in arr)
//            //{
//            //    Console.WriteLine(i);
//            //}
//        }
//    }
//}
