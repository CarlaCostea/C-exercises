using System;

namespace VowelsPER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static double GetPercentageOfVowelsFromTotalLetters(string text)
        {
            int vowelsCount = 0;
            int consonantsCount = 0;
            foreach (char c in text)
            {
                if (IsVowel(c))
                {
                    vowelsCount++;
                }
                if (IsConsonant(c))
                {
                    consonantsCount++;
                }
            }
            return (double)vowelsCount / (vowelsCount + consonantsCount) * 100;
        }

        private static bool IsConsonant(char c)
        {
            return Char.IsLetter(c) && !IsVowel(c);
        }

        private static bool IsVowel(char c)
        {
            return "aeiouAEIOU".IndexOf(c) != -1;
        }
        static bool IsPanagram(string phrase)
        {
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                if (phrase.IndexOf(letter, StringComparison.CurrentCultureIgnoreCase) == -1)
                {
                    return false;
                }
            }return true ;


        }
    }
}
