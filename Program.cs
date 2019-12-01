using System;

namespace _6din49
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int totalballs = Convert.ToInt32(num);
            string numy = Console.ReadLine();
            int extballs = Convert.ToInt32(numy);
            string cat = Console.ReadLine();
            double cnk;
            double ckj;

            int ncat = Nncat(ref cat, ref extballs);

            cnk = CombineNK(ref totalballs, ref extballs);
            ckj = CombineNK(ref extballs, ref ncat); 
            int nmink = totalballs - extballs;
            int kminj = extballs - ncat;
            double cnkkj = CombineNK(ref nmink, ref kminj);
            double odds = (ckj * cnkkj) / cnk;
            Console.WriteLine("{0:N10}", odds);

        }
        static double CombineNK(ref int n, ref int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }
        static double Factorial(int number)
            {
                if (number == 1 || number == 0)
                    return 1;
                else
                    return number * Factorial(number - 1);
            }

        static int Nncat(ref string text, ref int extb)
        {
            switch (text)
            {
                case "I":
                    return extb;
                case "II":
                    return extb - 1;
                case "III":
                    return extb - 2;
                default:
                    Console.WriteLine("Select Category:I, II or III");
                    return 0;
            }
        }
    }
}

        
         
    

