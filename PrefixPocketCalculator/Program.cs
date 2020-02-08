using System;
using System.Collections.Generic;

namespace PrefixPocketCalculator
{
    public class Program
    {
        public static void Main()
        {
            string[] inputRequest = Console.ReadLine().Split(" ");
            decimal resultNumber = 0;
            if (inputRequest.Length == 1)
            {
                Console.WriteLine(inputRequest[0]);
            }
            else
            {
                MathTranslate(inputRequest, ref resultNumber);
                Console.WriteLine(resultNumber.ToString("0.#####"));
            }
        }

        public static void MathTranslate(string[] inputRequest, ref decimal resultNumber)
        {
            if (inputRequest == null)
            {
                return;
            }

            if (inputRequest.Length == 0)
            {
                return;
            }

            const int second = 2;
            List<string> tmp = new List<string>(inputRequest);
            for (int i = inputRequest.Length - 1; i >= 0; i--)
            {
                if (!decimal.TryParse(inputRequest[i], out decimal n))
                {
                    resultNumber = Operate(Convert.ToDecimal(inputRequest[i + 1]), Convert.ToDecimal(inputRequest[i + second]), inputRequest[i]);
                    tmp.RemoveAt(i + second);
                    tmp.RemoveAt(i + 1);

                    // if we still have operations to make, put result in list
                    if (tmp.Count > 1)
                    {
                        tmp[i] = Convert.ToString(resultNumber);
                        inputRequest = tmp.ToArray();
                        MathTranslate(tmp.ToArray(), ref resultNumber);
                    }
                    else
                    {
                        tmp.RemoveAt(i);
                        MathTranslate(tmp.ToArray(), ref resultNumber);
                    }
                }
            }

            return;
        }

        private static decimal Operate(decimal resultNumber, decimal v, string operation)
        {
            switch (operation)
            {
                case "+":
                    return resultNumber + v;
                case "-":
                    return resultNumber - v;
                case "*":
                    return resultNumber * v;
                case "/":
                    return resultNumber / v;
                default:
                    return 0;
            }
        }
    }
}
