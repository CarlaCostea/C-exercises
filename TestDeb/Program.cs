using System;

namespace TestDeb
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     /*  double[] mathGrades = { 9, 9, 10 };
        //     double[] historyGrades = { 10, 10, 10 };
        //     double[] englishGrades = { 8, 8, 9 };
        //    double[] averages = new double[3];
        //averages[0] = Average(mathGrades);
        //averages[1] = Average(historyGrades);
        //averages[2] = Average(englishGrades);
        //PrintAverages(averages);
        //Console.Read();
        // }
        //     static void PrintAverages(double[] averages)
        //     {
        //        string text = "";
        //        for (int i = 0; i<averages.Length; i++)
        //          text += string.Format("{0:F2} ", averages[i]);
        //        Console.WriteLine(text);
        //        Console.Write("Media generala: ");
        //        text = string.Format("{0:F2}", Average(averages));
        //        Console.WriteLine(text);*/



        //         int[] numbers = { 1, 1, 2 };
        //         NextValue(numbers);
        //         PrintValues(numbers);
        //         Console.Read();
        //     }

        //     static void NextValue(int[] values)
        //     {
        //         values[0] = values[1];
        //         values[1] = values[2];
        //         values[2] = values[0] + values[1];
        //     }

        //     static void PrintValues(int[] values)
        //     {
        //         for (int i = 0; i < values.Length; i++)
        //             Console.Write(values[i] + " ");
        //         Console.Write('\n');
        //     }
        //     //static double Average(double[] grades)
        //     //{
        //     //   double sum = 0;
        //     // for (int i = 0; i<grades.Length; i++)
        //     //   sum += grades[i];
        //     //   return sum / grades.Length;
        //     // }
        //static void Main(string[] args)
        //{
        //    int[] numbers = { 1, -2, 3 };
        //    RemoveNegativeValues(numbers);
        //    PrintValues(numbers);
        //    Console.Read();
        //}

        //static void RemoveNegativeValues(int[] values)
        //{
        //    int positiveValuesCount = 0;
        //    for (int i = 0; i < values.Length; i++)
        //        if (values[i] >= 0) positiveValuesCount++;

        //    int[] result = new int[positiveValuesCount];
        //    int resultIndex = 0;

        //    for (int i = 0; i < values.Length; i++)
        //    {
        //        if (values[i] < 0)
        //            continue;

        //        result[resultIndex] = values[i];
        //        resultIndex++;
        //    }
        //    values = result;
        //}

        //static void PrintValues(int[] values)
        //{
        //    for (int i = 0; i < values.Length; i++)
        //        Console.Write(values[i] + " ");
        //    Console.Write('\n');
        //}
        //static void Main(string[] args)
        //{
        //    int[] numbers = { 1, 1, 2 };
        //    ExpandWithNextValue(ref numbers);
        //    PrintValues(numbers);
        //    Console.Read();
        //}

        //static void ExpandWithNextValue(ref int[] values)
        //{
        //    int[] result = new int[values.Length + 1];

        //    for (int i = 0; i < values.Length; i++)
        //        result[i] = values[i];

        //    result[values.Length] = values[values.Length - 2] + values[values.Length - 1];
        //    values = result;
        //}

        //static void PrintValues(int[] values)
        //{
        //    for (int i = 0; i < values.Length; i++)
        //        Console.Write(values[i] + " ");
        //    Console.Write('\n');
        //}
        static void Main(string[] args)
        {
            string text = "This is a test phrase.";
            Console.WriteLine(FindWord(text, "this", true));
            Console.Read();
        }

        static bool FindWord(string text, string word, bool caseSensitive = false)
        {
            string[] words = text.Split(' ', ',', '.', '!', '?');
            for (int i = 0; i < words.Length; i++)
            {
                bool bFound = caseSensitive ?
                    words[i].Equals(word) :
                    words[i].Equals(word, StringComparison.CurrentCultureIgnoreCase);

                if (bFound)
                    return true;
            }
            return false;
        }

    }
}
