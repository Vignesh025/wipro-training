//using System;


//namespace ConsoleAppwipro.Day7
//{
//    public delegate void Delegate_calc();
//    class Calc
//    {
//        public void Addition()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("The Addition is: " + (a + b));
//        }
//        public void Subtraction()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("The Subtraction is: " + (a - b));
//        }
//        public void Multiplication()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("The Multiplication is: " + (a * b));
//        }
//        public void Division()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("The Division is: " + (a / b));
//        }
//        static void Main(string[] args)
//        {
//            Calc c1 = new Calc();

//            // Single cast delegate
//            //Delegate_calc obj1 = new Delegate_calc(c1.Addition);
//            //obj1();
//            //Delegate_calc obj2 = new Delegate_calc(c1.Subtraction);
//            //obj2();
//            //Delegate_calc obj3 = new Delegate_calc(c1.Multiplication);
//            //obj3();
//            //Delegate_calc obj4 = new Delegate_calc(c1.Division);
//            //obj4();


//            // Multi cast delegate

//            //Delegate_calc obj1 = new Delegate_calc(c1.Addition);
//            //obj1 += c1.Subtraction;
//            //obj1 += c1.Multiplication;
//            //obj1 += c1.Division;
//            //obj1();


//        }
//    }
//}

  =====================================================================================================================


// Using static void functions

//using System;


//namespace ConsoleAppwipro.Day7
//{
//    public delegate void Delegate_calc();
//    class Calc
//    {
//        static void Addition()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("The Addition is: " + (a + b));
//        }
//        static void Subtraction()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("The Subtraction is: " + (a - b));
//        }
//        static void Multiplication()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("The Multiplication is: " + (a * b));
//        }
//        static void Division()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("The Division is: " + (a / b));
//        }
//        static void Main(string[] args)
//        {
//            Delegate_calc obj1 = new Delegate_calc(Addition);
//            obj1 += Subtraction;
//            obj1 += Multiplication;
//            obj1 += Division;

//            obj1();



//        }
//    }
//}

  =====================================================================================================================

// Delegate with parameters

//using System;


//namespace ConsoleAppwipro.Day7
//{
//    public delegate void Delegate_calc();
//    public delegate void Delegate_calc1(int a, int b);

//    class Calc
//    {
//        public void Addition(int a, int b)
//        {
//            Console.WriteLine("The Addition is: " + (a + b));
//        }
//        public void Subtraction()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("The Subtraction is: " + (a - b));
//        }
//        public void Multiplication()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("The Multiplication is: " + (a * b));
//        }
//        public void Division()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("The Division is: " + (a / b));
//        }
//        static void Main(string[] args)
//        {
//            Calc c1 = new Calc();

//            Delegate_calc1 obj1 = new Delegate_calc1(c1.Addition);
//            obj1(2, 3);


//        }
//    }
//}

  =====================================================================================================================



// Built in Delegates - Action and Func


// Action delegates

//using System;

//public delegate void Print(int val);

//class MyClass
//{
//    static void ConsolePrint(int i)
//    {
//        Console.WriteLine(i);
//    }

//    static void Main(string[] args)
//    {
//        Print prnt = ConsolePrint;
//        prnt(10);
//    }
//}

//the above program can be done using Action delegates as

//using System;

//class MyClass
//{
//    static void ConsolePrint(int i)
//    {
//        Console.WriteLine(i);
//    }

//    static void Main(string[] args)
//    {
//        Action<int> prnt = ConsolePrint;
//        prnt(5);
//    }
//}

  =====================================================================================================================

// Func Delegate

//using System;

//class MyClass
//{
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main(string[] args)
//    {
//        Func<int, int, int> add = Sum;
//        int result = add(10, 40);
//        Console.WriteLine(result);
//    }
//}

  =====================================================================================================================

// Predicate Delegate

//using System;

//class MyClass
//{
//    static bool IsUpperCase(string s)
//    {
//        return s.Equals(s.ToUpper());
//    }

//    static void Main(string[] args)
//    {
//        Predicate<string> upper = IsUpperCase;
//        bool result = upper("hello World!");
//        Console.WriteLine(result);
//    }
//}

//  =====================================================================================================================

// Anonymous method

//using System;

//public delegate void Print(int value);
//public delegate void Calc(int value1, int value2);

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        Print print = delegate (int val)
//        {
//            Console.WriteLine("Inside Anonymous method. Value : {0}", val);
//        };
//        print(50);

//        Calc add = delegate (int v1, int v2)
//        {
//            Console.WriteLine("Addition result is:" + (v1 + v2));
//        };

//        add(2, 3);

//    }
//}