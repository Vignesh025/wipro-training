////using System;


////namespace ConsoleAppwipro.Day5
////{
////    //class Employee
////    //{
////    //    public int a;
////    //    public int Id { get; }
////    //    public string Name { get; set; }            //automatic property
////    //    public string Description { get; set; }
////    //}
////    internal class Properties_demo
////    {
////            static void Main(string[] args)
////            {
////                //Employee emp = new Employee();

////                //emp.Id = 1;     //shows error because only get is available
////                //emp.Name = "Test";
////                //emp.Description = "Test description";

////                //Console.WriteLine($"Employee id is : {emp.Id}");
////                //Console.WriteLine($"Employee name is : {emp.Name}");
////                //Console.WriteLine($"Employee Description is : {emp.Description}");

////            }
////    }
////}

//using System;

//namespace ConsoleAppwipro.Day5
//{
//    class Book
//    {
//        public string title = "C# programming";
//        public string Title
//        {
//            get
//            {
//                return title;
//            }
//        }
//        string author;
//        public string Author
//        {
//            set
//            {
//                author = value;
//            }
//        }
//        int price = 1000;
//        public int Price
//        {
//            get
//            {
//                return price;
//            }
//            set
//            {
//                price = value;
//                price = price + price;
//            }
//        }
//    }
//    internal class Properties_demo
//    {
//        static void Main(string[] args)
//        {
//            Book b1 = new Book();
//            //b1.Title = "Test";  // Error - can only read the value of title but cannot set it
//            Console.WriteLine("Title is " + b1.Title);
//            b1.Author = "Test Author";
//            //Console.WriteLine("Author is: "+b1.Author); // Error - can only set the value of the author but cannot read it
//            b1.Price = 10000;
//            Console.WriteLine("The price is : " + b1.Price);
//        }
//    }
//}