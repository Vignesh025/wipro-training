//// calling methods from same class

////using System;


////namespace ConsoleAppwipro.Day3
////{
////    class methods_demo
////    {
////        static void Main(string[] args)
////        {
////            //static method
////            method1();

////            //public method
////            methods_demo pub = new methods_demo();
////            pub.method2();
////        }

////        static void method1()
////        {
////            Console.WriteLine("This is static method");
////        }

////        public void method2()
////        {
////            Console.WriteLine("This is a public method");
////        }
////    }
////}


//// =======================================================================================================================================


//// calling methods from different class
//using System;
//using System.Security.Cryptography.X509Certificates;


//namespace ConsoleAppwipro.Day3
//{
//    class methods_demo
//    {
//        static void Main(string[] args)
//        {
//            //static method
//            A.method1();

//            //public method
//            A pub = new A();
//            pub.method2();
//        }
//    }
//    class A
//    {
//        public static void method1()                        // by default all methods are private, so it should be public to access from other classes
//        {
//            Console.WriteLine("This is static method");
//        }

//        //public void method2()
//        //{
//        //    Console.WriteLine("This is a public method");
//        //}

//        internal void method2()                         // can be used within the same assembly
//        {
//            Console.WriteLine("This is a public method");
//        }
//    }
//}

