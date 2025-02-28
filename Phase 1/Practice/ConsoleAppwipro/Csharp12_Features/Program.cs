//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string[] words = { "first", "second", "third", "fourth", "fifth", "sixth", "Seventh", "eighth", "ninth", "tenth" };

//        Console.WriteLine(words[^1]);
//        Console.WriteLine(words[^2]);

//        string[] lasttwo = words[^2..^0];

//        foreach (var word in lasttwo)
//        {
//            Console.WriteLine(word);
//        }
//    }
//}


//  =====================================================================================================================


// Switch Expression

//using System;

//public abstract class Shape()
//{

//}

//public class Circle : Shape
//{
//    public double Radius { get; set; }
//}

//public class Rectangle : Shape
//{
//    public double Height { get; set; }
//    public double Width { get; set; }
//}

//public class Triangle : Shape
//{
//    public double Base { get; set; }
//    public double Height { get; set; }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Shape shape = new Circle { Radius = 5 };
//        double area = shape switch
//        {
//            Circle c => Math.PI * c.Radius * c.Radius,
//            Rectangle r => r.Width * r.Height,
//            Triangle t => 0.5 * t.Base * t.Height,
//            _ => throw new ArgumentException("Unknown Shape")
//        };
//        Console.WriteLine("The Area of the shape is: {0}",area);

//        shape = new Rectangle { Height = 2, Width = 3 };
//        area = shape switch
//        {
//            Circle c => Math.PI * c.Radius * c.Radius,
//            Rectangle r => r.Width * r.Height,
//            Triangle t => 0.5 * t.Base * t.Height,
//            _ => throw new ArgumentException("Unknown Shape")
//        };
//        Console.WriteLine("The Area of the shape is: {0}", area);

//        shape = new Triangle { Height = 2, Base = 4 };
//        area = shape switch
//        {
//            Circle c => Math.PI * c.Radius * c.Radius,
//            Rectangle r => r.Width * r.Height,
//            Triangle t => 0.5 * t.Base * t.Height,
//            _ => throw new ArgumentException("Unknown Shape")
//        };
//        Console.WriteLine("The Area of the shape is: {0}", area);

//    }
//}


//  =====================================================================================================================

// Using Declarations and readonly members

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        using FileStream fileStream = File.OpenRead("e:\\program.cs");
//        using StreamReader reader = new StreamReader(fileStream);

//        string content = reader.ReadToEnd();
//        Console.WriteLine(content);
//    }
//}

//  =====================================================================================================================

// Readonly

//using System;

//public class Car
//{
//    public readonly string Model;
//    public readonly string Make;

//    public Car(string make, string model)
//    {
//        Model = model; Make = make;
//    }

//    public void DisplyInfo()
//    {
//        //Make = "Honda";    // Error - as it is readonly
//        //Model = "City";
//        Console.WriteLine($"Car: {Make} {Model}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Car car = new Car("Toyota", "Camry");
//        car.DisplyInfo();
//    }
//}


//  =====================================================================================================================

// required member

//using System;

//public class Person
//{
//    public required string FirstName { get; set; }
//    public required string LastName { get; set; }

//    public int Age { get; set; }

//    public Person(int age)
//    {
//        Age = age;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        var person = new Person(25)
//        {
//            FirstName = "Neymar",
//            LastName = "Jr"
//        };
//        Console.WriteLine($"Person: {person.FirstName} {person.LastName} Age: {person.Age}");
//    }
//}

//  =====================================================================================================================

// Primary Constructor

//using System;

//public class Person(string firstname, string lastname, int age)
//{
//    public string Firstname { get; } = firstname;
//    public string Lastname { get; } = lastname;
//    public int Age { get; } = age;

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Name : {Firstname} {Lastname} Age: {Age}");
//    }
//}

//public class MyClass
//{
//    static void Main(string[] args)
//    {
//        var person = new Person("Lionel", "Messi", 36);
//        person.DisplayInfo();
//    }
//}


//  =====================================================================================================================

// Collection expression

