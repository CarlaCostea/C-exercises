using System;

namespace ReplaceChar
{
    class Program
    {
        static void Main()
        {
            string initialString = Console.ReadLine();
            char charToReplace = Convert.ToChar(Console.ReadLine());
            string newChar = Console.ReadLine();
            string newString = ReplaceChar(initialString, charToReplace, newChar);

            Console.WriteLine(newString);
        }

        private static string ReplaceChar(string initialString, char charToReplace, string newChar)
        {
            if (initialString.Length < 1)
            {
                return initialString;
            }

            string result = "";
            if (initialString[0] == charToReplace)
            {
                result = newChar;
            }
            else
            {
                result += initialString[0];
            }

            return result + ReplaceChar(initialString.Substring(1), charToReplace, newChar);
        }
    }
}
