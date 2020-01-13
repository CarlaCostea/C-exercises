using System;

namespace Program
{
    class @switch
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            //Double bani = Convert.ToDouble(inputData);
            //inputData = Console.ReadLine();
            //Double second= Convert.ToDouble(inputData);
            //inputData = Console.ReadLine();
            string luna = inputData;
            //inputData = Console.ReadLine();
            //int h = Convert.ToInt32(inputData);
            /*double camera = n * m;
            double pierderi = camera*15/100;
            double placa = a * b;
            double necesar=Math.Ceiling((camera+pierderi)/placa);
            Console.WriteLine(necesar);*/
            /*if (n%3==0)
            {
                if (n % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine("Fizz");
                }

            }
            else
            {
                if (n % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(n);
                }
            }

            int paine = 0;
            int oua = 0;
            int mere = 0;
            while (bani >= 5 && paine < 2)
            {
                bani = bani - 5;
                paine++;

            }
            while (bani >= 0.5 && oua < 10)
            {
                bani = bani - 0.5;
                oua++;
            }
            while(bani >= 3 && mere < 3)
            {
                bani = bani - 3;
                mere++;
            }

            Console.WriteLine(paine);
            Console.WriteLine(oua);
            Console.WriteLine(mere);
            if (paine==2 && oua==10 && mere == 3)
            {
                Console.WriteLine("DA");
               
            }else
            {
                Console.WriteLine("NU");
            }
            if (n / 1000 % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            if (n / 100 % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            if (n / 10 % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            if (n % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }*/
            switch (luna)
            {
                case "decembrie":   
                    Console.WriteLine("iarna");
                    break;
            case "ianuarie":
                    Console.WriteLine("iarna");
                    break;
            case "februarie":
                    Console.WriteLine("iarna");
                    break;
                case "martie":
                    Console.WriteLine("primavara");
                    break;
                case "aprilie":
                    Console.WriteLine("primavara");
                    break;
                case "mai":
                    Console.WriteLine("primavara");
                    break;
                case "iunie":
                    Console.WriteLine("vara");
                    break;
                case "iulie":
                    Console.WriteLine("vara");
                    break;
                case "august":
                    Console.WriteLine("vara");
                    break;
                case "septembrie":
                    Console.WriteLine("toamna");
                    break;
                case "octombrie":
                    Console.WriteLine("toamna");
                    break;
                case "noiembrie":
                    Console.WriteLine("toamna");
                    break;
                default:
                    Console.WriteLine("luna invalida");
                    break;
            }
        }
    }
}
