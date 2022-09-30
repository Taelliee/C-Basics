using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 1; i <= count; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    sumOdd += n;
                }
                else
                {
                    sumEven += n;
                }
            }
            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOdd}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumOdd-sumEven)}");
            }
        }
    }
}
