using System;

namespace AveragePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceApples = Convert.ToDouble(Console.ReadLine());
            double pricePears = Convert.ToDouble(Console.ReadLine());
            double pricePotatos = Convert.ToDouble(Console.ReadLine());
            double priceDetergent = Convert.ToDouble(Console.ReadLine());

            double averagePrice  = 0;
            switch (Console.ReadLine())
            {
                case "1":
                    averagePrice = AveragePrice(priceApples, pricePears);
                    break;
                case "2":
                    averagePrice = AveragePrice(priceApples, pricePears, pricePotatos);
                    break;
                case "3":
                    averagePrice = AveragePrice(priceApples, pricePears, pricePotatos, priceDetergent);
                    break;
            }

            Console.WriteLine(string.Format("{0:F2}", averagePrice));
            Console.Read();
        }

        static double AveragePrice(params double[] prices)
        {
            
                int count = 0;
                double average = 0;
                foreach (double price in prices)
                {
                    average += price;
                    count++;
                }
                return average/count;
            
        }
    }
}
