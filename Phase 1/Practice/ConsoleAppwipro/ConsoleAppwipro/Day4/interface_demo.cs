////using System;

////namespace ConsoleAppwipro.Day4
////{
////    interface ICalc1
////    {
////        void addition();
////    }

////    interface ICalc2
////    {
////        void subtraction();
////    }

////    class Demo : ICalc1, ICalc2
////    {
////        void ICalc1.addition()
////        {
////            int a = 10, b = 2;
////            Console.WriteLine("The addition is : "+ (a+b));
////        }

////        void ICalc2.subtraction()
////        {
////            int a = 10, b = 2;
////            Console.WriteLine("The subtraction is : "+(a - b));
////        }
////    }
////    internal class interface_demo
////    {
////        static void Main(string[] args)
////        {

////            // Implicit way
////            //Demo d1 = new Demo();
////            //d1.addition();
////            //d1.subtraction();

////            //ICalc1 c1 = new Demo();
////            //c1.addition();

////            //ICalc2 c2 = new Demo();
////            //c2.subtraction();

////            //explicit way

////            Demo d1 = new Demo();
////            //d1.addition();                      // Error
////            //d1.subtraction();                   // Error


////            ICalc1 c1 = new Demo();
////            c1.addition();

////            ICalc2 c2 = new Demo();
////            c2.subtraction();
////        }
////    }
////}


//// inheritance of interface 

//using System;

//namespace ConsoleAppwipro.Day4
//{
//    interface ICalc1
//    {
//        void addition();
//    }

//    interface ICalc2 : ICalc1
//    {
//        void subtraction();
//    }

//    class Demo : ICalc2
//    {
//        void ICalc1.addition()
//        {
//            int a = 10, b = 2;
//            Console.WriteLine("The addition is : " + (a + b));
//        }

//        void ICalc2.subtraction()
//        {
//            int a = 10, b = 2;
//            Console.WriteLine("The subtraction is : " + (a - b));
//        }
//    }
//    internal class interface_demo
//    {
//        static void Main(string[] args)
//        {

//            // Implicit way
//            //Demo d1 = new Demo();
//            //d1.addition();
//            //d1.subtraction();

//            //ICalc1 c1 = new Demo();
//            //c1.addition();

//            //ICalc2 c2 = new Demo();
//            //c2.subtraction();

//            //explicit way

//            Demo d1 = new Demo();
//            //d1.addition();                      // Error
//            //d1.subtraction();                   // Error


//            ICalc1 c1 = new Demo();
//            c1.addition();

//            ICalc2 c2 = new Demo();
//            c2.subtraction();
//        }
//    }
//}
