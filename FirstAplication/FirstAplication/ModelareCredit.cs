using System;
class ModelareCredit
{
    static void Main(string[] args)
    {
        // reading input data
        string inputData = Console.ReadLine();
        decimal amount = Convert.ToDecimal(inputData);
        inputData = Console.ReadLine();
        decimal interestRatePerYear = Convert.ToDecimal(inputData);
        inputData = Console.ReadLine();
        int totalMonths = Convert.ToInt32(inputData);
        inputData = Console.ReadLine();
        int currentMonth = Convert.ToInt32(inputData);

        // caculate rate
        // calculate principal
        decimal principal = amount / totalMonths;

        // calculate interest

        decimal interestRatePerMonth = interestRatePerYear / 12;
        decimal balance = amount - (currentMonth - 1) * principal;
        decimal interest = balance * interestRatePerMonth / 100;

        // calculate rate
        decimal rate = principal + interest;
        
        // display the result
        Console.WriteLine(rate);
        Console.Read();
    }
}
