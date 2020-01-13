using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string input = Console.ReadLine();
            int i = 0;
            int count = 0;
            int[] result = new int[100];
            while (input != "x")
            {
                int num = Convert.ToInt32(input);
                result[i] = num;
                i++;
                input = Console.ReadLine();
            }
            Array.Resize(ref result, i);
            for (int j = 0; j <i; j++)
            {
                if (result[j] % 2 == 0)
                {
                    Console.WriteLine(result[j]);
                    count++;
                }
            }
            if (count==0)
                Console.WriteLine("N/A");
            Double[] sir = new Double[12];
            string input = Console.ReadLine();
            string nr = Console.ReadLine();
            int n = Convert.ToInt32(nr);
            string[] nou = input.Split(" ");
            /*for (int i = 0; i < nou.Length; i++)
            {
                Console.WriteLine(nou[i]);
            }
                for (int i=0; i<nou.Length; i++)
                {

                    sir[i]=Convert.ToDouble(nou[i]);

                }
            Console.WriteLine(sir[n-1] * 2);*/
            String[] echipav = new String[3];
            String[] echipar = new String[3];
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                echipav[i] = input;
            }
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                echipar[i] = input;
            }
            string ver = Console.ReadLine();
            bool ex = false;
            for (int i = 0; i < 3; i++)
            {
                if (ver == echipav[i])
                {
                    Console.WriteLine("echipa verde");
                    ex = true;
                    break;
                }


                if (ver == echipar[i])
                {
                    Console.WriteLine("echipa rosie");
                    ex = true;
                    break;
                }
                
            }
            if (ex ==false) 
            Console.WriteLine("N/A");




        }
    }
}
