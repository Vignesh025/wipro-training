//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ConsoleAppwipro
//{
//    internal class Lambda_expressions_demo
//    {
//        static void Main(string[] args)
//        {
//            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
//            IEnumerable<int> evennumbers = numbers.Where(n => n % 2 == 0);
//            Console.WriteLine("Even Numbers: ");
//            foreach(int n in evennumbers)
//                Console.WriteLine(n);
//            IEnumerable<int> oddnumbers = numbers.Where(n => n % 2 != 0);
//            Console.WriteLine("Odd Numbers: ");
//            foreach (int n in oddnumbers)
//                Console.WriteLine(n);
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Person
//{
//    public string Name {  get; set; }
//    public int Age { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name; Age = age;
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Person> people = new List<Person>()
//        {
//            new Person("Alice",23),
//            new Person("Ben",24),
//            new Person("Charlie",25),
//            new Person("David",26)
//        };

//        var filteredPeople = people.Where(p => p.Age > 23);
//        var names = filteredPeople.Select(p => p.Name);
//        Console.WriteLine("People over 23");
//        foreach (var name in names)
//            Console.WriteLine(name);

//    }
//}

//List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
//List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

//foreach (var num in evenNumbers)
//{
//    Console.Write("{0} ", num);
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Dog
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
    
//}

//class Demo
//{
//    static void Main(string[] args)
//    {
//        List<Dog> dogs = new List<Dog>()
//        {
//            new Dog{Name="Rex", Age=2},
//            new Dog{Name="Harry", Age=1},
//            new Dog{Name = "Goldy", Age=0}
//        };
//        var names = dogs.Select(d => d.Name);
//        foreach (var name in names)
//        {
//            Console.WriteLine(name);
//        }

//    }
//}