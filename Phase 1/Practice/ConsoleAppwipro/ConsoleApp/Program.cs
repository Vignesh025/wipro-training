using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicMath obj = new BasicMath();
            Console.WriteLine(obj.Add(1, 2));
            Console.WriteLine(obj.Subtract(3, 4));
            Console.WriteLine(obj.Multiply(5, 6));
            Console.WriteLine(obj.divide(5, 6));
        }
    }
}
