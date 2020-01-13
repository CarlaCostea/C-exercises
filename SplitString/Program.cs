using System;
//using System.Text.RegularExpressions;

namespace SplitString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            while (str.Contains("  ")) str = str.Replace("  ", " ");
            //string nou = System.Text.RegularExpressions.Regex.Replace(str, " {2,}", " ");
            string[] elemente = str.Split(' ');
            /*string input = Console.ReadLine();
            int num = Convert.ToInt32(input);


            string[] elemente = str.Split(' ');
            if (num <= elemente.Length)
                Console.WriteLine(elemente[num - 1]);
            else
            { Console.WriteLine("N/A"); }*/

            foreach (string element in elemente)
                 Console.WriteLine(element);
             

        }
    }
}
