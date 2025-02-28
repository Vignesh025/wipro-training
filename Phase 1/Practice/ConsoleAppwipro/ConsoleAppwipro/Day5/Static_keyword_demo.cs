//using System;


//namespace ConsoleAppwipro.Day5
//{
//    //static class Demo
//    //{
//    //    public static int id;

//    //    public static void Display()
//    //    {
//    //        Console.WriteLine("Display() is invoked");
//    //    }

//    //    //public void Display()             // Error - Only static members can be declared inside a static class
//    //    //{
//    //    //    Console.WriteLine("Display() function is invoked");
//    //    //}
//    //}

//    class Demo
//    {
//        public static int id;

//        public static void Display()
//        {
//            Console.WriteLine("Display() is invoked");
//        }

//        //public void Display()             // Error - Only static members can be declared inside a static class
//        //{
//        //    Console.WriteLine("Display() function is invoked");
//        //}
//    }
//    internal class Static_keyword_demo
//    {
//        static void Main(string[] args)
//        {

//            // static class
//            //Demo d1 = new Demo();  // Error -  Cannot create an object for a static class

//            //Demo.id = 20;
//            //Console.WriteLine("The id is: "+Demo.id);
//            //Demo.Display();

//            // Non static class with static members

//            Demo d1 = new Demo();
//            //d1.id = 10;  // Error - static members should be called using only the class name

//            Demo.id = 10;
//            Demo.Display();
            


//        }
//    }
//}
