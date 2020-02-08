using System;
using System.Collections.Generic;

namespace PrefixPocketCalculator
{
    public class Program
    {
        public static void Main()
        {
            string[] inputRequest = Console.ReadLine().Split(" ");
            string result = "";
            MathTranslate(inputRequest, ref result);
            Console.WriteLine(result);
        }

        public static void MathTranslate(string[] inputRequest, ref string result)
        {
            if (inputRequest.Length == 0)
            {
                return;
            }

            List<string> tmp = new List<string>(inputRequest);
            for (int i = 0; i < inputRequest.Length; i++)
            {
                if (int.TryParse(inputRequest[i], out int n))
                {
                    if (result == "")
                    {
                        result += inputRequest[i] + " " + inputRequest[i - 1];
                        tmp.RemoveAt(i);
                        tmp.RemoveAt(i - 1);
                        inputRequest = tmp.ToArray();
                        MathTranslate(inputRequest, ref result);
                    }
                    else if (inputRequest.Length < 2)
                    {
                        result += " " + inputRequest[i];
                        tmp.RemoveAt(i);
                        inputRequest = tmp.ToArray();
                        MathTranslate(inputRequest, ref result);
                    }
                    else
                    {
                        result += " " + inputRequest[i] + " " + inputRequest[i - 1];
                        tmp.RemoveAt(i);
                        tmp.RemoveAt(i - 1);
                        inputRequest = tmp.ToArray();
                        MathTranslate(inputRequest, ref result);
                    }

                }
            }

            return;
        }
    }
}
