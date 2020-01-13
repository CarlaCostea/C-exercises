using System;

namespace KnowledgeContest
{
    class Program
    {
        static void Main(string[] args)
        {
            long initialAmount = Convert.ToInt64(Console.ReadLine());
            int questionsAnswered = Convert.ToInt32(Console.ReadLine());

            long amountEarned = initialAmount;
            for (int i = 1; i <= questionsAnswered; i++)
            {
                if (i % 3 != 0)
                {
                    Multiply(ref amountEarned);
                }
                else
                {
                    Multiply(ref amountEarned, 3);
                }

            }

            Console.WriteLine(amountEarned);
            Console.Read();
        }

        static void Multiply(ref long baseValue, int multiplier = 2)
        {
            long result = 0;
            for (int i=0;i<multiplier;i++)
            
                result += baseValue;
            baseValue = result;
            
        }
        
    }
}
