using System;

namespace BinarySearch
{
    class Program
    {
        static void Main()
        {
            int[] numbers = ReadNumbers();
            int numberToFind = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(BinarySearch(numbers, numberToFind));
            Console.Read();
        }

        private static int[] ReadNumbers()
        {
            string[] numbers = Console.ReadLine().Split();
            int[] result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = Convert.ToInt32(numbers[i]);
            }

            return result;
        }

        static int BinarySearch(int[] numbers, int numberToFind)
        {
            return BinarySearch(numbers, numberToFind, 0, numbers.Length - 1);
        }

        static int BinarySearch(int[] numbers, int numberToFind, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }

            var mid = (start + end) / 2;
            bool found = CheckNumberAtIndex(numbers, mid, numberToFind);
            if (numbers[mid] == numberToFind)
            {
                return mid;
            }

            return numbers[mid] < numberToFind ? BinarySearch(numbers, numberToFind, mid + 1, end)
                                          : BinarySearch(numbers, numberToFind, start, mid - 1);
        }

        static bool CheckNumberAtIndex(int[] numbers, int index, int numberToCheck)
        {
            Console.WriteLine("Checking index " + index + " (value " + numbers[index] + ")");
            return numbers[index] == numberToCheck;
        }
    }
}
