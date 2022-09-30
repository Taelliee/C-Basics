using System;

namespace Sum_Numbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < input)
            {
                int inputt = int.Parse(Console.ReadLine());
                sum += inputt; 
            }
            Console.WriteLine(sum);
        }
    }
}
