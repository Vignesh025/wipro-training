////using System;


////namespace ConsoleAppwipro.Day6
////{
////    public class Oldclass
////    {
////        public int x = 100;
////        public void Test1()
////        {
////            Console.WriteLine("Method 1 " + x);
////        }
////        public void Test2()
////        {
////            Console.WriteLine("Method 2 " +x);
////        }
////    }
////    public static class NewClass
////    {
////        public static void Test3(this Oldclass Obj)
////        {
////            Console.WriteLine("Method 3");
////        }
////        public static void Test4(this Oldclass Obj , int x)
////        {
////            Console.WriteLine("Method 4 "+x);
////        }
////        public static void Test5(this Oldclass Obj)
////        {
////            Console.WriteLine("Method 5 "+Obj.x);
////        }
////    }
////    internal class Csharp7_Extension_method
////    {
////        static void Main(string[] args)
////        {
////            Oldclass obj = new Oldclass();  
////            obj.Test1();
////            obj.Test2();
////            obj.Test3();
////            obj.Test4(10);
////            obj.Test5();
////        }
////    }
////}

//using System;

//public static class DateTimeExtensions
//{
//    public static bool isWeekend(this DateTime date)
//    {
//        return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
//    }
//}
//public class Demo
//{
//    static void Main(string[] args)
//    {
//        DateTime today = DateTime.Now;
//        bool isWeekend = today.isWeekend();

//        Console.WriteLine($"Is today a weekend: {isWeekend}");
//    }
//}

// ===============================================================================================================================


// C# 7.0 Features
// Tuples and Deconstruction

//using System;

//public class Demo
//{
//    static void Main(string[] args)
//    {
//        //var t = (123, "Hello", true);
//        //Console.WriteLine(t.Item1);
//        //Console.WriteLine(t.Item2);
//        //Console.WriteLine(t.Item3);
//        //Console.WriteLine(t) ;

//        // Using Tuple Constructor

//        //// Tuple with on element
//        //Tuple<string> t1 = new Tuple<string> ("Hello");

//        ////Tuple with three elements
//        //Tuple<string, string, int> t2 = new Tuple<string, string, int>("Hello", "World", 123);

//        //// Tuple with 8 elements
//        //Tuple<int, int, int, int, int, int, int, Tuple<int, int>> t3 = new Tuple<int, int, int, int, int, int, int, Tuple<int, int>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int, int>(8, 9));

//        //Console.WriteLine(t1);
//        //Console.WriteLine(t2);
//        //Console.WriteLine(t3);

//        // Deconstruction

//        //Create a tuple

//        var person = ("Cristiano Ronaldo", 39);

//        (string name, int age) = person;

//        Console.WriteLine($"Name:{name} Age:{age}");
//    }
//}

// ===============================================================================================================================


// Pattern Matching

//using System;

//public class Demo
//{
//    static void Main(string[] args)
//    {
//        Object obj = "Hello, World!";

//        // Method 1  using is keyword

//        //if(obj is string s)
//        //{
//        //    Console.WriteLine($"Strign Length:" + s.Length);
//        //}
//        //else
//        //{
//        //    Console.WriteLine("The object is not a string");
//        //}


//        // MEthod 2 using switch case


//        //switch (obj)
//        //{
//        //    case int i:
//        //        Console.WriteLine($"Integer Value: {i}");
//        //        break;
//        //    case float f:
//        //        Console.WriteLine($"Float Value: {f}");
//        //        break;
//        //    case string s:
//        //        Console.WriteLine($"String Value: {s}");
//        //        break;
//        //    default:
//        //        Console.WriteLine("Unknown type.");
//        //        break;
//        //}


//    }
//}


// ===============================================================================================================================


// Local Functions

using System;
using A;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int num = 5;
//        int result = Factorial(5);
//        Console.WriteLine($"Factorial of {num} is {result}");

//        // Local Function
//        int Factorial(int n)
//        {
//            if (n < 0)
//                throw new ArgumentException("Number must not be negative");
//            if (n == 0 || n == 1)
//                return 1;
//            return n * Factorial(n - 1);
//        }
//    }
//}

// ===============================================================================================================================

// Out Variable

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        if(int.TryParse("123", out int result))
//        {
//            Console.WriteLine($"Parsing Successful {result}");
//        }
//        else
//            Console.WriteLine("Parsing unsuccessful");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        string numberString = "25.0";
//        if (TryParseAndCalculateSquareRoot(numberString, out double number, out double squareRoot))
//        {
//            Console.WriteLine($"Parsed number: {number}");
//            Console.WriteLine($"Square root: {squareRoot}");
//        }
//        else
//        {
//            Console.WriteLine("Parsing or square root calculation failed.");
//        }
//    }

//    static bool TryParseAndCalculateSquareRoot(string input, out double number, out double squareRoot)
//    {
//        // Initialize out parameters
//        number = 0;
//        squareRoot = 0;

//        // Try to parse the string into a double
//        if (double.TryParse(input, out number))
//        {
//            // Calculate the square root if parsing is successful
//            if (number >= 0)
//            {
//                squareRoot = Math.Sqrt(number);
//                return true;
//            }
//        }

//        return false;
//    }
//}

// ===============================================================================================================================

// Ref Local

//using System;

//public class program
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

//        ref int numberref = ref GetElementByRef(numbers, 3);
//        numberref = 100;

//        Console.WriteLine("Modified Array:");
//        foreach(var number in numbers)
//            Console.WriteLine(number);
//    }

//    static ref int GetElementByRef(int[] numbers, int index)
//    {
//        return ref numbers[index];
//    }
//}

// ===============================================================================================================================

// Discards

//using System;

//public class Demo
//{
//    static void Main(string[] args)
//    {
//        var person = ("John", "Wick", 24);
//        // Deconstruct and use discard character
//        var (firstname, _, age) = person;

//        Console.WriteLine($"Firstname: {firstname} Age: {age}");

//    }
//}

// ===============================================================================================================================

// Expression Bodied Members

//using System;

//public class Program
//{
//    static void Main(string[] args)
//    {
//        var calculator = new Calculator();

//        Console.WriteLine("The Addition is: "+ calculator.Add(3,5));
//        Console.WriteLine("The square is: " + calculator.Square(5));
//    }
//}

//public class Calculator
//{
//    //Expression Bodied method for addition
//    public int Add(int x, int y) => x + y;

//    //Expression Bodied method for square
//    public int Square(int x) => x * x;
//}