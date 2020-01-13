using System;

namespace WTF
{
    internal class Program
    {
        private static void Main()
        {
            /** int numberStudents = Convert.ToInt32(Console.ReadLine());
            int numberStudents = 9;
            int[] payOf = new int[numberStudents];
            payOf[0] = 1;
            string[] students = new string[numberStudents];

            for (int i = 0; i < numberStudents; i++)
            {
                students[i] = Console.ReadLine();
            }

            int[] grades = new int[numberStudents];

            for (int i = 0; i < numberStudents; i++)
            {
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }
            */
            int[] payOf = new int[9];
            payOf[0] = 1;
            string[] students = "ion, ana, ene, ina, adi, ela, lia, dia, sia".Split(", ");
            /** int[] grades = { 8, 9, 10, 10, 8, 8, 6, 9, 8 }; */
            int[] grades = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            const int numberStudents = 9;

            DoCalc(numberStudents, grades, ref payOf);

            for (int j = 0; j < numberStudents; j++)
            {
                Console.WriteLine(students[j] + " " + grades[j] + " " + payOf[j]);
            }
        }

        private static void DoCalc(int numberStudents, int[] grades, ref int[] payOf)
        {
            const int cucu = 2;
            for (int i = 1; i < numberStudents; i++)
            {
                if (grades[i] > grades[i - 1])
                {
                    payOf[i] = payOf[i - 1] + 1;
                }
                else
                {
                    payOf[i] = 1;
                    int j = i - 1;
                    int curent = grades[j + 1];
                    int prev = grades[j];
                    while (j > 0 && (curent < prev))
                    {
                        Console.WriteLine("j:" + j + " curent:" + curent + " prev:" + prev);

#pragma warning disable S134 // Control flow statements "if", "switch", "for", "foreach", "while", "do"  and "try" should not be nested too deeply
                        if (prev == grades[j - 1])
#pragma warning restore S134 // Control flow statements "if", "switch", "for", "foreach", "while", "do"  and "try" should not be nested too deeply
                        {
                            payOf[j]++;
                        }
                        else if (prev < grades[j - 1])
                        {
                            Console.WriteLine("else 1");

                            payOf[j]++;
                        }

                        j--;
                        curent = grades[j + 1];
                        prev = grades[j];
                    }

                    /**
                    int k = i - 1;
                    while (k >= 1 && grades[k] < grades[k - 1])
                    {
                        payOf[k + 1]++;

                        k--;
                    }
                    */
                }
            }
        }
    }
}