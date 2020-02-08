using System;

namespace RecursiveExercise
{
    class Program
    {
        static void Main()
        {
            int bars = Convert.ToInt32(Console.ReadLine());
            int packs = Packs(bars);
            Console.WriteLine(packs);
        }

        private static int Packs(int bars)
        {
            const int packOf10 = 10;
            const int packOf5 = 5;
            const int packOf3 = 3;
            const int packOf2 = 2;
            const int packOf1 = 1;

            if (bars >= packOf10)
            {
                return 1 + Packs(bars - packOf10);
            }

            if (bars >= packOf5)
            {
                return 1 + Packs(bars - packOf5);
            }

            if (bars >= packOf3)
            {
                return 1 + Packs(bars - packOf3);
            }

            if (bars >= packOf2)
            {
                return 1 + Packs(bars - packOf2);
            }

            if (bars >= packOf1)
            {
                return 1 + Packs(bars - packOf1);
            }

            return 0;
        }
    }
}
