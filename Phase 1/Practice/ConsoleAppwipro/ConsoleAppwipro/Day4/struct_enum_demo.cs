////using System;


////namespace ConsoleAppwipro.Day4
////{
////    struct Book
////    {
////        public int BookId;
////        public string BookName;

////        public void Details ()
////        {
////            Console.WriteLine("Printing Book Details");
////        }
////    }
////    internal class struct_enum_demo
////    {
////        static void Main(string[] args)
////        {
////            Book b1= new Book();
////            b1.BookId = 1;
////            b1.BookName = "Test1";

////            Console.WriteLine("Book1 Details");
////            Console.WriteLine("Book id: "+b1.BookId);
////            Console.WriteLine("Book Name: "+b1.BookName);

////            Book b2 = new Book();
////            b2.BookId = 2;
////            b2.BookName = "Test2";

////            Console.WriteLine("Book2 Details");
////            Console.WriteLine("Book id: " + b2.BookId);
////            Console.WriteLine("Book Name: " + b2.BookName);
////        }
////    }
////}

//// Enum

//using System;


//namespace ConsoleAppwipro.Day4
//{
//    internal class struct_enum_demo
//    {
//        enum DayOfWeek
//        {
//            Sunday,
//            Monday,
//            Tuesday,
//            Wednesday,
//            Thursday,
//            Friday,
//            Saturday,
//        }
//        static void Main(string[] args)
//        {
//            DayOfWeek today = DayOfWeek.Friday;
//            Console.WriteLine("Today is : {0}", today);
//            int dayValue = (int)today;
//            Console.WriteLine("Numeric is Value of {0} is {1}",today,dayValue);
//        }
//    }
//}