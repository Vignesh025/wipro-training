////using System;


////namespace ConsoleAppwipro.Day4
////{
////    class Vehicle
////    {
////        public int number;
////        public string brand;
////        public string make;

////        public void Showdetails()
////        {
////            Console.WriteLine("number : " + number);
////            Console.WriteLine("brand : " +brand);
////            Console.WriteLine("make : " +make);
////        }
////    }

////    class Car:Vehicle      // Single level inheritance
////    {
////        //public void type()
////        //{
////        //    Console.WriteLine("The type of vehicle is Car");
////        //}

////        public void carwheel()
////        {
////            Console.WriteLine("4 wheels");
////        }
////    }

////    class Bike : Car
////    {
////        //public void type()
////        //{
////        //    Console.WriteLine("The type of vehicle is Bike");
////        //}

////        public void bikewheel() 
////        {
////            Console.WriteLine("2 wheels");
////        }
////    }

////    internal class Inheritance_demo
////    {
////        static void Main(string[] args)
////        {
////            // Single level inheritance
////            //Bike b1 = new Bike();
////            //b1.number = 1;
////            //b1.brand = "Honda";
////            //b1.make = "2024";
////            //b1.Showdetails();
////            //b1.type();

////            //Car c1 = new Car();
////            //c1.number = 2;
////            //c1.brand = "BMW";
////            //c1.make = "2022";
////            //c1.Showdetails();
////            //c1.type();

////            // Multilevel inheritance

////            Bike b1 = new Bike();

////            b1.number = 1;
////            b1.brand = "KTM";
////            b1.make = "2023";

////            b1.bikewheel();
////            b1.carwheel();
////            b1.Showdetails();
////        }
////    }
////}


//// Practice program


////using System;


////namespace ConsoleAppwipro.Day4
////{

////    class Animal
////    {
////        public string name;
////        public int age;
////        public int limbs;

////        public void ShowDetails()
////        {
////            Console.WriteLine("The animal is: " + name);
////            Console.WriteLine("The age is: " + age);
////            Console.WriteLine("No. of limbs: "+limbs);
////        }
////    }

////    class Dog : Animal
////    {
////        public void DogAction()
////        {
////            Console.WriteLine("The Dog is barking.");
////        }
////    }

////    class Frog:Dog
////    {
////        public void FrogAction()
////        {
////            Console.WriteLine("The Frog is jumping.");
////        }
////    }

////    class Lion : Frog
////    {
////        public void LionAction()
////        {
////            Console.WriteLine("The Lion is roaring.");
////        }
////    }

////    internal class Inheritance_demo
////    {
////        static void Main(string[] args)
////        {
////            Lion l1 = new Lion();

////            l1.name = "Simba";
////            l1.age = 5;
////            l1.limbs = 4;

////            l1.ShowDetails();
////            l1.LionAction();
////            l1.FrogAction();
////            l1.DogAction();
////        }
////    }
////}

////Hierarchical inheritance

//using System;


//namespace ConsoleAppwipro.Day4
//{

//    class Shape
//    {
//        public string name;

//        public void ShowDetails()
//        {
//            Console.WriteLine("I am "+name);
//        }
//    }

//    class Square:Shape
//    {
//        public void Sides()
//        {
//            Console.WriteLine("Square has 4 sides");
//        }
//    }

//    class Rectangle:Shape
//    {
//        public void Sides()
//        {
//            Console.WriteLine("Rectangle has 4 sides");
//        }
//    }

//    class Octagon:Shape
//    {
//        public void Sides()
//        {
//            Console.WriteLine("Octagon has 8 sides");
//        }
//    }

//    internal class Inheritance_demo
//    {
//        static void Main(string[] args)
//        {
//            Square s1 = new Square();

//            s1.name = "square";
//            s1.ShowDetails();
//            s1.Sides();

//            Rectangle r1 = new Rectangle();

//            r1.name = "rectangle";
//            r1.ShowDetails();
//            r1.Sides();

//            Octagon o1 = new Octagon();

//            o1.name = "octagon";
//            o1.ShowDetails();
//            o1.Sides();
//        }
//    }
//}