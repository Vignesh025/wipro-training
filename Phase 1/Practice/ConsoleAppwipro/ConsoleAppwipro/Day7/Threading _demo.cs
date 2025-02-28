////using System;
////using System.Threading;

////namespace Threaddemo
////{
////    public class mainthread1
////    {
////        // static method one
////        public static void thrd1()
////        {
////            // It prints numbers from 0 to 10
////            for (int t = 0; t <= 10; t++)
////            {
////                Console.WriteLine("Thread1 is : {0}", t);
////                // When the value of t is equal to
////                // 5 then this method sleeps for
////                // 5 seconds and after 5 seconds
////                // it resumes its working
////                if (t == 5)
////                {
////                    Thread.Sleep(5000);                // Thread 

////                }
////            }
////        }
////        // static method two
////        public static void thrd2()
////        {
////            // It prints numbers from 0 to 10
////            for (int p = 0; p <= 10; p++)
////            {
////                Console.WriteLine("Thread2 is : {0}", p);
////            }
////        }
////    }
////    // Driver Class
////    public class mainthread2
////    {
////        // Main Method
////        static public void Main()
////        {
////            // Calling static methods
////            mainthread1.thrd1();
////            mainthread1.thrd2();
////        }
////    }
////}

//using System;
//using System.Reflection;

//public class Car
//{
//    public string Make { get; set; }
//    public string Model { get; set; }
//    public int Year { get; set; }

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Car: {Year} {Make} {Model}");
//    }

//    public void Start()
//    {
//        Console.WriteLine("Car started.");
//    }

//    public void Stop()
//    {
//        Console.WriteLine("Car stopped.");
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Get the type information
//        Type carType = typeof(Car);

//        // Create an instance of Car
//        object carInstance = Activator.CreateInstance(carType);

//        // Set property values using reflection
//        PropertyInfo makeProp = carType.GetProperty("Make");
//        makeProp.SetValue(carInstance, "Toyota");
//        PropertyInfo modelProp = carType.GetProperty("Model");
//        modelProp.SetValue(carInstance, "Camry");

//        PropertyInfo yearProp = carType.GetProperty("Year");
//        yearProp.SetValue(carInstance, 2021);

//        // Invoke the DisplayInfo method
//        MethodInfo displayInfoMethod = carType.GetMethod("DisplayInfo");
//        displayInfoMethod.Invoke(carInstance, null);

//        // Invoke the Start method
//        MethodInfo startMethod = carType.GetMethod("Start");
//        startMethod.Invoke(carInstance, null);

//        // Invoke the Stop method
//        MethodInfo stopMethod = carType.GetMethod("Stop");
//        stopMethod.Invoke(carInstance, null);
//    }
//}