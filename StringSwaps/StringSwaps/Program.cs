using System;

namespace StringSwaps
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialText = Console.ReadLine();
            ReadSwaps(out int[] firstIndex, out int[] secondIndex);

            string updatedText = initialText;

            for (int i = 0; i < firstIndex.Length; i++)
                updatedText = ApplySwap(updatedText, firstIndex[i], secondIndex[i]);

            Console.WriteLine(updatedText);
            Console.Read();
        }

        static string ApplySwap(string text, int firstIndex, int secondIndex)
        {
            char[] array = text.ToCharArray(); // Get characters
            char aux = array[firstIndex]; // Get temporary copy of character
            array[firstIndex] = array[secondIndex]; // Assign element
            array[secondIndex] = aux; // Assign element
            return new string(array); // Return string
            
        }

        static void ReadSwaps(out int[] firstIndex, out int[] secondIndex)
        {
            int swapsNumber = Convert.ToInt32(Console.ReadLine());
            firstIndex = new int[swapsNumber];
            secondIndex = new int[swapsNumber];

            for (int i = 0; i < swapsNumber; i++)
            {
                string[] swapInfo = Console.ReadLine().Split(' ');
                firstIndex[i] = Convert.ToInt32(swapInfo[0]);
                secondIndex[i] = Convert.ToInt32(swapInfo[1]);
            }
        }

    }
}
