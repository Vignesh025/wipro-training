//using System;



////namespace ConsoleAppwipro.Day5
////{
////    class Employee
////    {
////        //public Employee()         // Default Constructor  
////        //{
////        //    Console.WriteLine("Non parameterized constructor is invoked");
////        //}

////        //public Employee(string fn, string ln)         // Parameterized constructor
////        //{
////        //    Console.WriteLine("Parameterized Constructor is invoked : "+ fn + " " + ln);
////        //}

////        static Employee()
////        {
////            Console.WriteLine("Static Constructor is invoked");
////        }
////    }
////    internal class Constructor_demo
////    {
////        static void Main(string[] args)
////        {
////            // Default Constructor invoked
////            //Employee emp1 = new Employee();

////            // Parameterized constructor
////            //Employee emp2 = new Employee("Sachin", "Tendulkar");

////            Employee e1 = new Employee();
////            Employee e2 = new Employee();
////            Employee e3 = new Employee();
////        }
////    }
////}

//namespace demo
//{
//    class A
//    {
//        public virtual void Print()
//        {
//            Console.WriteLine("Print method of Class A");
//        }
//    }

//    class B:A
//    {
//        public override void Print()
//        {
//            Console.WriteLine("Print method of class B");
//        }
//    }

//    class C : A
//    {
//        public override void Print()
//        {
//            Console.WriteLine("Print method of Class C");
//        }
//    }

//    //class D : B,C       // Error - Diamond problem -  cannot determine which method to invoke(from class B or class C) if print is called as it doesn't override print
//    //{
//    //    public void Detail()
//    //    {
//    //        Console.WriteLine("Detail method is invoked");
//    //    }
//    //}
//}