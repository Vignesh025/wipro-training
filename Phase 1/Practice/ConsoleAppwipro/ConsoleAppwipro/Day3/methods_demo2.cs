////using System;


////namespace ConsoleAppwipro.Day3
////{
////    internal class methods_demo2
////    {
////        static void Main(string[] args)
////        {
////            methods_demo2 obj = new methods_demo2();
////            Console.WriteLine("The addition is:" + obj.add(10,20));
////            Console.WriteLine("The subtraction is:" + obj.sub(10, 20));
////            Console.WriteLine("The multiplication is:" + obj.multiply(10, 20));
////            Console.WriteLine("The quotient is:" + obj.quotient(10, 20));
////            Console.WriteLine("The remainder is:" + obj.remainder(10, 20));
////        }

////        public int add(int a,int b)
////        {
////            return a + b;
////        }

////        public int sub(int a, int b)
////        {
////            return a - b;
////        }

////        public int multiply(int a, int b)
////        {
////            return a * b;
////        }

////        public int quotient(int a, int b)
////        {
////            return a / b;
////        }

////        public int remainder(int a, int b)
////        {
////            return a % b;
////        }
////    }
////}


////=====================================================================================================================

//// Practice problems

//using System;


//namespace ConsoleAppwipro.Day3
//{
//    internal class methods_demo2
//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine("The Factorial of 9 is:" + Factorial(9));
//            //Console.WriteLine("Fibonacci Series 1 to 50 is :");
//            //Fibonacci(50);
//            Console.WriteLine("Enter a number to check if it is Prime or not");
//            int num = int.Parse(Console.ReadLine());
//            if (Isprime(num))
//                Console.WriteLine(num + " is a Prime Number");
//            else
//                Console.WriteLine(num + " is not a Prime Number");
//        }
//        static int Factorial(int n)
//        {
//            int fact = 1;
//            for (int i = 1; i <= n; i++)
//            {
//                fact *= i;
//            }
//            return fact;
//        }

//        static void Fibonacci(int n)
//        {
//            int first = 0;
//            int second = 1;
//            int next = first + second;
//            Console.Write(next+" ");
//            for (int i = 1; next < n; i++)
//            {
//                Console.Write(next+" ");
//                first = second;
//                second = next;
//                next = first + second;
//            }
//        }

//        static bool Isprime(int n)
//        {
//            if(n<2)
//                return false;
//            if(n==2)
//                return true;
//            for (int i = 2; i < n / 2; i++)
//            {
//                if (n % i == 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//    }
//}
