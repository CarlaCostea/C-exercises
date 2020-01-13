using System;


namespace Anagrame
{
    class Program
    {
        static void Main(string[] args)
        {
            string cuvant = Console.ReadLine();
            string cuv = noDups(cuvant);
           
            int nrk= cuv.Length ;
            int n = cuvant.Length;
            double baza = 1;
            double anagrams;

            int[] Occ = new int[nrk];

            Occurrences(cuvant, Occ);

            for (int i = 0; i < nrk; i++)
                baza = baza * Factorial(Occ[i]);

            anagrams = Factorial(n) / baza;

            //Console.WriteLine(Factorial(n));
            Console.WriteLine(anagrams);







            static double Factorial(int number)
            {
                if (number == 1 || number == 0)
                    return 1;
                else
                    return number * Factorial(number - 1);
            }
            
            
        }

        static int[] Occurrences(string input, int[] Occurrence)
        {
            int i = 0;
            while (input.Length > 0)
            {
                //Console.Write(input[0] + " : ");
                int count = 0;
               
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[0] == input[j])
                    {
                        count++;
                    }
                    
                }
                Occurrence[i] = count;
                //Console.WriteLine(Occurrence[i]);
                i++;

                input = input.Replace(input[0].ToString(), string.Empty);
               // return Occurrence;
            }
            return Occurrence;
        }


        static string noDups(string word)
        {
            string table = "";

            foreach (var character in word)
            {
                if (table.IndexOf(character) == -1)
                {
                    table += character; 
                }
            }
            return table;
        }
    }

}
