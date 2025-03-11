using System;

class if_switch_demo
{
    static void Main(string[] args)
    {
        int age;
        Console.WriteLine("Enter the age of the candidate:");
        age =int.Parse(Console.ReadLine());

        // if else
        //if (age >= 18)
        //    Console.WriteLine("The candidate is eligible for voting.");
        //else
        //    Console.WriteLine("The candidate is ineligible.");

        if (age < 10)
            Console.WriteLine("Age is less than 10");
        else if (age < 20)
            Console.WriteLine("Age is greater than or equal to 10 but less than 20");
        else if(age < 30)
            Console.WriteLine("Age is greater than or equal to 20 but less than 30");
        else
            Console.WriteLine("Age is greater than or equal to 30");
    }
}