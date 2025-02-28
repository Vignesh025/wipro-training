using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorypatternDemo
{
    public interface MobileFactory
    {
        public static IMobile GetMobile(string type)
        {
            if(type.ToLower()=="android")
            {
                return new Andriod();
            }
            else if(type.ToLower()=="iphone")
            {
                return new Iphone();
            }    
            else
            {
                throw new Exception("Invalid Mobile Type");
            }
        }
    }
}
