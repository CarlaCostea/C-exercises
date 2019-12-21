using System;

namespace CorrectPhrase
{
    public class Program
    {
        public static void Main()
        {
            string[] wrongWords = Console.ReadLine().ToLower().Split(" ");
            string[] validWords = ReadValidWords();
            Console.WriteLine(GetTextAutoCorrectSuggestions(wrongWords, validWords));
        }

        public static string GetTextAutoCorrectSuggestions(string[] wrongWords, string[] validWords)
        {
            if (validWords == null || wrongWords == null)
            {
                return "";
            }

            string sugestie = "";
            foreach (string word in wrongWords)
            {
                if (!IsValid(word, validWords))
                {
                    sugestie += Sugestie(word, validWords);
                }
            }

            return sugestie == "" ? "Text corect!" : sugestie;
        }

        private static string Sugestie(string word, string[] validWords)
        {
            string sugestieComlpeta = "";
            string sugestie = "";
            foreach (string valid in validWords)
            {
                if (WordWithOneWrongLetter(word, valid, ref sugestie)
                    || WordWithOneMoreLetter(word, valid, ref sugestie)
                    || WordWithOneLessLetter(valid, word, ref sugestie)
                    || WordWithTwoLettersSwap(valid, word, ref sugestie))
                {
                    sugestieComlpeta += " " + sugestie;
                }
            }

            return sugestieComlpeta == "" ? word + ": (nu sunt sugestii)\n" : word + ":" + sugestieComlpeta + "\n";
        }

        private static bool WordWithTwoLettersSwap(string valid, string word, ref string sugestie)
        {
            int wrongLetter = 0;
            int swapLetter = 0;
            if (word.Length == valid.Length)
            {
                for (int i = 1; i < word.Length - 1; i++)
                {
                    wrongLetter += CompareLetters(word[i], valid[i]);
                    if (wrongLetter == 1)
                    {
                        swapLetter += CompareLetters(word[i], valid[i + 1]) + CompareLetters(word[i - 1], valid[i]);
                    }
                }
            }

            if (swapLetter != 1)
            {
                return false;
            }

            sugestie = valid;
            return true;
        }

        private static bool WordWithOneLessLetter(string word, string valid, ref string sugestie)
        {
          if (word.Length != valid.Length + 1)
            {
                return false;
            }

          for (int i = 0; i < word.Length; i++)
            {
                string removeLetter = word.Remove(i, 1);
                if (Validate(removeLetter, valid))
                {
                    sugestie = word;
                    return true;
                }
            }

          return false;
        }

        private static bool WordWithOneMoreLetter(string word, string valid, ref string sugestie)
        {
            if (word.Length != valid.Length + 1)
            {
                return false;
            }

            for (int i = 0; i < word.Length; i++)
            {
                string removeLetter = word.Remove(i, 1);
                if (Validate(removeLetter, valid))
                {
                    sugestie = valid;
                    return true;
                }
            }

            return false;
        }

        private static bool WordWithOneWrongLetter(string word, string valid, ref string sugestie)
            {
            int wrongLetter = 0;
            if (word.Length == valid.Length)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    wrongLetter += CompareLetters(word[i], valid[i]);
                }
            }

            if (wrongLetter != 1)
            {
                return false;
            }

            sugestie = valid;
            return true;
        }

        private static int CompareLetters(char v1, char v2)
        {
            return v1 != v2 ? 1 : 0;
        }

        private static bool IsValid(string word, string[] validWords)
    {
        foreach (string valid in validWords)
        {
            if (word == valid)
            {
                return true;
            }
        }

        return false;
    }

        private static bool Validate(string word, string valid)
        {
            return word == valid;
        }

        private static string[] ReadValidWords()
    {
        int numberOfWords = Convert.ToInt32(Console.ReadLine());
        string[] result = new string[numberOfWords];
        for (int i = 0; i < numberOfWords; i++)
        {
            result[i] = Console.ReadLine();
        }

        return result;
    }
}
}
