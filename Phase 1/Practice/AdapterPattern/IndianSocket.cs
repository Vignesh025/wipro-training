using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern;

namespace AdapterPattern
{
    // What we need
    public interface IndianSocket
    {
        void PlugIn(); //  this means indian socket need 3 pin charger
    }

    // what we have

    class AmericanCharger
    {
        void Connect()
        {
            Console.WriteLine("Charging with 2 pin");
        }
    }

    class ChargerAdapter : IndianSocket
    {
        private AmericanCharger charger;

        public ChargerAdapter(AmericanCharger charger)
        {
            this.charger = charger;
        }

        public void PlugIn()
        {
            Console.WriteLine("Using Adapter to convert 2 pin to 3 pin");
        }
    }

}