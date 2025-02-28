using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Laptop
    {
        public string Processor {  get; set; }

        public string RAM { get; set; }

        public string Storage { get; set; }

        public string CPU { get; set; }

        public void Showspecifications()
        {
            Console.WriteLine($"Processor : {Processor}");
        }

    }
}
