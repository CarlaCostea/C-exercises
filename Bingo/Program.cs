using System;

namespace Bingo
{
    class Program
    {
        static void Main()
        {
            const int dimension = 3;
            int[,] square = ReadSquare(dimension);
            const int numberOfNumbers = 15;
            int[] numbers = ReadNumbers(numberOfNumbers);
            bool[] line = Line(square, numbers, dimension);
            Print(line);
        }

        private static void Print(bool[] line)
        {
            const int i2 = 2;
            bool bingo = line[0] && line[1] && line[i2];
            bool currentline = line[0] || line[1] || line[i2];
            Console.WriteLine(bingo ? "bingo" : currentline ? "linie" : "nimic");
        }

        private static bool[] Line(int[,] square, int[] numbers, int dimension)
        {
            bool[] result = new bool[3];
            for (int i = 0; i < dimension; i++)
            {
                result[i] = true;
                for (int j = 0; j < dimension; j++)
                {
                    int currentNumber = square[i, j];
                    if (Array.IndexOf(numbers, currentNumber) == -1)
                    {
                        result[i] = false;
                    }
                }
            }

            return result;
        }

        private static int[] ReadNumbers(int numberOfNumbers)
        {
            int[] result = new int[numberOfNumbers];
            for (int i = 0; i < numberOfNumbers; i++)
            {
                result[i] = Convert.ToInt32(Console.ReadLine());
            }

            return result;
        }

        private static int[,] ReadSquare(int dimension)
        {
            int[,] result = new int[dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < dimension; j++)
                {
                    result[i, j] = Convert.ToInt32(line[j]);
                }
            }

            return result;
        }
    }
}
