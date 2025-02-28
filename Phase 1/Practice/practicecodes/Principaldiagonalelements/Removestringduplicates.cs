using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principaldiagonalelements
{
    public class Removestringduplicates
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder str1= new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (!str1.ToString().Contains(str[i]))
                {
                    str1.Append(str[i]);
                }
            }
            System.Console.WriteLine(str1);
        }
    }
}