using System;


namespace B
{
    internal class Fibonacci_demo
    {
        public static void Fibonacci(int n)
        {
            int first = 0;
            int second = 1;
            int next = first + second;
            Console.Write(next + " ");
            for (int i = 1; next < n; i++)
            {
                Console.Write(next + " ");
                first = second;
                second = next;
                next = first + second;
            }
        }
    }
}
