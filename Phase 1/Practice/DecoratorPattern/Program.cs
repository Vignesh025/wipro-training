using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlainText text = new PlainText();
            Console.WriteLine(text.GetText);

            BoldText b = new BoldText(text);
            Console.WriteLine(b.GetText);

            ItalicText i = new ItalicText(text);
            Console.WriteLine(i.GetText);


        }
    }
}