using System;

namespace ConsoleApp2
{
    class max
    {
        static void Main(string[] args)
        {
            //string inputData = Console.ReadLine();
            //Double bani = Convert.ToDouble(inputData);
            //inputData = Console.ReadLine();
            //Double second= Convert.ToDouble(inputData);
            //inputData = Console.ReadLine();
            //string luna = inputData;
            //inputData = Console.ReadLine();
            //int h = Convert.ToInt32(inputData);
            /*string inputData = Console.ReadLine();
            int max = Convert.ToInt32(inputData);
            bool maxim=true;
            if (max == 0)
            {
                Console.WriteLine(max);
            }
            else
            {
                do
                {
                    string input = Console.ReadLine();
                    int num = Convert.ToInt32(input);
                    if (num != 0)
                    {
                        if (num > max)
                        {
                            max = num;
                        }
                    }
                    else
                    {
                        if (num > max)
                        {
                            max = num;
                            maxim = false;
                            break;
                        }
                        else
                        {
                            maxim = false;
                            break;
                        }

                    }

                } while (maxim);
                Console.WriteLine(max);
            }
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            int sum = 0;
            for (int i=0; i <=n; i++)
            {
                sum += (i * i);
            }
            Console.WriteLine(sum); */
            bool conditie = true;
            int count = 0;
            while (conditie)
            {
                string inputData = Console.ReadLine();
                
                
                if (inputData == "x") {
                    conditie = false;
                   
                }
                else {
                    int max = Convert.ToInt32(inputData);
                    if (max > 0)
                    {
                        count+=1;
                    }
                }
                
            }
            Console.WriteLine(count);

        }
    }
}
