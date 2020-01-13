using System;

namespace SumaData
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string text = "text de test";
            Console.WriteLine(text[7] == ' ' ? "spatiu" : "cuvant");
            string input = Console.ReadLine();
            while (input != "stop" && input != "")
            {
                string inputType = "";
                bool onlyDigits = true;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < '0' || input[i] > '9')
                        onlyDigits = false;
                }

                if (onlyDigits)
                {
                    inputType = "numar";
                }

                if (input == "true" || input == "false")
                {
                    inputType = "valoare booleana";
                }

                if (inputType == "")
                {
                    inputType = "text";
                }

                Console.WriteLine(inputType);
                input = Console.ReadLine();

            }
            //string text = Console.ReadLine();
            string litera = Console.ReadLine();
            int ex = text.IndexOf(litera);
            if (ex>=0)
                Console.WriteLine("true");
            else Console.WriteLine("false");


            string text = Console.ReadLine();
            int count = 0;
            int i = 0; 
            while (i < text.Length)
            {
                if (text[i] == ' ')
                    count++;
                i++;
            }
            
                Console.WriteLine(count + 1);*/

            string text = Console.ReadLine();
            int egal = text.IndexOf("=");
            Console.WriteLine(text.Substring(0,egal));
            Console.WriteLine(text.Substring(egal+1));

        }
    }
}
