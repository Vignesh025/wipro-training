////using System;
////using System.Collections.Generic;

////namespace ConsoleAppwipro.Day7
////{
////    public class GenericClass <T>
////    {
////        public T msg;
////        public void GenericMethod(T name, T location)
////        {
////            Console.WriteLine(msg);
////            Console.WriteLine("Name: {0}", name);
////            Console.WriteLine("Location: {0}", location);
////        }

////        public void Addition(T v1, T v2)
////        {
////            Console.WriteLine(v1);
////            Console.WriteLine(v2);
////        }
////    }
////    internal class Generics_class_method_field_demo
////    {
////        static void Main(string[] args)
////        {
////            GenericClass<int> obj = new GenericClass<int>();
////            obj.msg = 100;
////            obj.GenericMethod(1, 2);

////            GenericClass<string> obj1 = new GenericClass<string>();
////            obj1.msg = "Hello";
////            obj1.GenericMethod("hala", "madrid");

////        }
////    }
////}

//using System;
//using System.Collections.Generic;

//public static class GenericCalculator
//{
//    public static T Add<T> (T a, T b)
//    {
//        return (dynamic) a + (dynamic) b;
//    }
//    public static T Subtract<T>(T a, T b)
//    {
//        return (dynamic)a - (dynamic)b;
//    }

//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        var intresultadd = GenericCalculator.Add(2, 3);
//        var intresultsubtract = GenericCalculator.Subtract(2, 3);

//        var doubleresultadd = GenericCalculator.Add(5.2, 10.3);
//        var doubleresultsubtract = GenericCalculator.Subtract(10.7, 5.5);

//        var floatresultadd = GenericCalculator.Add(6.6f, 7.20f);
//        var floatresultsubtract = GenericCalculator.Subtract(12.27f, 5.5f);

//        Console.WriteLine("Int Addition: "+intresultadd);
//        Console.WriteLine("Int Subtraction: "+intresultsubtract);

//        Console.WriteLine("Double Addition: "+doubleresultadd);
//        Console.WriteLine("Double Subtraction: "+doubleresultsubtract);

//        Console.WriteLine("Float Addition: "+floatresultadd);
//        Console.WriteLine("Float Subtraction: "+floatresultsubtract);


//    }
//}