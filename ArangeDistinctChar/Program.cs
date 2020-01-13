using System;

namespace ArangeDistinctChar
{
    class Program
    {
        static void Main()
        {
            const int div = 2;
            string text = Console.ReadLine();
            string distinct = GetDistinctChars(text);
            int[] charsApparitions = new int[distinct.Length];
            int indexOfMax = 0;
            int indexOfSecondMax = 0;
            for (int i = 0; i < distinct.Length; i++)
            {
                charsApparitions[i] = CountCharOccurrences(text, distinct[i]);
            }

            SecondMax(charsApparitions, ref indexOfSecondMax, ref indexOfMax);
            if (charsApparitions[indexOfMax] > (text.Length + 1) / div)
            {
                Console.WriteLine(distinct[indexOfMax]);
            }
            else
            {
                string arrange = "";
                int k = 0;
                while (k < text.Length)
                {
                    arrange = arrange + distinct[indexOfMax];
                    k++;
                    if (k < text.Length)
                    {
                        arrange = arrange + distinct[indexOfSecondMax];
                        k++;
                        charsApparitions[indexOfMax]--;
                        charsApparitions[indexOfSecondMax]--;
                        SecondMax(charsApparitions, ref indexOfSecondMax, ref indexOfMax);
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine(arrange);
            }
        }

        private static void SecondMax(int[] charsApparitions, ref int indexOfSecondMax, ref int indexOfMax)
        {
            int largest = 0;
            int second = 0;
            for (int i = 0; i < charsApparitions.Length; i++)
            {
                if (charsApparitions[i] > largest)
                {
                    second = largest;
                    largest = charsApparitions[i];
                    indexOfMax = i;
                }
                else if (charsApparitions[i] > second)
                {
                    second = charsApparitions[i];
                    indexOfSecondMax = i;
                }
            }
        }

        private static int CountCharOccurrences(string text, char charToCount)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (c == charToCount)
                {
                    count++;
                }
            }

            return count;
        }

        private static string GetDistinctChars(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                if (result.IndexOf(c) == -1)
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
