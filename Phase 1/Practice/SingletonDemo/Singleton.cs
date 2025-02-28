using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        public static int ctr = 0;

        public static Singleton Instance = null;

        public static Singleton GetInstace()
        {
            if(Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }

        private Singleton()
        {
            ctr++;
            Console.WriteLine("Counter value: "+ctr);
        }
    }
}
