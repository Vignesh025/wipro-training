////using System;


////namespace A
////{
////    class class1
////    {
////        public void function1()
////        {
////            Console.WriteLine("Namespace A - Class1 - function1");
////        }
////    }
////}

////namespace B
////{
////    class class2
////    {
////        public void function2()
////        {
////            Console.WriteLine("Namespace B - Class2 - function2");
////        }
////    }
////}

////namespace C
////{
////    class class3
////    {
////        public void function3()
////        {
////            Console.WriteLine("Namespace C - Class3 - function3");
////        }
////    }
////}

////namespace D
////{
////    class MyClass
////    {
////        static void Main(string[] args)
////        {
////            A.class1 o1 = new A.class1();
////            o1.function1 ();
////            B.class2 o2 = new B.class2();
////            o2 .function2 ();
////            C.class3 o3 = new C.class3();
////            o3.function3 ();
////        }
////    }
////}

//using System;

//namespace A
//{
//    class Myclass
//    {
//        public static void Greet()
//        {
//            Console.WriteLine("Hello");
//        }
//    }
//    namespace B
//    {
//        class nestedclass
//        {
//            public static void Bye()
//            {
//                Console.WriteLine("Good Bye!");
//            }
//        }
//    }
//}

//namespace C
//{
//    class Mainclass
//    {
//        static void Main(string[] args)
//        {
//            A.Myclass.Greet();
//            A.B.nestedclass.Bye();
//        }
//    }
//}