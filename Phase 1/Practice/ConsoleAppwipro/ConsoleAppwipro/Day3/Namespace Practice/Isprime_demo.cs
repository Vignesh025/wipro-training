using System;


namespace C
{
    internal class Isprime_demo
    {
        public static bool Isprime(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
