using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < count; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum1 += n;
            }
            for (int i = 0; i < count; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum2 += n;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1-sum2)}");
            }
        }
    }
}
