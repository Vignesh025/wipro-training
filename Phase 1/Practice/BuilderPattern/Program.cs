using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern;

namespace BuilderPatter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Laptop gaminglaptop =new Builder()
                                    .setProcessor("Intel Core i9")
                                    .setRAM("32 GB")
                                    .Build();

            gaminglaptop.Showspecifications();

            Laptop companylaptop = new Builder()
                                    .setProcessor("Intel Core i9")
                                    .setRAM("16 GB")
                                    .Build();
            companylaptop.Showspecifications();
        }
    }
}