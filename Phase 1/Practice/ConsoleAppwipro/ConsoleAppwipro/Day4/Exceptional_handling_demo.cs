//using System;


//namespace ConsoleAppwipro.Day4
//{
//    internal class Exceptional_handling_demo
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Console.WriteLine("Enter the first number:");
//                int num1 = int.Parse(Console.ReadLine());
//                Console.WriteLine("Enter the second number:");
//                int num2 = int.Parse(Console.ReadLine());

//                float div = num1 / num2;
//                Console.WriteLine("Division result is: " + div);
//            }
//            catch(DivideByZeroException ex)
//            {
//                Console.WriteLine("Divide by zero exception");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("This block will always execute");
//            }
//        }
//    }
//}
