
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern;

namespace AdapterPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            AmericanCharger charger = new AmericanCharger();

            IndianSocket adapter = new ChargerAdapter(charger);
            adapter.PlugIn();
        }
    }
}