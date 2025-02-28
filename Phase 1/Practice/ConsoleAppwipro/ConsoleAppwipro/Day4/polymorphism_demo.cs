
//// MEthod Overloading

////using System;


////namespace ConsoleAppwipro.Day4
////{
////    class Demo
////    {
////        public void addition()
////        {
////            int a = 10, b = 40;
////            Console.WriteLine("The addition is: " +(a+b));
////        }

////        public void addition(int a)
////        {
////            Console.WriteLine("The addition is: "+(a+a));
////        }

////        public void addition(int a, int b)
////        {
////            Console.WriteLine("The addition is: "+(a+b));
////        }
////    }
////    internal class polymorphism_demo
////    {
////        static void Main(string[] args)
////        {
////            Demo d = new Demo();
////            d.addition();
////            d.addition(10);
////            d.addition(30, 40);
////        }
////    }
////}



//// Method Overriding

//using System;


//namespace ConsoleAppwipro.Day4
//{
//    class Demo1
//    {
//        public virtual void Addition()
//        {
//            int a = 10, b = 40;
//            Console.WriteLine("The addition is: " + (a + b));
//        }
//    }

//    class Demo2:Demo1
//    {
//        public override void Addition()
//        {
//            int a = 60, b = 40;
//            Console.WriteLine("The addition is: " + (a + b));
//        }
//    }

//    internal class polymorphism_demo
//    {
//        static void Main(string[] args)
//        {

//            Demo2 d = new Demo2();
//            d.Addition();
//        }
//    }
//}
