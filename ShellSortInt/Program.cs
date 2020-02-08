using System;

namespace SortRandomNumbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = ReadNumbers();
            ShellSort(numbers);
            Print(numbers);
            Console.Read();
        }

        static void ShellSort(int[] numbers)
        {
            const int two = 2;
            int gap = numbers.Length / two;
            int temp;

            while (gap > 0)
            {
                for (int i = 0; i + gap < numbers.Length; i++)
                {
                    int j = i + gap;
                    temp = numbers[j];

                    while (j - gap >= 0 && temp < numbers[j - gap])
                    {
                        numbers[j] = numbers[j - gap];
                        j = j - gap;
                    }

                    numbers[j] = temp;
                }

                gap = gap / two;
            }
        }

        static void Print(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.Write("\n");
        }

        static int[] ReadNumbers()
        {
            string[] numbers = Console.ReadLine().Split();
            int[] result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = Convert.ToInt32(numbers[i]);
            }

            return result;
        }
    }
}
