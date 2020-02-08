using System;

namespace CorrectPassword
{
    struct Complexity
    {
        public int NumberOfSmallLetters;
        public int NumberOfBigLetters;
        public int Numbers;
        public int Symbols;
        public bool ContainSimilars;
        public bool ContainAmbiguous;

        public Complexity(int numberOfSmallLetters, int numberOfBigLetters, int numbers, int symbols, bool containSimilars, bool containAmbiguous)
        {
            this.NumberOfSmallLetters = numberOfSmallLetters;
            this.NumberOfBigLetters = numberOfBigLetters;
            this.Numbers = numbers;
            this.Symbols = symbols;
            this.ContainSimilars = containSimilars;
            this.ContainAmbiguous = containAmbiguous;
        }
    }

    public class Program
    {
        public static void Main()
        {
            string password = Console.ReadLine();
            Complexity givenComplexity = ReadComplexity();
            Complexity actualComplexity = new Complexity();
            string[] similars = "l,1,I,o,0,O".Split(',');
            string[] ambiguous = "{ } [ ] ( ) / \\ \' \" ~ , ; . < >".Split(' ');
            actualComplexity.NumberOfSmallLetters = CountSmallLetters(password);
            actualComplexity.NumberOfBigLetters = CountBigLetters(password);
            actualComplexity.Numbers = CountNumbers(password);
            actualComplexity.Symbols = password.Length - actualComplexity.NumberOfSmallLetters - actualComplexity.NumberOfBigLetters - actualComplexity.Numbers;
            actualComplexity.ContainSimilars = SearchSimilars(password, similars);
            actualComplexity.ContainAmbiguous = SearchAmbiguous(password, ambiguous);
            Console.WriteLine(Compare(givenComplexity, actualComplexity));
        }

        public static bool SearchAmbiguous(string password, string[] ambiguous)
        {
            if (ambiguous == null || password == null)
            {
                return false;
            }

            foreach (string ambigu in ambiguous)
            {
                if (password.IndexOf(Convert.ToChar(ambigu)) != -1)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool SearchSimilars(string password, string[] similars)
        {
            if (similars == null || password == null)
            {
                return false;
            }

            foreach (string similar in similars)
            {
                if (password.IndexOf(Convert.ToChar(similar)) != -1)
                {
                    return true;
                }
            }

            return false;
        }

        public static int CountNumbers(string password)
        {
            if (password == null)
            {
                return 0;
            }

            int count = 0;
            foreach (char letter in password)
            {
                if (char.IsNumber(letter))
                {
                    count++;
                }
            }

            return count;
        }

        public static int CountBigLetters(string password)
        {
            if (password == null)
            {
                return 0;
            }

            int count = 0;
            foreach (char letter in password)
            {
                if (char.IsUpper(letter))
                {
                    count++;
                }
            }

            return count;
        }

        public static int CountSmallLetters(string password)
        {
            if (password == null)
            {
                return 0;
            }

            int count = 0;
            foreach (char letter in password)
            {
                if (char.IsLetter(letter) && !char.IsUpper(letter))
                {
                    count++;
                }
            }

            return count;
        }

        private static Complexity ReadComplexity()
        {
            return new Complexity
            {
                NumberOfSmallLetters = Convert.ToInt32(Console.ReadLine()),
                NumberOfBigLetters = Convert.ToInt32(Console.ReadLine()),
                Numbers = Convert.ToInt32(Console.ReadLine()),
                Symbols = Convert.ToInt32(Console.ReadLine()),
                ContainSimilars = Convert.ToBoolean(Console.ReadLine()),
                ContainAmbiguous = Convert.ToBoolean(Console.ReadLine())
            };
        }

        static bool Compare(Complexity givenComplexity, Complexity actualComplexity)
        {
            if (actualComplexity.NumberOfSmallLetters < givenComplexity.NumberOfSmallLetters || actualComplexity.Symbols < givenComplexity.Symbols)
            {
                return false;
            }

            if (actualComplexity.NumberOfBigLetters < givenComplexity.NumberOfBigLetters || actualComplexity.Numbers < givenComplexity.Numbers)
            {
                return false;
            }

            return Ambiguity(givenComplexity.ContainAmbiguous, actualComplexity.ContainAmbiguous) && Similarity(givenComplexity.ContainSimilars, actualComplexity.ContainSimilars);
        }

        private static bool Ambiguity(bool given, bool actual)
        {
            return given || given == actual;
        }

        private static bool Similarity(bool given, bool actual)
        {
            return given || given == actual;
        }
    }
}
