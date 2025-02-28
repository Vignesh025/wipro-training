////using System;


////namespace ConsoleAppwipro.Day6
////{
////    internal class Exception_handling_demo
////    {
////        static void Main(string[] args)
////        {
////            try
////            {
////                Console.WriteLine("Enter first number:");
////                int num1 = int.Parse(Console.ReadLine());
////                Console.WriteLine("Enter second number:");
////                int num2 = int.Parse(Console.ReadLine());

////                float div = num1 / num2;
////            }
////            //catch (Exception)                 IF an exception is thrown without catch block then finally will not be executed
////            //{
////            //    Console.WriteLine("Exception is thrown");
////            //}
////            finally
////            {
////                Console.WriteLine("This is finally block");
////            }
////        }
////    }
////}

// ===============================================================================================================================


//// Custom exception

////using System;

////namespace demo
////{
////    public class InvalidAgeException : Exception
////    {
////        public InvalidAgeException(string message)
////            : base(message)
////        {
////        }
////    }

////    public class UserDefinedExceptionDemo
////    {
////        static void validate(int age)
////        {
////            if (age < 18)
////                throw new InvalidAgeException("Age must be above 18.");
////        }
////        static void Main(string[] args)
////        {
////            try
////            {
////                validate(15);
////            }
////            catch (InvalidAgeException e)
////            {
////                Console.WriteLine(e);
////            }
////            finally
////            {
////                Console.WriteLine("Finally block");
////            }
////        }
////    }
////}


// ===============================================================================================================================


//// Exception Filter


//using System;

//public class Demo
//{
//    static void Main(string[] args)
//    {
//		//try
//		//{
//		//	int result = Divide(10, 0);
//		//}
//		//catch (DivideByZeroException) when (LogException)
//		//{

//		//}

//		try
//		{
//			throw new Exception("This is a Specific Condition");
//		}
//		catch (Exception ex) when (ex.Message.Contains("Specific Condition"))
//		{
//            Console.WriteLine("Handled an exception with a specific message condition");
//		}
//		catch ( Exception ex)
//		{
//            Console.WriteLine($"Unhandled Exception {ex.Message}");
//		}
//    }

//	static int Divide(int numerator, int denominator)
//	{
//		return numerator / denominator;
//	}

//	static bool LogException(Exception ex)
//	{
//		Console.WriteLine($"Exception: {ex.Message}");
//		return true;
//	}
//}