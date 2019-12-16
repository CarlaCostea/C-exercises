using System;

namespace Base26ToBase10
{
    class Program
    {
        static void Main()
        {
            int columnToConvert = Convert.ToInt32(Console.ReadLine());
            string[] baseChars = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z".Split(' ');
            string excelColumn = IntToString(columnToConvert, baseChars);
            Console.WriteLine(excelColumn);
        }

        static string IntToString(int columnToConvert, string[] baseChars)
        {
            int dec = 1;
            string result = string.Empty;
            int targetBase = baseChars.Length;
            do
                {
                    if (columnToConvert % targetBase == 0)
                    {
                        result = baseChars[targetBase - 1] + result;
                        columnToConvert = columnToConvert / targetBase;
                        if (columnToConvert == 1)
                        {
                        break;
                        }

                        dec++;
                }
                    else
                    {
                        result = baseChars[columnToConvert % targetBase - dec] + result;
                        columnToConvert = columnToConvert / targetBase;
                    }
                }
                while (columnToConvert > 0);

            return result;
        }
    }
}