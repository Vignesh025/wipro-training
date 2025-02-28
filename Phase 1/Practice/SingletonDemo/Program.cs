using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton user1 = Singleton.GetInstace();
            Console.WriteLine("Object is created for user1");
            Singleton user2 = Singleton.GetInstace();
            Console.WriteLine("Object is used by user2");
        }
    }
}