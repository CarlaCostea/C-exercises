using System;

namespace NoteSiMonede
{
    class Program
    {
        static void Main()
        {
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            string[] students = ReadStudents(numberOfStudents);
            int[] grades = ReadGrades(numberOfStudents);
            int[] coins = CalculatePayOf(numberOfStudents, grades);
            PrintResult(numberOfStudents, students, coins);
        }

        private static void PrintResult(int numberOfStudents, string[] students, int[] coins)
        {
            for (int j = 0; j < numberOfStudents; j++)
            {
                Console.WriteLine(students[j] + " " + coins[j]);
            }
        }

        private static int[] CalculatePayOf(int numberOfStudents, int[] grades)
        {
            int[] result = new int[numberOfStudents];
            result[0] = 1;
            for (int i = 1; i < grades.Length; i++)
            {
                result[i] = grades[i] > grades[i - 1] ? result[i - 1] + 1 : 1;
            }

            for (int i = grades.Length - 2; i >= 0; i--)
                {
                  if (grades[i + 1] < grades[i] && result[i + 1] + 1 > result[i])
                    {
                        result[i] = result[i + 1] + 1;
                    }
                }

            return result;
            }

        private static int[] ReadGrades(int numberOfStudents)
        {
            int[] result = new int[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                result[i] = Convert.ToInt32(Console.ReadLine());
            }

            return result;
        }

        private static string[] ReadStudents(int numberOfStudents)
        {
            string[] result = new string[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                result[i] = Console.ReadLine();
            }

            return result;
        }
    }
}
