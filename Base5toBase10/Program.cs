using System;

namespace Base5toBase10
{
    class Program
    {
        static void Main()
        {
            const int base5 = 5;
            const string codePath = "0Oo1l";
            string[] codedList = Console.ReadLine().Split(' ');
            int[] result = new int[codedList.Length];
            for (int i = 0; i < codedList.Length; i++)
            {
                string text = codedList[i];
                int powerOfFive = 1;
                result[i] = 0;
                for (int j = text.Length - 1; j >= 0; j--)
                {
                    int decodedDigit = DecodedChar(text[j], codePath);
                    result[i] += decodedDigit * powerOfFive;
                    powerOfFive *= base5;
                }
            }

            for (int i = 0; i < codedList.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }

        private static int DecodedChar(char v, string codePath)
        {
            return codePath.IndexOf(v) + 1;
        }
    }
}
