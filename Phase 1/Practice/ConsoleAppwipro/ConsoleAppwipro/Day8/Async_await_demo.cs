//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppwipro.Day8
//{
//    internal class Async_await_demo
//    {
//        static void Main(string[] args)
//        {
//            Method1();
//            Method2();
//        }
//        public static async Task Method1()
//        {
//            await Task.Run(() =>
//            {
//                for (int i = 0; i < 10; i++)
//                {
//                    Console.WriteLine("Method 1");
//                }
//            });
//        }

//        public static void Method2()
//        {
//            for(int i = 0;i<25;i++)
//                Console.WriteLine("Method2");
//        }
//    }
//}


//using System;
//using System.Threading.Tasks;

//class Program
//{
//    static void Main(string[] args)
//    {
//        CallMethod();
//    }
//    public static async void CallMethod()
//    {
//        Task<int> task = Method1();
//        Method2();
//        int count = await task;
//        Method3(count);
//    }
//    public static async Task<int> Method1()
//    {
//        int count = 0;
//        await Task.Run(() =>
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Method 1");
//                count+=1;
//            }
//        });
//        return count;
//    }

//    public static void Method2()
//    {
//        Console.WriteLine("Method 2");
//    }

//    public static void Method3(int count)
//    {
//        Console.WriteLine("The Count is: " +count);
//    }
//}