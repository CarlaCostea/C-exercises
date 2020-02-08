using System;
using System.Collections.Generic;

class Program
{
    // The vector v stores current subset.
    public static void PrintAllSubsetsRec(int[] arr, int n, List<int> v, int sum, int target, ref bool solution)
    {
        // If remaining sum is 0, then print all
        // elements of current subset.
        if (sum == 0 && v[v.Count - 1] != 1 && target > 0)
        {
            solution = true;
            Console.Write("1");
            for (int j = 1; j < arr.Length; j++)
            {
                Console.Write(v.Contains(j + 1) ? " - " + arr[j] : " + " + arr[j]);
            }

            Console.Write(" = " + target);
            Console.WriteLine();
            return;
        }

        // If no remaining elements,
        if (n == 0)
        {
            return;
        }

        // We consider two cases for every element.
        // a) We do not include last element.
        // b) We include last element in current subset.
        PrintAllSubsetsRec(arr, n - 1, v, sum, target, ref solution);
        List<int> v1 = new List<int>(v);
        v1.Add(arr[n - 1]);
        PrintAllSubsetsRec(arr, n - 1, v1, sum - arr[n - 1], target, ref solution);
    }

    public static void PrintAllNegativeSubsetsRec(int[] arr, int n, List<int> v, int sum, int target, ref bool solution)
    {
        if (sum == -1 && target < 0 && v[v.Count - 1] != 1)
        {
            solution = true;
            Console.Write("1");
            for (int j = 1; j < arr.Length; j++)
            {
                Console.Write(v.Contains(j + 1) ? " + " + arr[j] : " - " + arr[j]);
            }

            Console.Write(" = " + target);
            Console.WriteLine();
            return;
        }

        // If no remaining elements,
        if (n == 0)
        {
            return;
        }

        // We consider two cases for every element.
        // a) We do not include last element.
        // b) We include last element in current subset.
        PrintAllNegativeSubsetsRec(arr, n - 1, v, sum, target, ref solution);
        List<int> v1 = new List<int>(v);
        v1.Add(arr[n - 1]);
        PrintAllNegativeSubsetsRec(arr, n - 1, v1, sum + arr[n - 1], target, ref solution);
    }

    // Wrapper over printAllSubsetsRec()
    public static void PrintAllSubsets(int[] arr, int n, int sum, int target, ref bool solution)
    {
        List<int> v = new List<int>();
        if (target < 0)
        {
            PrintAllNegativeSubsetsRec(arr, n, v, sum, target, ref solution);
        }
        else
        {
            PrintAllSubsetsRec(arr, n, v, sum, target, ref solution);
        }
    }

    // Driver code
    public static void Main()
    {
        const int two = 2;
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }

        int target = Convert.ToInt32(Console.ReadLine());
        int sum = target > 0 ? (n * (n + 1) / two - target) / two : target + n;

        // Console.WriteLine(sum),
        if (n == two && target == two + 1)
        {
            Console.WriteLine(arr[0] + " + " + arr[1] + " = " + target);
        }
        else
        {
            decimal decimalSum = (n * (n + 1) / two - target) / two;
            if ((n * (n + 1) / two - target) / two <= n / two)
            {
                Console.WriteLine("N/A");
            }
            else
            {
                bool solution = false;
                PrintAllSubsets(arr, n, sum, target, ref solution);
                if (!solution)
                {
                    Console.WriteLine("N/A");
                }
            }
        }
    }
}