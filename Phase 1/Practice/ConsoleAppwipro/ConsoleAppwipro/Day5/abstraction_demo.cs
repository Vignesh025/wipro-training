//using System;


//namespace ConsoleAppwipro.Day5
//{
//    abstract class Computer
//    {
//        public int x = 10;
//        public abstract void Addition();

//        public void Details()
//        {
//            Console.WriteLine("Computer Details");
//        }
//    }

//    class Mouse:Computer
//    {
//        public override void Addition()
//        {
//            x = 100;
//            Console.WriteLine("Addition is invoked in Mouse");
//        }

//        public new void Details()
//        {
//            Console.WriteLine("Mouse Details");
//        }
       

//    }
//    internal class abstraction_demo
//    {
//        static void Main(string[] args)
//        {
//            Mouse m1 = new Mouse();
//            m1.Addition();
//            m1.Details();
//            m1.x = 1000;

//            Console.WriteLine(m1.x);

//            Computer c1 = new Mouse();
//            c1.Addition();
//            c1.Details();

//            Console.WriteLine(c1.x);
//        }
//    }
//}
