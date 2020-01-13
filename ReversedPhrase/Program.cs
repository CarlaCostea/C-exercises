using System;

namespace ReversedPhrase
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversedPhrase = Console.ReadLine();
            string phrase = "";

            for (int i = reversedPhrase.Length - 1; i >= 0; i--)
            {
                if (reversedPhrase[i] >= 'A' && reversedPhrase[i] <= 'Z')
                {
                    phrase += " "+(char)(reversedPhrase[i] + 32);
                }
                else
                {
                    phrase += reversedPhrase[i];
                }
            }

            Console.WriteLine(phrase);
            Console.ReadLine();
        }
    }
}
