using System;

namespace livezi
{
    class Program
    {
        static void Main(string[] args)
        {
            String liv = Console.ReadLine();
            int nrliv = Convert.ToInt32(liv);
            int[,] livada = new int[nrliv, 3];
            int[] sum = new int[nrliv];
            int sumam = 0;
            int sumap = 0;
            int sumac = 0;
            for (int i = 0; i < nrliv; i++)
            {
                string input = Console.ReadLine();

                string[] nou = input.Split(" ");
                sum[i] = 0;

                for (int j = 0; j < 3; j++)
                {
                    livada[i, j] = Convert.ToInt32(nou[j]);
                    sum[i] += livada[i, j];
                }

            }
            for (int i = 0; i < nrliv; i++)
            {
                sumam += livada[i, 0];
                sumap += livada[i, 1];
                sumac += livada[i, 2];
            }
            for (int i = 0; i < nrliv; i++)
                Console.WriteLine("Livada " + (i+1) + ": " + sum[i]);
            Console.WriteLine("Meri: " + sumam);
            Console.WriteLine("Peri: " + sumap);
            Console.WriteLine("Ciresi: " + sumac);

            /*int[] livezi = new int[3];
            
            string nr = Console.ReadLine();
            int n = Convert.ToInt32(nr);
            
            for (int i = 0; i < nou.Length; i++)
            {
                Console.WriteLine(nou[i]);
            }
                for (int i=0; i<nou.Length; i++)
                {

                    sir[i]=Convert.ToDouble(nou[i]);

                }
            Console.WriteLine(sir[n-1] * 2);*/
        }
    }
}
