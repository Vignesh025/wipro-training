using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorypatternDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mobile Type (Android/Iphone) : ");
            string mobiletype = Console.ReadLine();

            try
            {
                IMobile mobile = MobileFactory.GetMobile(mobiletype);
                mobile.GetMobileDetails();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}