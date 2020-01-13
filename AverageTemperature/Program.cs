using System;

namespace AverageTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] averageTemperatures = ReadAverageTemperatures();
            int[] averageTemperaturesPerMonth = CalculateAverages(averageTemperatures, true);
            PrintValues(averageTemperaturesPerMonth, "Average temperatures per month:");
            int[] averageTemperaturesPerYear = CalculateAverages(averageTemperatures, false);
            PrintValues(averageTemperaturesPerYear, "Average temperatures per year:");
            Console.Read();

            static int[,] ReadAverageTemperatures()
            {
                int[,] averageTemperatures = new int[3, 3];

                for (int monthIndex = 0; monthIndex < 3; monthIndex++)
                    ReadAverageTemperaturesPerMonth(averageTemperatures, monthIndex);

                return averageTemperatures;
            }

            static void ReadAverageTemperaturesPerMonth(int[,] averageTemperatures, int monthIndex)
            {
                string[] temperatureValues = Console.ReadLine().Split(' ');
                for (int yearIndex = 0; yearIndex < 3; yearIndex++)
                    averageTemperatures[monthIndex, yearIndex] = Convert.ToInt32(temperatureValues[yearIndex]);
            }

            /* static int[] CalculateAverageTemperaturesPerMonth(int[,] averageTemperatures)
             {
                 int[] result = new int[3];
                 for (int monthIndex = 0; monthIndex < 3; monthIndex++)
                     result[monthIndex] = CalculateAverageTemperatureForMonth(averageTemperatures, monthIndex);
                 return result;
             }*/
            /*static int CalculateAverageTemperatureForMonth(int[,] averageTemperatures, int monthIndex)
             {
                 double sum = 0;
                 for (int yearIndex = 0; yearIndex < 3; yearIndex++)
                     sum += averageTemperatures[monthIndex, yearIndex];
                 return (int)Math.Round(sum / 3);
             }*/
            //private 
            static int[] CalculateAverages(int[,] table, bool perLine)
            {
                int length = perLine ? table.GetLength(0) : table.GetLength(1);
                int[] result = new int[length];
                for (int i = 0; i < length; i++)
                    result[i] = CalculateAverage(table, i, perLine);
                return result;
            }

            /*static void PrintAverageTemperaturesPerMonth(int[] averageTemperaturesPerMonth)
            {
                Console.WriteLine("Average temperatures per month:");
                for (int i = 0; i < averageTemperaturesPerMonth.Length; i++)
                    Console.Write(averageTemperaturesPerMonth[i] + " ");
                Console.Write('\n');
            }*/

            /*static int[] CalculateAverageTemperaturesPerYear(int[,] averageTemperatures)
            {
                int[] result = new int[3];
                for (int yearIndex = 0; yearIndex < 3; yearIndex++)
                    result[yearIndex] = CalculateAverageTemperatureForYear(averageTemperatures, yearIndex);
                return result;
            }*/


            //GENERAL AVERAGE
            static int CalculateAverage(int[,] table, int index, bool perLine)
            {
                int length = perLine ? table.GetLength(1) : table.GetLength(0);
                double sum = 0;
                for (int i = 0; i < length; i++)
                    sum += perLine ? table[index, i] : table[i, index];
                return (int)Math.Round(sum / length);
            }

            /*static int[] CalculateAverageTemperaturesPerMonth(int[,] averageTemperatures)
            {
                int[] result = new int[3];
                for (int monthIndex = 0; monthIndex < 3; monthIndex++)
                    result[monthIndex] = CalculateAverage(averageTemperatures, monthIndex, true);
                return result;
            }

            static int[] CalculateAverageTemperaturesPerYear(int[,] averageTemperatures)
            {
                int[] result = new int[3];
                for (int yearIndex = 0; yearIndex < 3; yearIndex++)
                    result[yearIndex] = CalculateAverage(averageTemperatures, yearIndex, false);
                return result;
            }*/

            /*static int[] CalculateAverageTemperaturesPerMonth(int[,] averageTemperatures)
            {
                int[] result = new int[3];
                for (int monthIndex = 0; monthIndex < 3; monthIndex++)
                    result[monthIndex] = CalculateAverage(averageTemperatures, monthIndex, true);
                return result;
            }*/

            /*static int[] CalculateAverageTemperaturesPerYear(int[,] averageTemperatures)
            {
                int[] result = new int[3];
                for (int yearIndex = 0; yearIndex < 3; yearIndex++)
                    result[yearIndex] = CalculateAverage(averageTemperatures, yearIndex, false);
                return result;
            }*/


            /*static int CalculateAverageTemperatureForYear(int[,] averageTemperatures, int yearIndex)
            {
                double sum = 0;
                for (int monthIndex = 0; monthIndex < 3; monthIndex++)
                    sum += averageTemperatures[monthIndex, yearIndex];
                return (int)Math.Round(sum / 3);
            }*/

            //Înlocuim CalculateAverageTemperatureForMonth și CalculateAverageTemperatureForYear cu o singură funcție nouă numită CalculateAverageTemperature
            static int CalculateAverageTemperature(int[,] averageTemperatures, int index, bool perMonth)
            {
                double sum = 0;
                for (int i = 0; i < 3; i++)
                    sum += perMonth ? averageTemperatures[index, i] : averageTemperatures[i, index];
                return (int)Math.Round(sum / 3);
            }

            /*static void PrintAverageTemperaturesPerYear(int[] averageTemperaturesPerYear)
            {
                Console.WriteLine("Average temperatures per year:");
                for (int i = 0; i < averageTemperaturesPerYear.Length; i++)
                    Console.Write(averageTemperaturesPerYear[i] + " ");
                Console.Write('\n');
            }*/

            static void PrintValues(int[] values, string message)
            {
                Console.WriteLine(message);
                for (int i = 0; i < values.Length; i++)
                    Console.Write(values[i] + " ");
                Console.Write('\n');
            }
        }

   }
}
