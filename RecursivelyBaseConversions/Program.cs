using System;

namespace RecursivelyBaseConversions
{
    class Program
    {
        const int Hexa = 16;

        static void Main()
        {
            string numberToChange = Console.ReadLine();
            Console.WriteLine(HexToDecimal(numberToChange, 0));
        }

        static int HexToDecimal(string numberToChange, int pos)
        {
            if (pos == numberToChange.Length)
            {
                return 0;
            }

            char digit = numberToChange[numberToChange.Length - pos - 1];
            int add = digit >= '0' && digit <= '9' ? digit - '0'
                                               : digit - 'A' + 10;
            return Hexa * HexToDecimal(numberToChange, pos + 1) + add;
        }
    }
}
