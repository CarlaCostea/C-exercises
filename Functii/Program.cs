using System;

namespace Functii
{
    class Program
    {
        static void Main(string[] args)
        {
            int Add(int a, int b)
            {
                return a + b;
            }

            int AddTenToSmallNumbers(int a)
            {
                if (a < 10)
                    return a + 10; // funcția returnează a + 10 pentru a < 10

                return a; // altfel returnează a
                          // Folosirea lui 'else' ar fi redundantă aici
                          // pentru că nu se ajunge la această instrucțiune decât dacă a >= 10
            }
            int eight = Add(3, 5);
            int twelve = Add(Add(3, 5), Add(2, 2));


            void Swap(ref int first, ref int second)
            {
                int temp = first;
                first = second;
                second = temp;
            }
            int x = 3;
            int y = 2;
            Swap(ref x, ref y);
            Console.WriteLine("x = " + x + "\ny = " + y); // tipărește x = 2 și y = 3

            //swap intre siruri
            void SwapS(ref int[] first, ref int[] second)
            {
                int[] temp = first;
                first = second;
                second = temp;
            }

            void IncrementArrayElements(decimal[] a, decimal increment)
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] += increment;
            }
            
            decimal[] prices = { 2, 5, 6 };
            IncrementArrayElements(prices, 2);
            Console.WriteLine(prices[0] + " " + prices[1] + " " + prices[2]); // tipărește 4 7 8

            /*bool TryParse(string s, out int result);
             int number;
                if (int.TryParse("3", out number)) {
    
                    }
                    if (int.TryParse("3", int out number)) {}*/

            //TUPLE TYPES

            static (int Max, int Min) Extremes(int[] numbers)
            {
                int min = int.MaxValue;
                int max = int.MinValue;
                foreach (var n in numbers)
                {
                    min = (n < min) ? n : min;
                    max = (n > max) ? n : max;
                }
                return (max, min);
            }
            int[] list = { 2, 5, 3, 1, 7, 3 };
            var extremes = Extremes(list);
            Console.WriteLine(extremes.Min + " " + extremes.Max);
            
            int Adds(params int[] numbers)
            {
                int result = 0;
                foreach (int number in numbers)
                    result += number;
                return result;
            }

            /*Console.WriteLine(Add(1, 2, 3)); // tipărește 6
            Console.WriteLine(Add(1, 2, 3, 2, 1)); // tipărește 9
            Console.WriteLine(Add(new int[] {1, 2, 3})); // tipărește 6
            Console.WriteLine(Add(new int[] {1, 2, 3, 2, 1})); // tipărește 9*/

            Console.WriteLine("Hello World!");
        }
    }
}
