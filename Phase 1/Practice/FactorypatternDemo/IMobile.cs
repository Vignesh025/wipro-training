using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorypatternDemo;

namespace FactorypatternDemo
{
    public interface IMobile
    {
        void GetMobileDetails();
    }
}

public class Iphone : IMobile
{
    public void GetMobileDetails()
    {
        Console.WriteLine("IPhone Specifications: ");
    }
}

public class Andriod : IMobile
{
    public void GetMobileDetails()
    {
        Console.WriteLine("Android Phone Specifications: ");
    }
}