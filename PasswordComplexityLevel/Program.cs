using System;

namespace PasswordComplexityLevel
{
    enum PasswordComplexityLevel
    {
        High,
        Medium,
        Low
    }

    struct PasswordComplexity
    {
        public int MinLowercaseChars;
        public int MinUpercaseChars;
        public int MinDigits;
        public int MinSymbols;
        public bool CanContainSimilarChars;
        public bool CanContainAmbiguousChars;
    }

    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            Console.WriteLine(GetPasswordComplexityLevel(password));
            Console.Read();
        }

        static PasswordComplexityLevel GetPasswordComplexityLevel(string password)
        {
            PasswordComplexity high = GetHighPasswordComplexity();
            PasswordComplexity medium = GetMediumPasswordComplexity();
            PasswordComplexity givenPassword = new PasswordComplexity();
            string[] similars = "l,1,I,o,0,O".Split(',');
            string[] ambiguous = "{ } [ ] ( ) / \\ \' \" ~ , ; . < >".Split(' ');
            givenPassword.MinLowercaseChars = CountSmallLetters(password);
            givenPassword.MinUpercaseChars = CountBigLetters(password);
            givenPassword.MinDigits = CountNumbers(password);
            givenPassword.MinSymbols = password.Length - givenPassword.MinLowercaseChars - givenPassword.MinUpercaseChars - givenPassword.MinDigits;
            givenPassword.CanContainSimilarChars = SearchSimilars(password, similars);
            givenPassword.CanContainAmbiguousChars = SearchAmbiguous(password, ambiguous);
            if (Compare(high, givenPassword))
            {
                return PasswordComplexityLevel.High;
            }

            if (Compare(medium, givenPassword))
            {
                return PasswordComplexityLevel.Medium;
            }

            return PasswordComplexityLevel.Low;
        }

        static bool SearchAmbiguous(string password, string[] ambiguous)
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

        static bool SearchSimilars(string password, string[] similars)
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

        static int CountNumbers(string password)
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

        static int CountBigLetters(string password)
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

        static int CountSmallLetters(string password)
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

        static bool Compare(PasswordComplexity givenComplexity, PasswordComplexity actualComplexity)
        {
            if (actualComplexity.MinLowercaseChars < givenComplexity.MinLowercaseChars || actualComplexity.MinSymbols < givenComplexity.MinSymbols)
            {
                return false;
            }

            if (actualComplexity.MinUpercaseChars < givenComplexity.MinUpercaseChars || actualComplexity.MinDigits < givenComplexity.MinDigits)
            {
                return false;
            }

            return Ambiguity(givenComplexity.CanContainAmbiguousChars, actualComplexity.CanContainAmbiguousChars) &&
                Similarity(givenComplexity.CanContainSimilarChars, actualComplexity.CanContainSimilarChars);
        }

        private static bool Ambiguity(bool given, bool actual)
        {
            return given || given == actual;
        }

        private static bool Similarity(bool given, bool actual)
        {
            return given || given == actual;
        }

        static PasswordComplexity GetHighPasswordComplexity()
        {
            const int HighComplexityMinLowercaseChars = 5;
            const int HighComplexityMinUppercaseChars = 2;
            const int HighComplexityMinDigits = 2;
            const int HighComplexityMinSymbols = 2;

            return new PasswordComplexity
            {
                MinLowercaseChars = HighComplexityMinLowercaseChars,
                MinUpercaseChars = HighComplexityMinUppercaseChars,
                MinDigits = HighComplexityMinDigits,
                MinSymbols = HighComplexityMinSymbols,
                CanContainSimilarChars = true,
                CanContainAmbiguousChars = true
            };
        }

        static PasswordComplexity GetMediumPasswordComplexity()
        {
            const int MediumComplexityMinLowercaseChars = 3;
            const int MediumComplexityMinUpercaseChars = 1;
            const int MediumComplexityMinDigits = 1;
            const int MediumComplexityMinSymbols = 1;

            return new PasswordComplexity
            {
                MinLowercaseChars = MediumComplexityMinLowercaseChars,
                MinUpercaseChars = MediumComplexityMinUpercaseChars,
                MinDigits = MediumComplexityMinDigits,
                MinSymbols = MediumComplexityMinSymbols,
                CanContainSimilarChars = true,
                CanContainAmbiguousChars = true
            };
        }
    }
}
