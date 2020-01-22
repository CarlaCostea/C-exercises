using System;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }

        private static double Factorial(double n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

        private static int FibonacciResult(int n)
        {
            int previous = 0;
            return Fibonacci(n, ref previous);
        }

        private static int Fibonacci(int n, ref int previous)
        {
            const int min = 2;
            if (n < min)
            {
                return n;
            }

            int beforePrevious = 0;
            previous = Fibonacci(n - 1, ref beforePrevious);
            return previous + beforePrevious;
        }
    }
}
