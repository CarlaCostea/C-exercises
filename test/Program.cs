using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string num = Console.ReadLine();
            /*int n = Convert.ToInt32(num);
            int nod = 0;
            for (int i = 1; i <= n; i++)
                nod += i;
            Console.WriteLine(nod+n+1);
            int count = 0;
            
            for (int i = 0; i <= (num.Length / 2-1); i++)
                
                
                    if (num[i] == num[num.Length - 1 - i])
                        count++;
            if (count == (num.Length/2 )) 
                Console.WriteLine(count * 2);
            else
            Console.WriteLine(count); */
            string num = Console.ReadLine();
            int x = Convert.ToInt32(num);
            string numy = Console.ReadLine();
            int y = Convert.ToInt32(numy);
            Console.WriteLine(gcf(x, y));
            Console.WriteLine(lcm(x, y));
            static int gcf(int a, int b)
            {
                if (a < b)
                {
                    while (b != 0)
                    {
                        int temp = b;
                        b = a % b;
                        a = temp;
                    }
                    return a;
                }
                else
                {
                    while (a != 0)
                    {
                        int temp = a;
                        a = b % a;
                        b = temp;
                    }
                    return b;

                }
            }

            static int lcm(int a, int b)
            {
                return (a / gcf(a, b)) * b;
            }
          

        }
    }
}
