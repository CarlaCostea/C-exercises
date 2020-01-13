using System;

namespace SwapChar
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            char x = Convert.ToChar(Console.ReadLine());
            char y = Convert.ToChar(Console.ReadLine());
            string newBeginning = TransformBeginning(text, x);
            string newAll = TransformEnd(newBeginning, y);
            Console.WriteLine(newAll);
        }

        private static string TransformEnd(string newBeginning, char y)
        {
            string end = "";
            string middle = "";
            for (int i = 0; i < newBeginning.Length; i++)
            {
                char c = newBeginning[i];
                if (newBeginning[i] == y)
                {
                    end += c;
                }
                else
                {
                    middle += c;
                }
            }

            return middle + end;
        }

        private static string TransformBeginning(string text, char x)
        {
            string beginning = "";
            string middle = "";
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (text[i] == x)
                {
                    beginning += c;
                }
                else
                {
                    middle += c;
                }
            }

            return beginning + middle;
        }
    }
}
