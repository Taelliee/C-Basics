using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int n = 0;
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < count; i++)
            {
                n = int.Parse(Console.ReadLine());
                sum += n;
                if (n > max)
                {
                    max = n;
                }
            }
            if (max == sum - max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - max - max)}");

            }
        }
    }
}
